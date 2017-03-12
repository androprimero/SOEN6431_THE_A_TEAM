namespace AcademicManagementSystem.UserInterface
{
    partial class DepartmentForm
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
            this.lblDeprtmentForm = new System.Windows.Forms.Label();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.pnlDepartmentBody = new System.Windows.Forms.Panel();
            this.pnlFormTitle.SuspendLayout();
            this.pnlDepartmentBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeprtmentForm
            // 
            this.lblDeprtmentForm.AutoSize = true;
            this.lblDeprtmentForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDeprtmentForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDeprtmentForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeprtmentForm.ForeColor = System.Drawing.Color.Purple;
            this.lblDeprtmentForm.Location = new System.Drawing.Point(0, 0);
            this.lblDeprtmentForm.Name = "lblDeprtmentForm";
            this.lblDeprtmentForm.Size = new System.Drawing.Size(145, 26);
            this.lblDeprtmentForm.TabIndex = 1;
            this.lblDeprtmentForm.Text = "Department Form";
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblDeprtmentForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(800, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // pnlDepartmentBody
            // 
            this.pnlDepartmentBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDepartmentBody.Controls.Add(this.pnlFormTitle);
            this.pnlDepartmentBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepartmentBody.Location = new System.Drawing.Point(0, 0);
            this.pnlDepartmentBody.Name = "pnlDepartmentBody";
            this.pnlDepartmentBody.Size = new System.Drawing.Size(800, 600);
            this.pnlDepartmentBody.TabIndex = 1;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlDepartmentBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DepartmentForm";
            this.Text = "Department";
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.pnlDepartmentBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeprtmentForm;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Panel pnlDepartmentBody;
    }
}