namespace TinyCollege
{
    partial class frmCurrentlyEnrolled
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
            this.grpStudentData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblStudentResults = new System.Windows.Forms.Label();
            this.lblCoursesByStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstCourseList = new System.Windows.Forms.ListBox();
            this.grpStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudentData
            // 
            this.grpStudentData.Controls.Add(this.lblStudentResults);
            this.grpStudentData.Controls.Add(this.btnFind);
            this.grpStudentData.Controls.Add(this.txtStudentID);
            this.grpStudentData.Controls.Add(this.lblStudentName);
            this.grpStudentData.Controls.Add(this.label1);
            this.grpStudentData.Location = new System.Drawing.Point(12, 0);
            this.grpStudentData.Name = "grpStudentData";
            this.grpStudentData.Size = new System.Drawing.Size(995, 238);
            this.grpStudentData.TabIndex = 0;
            this.grpStudentData.TabStop = false;
            this.grpStudentData.Text = "Student Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(26, 160);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(309, 51);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(298, 64);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(472, 31);
            this.txtStudentID.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(807, 46);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(177, 65);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // lblStudentResults
            // 
            this.lblStudentResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentResults.Location = new System.Drawing.Point(341, 160);
            this.lblStudentResults.Name = "lblStudentResults";
            this.lblStudentResults.Size = new System.Drawing.Size(643, 51);
            this.lblStudentResults.TabIndex = 5;
            // 
            // lblCoursesByStudent
            // 
            this.lblCoursesByStudent.AutoSize = true;
            this.lblCoursesByStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoursesByStudent.Location = new System.Drawing.Point(26, 273);
            this.lblCoursesByStudent.Name = "lblCoursesByStudent";
            this.lblCoursesByStudent.Size = new System.Drawing.Size(554, 51);
            this.lblCoursesByStudent.TabIndex = 6;
            this.lblCoursesByStudent.Text = "All Course by This Student: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 596);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(269, 71);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstCourseList
            // 
            this.lstCourseList.FormattingEnabled = true;
            this.lstCourseList.ItemHeight = 25;
            this.lstCourseList.Location = new System.Drawing.Point(35, 367);
            this.lstCourseList.Name = "lstCourseList";
            this.lstCourseList.Size = new System.Drawing.Size(961, 204);
            this.lstCourseList.TabIndex = 8;
            // 
            // frmCurrentlyEnrolled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 694);
            this.Controls.Add(this.lstCourseList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCoursesByStudent);
            this.Controls.Add(this.grpStudentData);
            this.Name = "frmCurrentlyEnrolled";
            this.Text = "What Course is a Student Currently Enrolled";
            this.grpStudentData.ResumeLayout(false);
            this.grpStudentData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudentData;
        private System.Windows.Forms.Label lblStudentResults;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCoursesByStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstCourseList;
    }
}