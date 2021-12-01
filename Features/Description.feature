Feature: Seller Profile Description
As a Seller
I want to add Description to my Profile Details
So that viaitors can view and know more about me.

# profile Description
 @sellerprofiletest
 Scenario Outline: Add Profile Description with data 
    Given I am on the Trade Skills portal
    And I click on pen icon
    When I Add '<Description>' and click Save button
    Then A popup  with '<Message>' should be displayed
       
    Examples: 
    | Description                | Message |
    | hello, I added description | Description has been saved successfully |

         
 @sellerprofiletest
 Scenario Outline: Add Profile Description without data
   Given I am the Trade Skills portal 
   And I click on pen icon
   When I click Save button without data
   Then A popup with '<Message>' should be displayed
        
    Examples: 
    | Message                       |
    | Please, description is required |


        
 @sellerprofiletest
 Scenario: Edit Profile Description
    Given I am on the Trade Skills portal 
    And I click on pen icon
    When  I edit '<Description>' and click Save button
    Then A popup  with '<Message>' should be displayed
        
    Examples: 
    | Description                 | Message |
    | Hello, I have edited description | Description has been saved successfully |
