namespace Control_Library
{
    partial class BaseDialogForm
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
            this.courseInfo = new Control_Library.Course();
            this.FullName = new Control_Library.Full_Name();
            this.MiddlePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // courseInfo
            // 
            this.courseInfo.BackColor = System.Drawing.Color.Transparent;
            this.courseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseInfo.Location = new System.Drawing.Point(0, 0);
            this.courseInfo.Name = "courseInfo";
            this.courseInfo.Size = new System.Drawing.Size(284, 37);
            this.courseInfo.TabIndex = 1;
            this.courseInfo.Load += new System.EventHandler(this.courseInfo_Load);
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FullName.BackColor = System.Drawing.Color.Transparent;
            this.FullName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FullName.Location = new System.Drawing.Point(0, 233);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(284, 28);
            this.FullName.TabIndex = 0;
            // 
            // MiddlePanel
            // 
            this.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddlePanel.Location = new System.Drawing.Point(0, 37);
            this.MiddlePanel.Name = "MiddlePanel";
            this.MiddlePanel.Size = new System.Drawing.Size(284, 196);
            this.MiddlePanel.TabIndex = 4;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MiddlePanel);
            this.Controls.Add(this.courseInfo);
            this.Controls.Add(this.FullName);
            this.Name = "BaseDialogForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Full_Name FullName;
        private Course courseInfo;
        private System.Windows.Forms.Panel MiddlePanel;

    }
}