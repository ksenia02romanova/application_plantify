namespace Planify
{
    partial class CreateTaskForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTaskForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingsToolStripMenuItem,
            this.RightToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(873, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            this.экспортToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.SettingsToolStripMenuItem.Text = "Настройки";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // RightToolStripMenuItem
            // 
            this.RightToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightToolStripMenuItem.Name = "RightToolStripMenuItem";
            this.RightToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.RightToolStripMenuItem.Text = "Справка";
            this.RightToolStripMenuItem.Click += new System.EventHandler(this.InfoClick);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.AutoSize = true;
            this.CreateTaskButton.Location = new System.Drawing.Point(23, 331);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(207, 27);
            this.CreateTaskButton.TabIndex = 3;
            this.CreateTaskButton.Text = "Создать задачу";
            this.CreateTaskButton.UseVisualStyleBackColor = true;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButtonClick);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Location = new System.Drawing.Point(323, 331);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(207, 25);
            this.EditTaskButton.TabIndex = 4;
            this.EditTaskButton.Text = "Изменить задачу";
            this.EditTaskButton.UseVisualStyleBackColor = true;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Location = new System.Drawing.Point(646, 331);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(207, 25);
            this.DeleteTaskButton.TabIndex = 5;
            this.DeleteTaskButton.Text = "Удалить задачу";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SearchNameTextBox);
            this.groupBox1.Controls.Add(this.CategoryComboBox);
            this.groupBox1.Controls.Add(this.StatusComboBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 371);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры для поиска";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(551, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Категория";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(276, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Задача";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Location = new System.Drawing.Point(63, 42);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(207, 25);
            this.SearchNameTextBox.TabIndex = 2;
            this.SearchNameTextBox.TextChanged += new System.EventHandler(this.SearchCriteriaChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Все",
            "Материальные",
            "Личные",
            "Профессиональные",
            "Духовные"});
            this.CategoryComboBox.Location = new System.Drawing.Point(633, 40);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(207, 25);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchCriteriaChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Все",
            "Завершено ",
            "В процессе"});
            this.StatusComboBox.Location = new System.Drawing.Point(338, 41);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(207, 25);
            this.StatusComboBox.TabIndex = 0;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchCriteriaChanged);
            // 
            // TasksListBox
            // 
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.ItemHeight = 17;
            this.TasksListBox.Location = new System.Drawing.Point(13, 39);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(848, 276);
            this.TasksListBox.TabIndex = 7;
            this.TasksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TasksListBoxDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статус:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(67, 476);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusLabel.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время:";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(698, 476);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 17);
            this.TimeLabel.TabIndex = 11;
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 502);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TasksListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateTaskForm";
            this.Text = "Карточка Задачи";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RightToolStripMenuItem;
        private System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.Button EditTaskButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортToolStripMenuItem;
    }
}

