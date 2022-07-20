
namespace Chapter6Example1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.advisorCombobox = new System.Windows.Forms.ComboBox();
            this.advisorlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Advisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Advisee Names";
            // 
            // advisorCombobox
            // 
            this.advisorCombobox.FormattingEnabled = true;
            this.advisorCombobox.Location = new System.Drawing.Point(76, 50);
            this.advisorCombobox.Name = "advisorCombobox";
            this.advisorCombobox.Size = new System.Drawing.Size(200, 24);
            this.advisorCombobox.TabIndex = 2;
            // 
            // advisorlistBox
            // 
            this.advisorlistBox.FormattingEnabled = true;
            this.advisorlistBox.ItemHeight = 16;
            this.advisorlistBox.Location = new System.Drawing.Point(87, 225);
            this.advisorlistBox.Name = "advisorlistBox";
            this.advisorlistBox.Size = new System.Drawing.Size(441, 84);
            this.advisorlistBox.TabIndex = 3;
            this.advisorlistBox.SelectedIndexChanged += new System.EventHandler(this.advisorlistBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.advisorlistBox);
            this.Controls.Add(this.advisorCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox advisorCombobox;
        private System.Windows.Forms.ListBox advisorlistBox;
    }
}

