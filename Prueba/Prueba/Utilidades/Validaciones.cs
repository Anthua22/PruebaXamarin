using Plugin.ValidationRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Prueba.Utilidades
{
    public class Validaciones: IValidationRule<string>
    {
        static readonly Regex patronUser = new Regex("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*");
        static readonly Regex patronPass = new Regex(@"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$");

        public string ValidationMessage { get ; set ; }

        public static bool ValidarEmail(string email)
        {
            if (patronUser.IsMatch(email) && !string.IsNullOrWhiteSpace(email))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarPass(string pass)
        {
            if(patronPass.IsMatch(pass) && !string.IsNullOrWhiteSpace(pass))
            {
                return true;
            }
            return false;
        }

        public bool Check(string value)
        {
            if(value == null)
            {
                return false;
            }
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
