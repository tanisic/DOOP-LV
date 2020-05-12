using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class UserValidator : IRegistrationValidator
    {
        private PasswordValidator PasswordValidator;
        private EmailValidator EmailValidator;
        public UserValidator()
        {
            PasswordValidator = new PasswordValidator(10);
            EmailValidator = new EmailValidator();
        }
        public bool IsUserEntryValid(UserEntry entry)
        {
            if (PasswordValidator.IsValidPassword(entry.Password) && EmailValidator.IsValidAddress(entry.Email))
                return true;
            else
            return false;
        }
    }
}
