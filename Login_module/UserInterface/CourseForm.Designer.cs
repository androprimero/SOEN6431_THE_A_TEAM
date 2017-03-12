namespace AcademicManagementSystem.UserInterface
{
    partial class CourseForm
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
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblCourseForm = new System.Windows.Forms.Label();
            this.pnlCourseBody = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlCourseBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblCourseForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(800, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // lblCourseForm
            // 
            this.lblCourseForm.AutoSize = true;
            this.lblCourseForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCourseForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCourseForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseForm.Location = new System.Drawing.Point(0, 0);
            this.lblCourseForm.Name = "lblCourseForm";
            this.lblCourseForm.Size = new System.Drawing.Size(108, 26);
            this.lblCourseForm.TabIndex = 1;
            this.lblCourseForm.Text = "Course Form";
            // 
            // pnlCourseBody
            // 
            this.pnlCourseBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlCourseBody.Controls.Add(this.pnlFormTitle);
            this.pnlCourseBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCourseBody.Location = new System.Drawing.Point(0, 0);
            this.pnlCourseBody.Name = "pnlCourseBody";
            this.pnlCourseBody.Size = new System.Drawing.Size(800, 600);
            this.pnlCourseBody.TabIndex = 3;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlCourseBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlCourseBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblCourseForm;
        private System.Windows.Forms.Panel pnlCourseBody;
    }
}