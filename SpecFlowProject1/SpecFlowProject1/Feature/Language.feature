Feature: Profile Language
	As a Seller on Mars
	I want to add language details to my Profile 
	So that visitors can view my Languages.

@addlanguage1
Scenario: Add Profile Language with invalid data
	Given I login to the mars portal
	And I click on the Add New button under Languages tab
	When I click on the Add button without records
	And The display error popup message of '<Message>' will appear
	And I enter the data in level of '<Level>' and click on Add button
	And The display error popup message '<Message>' will appear
	And I enter the data in language of '<Language>' and click on Add button
	Then The display error popup message '<Message>' will appear
	
	Examples:
	| Language | Level            | Message                         |
	|          |                  | Please enter language and level |
	|          | Native/Bilingual | Please enter language and level |
	| Edo      |                  | Please enter language and level |



@addlanguage2
Scenario: Add Profile Language with data
	Given I login to the Trade Skills portal in the Profile successfully
	And I click on the Add New button under Languages tab
	When I enter the data in language and level '<Language>', '<Level>' and click on Add button
	And The popup message of '<message>' will appear
	Then The new row should be added as '<Language>', '<Level>' successfully

	Examples:
	| Language | Level  | message                              |
	| Edo      | Fluent | Edo has been added to your languages |


@addlanguage3
Scenario: Add Profile Language with duplicate data
	Given I login to the mars portal
	And I click on Add New button under Languages section
	When I enter the records in language,level '<Language>', '<SecondLevel>' and click on Add button
	And The popup with '<Message>' should be displayed
	And I enter the data in language and level '<Language>', '<SecondLevel>' and click on Add button
	Then The error popup '<Message>' should be displayed
	
	Examples:
	| Language | Level  | SecondLevel    | Message                                               |
	| English  | Fluent | Conversational | This language is already exist in your language list. |
	| English  | Fluent | Fluent         | Duplicated data                                       |



@editlanguage
Scenario: Edit Profile Language with data
	Given I login to the mars portal
	And I click on Edit pen icon under Languages tab
	When I edit the data in language and level '<Language>', '<Level>' and click on Add button
	And The popup '<Message>' should be displayed
	Then The new row should be edited as '<Language>', '<Level>' successfully

	Examples:
	| Language | Level            | Message                                    |
	| English  | Native/Bilingual | English has been updated to your languages |



@deletelanguage
Scenario: Delete Profile Language
	Given I login to the mars portal
	And I click on delete icon under Languages tab
	When The prompt message of the '<Message>' will shown
	Then the Language should have the deleted successfully

	Examples:
	| Message                                      |
	| English has been deleted from your languages |
