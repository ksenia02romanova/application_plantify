using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Xml;
using Newtonsoft.Json;
using Planify.Data;
using Planify.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Planify
{
    public partial class CreateTaskForm : Form
    {
        private System.Windows.Forms.Timer timeTimer;
        private List<Data.Task> allTasks = new List<Data.Task>();
        private string filePath = "tasks.json"; 
        private string currentTheme = "Светлая";
        public List<Data.Task> AllTasks { get { return allTasks; } }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string CurrentTheme
        {
            get { return currentTheme; }
            set { currentTheme = value; }
        }
        public CreateTaskForm()
        {
            InitializeComponent();
            allTasks = LoadTasksFromJson();
            LoadSettings();
        }
        public void AddTask(Data.Task task)
        {
            allTasks.Add(task);
        }
        public void RemoveTask(Data.Task task)
        {
            allTasks.Remove(task);
        }
        public void UpdateTask(Data.Task oldTask, Data.Task newTask)
        {
            int index = allTasks.FindIndex(t => t == oldTask);
            if (index >= 0)
            {
                allTasks[index] = newTask;
            }
        }
        private void CreateTaskForm_Load(object sender, EventArgs e)
        {
            TasksListBox.MouseClick += TasksListBoxDoubleClick;
            SearchNameTextBox.TextChanged += SearchCriteriaChanged;
            StatusComboBox.SelectedIndexChanged += SearchCriteriaChanged;
            CategoryComboBox.SelectedIndexChanged += SearchCriteriaChanged;
            UpdateTaskCounts();
            timeTimer = new System.Windows.Forms.Timer();
            timeTimer.Interval = 1000; 
            timeTimer.Tick += new EventHandler(TimeTimer_Tick);
            timeTimer.Start();
        }
        private void CreateTaskButtonClick(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(this, TasksListBox);
            this.Hide();
            taskForm.FormClosed += (s, args) => UpdateTaskCounts();
            taskForm.Show();
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу для редактирования!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Data.Task task = TasksListBox.SelectedItem as Data.Task;
            if (task != null)
            {
                TaskForm taskForm = new TaskForm(this, TasksListBox, task);
                TasksListBox.Items.Remove(task);
                allTasks.Remove(task);
                taskForm.FormClosed += (s, args) => UpdateTaskCounts();
                this.Hide();
                taskForm.Show();
            }
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            if(TasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу для удаления!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Data.Task task = TasksListBox.SelectedItem as Data.Task;
            if (task != null)
            {
                DialogResult result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить задачу '{task.Name}'?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    TasksListBox.Items.Remove(task);
                    allTasks.Remove(task);
                    UpdateTaskCounts();
                    MessageBox.Show("Задача успешно удалена!", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void UpdateTaskCounts()
        {
            int completedCount = TasksListBox.Items.Cast<Data.Task>().Count(t => t.IsCompleted);
            int uncompletedCount = TasksListBox.Items.Cast<Data.Task>().Count(t => !t.IsCompleted);
            StatusLabel.Text = $"Завершённые задачи: {completedCount} | Незавершённые задачи: " +
                $"{uncompletedCount}";
        }
        private void TasksListBoxDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = TasksListBox.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    TasksListBox.SelectedIndex = index;
                    Data.Task task = TasksListBox.SelectedItem as Data.Task;
                    if (task != null)
                    {
                        task.IsCompleted = !task.IsCompleted;
                        TasksListBox.Items[index] = task;
                        allTasks[allTasks.FindIndex(t => t == task)] = task;
                        TasksListBox.Refresh();
                        UpdateTaskCounts();
                    }
                }
            }
        }

        private void SearchCriteriaChanged(object sender, EventArgs e)
        {
            FilterTasks();
        }

        private void FilterTasks()
        {
            TasksListBox.Items.Clear();
            IEnumerable<Data.Task> filteredTasks = allTasks;

            string searchText = SearchNameTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredTasks = filteredTasks.Where(t => t.Name.IndexOf(searchText, 
                    StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (StatusComboBox.SelectedIndex > 0)
            {
                bool isCompleted = StatusComboBox.SelectedIndex == 1; 
                filteredTasks = filteredTasks.Where(t => t.IsCompleted == isCompleted);
            }

            if (CategoryComboBox.SelectedIndex > 0)
            {
                Data.Category category = Data.Category.Material;
                string selectedCategory = CategoryComboBox.SelectedItem.ToString();
                switch (selectedCategory)
                {
                    case "Материальные":
                        category = Data.Category.Material;
                        break;
                    case "Личные":
                        category = Data.Category.Personal;
                        break;
                    case "Профессиональные":
                        category = Data.Category.Professional;
                        break;
                    case "Духовные":
                        category = Data.Category.Spiritual;
                        break;
                }
                filteredTasks = filteredTasks.Where(t => t.category == category);
            }

            foreach (Data.Task task in filteredTasks)
            {
                TasksListBox.Items.Add(task);
            }

            UpdateTaskCounts();
        }
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = $"Текущее время: {DateTime.Now:HH:mm:ss}";
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && m.WParam.ToInt32() == SC_CLOSE)
            {
                SaveTasksToJson(allTasks);
                Application.Exit();
            }

            base.WndProc(ref m);
        }

        public void SaveTasksToJson(List<Data.Task> tasksList)
        {
            try
            {
                string json = JsonConvert.SerializeObject(tasksList, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Data.Task> LoadTasksFromJson()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<Data.Task>>(json) ?? new List<Data.Task>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<Data.Task>();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string newFilePath = openFileDialog.FileName;
                    try
                    {
                        string json = File.ReadAllText(newFilePath);
                        allTasks = JsonConvert.DeserializeObject<List<Data.Task>>(json) ?? 
                            new List<Data.Task>();
                        filePath = newFilePath;
                        FilterTasks();
                        UpdateTaskCounts();
                        MessageBox.Show("Задачи загружены из файла!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                saveFileDialog.DefaultExt = "txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string exportContent = string.Join("\n", allTasks.Select(t => t.ToString()));
                        File.WriteAllText(saveFileDialog.FileName, exportContent);
                        MessageBox.Show("Задачи экспортированы в текстовый файл!", "Информация",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при экспорте: {ex.Message}", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(this))
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    SaveTasksToJson(allTasks);
                    SaveSettings();
                }
            }
        }
        private void SaveSettings()
        {
            var settings = new { FilePath = filePath, Theme = currentTheme };
            string settingsJson = JsonConvert.SerializeObject(settings, 
                Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("settings.json", settingsJson);
        }

        private void LoadSettings()
        {
            if (File.Exists("settings.json"))
            {
                string settingsJson = File.ReadAllText("settings.json");
                var settings = JsonConvert.DeserializeObject<dynamic>(settingsJson);
                filePath = settings.FilePath;
                currentTheme = settings.Theme;
            }
        }

        private void InfoClick(object sender, EventArgs e)
        {
            string pdfFilePath = Path.Combine(Application.StartupPath, "C:\\Users" +
                "\\Admin\\Desktop\\It\\ALL Projects\\Основные\\Planify\\Planify\\Data\\Help.pdf"); 

            if (File.Exists(pdfFilePath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = pdfFilePath,
                        UseShellExecute = true 
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось открыть файл справки: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл справки (Help.pdf) не найден в директории приложения.", 
                    "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
