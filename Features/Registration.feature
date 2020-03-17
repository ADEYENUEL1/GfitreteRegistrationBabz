Feature: Registration
	In order to be able to Register on the website 
	I need to enter some registration Credentials
@mytag
Scenario: Valid Registration
	Given I navigate to the site "https://www.giftrete.com/"
	When I click on the create account button
	And I enter the first name "muyiwa"
	And I enter last name "Babz"
	And I enter  email address "olumuyee1@gmail.com"
	And I enter mobile number "07475703778"
	And I enter password "master2000"
	And I enter confirm password "master2000"
	Then the result should be 120 on the screen
