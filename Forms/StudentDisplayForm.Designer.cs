namespace Assignment4._2._1
{
    partial class StudentDisplayForm
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
            DisplayStudentsListBox = new ListBox();
            SuspendLayout();
            // 
            // DisplayStudentsListBox
            // 
            DisplayStudentsListBox.FormattingEnabled = true;
            DisplayStudentsListBox.ItemHeight = 15;
            DisplayStudentsListBox.Location = new Point(12, 12);
            DisplayStudentsListBox.Name = "DisplayStudentsListBox";
            DisplayStudentsListBox.Size = new Size(776, 94);
            DisplayStudentsListBox.TabIndex = 0;
            // 
            // StudentDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DisplayStudentsListBox);
            Name = "StudentDisplayForm";
            Text = "StudentDisplayForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox DisplayStudentsListBox;
    }
}