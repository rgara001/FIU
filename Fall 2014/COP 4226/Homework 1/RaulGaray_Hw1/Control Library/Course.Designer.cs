namespace Control_Library
{
    partial class Course
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseName = new System.Windows.Forms.Label();
            this.courseSemester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseName
            // 
            this.courseName.AutoSize = true;
            this.courseName.Location = new System.Drawing.Point(39, 43);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(71, 13);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "Course Name";
            this.courseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseSemester
            // 
            this.courseSemester.AutoSize = true;
            this.courseSemester.Location = new System.Drawing.Point(39, 76);
            this.courseSemester.Name = "courseSemester";
            this.courseSemester.Size = new System.Drawing.Size(87, 13);
            this.courseSemester.TabIndex = 1;
            this.courseSemester.Text = "Course Semester";
            this.courseSemester.Click += new System.EventHandler(this.courseSemester_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.courseSemester);
            this.Controls.Add(this.courseName);
            this.Name = "Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseSemester;
    }
}
