Feature: Login
![Login](https://w3layouts.com/wp-content/uploads/2016/07/simple_login_form.jpg)
Simple Login Page...
Link to a feature: [Login](SpecFlowProject/Features/Login.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Login

  Scenario: Valid Login
    Given the user is on the login page
    When the user enters valid username and password
    And clicks the login button
    Then they should be logged in successfully
@Login
  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid username or password
    And clicks the login button
    Then they should see an error message
@Login
  Scenario: Missing Credentials
    Given the user is on the login page
    When the user doesn't provide a username or password
    And clicks the login button
    Then they should see a validation message
