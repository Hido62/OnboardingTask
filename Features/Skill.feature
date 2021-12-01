Feature: SkillFeature
As a Seller
I want to add skills in my Profile Details
So that visitors to my page will be able to see them


@sellerprofiletest
Scenario: Add Profile skills with data
    Given I am on the Trade Skills portal 
    And I click on skills tab
    And I click on Add New button
    When I enter the data in '<SkillName>' and '<SkillLevel>'  and click on Add button
    Then A popup '<Message>' should be displayed

 Examples:
 | SkillName      | SkillLevel | Message                                     |
 | Manual Testing | Expert     | Manual Testing has been added to your skills|
 | Automation     | Beginner   |  aAutomation has been added to your skills  |


 @sellerprofiletest
 Scenario: Add Profile Skills without data
    Given I am on the Trade Skills portal 
    And I click on Add New Button
    When I click on Add button  without data in Skills and Skills level field
    Then A popup with (Please enter Skills and Experience level) should be displayed

 
 @sellerprofiletest
 Scenario: Add Profile Skills with only Add skills
    Given I am on the Trade Skills portal
    And I click on Add New button
    When I Enter data in Skills and click on Add button
    Then A popup with (Please enter Skills and Experience level) should be displayed



 @sellerprofiletest
 Scenario: Add Profile Skills with only Skill level
    Given I am on the Trade Skills portal
    And I click on Add New button
    When I Select Skill level and click on Add button
    Then A popup with (Please enter Skills and Experience level) should be displayed


 @sellerprofiletest
 Scenario: Add Profile Skills with Specal characters
    Given I am on the Trade Skills portal
    And I click on Add New button
    When I Enter Specal characters in Skills and select Skill level and click on Add button
    Then Skills should be saved successfully


  # profile skills edit

 @sellerprofiletest
 Scenario: Edit Profile Skills with data
    Given I am on the Trade Skills portal
    And I click on Skill Edit pen icon
    When I Edit the data in '<SkillName>' and '<SkillLevel>'  and click on update button
    Then A popup '<Message>' should be shown

  Examples:
  | SkillName | SkillLevel | Message|
  | Automation   | Expert |Automation has been updated to your skills|
        


 Scenario: Edit Profile Skills without data
    Given I am on the Trade Skills portal
    And I click on Skill Edit pen icon
    When I click on update button without data
    Then A popup with (Please enter Skills and Experience level) should be displayed
   
   
 Scenario: Edit Profile Skills without Editing
    Given I am on the Trade Skills portal
    And I click on Skill Edit pen icon
    When I click on update button without edited
    Then A popup with (This Skills is already added to your Skills list) should be displayed 

 Scenario: Edit Profile Skills with only language
    Given I am on the Trade Skills portal
    And I click on pen icon
    When I Edited the Skills click on update button
    Then Laguages should be edited successfully

 Scenario: Edit Profile Skills with only language level
    Given I am on the Trade Skills portal
    And I click on pen icon
    When I edited Skills level and click on update button
    Then Skills should be edited successfully


  #	profile skills delete

 @sellerprofiletest
 Scenario: Profile Skills delete
    Given I am on the Trade Skills portal
    And   I click on skills tab
    When  I click on delete icon
    Then  A popup '<Message>' should be shown

   Examples: 
    |Message|
    |Manual Testing has been deleted|