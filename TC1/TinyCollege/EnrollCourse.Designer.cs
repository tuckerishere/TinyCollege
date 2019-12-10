namespace TinyCollege
{
    partial class frmEnrollCourse
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
            this.lblEnrollmentData = new System.Windows.Forms.Label();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.cmbStudentSelect = new System.Windows.Forms.ComboBox();
            this.cmbCourseSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblEnrollmentData
            // 
            this.lblEnrollmentData.AutoSize = true;
            this.lblEnrollmentData.Location = new System.Drawing.Point(32, 9);
            this.lblEnrollmentData.Name = "lblEnrollmentData";
            this.lblEnrollmentData.Size = new System.Drawing.Size(165, 25);
            this.lblEnrollmentData.TabIndex = 0;
            this.lblEnrollmentData.Text = "Enrollment Data";
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Location = new System.Drawing.Point(32, 102);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(158, 25);
            this.lblSelectStudent.TabIndex = 1;
            this.lblSelectStudent.Text = "Select Student:";
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(32, 200);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(171, 25);
            this.lblSelectCourse.TabIndex = 2;
            this.lblSelectCourse.Text = "Select a Course:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(395, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(268, 70);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(37, 322);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(268, 70);
            this.btnEnroll.TabIndex = 7;
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // cmbStudentSelect
            // 
            this.cmbStudentSelect.FormattingEnabled = true;
            this.cmbStudentSelect.Location = new System.Drawing.Point(256, 102);
            this.cmbStudentSelect.Name = "cmbStudentSelect";
            this.cmbStudentSelect.Size = new System.Drawing.Size(407, 33);
            this.cmbStudentSelect.TabIndex = 8;
            this.cmbStudentSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbCourseSelect
            // 
            this.cmbCourseSelect.FormattingEnabled = true;
            this.cmbCourseSelect.Location = new System.Drawing.Point(256, 200);
            this.cmbCourseSelect.Name = "cmbCourseSelect";
            this.cmbCourseSelect.Size = new System.Drawing.Size(407, 33);
            this.cmbCourseSelect.TabIndex = 9;
            this.cmbCourseSelect.SelectedIndexChanged += new System.EventHandler(this.cmbCourseSelect_SelectedIndexChanged);
            // 
            // frmEnrollCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.cmbCourseSelect);
            this.Controls.Add(this.cmbStudentSelect);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lblSelectStudent);
            this.Controls.Add(this.lblEnrollmentData);
            this.Name = "frmEnrollCourse";
            this.Text = "Enroll a Student in a Course";
            this.Load += new System.EventHandler(this.frmEnrollCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnrollmentData;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.ComboBox cmbStudentSelect;
        private System.Windows.Forms.ComboBox cmbCourseSelect;
    }
}