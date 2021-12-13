Feature: Login
      As a seller on Mars portal
	  I want to be able to register
	  So that visitors can view my details
	
@mytag
Scenario: Login to website
	Given I login to the website


@myTest
Scenario: Create profile languate
     Given  I am on the language tab
	 And I enter my details
	 When I click on the add new button
	 Then My details should be successfully added

