using CalcLib;
namespace CalculatorTestPro
{
    public class UnitTest1
    {
        Calculator calculator = new();
        [Fact]
        public void Test1()
        {
            int num1, num2;
            num1 = 10;
            num2 = 10;
            Assert.Equal(num1, num2);
        }
        [Fact]
        public void AddTest()
        {
            double num1, num2, result;
            num1 = 10;
            num2 = 5;
            result = 15;
            Assert.Equal(result,calculator.Add(num1, num2));
        }
        [Fact]
        public void SubTest()
        {
            int num1,num2,result;
            num1 = 10;
            num2 = 5;
            result = 5;
            Assert.Equal(result, calculator.Sub(num1, num2));
        }

        [Fact]
        public void MultiTest()
        {
            int num1,num2, result;
            num1 = 10;
            num2 = 5;
            result = 50;
            Assert.Equal(result, calculator.Multi(num1, num2));
        }

        [Fact]
        public void DivisionTest()
        {
            int num1,num2,result;
            num1 = 10;
            num2 = 5;
            result = 2;
            Assert.Equal(result, calculator.Div(num1, num2));
        }

        [Fact]
        public void AvgTest()
        {
            int num1,num2,result;
            num1 = 10;
            num2 = 10;
            result = 10;
            Assert.Equal(result, calculator.Avg(num1, num2));
        }
    }
}