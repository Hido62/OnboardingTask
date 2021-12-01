
Feature: SellerProfile_Education
As a Seller
I want to add Education to my Profile details
So that visitors can view them


#Added profile Education 
@sellerprofiletest
Scenario: Add Profile Education with data
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I Enter my Education details and click on Add button
    Then Education details should be Added successfully
        

@sellerprofiletest
Scenario: Add Profile Education without data
   Given I am on the Skills tab
   And I click on Education and Add New button
   When I click on Add button
   Then A pop up with(Please enter all the fields)should be displayed 
        

@sellerprofiletest
Scenario: Add Profile Education with only college/University Name field
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I enter college/University Name field click on Add button
    Then A pop up with(Please enter all the fields)should be displayed
        

 @sellerprofiletest
Scenario: Add Profile Education with only country of college/University field
    Given I am on the Skills tab 
    And I click on Education and Add New button
    When I enter country of college/University field click on Add button
    Then A pop up with(Please enter all the fields)should be displayed
        
 @sellerprofiletest
Scenario: Add Profile Education with only title field
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I Selected title field click on Add button
    Then A pop up with(Please enter all the fields)should be displayed

@sellerprofiletest
Scenario: Add Profile Education with only degree field
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I enter degree field click on Add button
    Then A pop up with(Please enter all the fields)should be displayed
        

@sellerprofiletest
Scenario: Add Profile Education with only year of Graduation field
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I enter year of Graduation field click on Add button
    Then A pop up with(Please enter all the fields)should be displayed



  #Edit profile Education 
 @sellerprofiletest
Scenario: Edit Profile Education with edited data
    Given I am on the Skills tab
    And I click on Education and Add New button
    When I enter college/University Name field and country of college/University field click on Add button
    And I click on Education and pen Icon
    When I Edit Education details and click on Update button
    Then Education details should be Added and saved successfully


@sellerprofiletest
Scenario: Edit Profile Education without any data
    Given I am on the Skills tab
    And I click on Education and pen Icon
    When I click on update button
    Then A pop up with(Please enter all the fields)should be displayed