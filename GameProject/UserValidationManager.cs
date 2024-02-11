using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class UserValidationManager: IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "cihat" && user.IdentityNumber == 123)
            {
                return true;
            }
            else return false;
        }
    }
}
