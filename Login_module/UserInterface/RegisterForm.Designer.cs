namespace AcademicManagementSystem.UserInterface
{
    partial class RegisterForm
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
            this.pnlRegisterBody = new System.Windows.Forms.Panel();
            this.pnlFormTitle = new System.Windows.Forms.Panel();
            this.lblRegisterForm = new System.Windows.Forms.Label();
            this.pnlRegisterBody.SuspendLayout();
            this.pnlFormTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegisterBody
            // 
            this.pnlRegisterBody.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRegisterBody.Controls.Add(this.pnlFormTitle);
            this.pnlRegisterBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRegisterBody.Location = new System.Drawing.Point(0, 0);
            this.pnlRegisterBody.Name = "pnlRegisterBody";
            this.pnlRegisterBody.Size = new System.Drawing.Size(800, 600);
            this.pnlRegisterBody.TabIndex = 2;
            // 
            // pnlFormTitle
            // 
            this.pnlFormTitle.Controls.Add(this.lblRegisterForm);
            this.pnlFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlFormTitle.Name = "pnlFormTitle";
            this.pnlFormTitle.Size = new System.Drawing.Size(800, 32);
            this.pnlFormTitle.TabIndex = 0;
            // 
            // lblRegisterForm
            // 
            this.lblRegisterForm.AutoSize = true;
            this.lblRegisterForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegisterForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRegisterForm.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterForm.ForeColor = System.Drawing.Color.Blue;
            this.lblRegisterForm.Location = new System.Drawing.Point(0, 0);
            this.lblRegisterForm.Name = "lblRegisterForm";
            this.lblRegisterForm.Size = new System.Drawing.Size(117, 26);
            this.lblRegisterForm.TabIndex = 1;
            this.lblRegisterForm.Text = "Register Form";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlRegisterBody);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.pnlRegisterBody.ResumeLayout(false);
            this.pnlFormTitle.ResumeLayout(false);
            this.pnlFormTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegisterBody;
        private System.Windows.Forms.Panel pnlFormTitle;
        private System.Windows.Forms.Label lblRegisterForm;
    }
}