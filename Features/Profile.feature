Feature: profile
	As a seller
	I want to be able to add my profile to the portal 
	So that visitors to the site will be able to view my details.

@sellerprofilesetting
Scenario: create Profile name 
	Given I am on the profile page 
	And I click on the name expand icon
	When I enter my First name, last name,availabily, hours, earned target and click on Save button
	Then Name and profile details should be saved successfully

@sellerprofiletest
Scenario: Edit Profile name without data
    Given I am logged onto the portal
	And I click on name expand icon
	When I click on save button without any data
	Then a pop up with(First name,Last name are required)should be displayed

@sellerprofiletest
Scenario: Edit Profile with only the first name
    Given I am logged onto the portal
	And I click on name expand icon
	When I enter the first name and click on save button
	Then a pop up with(First Name,Last Name are required)should be displayed
 
 
@sellerprofiletest
Scenario: Edit Profile with only the last name
    Given I am logged onto the portal
	And I click on name expand icon
	When I enter the last name and click on save button
	Then a pop up with(First Name,Last Name are required)should be displayed

@sellerAvailabilitytest
Scenario: Add Profile Availability
    Given I am on the profile section
	And I click on the availability pen icon
	And I select the dropdown button
	When I select a value from the dropdown
	Then Availability should be saved successfully

@sellerHourstest
Scenario: Add Profile Hours
    Given I am on the profile section
	And I click on the hours pen icon
	And I select the dropdown button
	When I select a value from the dropdown
	Then Hours should be saved successfully

 
@sellerEarnTargettest
Scenario: Add Profile Earn Target
    Given I am on the profile section
	And I click on the Earn Target pen icon
	And I select the dropdown button
	When I select a value from the dropdown
	Then Earn target should be saved successfully

 

