using Xunit;
using CalcLib;

namespace CalculatorTestPro
{
    public class SignTestFile
    {
        [Fact]

        public void  SignInTest()
        {
            string result = "Invalid Credential";
            string userName = "amit";
            string userPwd = "amit@123";
            Assert.Equal(result, SignIn.SignInCheck(userName, userPwd));
        }
    }
}
