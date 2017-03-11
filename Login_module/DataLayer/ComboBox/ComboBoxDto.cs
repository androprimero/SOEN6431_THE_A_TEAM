using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademicManagementSystem.DataLayer.ComboBox
{
    public class ComboBoxDto
    {

        public string Code { get; set; }
        public string Description { get; set; }


        public ComboBoxDto(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
