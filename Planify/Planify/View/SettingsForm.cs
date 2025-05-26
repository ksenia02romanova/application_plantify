using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planify.View
{
    public partial class SettingsForm : Form
    {
        private CreateTaskForm createTaskForm;
        public SettingsForm(CreateTaskForm createTaskForm)
        {
            InitializeComponent();
            this.createTaskForm = createTaskForm;
            FilePathtextBox.Text = createTaskForm.FilePath;
            switch (createTaskForm.CurrentTheme)
            {
                case "Светлая":
                    ThemeComboBox.SelectedIndex = 0;
                    break;
                case "Тёмная":
                    ThemeComboBox.SelectedIndex = 1;
                    break;
            }
        }

        private void DelayButtonMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Close();
            }
        }

        private void SaveButtonMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                string path = FilePathtextBox.Text.Trim();
                if (!string.IsNullOrEmpty(path) && path.EndsWith(".json", 
                    StringComparison.OrdinalIgnoreCase))
                {
                    string oldFilePath = createTaskForm.FilePath; 
                    createTaskForm.FilePath = path;
                    createTaskForm.CurrentTheme = ThemeComboBox.SelectedItem?.ToString() ?? "Светлая";

                    createTaskForm.SaveTasksToJson(createTaskForm.AllTasks);

                    if (File.Exists(oldFilePath) && oldFilePath != path)
                    {
                        try
                        {
                            File.Delete(oldFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Не удалось удалить старый файл: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    if (createTaskForm.CurrentTheme == "Тёмная")
                    {
                        createTaskForm.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        createTaskForm.BackColor = SystemColors.Control;
                    }

                    DialogResult = DialogResult.OK;
                    this.Close();
                    MessageBox.Show("Настройки были обновлены.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Путь к файлу должен заканчиваться на .json!", "Предупреждение",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    
    }
}
