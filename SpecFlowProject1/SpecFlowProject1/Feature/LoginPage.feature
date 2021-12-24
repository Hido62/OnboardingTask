Feature: LoginPage
	As a user I want to login to the Mars Portal
	So I can be on the home page 

@automate
Scenario: Navigate to the Login page with valid credentials 
	Given I logged into the mars portal
	And I click on the sign in button
	When I enter valid '<Email>', '<Password>' details
	Then I navigate to the profile page successfully

	Examples: 
	| Email                        | Password    |
	| ogedengbe_idowu@yahoo.co.uk  | Okheme62.   |