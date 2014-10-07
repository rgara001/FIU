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
            this.courseName.BackColor = System.Drawing.Color.Transparent;
            this.courseName.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.courseName.Location = new System.Drawing.Point(83, 0);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(102, 19);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "Course Name";
            this.courseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseSemester
            // 
            this.courseSemester.AutoSize = true;
            this.courseSemester.BackColor = System.Drawing.Color.Transparent;
            this.courseSemester.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.courseSemester.Location = new System.Drawing.Point(85, 19);
            this.courseSemester.Name = "courseSemester";
            this.courseSemester.Size = new System.Drawing.Size(100, 15);
            this.courseSemester.TabIndex = 1;
            this.courseSemester.Text = "Course Semester";
            this.courseSemester.Click += new System.EventHandler(this.courseSemester_Click);
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.courseSemester);
            this.Controls.Add(this.courseName);
            this.Name = "Course";
            this.Size = new System.Drawing.Size(288, 52);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseSemester;
    }
}
