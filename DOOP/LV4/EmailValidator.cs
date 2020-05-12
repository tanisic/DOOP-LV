using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(string candidate)
        {           
            if (candidate.Contains('@') && (candidate.EndsWith(".hr") || candidate.EndsWith(".com"))) return true;
            return false;
        }
    }
}
