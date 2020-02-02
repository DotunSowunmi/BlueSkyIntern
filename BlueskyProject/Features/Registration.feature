Feature: Registration
	In order to use giftrete.com
	I need to register

 Scenario: Registration 
	Given I navigate to the website
		And I click on the Register button
	When I enter the First name
		And I enter the Last name
		And I enter the password
		And I enter the confirm password
		And I click the sign Up button
	Then I should be logged in
	

	Scenario: Registration Negative Test 
	Given I navigate to the website
		And I click on the Register button
	When I enter the First name "Dotun"
		And I enter the Last name "Sowunmi"
		And I enter the password "My Secure Password"
		And I enter a wrong password for the confirm password
		And I click the sign Up button
	Then I should NOT be logged in
	   

Scenario Outline: Registration Negative Test with Parameter
	When I enter the First name "<FirstName>"
		And I enter the Last name "<LastName>"
		And I enter the password "<Password>"
		And I enter a wrong password "<ConfirmPAssword>" for the confirm password
		And I click the sign Up button
	Then I should NOT be logged in	

		Examples: 
		| Firstname | Lastname | Password     | ConfirmPAssword |
		| Dotun      | Sowunmi  | MySecurePass | MySecurePAss    |