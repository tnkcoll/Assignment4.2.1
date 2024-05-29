namespace Assignment4._2._1
{
    partial class AddNewStudent
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
            AddNewStudentButton = new Button();
            StudentGPATextBox = new TextBox();
            StudentGPALabel = new Label();
            StudentNameTextBox = new TextBox();
            StudentNameLabel = new Label();
            StudentIdTextBox = new TextBox();
            StudentIDLabel = new Label();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // AddNewStudentButton
            // 
            AddNewStudentButton.Location = new Point(12, 111);
            AddNewStudentButton.Name = "AddNewStudentButton";
            AddNewStudentButton.Size = new Size(135, 23);
            AddNewStudentButton.TabIndex = 3;
            AddNewStudentButton.Text = "Add New Student";
            AddNewStudentButton.UseVisualStyleBackColor = true;
            AddNewStudentButton.Click += AddNewStudentButton_Click;
            // 
            // StudentGPATextBox
            // 
            StudentGPATextBox.Location = new Point(157, 63);
            StudentGPATextBox.Name = "StudentGPATextBox";
            StudentGPATextBox.Size = new Size(179, 23);
            StudentGPATextBox.TabIndex = 2;
            StudentGPATextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // StudentGPALabel
            // 
            StudentGPALabel.AutoSize = true;
            StudentGPALabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentGPALabel.ImageAlign = ContentAlignment.MiddleLeft;
            StudentGPALabel.Location = new Point(12, 60);
            StudentGPALabel.Name = "StudentGPALabel";
            StudentGPALabel.Size = new Size(120, 25);
            StudentGPALabel.TabIndex = 11;
            StudentGPALabel.Text = "Student GPA:";
            StudentGPALabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StudentNameTextBox
            // 
            StudentNameTextBox.Location = new Point(157, 39);
            StudentNameTextBox.Name = "StudentNameTextBox";
            StudentNameTextBox.Size = new Size(179, 23);
            StudentNameTextBox.TabIndex = 1;
            StudentNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // StudentNameLabel
            // 
            StudentNameLabel.AutoSize = true;
            StudentNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            StudentNameLabel.Location = new Point(12, 35);
            StudentNameLabel.Name = "StudentNameLabel";
            StudentNameLabel.Size = new Size(135, 25);
            StudentNameLabel.TabIndex = 9;
            StudentNameLabel.Text = "Student Name:";
            StudentNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StudentIdTextBox
            // 
            StudentIdTextBox.Location = new Point(157, 15);
            StudentIdTextBox.Name = "StudentIdTextBox";
            StudentIdTextBox.Size = new Size(179, 23);
            StudentIdTextBox.TabIndex = 0;
            StudentIdTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StudentIDLabel.ImageAlign = ContentAlignment.MiddleLeft;
            StudentIDLabel.Location = new Point(12, 10);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(101, 25);
            StudentIDLabel.TabIndex = 6;
            StudentIDLabel.Text = "Student Id:";
            StudentIDLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(201, 111);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(135, 23);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelButton_Click;
            // 
            // AddNewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 157);
            Controls.Add(CancelBtn);
            Controls.Add(AddNewStudentButton);
            Controls.Add(StudentGPATextBox);
            Controls.Add(StudentGPALabel);
            Controls.Add(StudentNameTextBox);
            Controls.Add(StudentNameLabel);
            Controls.Add(StudentIdTextBox);
            Controls.Add(StudentIDLabel);
            Name = "AddNewStudent";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNewStudentButton;
        private TextBox StudentGPATextBox;
        private Label StudentGPALabel;
        private TextBox StudentNameTextBox;
        private Label StudentNameLabel;
        private TextBox StudentIdTextBox;
        private Label StudentIDLabel;
        private Button CancelBtn;
    }
}