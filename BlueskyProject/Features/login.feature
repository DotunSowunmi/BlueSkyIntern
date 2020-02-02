Feature: login
	As a registered user of Giftrete.com
	I want to login
	So that I can get freebie

Scenario: Login with valid user details
	Given I navigate to the website
		And I click on login button
	When I enter username 
		And I enter the password
	Then I am logged in
