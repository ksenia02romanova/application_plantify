namespace Planify.View
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTaskTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryOfTaskComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.HighPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddlePriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.LowPriorityRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ReminderTaskComboBox = new System.Windows.Forms.ComboBox();
            this.SaveTaskButton = new System.Windows.Forms.Button();
            this.DelayTaskButton = new System.Windows.Forms.Button();
            this.PriorityTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PriorityTaskGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Planify.Properties.Resources.logo;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание задачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(256, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            // 
            // NameTaskTextBox
            // 
            this.NameTaskTextBox.Location = new System.Drawing.Point(360, 43);
            this.NameTaskTextBox.Name = "NameTaskTextBox";
            this.NameTaskTextBox.Size = new System.Drawing.Size(158, 25);
            this.NameTaskTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Категория:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(256, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Дедлайн:";
            // 
            // TaskDateTimePicker
            // 
            this.TaskDateTimePicker.Location = new System.Drawing.Point(360, 105);
            this.TaskDateTimePicker.Name = "TaskDateTimePicker";
            this.TaskDateTimePicker.Size = new System.Drawing.Size(158, 25);
            this.TaskDateTimePicker.TabIndex = 7;
            // 
            // CategoryOfTaskComboBox
            // 
            this.CategoryOfTaskComboBox.FormattingEnabled = true;
            this.CategoryOfTaskComboBox.Items.AddRange(new object[] {
            "Материальные",
            "Личные",
            "Профессиональные",
            "Духовные"});
            this.CategoryOfTaskComboBox.Location = new System.Drawing.Point(360, 74);
            this.CategoryOfTaskComboBox.Name = "CategoryOfTaskComboBox";
            this.CategoryOfTaskComboBox.Size = new System.Drawing.Size(158, 25);
            this.CategoryOfTaskComboBox.TabIndex = 8;
            // 
            // PriorityTaskGroupBox
            // 
            this.PriorityTaskGroupBox.Controls.Add(this.HighPriorityRadioButton);
            this.PriorityTaskGroupBox.Controls.Add(this.MiddlePriorityRadioButton);
            this.PriorityTaskGroupBox.Controls.Add(this.LowPriorityRadioButton);
            this.PriorityTaskGroupBox.Location = new System.Drawing.Point(259, 145);
            this.PriorityTaskGroupBox.Name = "PriorityTaskGroupBox";
            this.PriorityTaskGroupBox.Size = new System.Drawing.Size(259, 76);
            this.PriorityTaskGroupBox.TabIndex = 10;
            this.PriorityTaskGroupBox.TabStop = false;
            this.PriorityTaskGroupBox.Text = "Приоритет";
            // 
            // HighPriorityRadioButton
            // 
            this.HighPriorityRadioButton.AutoSize = true;
            this.HighPriorityRadioButton.Location = new System.Drawing.Point(184, 35);
            this.HighPriorityRadioButton.Name = "HighPriorityRadioButton";
            this.HighPriorityRadioButton.Size = new System.Drawing.Size(76, 21);
            this.HighPriorityRadioButton.TabIndex = 2;
            this.HighPriorityRadioButton.TabStop = true;
            this.HighPriorityRadioButton.Text = "Высокий";
            this.HighPriorityRadioButton.UseVisualStyleBackColor = true;
            this.HighPriorityRadioButton.CheckedChanged += new System.EventHandler(this.HighPriorityButtonCheckedChanged);
            // 
            // MiddlePriorityRadioButton
            // 
            this.MiddlePriorityRadioButton.AutoSize = true;
            this.MiddlePriorityRadioButton.Location = new System.Drawing.Point(101, 35);
            this.MiddlePriorityRadioButton.Name = "MiddlePriorityRadioButton";
            this.MiddlePriorityRadioButton.Size = new System.Drawing.Size(77, 21);
            this.MiddlePriorityRadioButton.TabIndex = 1;
            this.MiddlePriorityRadioButton.TabStop = true;
            this.MiddlePriorityRadioButton.Text = "Средний";
            this.MiddlePriorityRadioButton.UseVisualStyleBackColor = true;
            this.MiddlePriorityRadioButton.CheckedChanged += new System.EventHandler(this.MiddlePriorityButtonCheckedChanged);
            // 
            // LowPriorityRadioButton
            // 
            this.LowPriorityRadioButton.AutoSize = true;
            this.LowPriorityRadioButton.Location = new System.Drawing.Point(18, 35);
            this.LowPriorityRadioButton.Name = "LowPriorityRadioButton";
            this.LowPriorityRadioButton.Size = new System.Drawing.Size(68, 21);
            this.LowPriorityRadioButton.TabIndex = 0;
            this.LowPriorityRadioButton.TabStop = true;
            this.LowPriorityRadioButton.Text = "Низкий";
            this.LowPriorityRadioButton.UseVisualStyleBackColor = true;
            this.LowPriorityRadioButton.CheckedChanged += new System.EventHandler(this.LowPriorityButtonCheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(256, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Напоминание:";
            // 
            // ReminderTaskComboBox
            // 
            this.ReminderTaskComboBox.FormattingEnabled = true;
            this.ReminderTaskComboBox.Items.AddRange(new object[] {
            "нет",
            "за 15 минут",
            "за 1 час",
            "за день"});
            this.ReminderTaskComboBox.Location = new System.Drawing.Point(360, 236);
            this.ReminderTaskComboBox.Name = "ReminderTaskComboBox";
            this.ReminderTaskComboBox.Size = new System.Drawing.Size(105, 25);
            this.ReminderTaskComboBox.TabIndex = 12;
            // 
            // SaveTaskButton
            // 
            this.SaveTaskButton.Location = new System.Drawing.Point(248, 282);
            this.SaveTaskButton.Name = "SaveTaskButton";
            this.SaveTaskButton.Size = new System.Drawing.Size(125, 29);
            this.SaveTaskButton.TabIndex = 13;
            this.SaveTaskButton.Text = "Сохранить";
            this.SaveTaskButton.UseVisualStyleBackColor = true;
            this.SaveTaskButton.Click += new System.EventHandler(this.SaveTaskButtonClick);
            // 
            // DelayTaskButton
            // 
            this.DelayTaskButton.Location = new System.Drawing.Point(390, 282);
            this.DelayTaskButton.Name = "DelayTaskButton";
            this.DelayTaskButton.Size = new System.Drawing.Size(128, 29);
            this.DelayTaskButton.TabIndex = 14;
            this.DelayTaskButton.Text = "Отмена";
            this.DelayTaskButton.UseVisualStyleBackColor = true;
            this.DelayTaskButton.Click += new System.EventHandler(this.DelayTaskButtonClick);
            // 
            // PriorityTimeLabel
            // 
            this.PriorityTimeLabel.AutoSize = true;
            this.PriorityTimeLabel.Location = new System.Drawing.Point(471, 239);
            this.PriorityTimeLabel.Name = "PriorityTimeLabel";
            this.PriorityTimeLabel.Size = new System.Drawing.Size(0, 17);
            this.PriorityTimeLabel.TabIndex = 15;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 323);
            this.Controls.Add(this.PriorityTimeLabel);
            this.Controls.Add(this.DelayTaskButton);
            this.Controls.Add(this.SaveTaskButton);
            this.Controls.Add(this.ReminderTaskComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriorityTaskGroupBox);
            this.Controls.Add(this.CategoryOfTaskComboBox);
            this.Controls.Add(this.TaskDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTaskTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PriorityTaskGroupBox.ResumeLayout(false);
            this.PriorityTaskGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTaskTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TaskDateTimePicker;
        private System.Windows.Forms.ComboBox CategoryOfTaskComboBox;
        private System.Windows.Forms.GroupBox PriorityTaskGroupBox;
        private System.Windows.Forms.RadioButton HighPriorityRadioButton;
        private System.Windows.Forms.RadioButton MiddlePriorityRadioButton;
        private System.Windows.Forms.RadioButton LowPriorityRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ReminderTaskComboBox;
        private System.Windows.Forms.Button SaveTaskButton;
        private System.Windows.Forms.Button DelayTaskButton;
        private System.Windows.Forms.Label PriorityTimeLabel;
    }
}