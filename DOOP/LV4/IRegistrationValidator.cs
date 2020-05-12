using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    interface IRegistrationValidator
    {
       static PasswordValidator PasswordValidator;
       static  EmailValidator EmailValidator;
        bool IsUserEntryValid(UserEntry entry);
    }
}
