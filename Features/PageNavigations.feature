Feature: PageNavigations
	
	Navigating from homepage to other pages in the website

@SmokeTest
Scenario: As a user I want to navigate from homepage to other pages of the website 
	Given I'm on homepage
	When I Click on Careers tab 
	Then I Should navigate to Careers page