namespace TinyCollege
{
    partial class frmAddStudent
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
            this.lblstuInfo = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblstuInfo
            // 
            this.lblstuInfo.AutoSize = true;
            this.lblstuInfo.Location = new System.Drawing.Point(12, 27);
            this.lblstuInfo.Name = "lblstuInfo";
            this.lblstuInfo.Size = new System.Drawing.Size(255, 25);
            this.lblstuInfo.TabIndex = 0;
            this.lblstuInfo.Text = "Enter Student Information";
            this.lblstuInfo.Click += new System.EventHandler(this.lblstuInfo_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(12, 117);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(211, 25);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Enter Student Name:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(26, 211);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(316, 119);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "&Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(408, 211);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(316, 119);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(279, 117);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(445, 31);
            this.txtStudentName.TabIndex = 4;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 386);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblstuInfo);
            this.Name = "frmAddStudent";
            this.Text = "Add a Student";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstuInfo;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtStudentName;
    }
}