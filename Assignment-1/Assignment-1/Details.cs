namespace Assignment_1
{
    public class Details
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public bool AuthenticateUser(string UserName, string Password)
        {

            if (UserName == "admin" && Password == "password")
            {
                return true;
            }
            return false;
        }


    }
 }