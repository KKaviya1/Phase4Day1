using OurCalcLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    //    public sealed class CalculatorStepDefinitions
    //    {
    //        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
    //        //    private SimpleCalc calc = new SimpleCalc();
    //        //    private int myresult;

    //        //    [Given("the first number is (.*)")]
    //        //    public void GivenTheFirstNumberIs(int number)
    //        //    {
    //        //        //TODO: implement arrange (precondition) logic
    //        //        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
    //        //        // To use the multiline text or the table argument of the scenario,
    //        //        // additional string/Table parameters can be defined on the step definition
    //        //        // method. 


    //        //        calc.FirstNumber = number;
    //        //    }

    //        //    [Given("the second number is (.*)")]
    //        //    public void GivenTheSecondNumberIs(int number)
    //        //    {
    //        //        //TODO: implement arrange (precondition) logic


    //        //        calc.SecondNumber = number;
    //        //    }

    //        //    [When("the two numbers are added")]
    //        //    public void WhenTheTwoNumbersAreAdded()
    //        //    {
    //        //        //TODO: implement act (action) logic

    //        //        calc.Add();
    //        //    }

    //        //    [Then("the result should be (.*)")]
    //        //    public void ThenTheResultShouldBe(int result)
    //        //    {
    //        //        //TODO: implement assert (verification) logic
    //        //        myresult = result;
    //        //    }
    //        //}


    //        private readonly SimpleCalc _calculator = new SimpleCalc();
    //        private int _result;

    //        [Given("the first number is (.*)")]
    //        public void GivenTheFirstNumberIs(int number)
    //        {
    //            //TODO: implement arrange (precondition) logic
    //            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
    //            // To use the multiline text or the table argument of the scenario,
    //            // additional string/Table parameters can be defined on the step definition
    //            // method. 


    //            _calculator.FirstNumber = number;
    //        }

    //        [Given("the second number is (.*)")]
    //        public void GivenTheSecondNumberIs(int number)
    //        {
    //            //TODO: implement arrange (precondition) logic


    //            _calculator.SecondNumber = number;
    //        }

    //        [When("the two numbers are added")]
    //        public void WhenTheTwoNumbersAreAdded()
    //        {
    //            //TODO: implement act (action) logic

    //            _result=_calculator.Add();
    //        }

    //        [Then("the result should be (.*)")]
    //        public void ThenTheResultShouldBe(int result)
    //        {
    //            //TODO: implement assert (verification) logic
    //            _result.Should().Be(result);
    //        }
    //    }
    //}


    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private SimpleCalc calc = new SimpleCalc();
        private int myResult;

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calc.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calc.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            myResult = calc.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            myResult.Should().Be(result);
        }
    }
}