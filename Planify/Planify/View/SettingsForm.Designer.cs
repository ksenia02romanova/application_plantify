namespace Planify.View
{
    partial class SettingsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FilePathtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Delaybutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Planify.Properties.Resources.настройки_значок;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настройки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тема:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FilePathtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ThemeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 145);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FilePathtextBox
            // 
            this.FilePathtextBox.Location = new System.Drawing.Point(20, 67);
            this.FilePathtextBox.Name = "FilePathtextBox";
            this.FilePathtextBox.Size = new System.Drawing.Size(260, 22);
            this.FilePathtextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Путь к файлу:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Светлая",
            "Тёмная"});
            this.ThemeComboBox.Location = new System.Drawing.Point(101, 106);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(179, 24);
            this.ThemeComboBox.TabIndex = 3;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Savebutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savebutton.Location = new System.Drawing.Point(13, 217);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(157, 30);
            this.Savebutton.TabIndex = 5;
            this.Savebutton.Text = "Сохранить";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveButtonMouseClick);
            // 
            // Delaybutton
            // 
            this.Delaybutton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delaybutton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delaybutton.Location = new System.Drawing.Point(176, 217);
            this.Delaybutton.Name = "Delaybutton";
            this.Delaybutton.Size = new System.Drawing.Size(137, 30);
            this.Delaybutton.TabIndex = 6;
            this.Delaybutton.Text = "Отмена";
            this.Delaybutton.UseVisualStyleBackColor = false;
            this.Delaybutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DelayButtonMouseClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 259);
            this.Controls.Add(this.Delaybutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Delaybutton;
        private System.Windows.Forms.TextBox FilePathtextBox;
        private System.Windows.Forms.Label label3;
    }
}