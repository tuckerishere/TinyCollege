namespace TinyCollege
{
    partial class frmAddCourse
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
            this.lblCourseData = new System.Windows.Forms.Label();
            this.lblSemesterOffered = new System.Windows.Forms.Label();
            this.lblCourseTitle = new System.Windows.Forms.Label();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCourseData
            // 
            this.lblCourseData.AutoSize = true;
            this.lblCourseData.Location = new System.Drawing.Point(17, 14);
            this.lblCourseData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseData.Name = "lblCourseData";
            this.lblCourseData.Size = new System.Drawing.Size(94, 13);
            this.lblCourseData.TabIndex = 0;
            this.lblCourseData.Text = "Enter Course Data";
            // 
            // lblSemesterOffered
            // 
            this.lblSemesterOffered.AutoSize = true;
            this.lblSemesterOffered.Location = new System.Drawing.Point(17, 141);
            this.lblSemesterOffered.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemesterOffered.Name = "lblSemesterOffered";
            this.lblSemesterOffered.Size = new System.Drawing.Size(92, 13);
            this.lblSemesterOffered.TabIndex = 1;
            this.lblSemesterOffered.Text = "Semester Offered:";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(17, 68);
            this.lblCourseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(66, 13);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title:";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(139, 82);
            this.txtCourseTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(206, 20);
            this.txtCourseTitle.TabIndex = 3;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(20, 198);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(137, 34);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(206, 198);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbSemester
            // 
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall",
            "Winter"});
            this.cmbSemester.Location = new System.Drawing.Point(139, 137);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(206, 21);
            this.cmbSemester.TabIndex = 7;
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 267);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.lblSemesterOffered);
            this.Controls.Add(this.lblCourseData);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddCourse";
            this.Text = "Add a Course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseData;
        private System.Windows.Forms.Label lblSemesterOffered;
        private System.Windows.Forms.Label lblCourseTitle;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbSemester;
    }
}