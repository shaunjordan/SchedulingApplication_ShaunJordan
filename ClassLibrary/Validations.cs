﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary
{
    public class Validations
    {
       public delegate void FieldValidation(string textboxValue);

       public void Error(FieldValidation fieldValidation)
        {
            string errors = "";

            errors += "Error";

            fieldValidation(errors);
            //if (String.IsNullOrWhiteSpace(value))
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }

    }
}
