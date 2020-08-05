using System;
using System.Collections.Generic;
using System.Text;

namespace fandom.Model.Requests
{
   public class UserInsertRequest
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string PasswordConfirmation { get; set; }

    }
}
