namespace Assignment4._2._1
{
    partial class LogOnScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogOnButton = new Button();
            TeacherPasswordTextBox = new TextBox();
            TeacherPasswordLabel = new Label();
            TeacherUserNameTextBox = new TextBox();
            TeacherUserNameLabel = new Label();
            SuspendLayout();
            // 
            // LogOnButton
            // 
            LogOnButton.Location = new Point(59, 67);
            LogOnButton.Name = "LogOnButton";
            LogOnButton.Size = new Size(179, 23);
            LogOnButton.TabIndex = 2;
            LogOnButton.Text = "LogOn";
            LogOnButton.UseVisualStyleBackColor = true;
            LogOnButton.Click += LogOnButton_Click;
            // 
            // TeacherPasswordTextBox
            // 
            TeacherPasswordTextBox.Location = new Point(157, 38);
            TeacherPasswordTextBox.Name = "TeacherPasswordTextBox";
            TeacherPasswordTextBox.Size = new Size(179, 23);
            TeacherPasswordTextBox.TabIndex = 1;
            TeacherPasswordTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TeacherPasswordLabel
            // 
            TeacherPasswordLabel.AutoSize = true;
            TeacherPasswordLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeacherPasswordLabel.ImageAlign = ContentAlignment.MiddleLeft;
            TeacherPasswordLabel.Location = new Point(12, 34);
            TeacherPasswordLabel.Name = "TeacherPasswordLabel";
            TeacherPasswordLabel.Size = new Size(95, 25);
            TeacherPasswordLabel.TabIndex = 13;
            TeacherPasswordLabel.Text = "Password:";
            TeacherPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TeacherUserNameTextBox
            // 
            TeacherUserNameTextBox.Location = new Point(157, 14);
            TeacherUserNameTextBox.Name = "TeacherUserNameTextBox";
            TeacherUserNameTextBox.Size = new Size(179, 23);
            TeacherUserNameTextBox.TabIndex = 0;
            TeacherUserNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TeacherUserNameLabel
            // 
            TeacherUserNameLabel.AutoSize = true;
            TeacherUserNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeacherUserNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            TeacherUserNameLabel.Location = new Point(12, 9);
            TeacherUserNameLabel.Name = "TeacherUserNameLabel";
            TeacherUserNameLabel.Size = new Size(104, 25);
            TeacherUserNameLabel.TabIndex = 10;
            TeacherUserNameLabel.Text = "UserName:";
            TeacherUserNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogOnScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 103);
            Controls.Add(TeacherPasswordTextBox);
            Controls.Add(TeacherPasswordLabel);
            Controls.Add(TeacherUserNameTextBox);
            Controls.Add(TeacherUserNameLabel);
            Controls.Add(LogOnButton);
            Name = "LogOnScreen";
            Text = "LogOn Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TeacherUserNameLabel;
        private TextBox TeacherUserNameTextBox;
        private TextBox TeacherPasswordTextBox;
        private Label TeacherPasswordLabel;
        private Button LogOnButton;
    }
}
