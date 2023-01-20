Feature: Login
	
Background: 
	Given I am on Login Page
	And I accept all cookies

Scenario: I log into website with correct credentials
	When I enter credentials "psobocinski@pgs-soft.com", "TestForInterview1"
	Then I should see profile with name "Profil for psobocinski@pgs-soft.com"
	
Scenario: I provide wrong credentials
	When I enter credentials "Wrong@wrong.com", "TestForInterview1"
	Then I see alert information "Der opstod en fejl"
