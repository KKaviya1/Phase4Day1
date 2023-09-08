using Assignment_1;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        
            [Given("the user is on the login page")]
            public void GivenTheUserIsOnTheLoginPage()
            {
                // Add code to navigate to your application's login page
                // Example: YourNavigationClass.GoToLoginPage();
            }

            [When("the user enters valid username and password")]
            public void WhenTheUserEntersValidUsernameAndPassword()
            {
                // Add code to input valid credentials
                // Example: YourLoginPageClass.EnterCredentials("validUsername", "validPassword");
            }

            [When("the user enters invalid username or password")]
            public void WhenTheUserEntersInvalidUsernameOrPassword()
            {
                // Add code to input invalid credentials
                // Example: YourLoginPageClass.EnterCredentials("invalidUsername", "invalidPassword");
            }

            [When("the user doesn't provide a username or password")]
            public void WhenTheUserDoesntProvideAUsernameOrPassword()
            {
                // Add code to leave the username and/or password fields blank
                // Example: YourLoginPageClass.LeaveCredentialsBlank();
            }

            [When("clicks the login button")]
            public void WhenClicksTheLoginButton()
            {
                // Add code to perform a click action on the login button
                // Example: YourLoginPageClass.ClickLoginButton();
            }

            [Then("they should be logged in successfully")]
            public void ThenTheyShouldBeLoggedInSuccessfully()
            {
                // Add code to verify successful login, e.g., assert user is redirected to a dashboard
                // Example: Assert.IsTrue(YourDashboardPageClass.IsDashboardDisplayed());
            }

            [Then("they should see an error message")]
            public void ThenTheyShouldSeeAnErrorMessage()
            {
                // Add code to verify that an error message is displayed
                // Example: Assert.IsTrue(YourLoginPageClass.IsErrorMessageDisplayed());
            }

            [Then("they should see a validation message")]
            public void ThenTheyShouldSeeAValidationMessage()
            {
                // Add code to verify that a validation message is displayed
                // Example: Assert.IsTrue(YourLoginPageClass.IsValidationMessageDisplayed());
            }
        }
    }
















