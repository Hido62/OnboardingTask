Feature: Profile Education
	As a Seller on Mars portal
	I want to add my education details.
	So that visitors can view my education.

@addEducation1
Scenario: Add Education with invalid data
	Given I login to the mars portal
	And I navigate to the education tab
	And I click on the Add New button
	When I enter the records for '<UniversityName>', '<CountryUniversity>', '<GraduationYear>' and click on Add button
	Then The popup message '<Message>' should be dispalayed

	Examples:
	| UniversityName | CountryUniversity | Title | Degree | GraduationYear | Message                     |
	| IT Tralee      | Ireland           |       |        | 2018          | Please enter all the fields  |


@addEducation2
Scenario: Add Profile Education with valid data
	Given I login to the mars portal
	And I navigate to the education tab
	And I click on Add New button
	When I enter the records as '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	Then The popup message '<Message>' should be displayed
	And The new row should be added for '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title   | Degree           | GraduationYear | Message                  |
	| IT Tralee      |  Ireland          | Level 7 | Mechatronics     | 2018           | Education has been added |


@addEducation3
Scenario: Add Profile education with duplicate data
	Given I login to the mars portal
	And I navigate to the education tab
	And I click on Add New button 
	When I enter the details of '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<SecondGraduationYear>' and click on Add button
	And The popup message '<Message>' should be displayed
	And I enter the data in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<SecondGraduationYear>'and click on Add button
	Then The  popup message '<Message>' should be displayed

	Examples:
	| UniversityName | CountryUniversity | Title   | Degree        | GraduationYear | SecondGraduationYear | Message                            |
	|  IT Tralee     |     Ireland       | Level 7 | Mechatronics  | 2018           | 2018                 | This information is already exist. |
	|  IT Tralee     |     Ireland       | Level 7 | Mechatronics  | 2018           | 2019                 | Duplicated data                    |



@editEducation
Scenario: Edit Profile Education with data
	Given I login to the mars portal
	And I navigate to the Education tab
	And I click on the Education pen icon
	When I edit the records in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' and click on Add button
	And The popup message '<Message>' should be displayed
	Then The new row should be updated in '<UniversityName>', '<CountryUniversity>', '<Title>', '<Degree>', '<GraduationYear>' successfully

	Examples:
	| UniversityName | CountryUniversity | Title  | Degree           | GraduationYear | Message                   |
	|RUST            | Nigeria           | HND    | Mechanical Engrn.| 2000           | Education as been updated |


@deleteEducation
Scenario: Delete  Profile Education
	Given I login to the mars portal
	And I navigate to the Education tab
	And I click on delete icon 
	When The popup with '<Message>' should be displayed
	Then the Education should be deleted successfully

	Examples:
	| Message                              |
	| Education entry successfully removed |