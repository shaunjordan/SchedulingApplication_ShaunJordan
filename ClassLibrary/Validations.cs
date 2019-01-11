using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Validations
    {
        //public delegate bool FieldValidation(TextBox text);

       public bool Error(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
