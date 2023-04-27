Feature: MarsQA


As a Mars QA user
 I would like to Login and create profile
 so that seller is able to see his profile details on the page 


@tag1
Scenario: 1) I will add the skills on the profile page 
	Given I logged into Mars QA successfully
	When  I navigate skills tab and add the skills 
	Then The skills should be added to the profile page successfully

Scenario Outline:2) I will update the skills on the profilepage
    Given I logged into Mars QA successfully
	When I navigate to skills tab and update skills
	Then The skills should be deleted sucessfully

Scenario Outline: 3) I will delete the skills on the profile page 
     Given I logged into Mars QA successfully
	 When  I navigate to skills tab and delete skills
	 Then  The skills should be deleted sucessfuly