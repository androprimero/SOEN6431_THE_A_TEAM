namespace AcademicManagementSystem.UserInterface
{
    partial class StudentForm
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
            this.lblStudentForm = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.pnlStudentBody = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlStudentBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentForm
            // 
            this.lblStudentForm.AutoSize = true;
            this.lblStudentForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStudentForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStudentForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentForm.ForeColor = System.Drawing.Color.Green;
            this.lblStudentForm.Location = new System.Drawing.Point(0, 0);
            this.lblStudentForm.Name = "lblStudentForm";
            this.lblStudentForm.Size = new System.Drawing.Size(117, 26);
            this.lblStudentForm.TabIndex = 1;
            this.lblStudentForm.Text = "Student Form";
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblStudentForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(800, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // pnlStudentBody
            // 
            this.pnlStudentBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlStudentBody.Controls.Add(this.pnlFormTitle);
            this.pnlStudentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudentBody.Location = new System.Drawing.Point(0, 0);
            this.pnlStudentBody.Name = "pnlStudentBody";
            this.pnlStudentBody.Size = new System.Drawing.Size(800, 600);
            this.pnlStudentBody.TabIndex = 1;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlStudentBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlStudentBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudentForm;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlStudentBody;
    }
}