Feature: MarsQA


As a Mars QA user
 I would like to Login and create profile
 so that seller is able to see his profile details on the page 


@tag1
Scenario: 1) I will add the skills on the profile page 
	Given I logged into Mars QA successfully
	When  I navigate skills tab and add the skills 
	Then The skills should be added to the profile page successfully

Scenario:2) I will update the skills on the profilepage
    Given I logged into Mars QA successfully
	When I navigate to skills tab and update skills
	Then The skills should be updated sucessfully

Scenario: 3) I will delete the skills on the profile page 
     Given I logged into Mars QA successfully
	 When  I navigate to skills tab and delete skills
	 Then  The skills should be deleted sucessfuly
Scenario Outline:  4) I will add the language on the profile page		
     Given  I logged into Mars QA successfully
	 When  I navigate language tab and add new '<Language>' and '<Level>' 
	 Then  '<Language>' and '<Level>'should be add successfully in the language tab

	 Examples: 
   | Language |  Level  |
   | Telugu   |  Fluent |
   | Hindi    |  Basic  |