Feature: Seller Profile Languages
As a Seller
I want to add Languages to my Profile Details
So that visitor can my profile can see what language i know.

# profile language add
@sellerprofiletest
Scenario Outline: Add Profile Languages with data
	Given I am on the Trade Skills portal 
	And  I click on language Add New Button
	When I Enter the data in '<AddLanguage>' and '<Languagelevel>' and click on Add button
	Then A popup with '<Message>' should be displayed
		
	Examples: 
    | AddLanguage | Languagelevel | Message                                  |
    | English     | Fluent        | English has been added to your languages |
    | French      | Basic         | French has been added to your languages  |
    | Spanish     | fluent        | Spanish has been added to youe languages |
	| Irish       | Basic         | Irish has been added to your languages   |

	
@sellerprofiletest
Scenario: Add Profile Languages without data
	Given I am on the Trade Skills portal
	And I click on Add New Button 
	When I click on Add button  without data in Language and language level field 
	Then a popup with (Please enter language and level) should be displayed
	

@sellerprofiletest
Scenario: Add Profile Languages with only Language 
	Given I am on the Trade Skills portal
	And I click on Add New button
	When I Enter Language and click on Add button
	Then a popup with (Please entry language and level) should be displayed
			

			
@sellerprofiletest
Scenario: Add Profile Languages with only Language level
    Given I am on the Trade Skills portal
	And I click on Add New button
	When I Select language level and click on Add button
	Then a popup with (Please enter language and level) should be displayed
	
	
@sellerprofiletest
Scenario: Add Profile Languages with Specal characters  languages and with language level
	Given I am on the Trade Skills portal
	And I click on Add New button
	When I Enter Specal characters in Language and select language level and click on Add button
	Then Laguages should be Added and saved successfully
		
		
#profile language edit
	
@sellerprofiletest
Scenario: Edit Profile Languages with data
	Given I am on the Trade Skills portal
	And I click on language pen icon 
	When I Edited the data in '<Edit Language>' and '<Edit Language level>'  and click on update button
	Then A popup with '<Message>' should be displayed

  Examples: 
  | EditLanguage | EditLanguagelevel | Message                                     |
  | Engish        | Basic             | English has been updated on your languages |
		
		
Scenario: Edit Profile Languages without data
	Given I am on the Trade Skills portal
	And I click on pen icon 
	When I click on update button without data
	Then Laguages popup with (Please enter language and level) should be displayed
		
Scenario: Edit Profile Languages without Edited
	Given I am on the Trade Skills portal
	And I click on pen icon 
	When I click on update button without edited 
	Then Laguages popup with (This language is already added to your language list)  should be displayed
		
Scenario: Edit Profile Languages with only language
	Given I am on the Trade Skills portal
	And I click on pen icon 
	When I Edited the Language click on update button
	Then Laguages should be edited successfully
		
Scenario: Edit Profile Languages with only language level
	Given I am on the Trade Skills portal
	And I click on pen icon 
	When I edited language level and click on update button
	Then Laguages should be edited successfully
		
		
#	profile language delete
		
@sellerprofiletest
Scenario: Profile Languages delete
	Given I am on the Trade Skills portal
	And I click language delet icon
	Then A popup with '<Message>' should be displayed


 Examples: 
         | Message |
         | Spanish has been deleted from your languages |