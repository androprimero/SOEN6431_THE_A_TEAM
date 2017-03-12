namespace AcademicManagementSystem.UserInterface
{
    partial class FacultyForm
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
            this.pnlFacultyBody = new System.Windows.Forms.Panel();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblFacultyForm = new System.Windows.Forms.Label();
            this.pnlFacultyBody.SuspendLayout();
            this.pnlFormTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFacultyBody
            // 
            this.pnlFacultyBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlFacultyBody.Controls.Add(this.pnlFormTitle);
            this.pnlFacultyBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFacultyBody.Location = new System.Drawing.Point(0, 0);
            this.pnlFacultyBody.Name = "pnlFacultyBody";
            this.pnlFacultyBody.Size = new System.Drawing.Size(784, 561);
            this.pnlFacultyBody.TabIndex = 0;
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblFacultyForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(784, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // lblFacultyForm
            // 
            this.lblFacultyForm.AutoSize = true;
            this.lblFacultyForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFacultyForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFacultyForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacultyForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFacultyForm.Location = new System.Drawing.Point(0, 0);
            this.lblFacultyForm.Name = "lblFacultyForm";
            this.lblFacultyForm.Size = new System.Drawing.Size(118, 26);
            this.lblFacultyForm.TabIndex = 1;
            this.lblFacultyForm.Text = "Faculty Form";
            // 
            // FacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlFacultyBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FacultyForm";
            this.Text = "FacultyForm";
            this.pnlFacultyBody.ResumeLayout(false);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFacultyBody;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblFacultyForm;
    }
}