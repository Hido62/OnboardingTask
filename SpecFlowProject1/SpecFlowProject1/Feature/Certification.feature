Feature: Profile Certifications
	As a Seller on Mars portal
	I would like to add my Profile certification details 
	So that visitors to the site can view them

@addCertifications1
Scenario: Add Seller Profile Certifications with invalid data
	Given I login to the mars portal 
	And I navigate to the  Certifications tab
	And I click on Add New button under Certifications tab
	When I enter my details in '<Certificate>', '<From>' and click on Add button
	Then Error popup message '<Message>' should be displayed

	Examples:
	| Certificate | From  | Year | Message                                                                    |
	| ISTQB       | ISTQB |      | Please enter Certification Name, Certification From and Certification Year |



@addCertifications2
Scenario: Add Profile Certifications with valid data
	Given I login to the mars portal
	And I click on the Add New button under Certifications tab
	When I enter the details in '<Certificate>', '<From>', '<Year>' and click on add button
	Then My certification should be added  successfully

	Examples:
	| Certificate | From  | Year | Message                                    |
	| ISTQB       | ISTQB | 2019 | ISTQB has been added to your certification |



@addCertifications3
Scenario: Duplicate Profile Certifications details
	Given I login to the mars portal
	And I navigate to the Certifications tab
	When I enter the details in '<Certificate>', '<From>', '<SecondYear>' 
	And The error popup message of '<Message>' should be displayed
	And I enter the record '<Certificate>', '<From>', '<SecondYear>' and click on add button
	Then The display error popup message '<Message>' will shown

	Examples:
	| Certificate | From  | Year | SecondYear | Message                            |
	| ISTQB       | ISTQB | 2019 | 2019       | This information is already exist. |
	| ISTQB       | ISTQB | 2019 | 2020       | Duplicated data                    |




@editCertifications
Scenario: Edit  Profile Certifications with data
	Given I login to the mars portal
	And I click on the Certification pen icon
	When edit the data in '<Certificate>', '<From>', '<Year>' and click on Add button
	And The display prompt message '<Message>' should be displayed
	Then The new row should be updated as '<Certificate>', '<From>', '<Year>' successfully

	Examples:
	| Certificate | From     | Year | Message                                      |
	| ISTQB       | ISTQB-V2 | 2020 | ISTQB has been updated to your certification |



@deleteCertifications
Scenario: Delete Seller Certifications Language
	Given I login to the mars portal 
	And I click on delete icon under Certification tab
	When The popup message  '<Message>' should be displayed
	Then the Certification should have the deleted successfully

	Examples:
	| Message                                        |
	| ISTQB has been deleted from your certification |