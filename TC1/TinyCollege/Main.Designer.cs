namespace TinyCollege
{
    partial class frmMain
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEnroll = new System.Windows.Forms.Button();
            this.btnCourseEnrolled = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnWhoCourse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(122, 148);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(283, 113);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEnroll
            // 
            this.btnEnroll.Location = new System.Drawing.Point(122, 303);
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(283, 113);
            this.btnEnroll.TabIndex = 1;
            this.btnEnroll.Text = "Enroll a Student In a Course";
            this.btnEnroll.UseVisualStyleBackColor = true;
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnCourseEnrolled
            // 
            this.btnCourseEnrolled.Location = new System.Drawing.Point(122, 464);
            this.btnCourseEnrolled.Name = "btnCourseEnrolled";
            this.btnCourseEnrolled.Size = new System.Drawing.Size(283, 113);
            this.btnCourseEnrolled.TabIndex = 2;
            this.btnCourseEnrolled.Text = "Courses Student is Enrolled In";
            this.btnCourseEnrolled.UseVisualStyleBackColor = true;
            this.btnCourseEnrolled.Click += new System.EventHandler(this.btnCourseEnrolled_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(562, 148);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(283, 113);
            this.btnAddCourse.TabIndex = 3;
            this.btnAddCourse.Text = "Add a Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnWhoCourse
            // 
            this.btnWhoCourse.Location = new System.Drawing.Point(562, 303);
            this.btnWhoCourse.Name = "btnWhoCourse";
            this.btnWhoCourse.Size = new System.Drawing.Size(283, 113);
            this.btnWhoCourse.TabIndex = 4;
            this.btnWhoCourse.Text = "Who is in a Course";
            this.btnWhoCourse.UseVisualStyleBackColor = true;
            this.btnWhoCourse.Click += new System.EventHandler(this.btnWhoCourse_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(562, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(283, 113);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(822, 79);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tiny College Course Tracking System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWhoCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnCourseEnrolled);
            this.Controls.Add(this.btnEnroll);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "frmMain";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEnroll;
        private System.Windows.Forms.Button btnCourseEnrolled;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnWhoCourse;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

