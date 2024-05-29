namespace Assignment4._2._1
{
    partial class WelcomeForm
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
            LogInToAccount = new Button();
            AddStudentButton = new Button();
            ExitButton = new Button();
            SaveStudentListByGPA = new Button();
            SuspendLayout();
            // 
            // LogInToAccount
            // 
            LogInToAccount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInToAccount.Location = new Point(12, 12);
            LogInToAccount.Name = "LogInToAccount";
            LogInToAccount.Size = new Size(191, 37);
            LogInToAccount.TabIndex = 0;
            LogInToAccount.Text = "Log In to Account";
            LogInToAccount.UseVisualStyleBackColor = true;
            LogInToAccount.Click += LogInToAccount_Click;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddStudentButton.Location = new Point(12, 55);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(191, 37);
            AddStudentButton.TabIndex = 1;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(713, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 37);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SaveStudentListByGPA
            // 
            SaveStudentListByGPA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveStudentListByGPA.Location = new Point(12, 98);
            SaveStudentListByGPA.Name = "SaveStudentListByGPA";
            SaveStudentListByGPA.Size = new Size(191, 71);
            SaveStudentListByGPA.TabIndex = 2;
            SaveStudentListByGPA.Text = "Save Student List by Highest GPA";
            SaveStudentListByGPA.UseVisualStyleBackColor = true;
            SaveStudentListByGPA.Click += SaveStudentListByGPA_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 218);
            Controls.Add(SaveStudentListByGPA);
            Controls.Add(ExitButton);
            Controls.Add(AddStudentButton);
            Controls.Add(LogInToAccount);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LogInToAccount;
        private Button AddStudentButton;
        private Button ExitButton;
        private Button SaveStudentListByGPA;
    }
}