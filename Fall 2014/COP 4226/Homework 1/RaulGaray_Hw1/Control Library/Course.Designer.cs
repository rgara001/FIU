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
            this.courseName.BackColor = System.Drawing.Color.Transparent;
            this.courseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseName.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.courseName.Location = new System.Drawing.Point(0, 0);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(289, 32);
            this.courseName.TabIndex = 0;
            this.courseName.Text = "COP 4226";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.courseName.Click += new System.EventHandler(this.label1_Click);
            // 
            // courseSemester
            // 
            this.courseSemester.BackColor = System.Drawing.Color.Transparent;
            this.courseSemester.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseSemester.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.courseSemester.Location = new System.Drawing.Point(0, 17);
            this.courseSemester.Name = "courseSemester";
            this.courseSemester.Size = new System.Drawing.Size(289, 15);
            this.courseSemester.TabIndex = 1;
            this.courseSemester.Text = "Fall 2014";
            this.courseSemester.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.Size = new System.Drawing.Size(289, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label courseSemester;
    }
}
