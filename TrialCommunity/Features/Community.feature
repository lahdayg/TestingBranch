Feature: Community
	As a Giftrete User
	I want to be able to create more than one community

@mytag
Scenario: Creating Multiple Community
	Given I navigate to www.qa1.gifrt.com
	When I click on Login
	And I enter my Username
	And I enter my password
	And I click on signin
	And I click on Community
	And I click on create new
	#Then I should be able to create multiple community