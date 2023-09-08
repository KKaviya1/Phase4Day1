using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
     public class SignIn
      {
        public static string SignInCheck(string userName, string userPwd)
        {
            string msg = "";
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userPwd))
            {
                msg = "Please provide userName and Password";

            }
            else
            {
                if ((userName == "sam") || (userPwd == "sam@1256"))
                {
                    msg = "SignIn Success";
                }
                else
                {
                    msg = "Invalid Credential";
                }
            }
            return msg;

        }
    }
}