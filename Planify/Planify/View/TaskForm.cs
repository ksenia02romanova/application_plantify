using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Planify.Data;

namespace Planify.View
{
    public partial class TaskForm : Form
    {
        private CreateTaskForm createTaskForm;
        private ListBox ListBox;
        private Data.Task editingTask;
        private bool isEditing;

        public TaskForm(CreateTaskForm createTaskForm, ListBox listBox, Data.Task task = null)
        {
            InitializeComponent();
            this.createTaskForm = createTaskForm;
            ListBox = listBox;
            editingTask = task;
            isEditing = task != null;

            if (isEditing)  // для кнопки редактирования задачи
            {
                NameTaskTextBox.Text = task.Name;
                switch (task.category)
                {
                    case Category.Material:
                        CategoryOfTaskComboBox.Text = "Материальные";
                        break;
                    case Category.Personal:
                        CategoryOfTaskComboBox.Text = "Личные";
                        break;
                    case Category.Professional:
                        CategoryOfTaskComboBox.Text = "Профессиональные";
                        break;
                    case Category.Spiritual:
                        CategoryOfTaskComboBox.Text = "Духовные";
                        break;
                }
                TaskDateTimePicker.Value = task.DeadLine;
                switch (task.priority)
                {
                    case Priority.Low:
                        LowPriorityRadioButton.Checked = true;
                        break;
                    case Priority.Medium:
                        MiddlePriorityRadioButton.Checked = true;
                        break;
                    case Priority.High:
                        HighPriorityRadioButton.Checked = true;
                        break;
                }
                switch (task.reminder)
                {
                    case Reminder.None:
                        ReminderTaskComboBox.Text = "нет";
                        break;
                    case Reminder.Speedy:
                        ReminderTaskComboBox.Text = "за 15 минут";
                        break;
                    case Reminder.Fast:
                        ReminderTaskComboBox.Text = "за 1 час";
                        break;
                    case Reminder.Slow:
                        ReminderTaskComboBox.Text = "за день";
                        break;
                }
            }
        }

        private void DelayTaskButtonClick(object sender, EventArgs e)
        {
            createTaskForm.Show();
            this.Close();
            if (isEditing)
            {
                ListBox.Items.Add(editingTask);
                createTaskForm.AddTask(editingTask);
                createTaskForm.UpdateTaskCounts();
                MessageBox.Show("Редактирование отменено!", "",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveTaskButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTaskTextBox.Text) || 
                string.IsNullOrEmpty(CategoryOfTaskComboBox.Text) ||
        (!LowPriorityRadioButton.Checked && !MiddlePriorityRadioButton.Checked && 
        !HighPriorityRadioButton.Checked) ||
        string.IsNullOrEmpty(ReminderTaskComboBox.Text))
            {
                MessageBox.Show("У вас есть незаполненные поля!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
                Data.Task task = new Data.Task();
                task.Name = NameTaskTextBox.Text;
                switch (CategoryOfTaskComboBox.Text)     
                {
                    case "Материальные":
                        task.category = Category.Material;
                        break;
                    case "Личные":
                        task.category = Category.Personal;
                        break;
                    case "Профессиональные":
                        task.category = Category.Professional;
                        break;
                    case "Духовные":
                        task.category = Category.Spiritual;
                        break;
                }
                task.DeadLine = TaskDateTimePicker.Value;
                if (LowPriorityRadioButton.Checked != true)
                {
                    if (MiddlePriorityRadioButton.Checked != true)
                    {
                        task.priority = Priority.High;
                    }
                    else { task.priority = Priority.Medium; }
                }
                else { task.priority = Priority.Low; }
                switch (ReminderTaskComboBox.Text)
                {
                    case "нет":
                        task.reminder = Reminder.None;
                        break;
                    case "за 15 минут":
                        task.reminder = Reminder.Speedy;
                        break;
                    case "за 1 час":
                        task.reminder = Reminder.Fast;
                        break;
                    case "за день":
                        task.reminder = Reminder.Slow;
                        break;
                }
                ListBox.Items.Add(task);

                if (!isEditing)
                    {
                        createTaskForm.AddTask(task); 
                    }
                else
                    {
                        createTaskForm.UpdateTask(editingTask, task); 
                    }

                createTaskForm.UpdateTaskCounts();
                createTaskForm.Show();
                this.Close();
                if (!isEditing)
                {
                    MessageBox.Show("Задача была успешно добавлена!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Задача была успешно отредактирована!", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void LowPriorityButtonCheckedChanged(object sender, EventArgs e)
        {
            if (LowPriorityRadioButton.Checked == true)
            {
                MiddlePriorityRadioButton.Checked = false;
                HighPriorityRadioButton.Checked = false;
            }
        }

        private void MiddlePriorityButtonCheckedChanged(object sender, EventArgs e)
        {
            if ( MiddlePriorityRadioButton.Checked == true)
            {
                LowPriorityRadioButton.Checked = false;
                HighPriorityRadioButton.Checked = false;
            }
        }

        private void HighPriorityButtonCheckedChanged(object sender, EventArgs e)
        {
            if (HighPriorityRadioButton.Checked == true)
            {
                MiddlePriorityRadioButton.Checked = false;
                LowPriorityRadioButton.Checked = false;
            }
        }
    }
}
