Feature: CertificationFeature
As a Seller
I want to add Certification to my Profile Details
So that visitors can view my certification details


#	profile Certification Add
@sellerprofiletest
Scenario: Add Profile Certifications with data
	Given I am on the certification tab
	And I click on Certifications and Add New button
	When I Enter my Certifications details and click on Add button
	Then Certifications details should be Added and saved successfully

	@sellerprofiletest
Scenario: Add Profile Certifications withot data
	Given I am on the certification tab
	And I click on Certifications and Add New button
	When I click on Add button
	Then A popup with (Please enter certification Name and certification Form and certification Year) should be displayed

@sellerprofiletest
Scenario: Add Profile Certification with only Certification Name field
	Given I am on the certification tab
	And I click on Certification and Add New button
	When I enter Certification Name field click on Add button
	Then A popup with (Please enter certification Name and certification Form and certification Year) should be displayed

@sellerprofiletest
Scenario: Add Profile Certification with only Certification Form field
	Given I am on the certification tab
	And I click on Certification and Add New button
	When I enter Certification Form field click on Add button
	Then A popup with (Please enter certification Name and certification Form and certification Year) should be displayed

@sellerprofiletest
Scenario: Add Profile Certification with only Certification Year field
	Given I am on the certification tab
	And I click on Certification and Add New button		When I enter Certification Year field click on Add button
	Then A popup with (Please enter certification Name and certification Form and certification Year) should be displayed


#profile Certification edit
@sellerprofiletest
Scenario: Edit Profile Certifications with data
	Given I am on the certification tab
	And I click on Certifications and Update button
	When I Edited seller Certifications details and click on Update button
	Then Certifications details should be Edited successfully


@sellerprofiletest
Scenario: Edit Profile Certifications withot any data
	Given I am on the certification tab
	And I click on Certifications and Update button
	When I click on Update button withot any data
	Then A pop up with(Please enter all the fields)should be displayed
	
	
@sellerprofiletest
Scenario: Edit Profile Certifications without Update data
	Given I am on the certification tab
	And I click on Certifications and update button
	When I click on Update button without Updated data
	Then A pop up with(This information already exist)should be displayed

	
	
#profile Certification delete
@sellerprofiletest
Scenario: Profile Certification delete
	Given I am  on the certification tab
	And I selected the Certification
	When I click on delete icon
    Then Certification should be Deleted successfully