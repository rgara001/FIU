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
            this.middlePanel = new System.Windows.Forms.Panel();
            this.courseInfo = new Control_Library.Course();
            this.FullName = new Control_Library.Full_Name();
            this.SuspendLayout();
            // 
            // middlePanel
            // 
            this.middlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlePanel.BackColor = System.Drawing.Color.Transparent;
            this.middlePanel.Location = new System.Drawing.Point(0, 37);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(284, 196);
            this.middlePanel.TabIndex = 0;
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
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.courseInfo);
            this.Controls.Add(this.FullName);
            this.Name = "BaseDialogForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Full_Name FullName;
        private Course courseInfo;
        protected internal System.Windows.Forms.Panel middlePanel;

    }
}