using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AcademicManagementSystem.Common
{
    public class CommonFunctions
    {
        public Int64 ValidateLongInteger(string input)
        {
            Int64 output = 0;
            if (Int64.TryParse(input, out output))
                return output;
            return output;
        }

        public Int32 ValidateInteger(string input)
        {
            Int32 output = 0;
            if (Int32.TryParse(input, out output))
                return output;
            return output;
        }

        public void LoadInfoMessagePanel(PictureBox imgWow, PictureBox imgOops, Label lblError, Label lblSuccess, bool isError, string message)
        {
            if(isError)
            {
                imgWow.Visible = false;
                imgOops.Visible = true;
                lblSuccess.Text = "";
                lblError.Text = message;
            }
            else
            {
                imgWow.Visible = true; 
                imgOops.Visible =false;
                lblSuccess.Text =message;
                lblError.Text = ""; 
            }
        }
        public void ClearInfoMessagePanel(PictureBox imgWow, PictureBox imgOops, Label lblError, Label lblSuccess)
        {
            imgWow.Visible = false;
            imgOops.Visible = false;
            lblSuccess.Text = "";
            lblError.Text = "";
        }

    }
}
