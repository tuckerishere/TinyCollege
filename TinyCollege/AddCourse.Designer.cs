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
            this.txtSemesterOffered = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseData
            // 
            this.lblCourseData.AutoSize = true;
            this.lblCourseData.Location = new System.Drawing.Point(34, 27);
            this.lblCourseData.Name = "lblCourseData";
            this.lblCourseData.Size = new System.Drawing.Size(189, 25);
            this.lblCourseData.TabIndex = 0;
            this.lblCourseData.Text = "Enter Course Data";
            // 
            // lblSemesterOffered
            // 
            this.lblSemesterOffered.AutoSize = true;
            this.lblSemesterOffered.Location = new System.Drawing.Point(34, 271);
            this.lblSemesterOffered.Name = "lblSemesterOffered";
            this.lblSemesterOffered.Size = new System.Drawing.Size(186, 25);
            this.lblSemesterOffered.TabIndex = 1;
            this.lblSemesterOffered.Text = "Semester Offered:";
            // 
            // lblCourseTitle
            // 
            this.lblCourseTitle.AutoSize = true;
            this.lblCourseTitle.Location = new System.Drawing.Point(34, 131);
            this.lblCourseTitle.Name = "lblCourseTitle";
            this.lblCourseTitle.Size = new System.Drawing.Size(134, 25);
            this.lblCourseTitle.TabIndex = 2;
            this.lblCourseTitle.Text = "Course Title:";
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(278, 131);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.Size = new System.Drawing.Size(409, 31);
            this.txtCourseTitle.TabIndex = 3;
            // 
            // txtSemesterOffered
            // 
            this.txtSemesterOffered.Location = new System.Drawing.Point(278, 265);
            this.txtSemesterOffered.Name = "txtSemesterOffered";
            this.txtSemesterOffered.Size = new System.Drawing.Size(409, 31);
            this.txtSemesterOffered.TabIndex = 4;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(39, 381);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(274, 66);
            this.btnAddCourse.TabIndex = 5;
            this.btnAddCourse.Text = "&Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(413, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(274, 66);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cl&ose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 513);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtSemesterOffered);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.lblCourseTitle);
            this.Controls.Add(this.lblSemesterOffered);
            this.Controls.Add(this.lblCourseData);
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
        private System.Windows.Forms.TextBox txtSemesterOffered;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnClose;
    }
}