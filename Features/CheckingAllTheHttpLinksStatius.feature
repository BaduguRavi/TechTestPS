Feature: CheckingAllTheHttpLinksStatius
	
	Checking the HTTP Links Status and Writing it in a log file TestLog.txt in base directory

@SmokeTest
Scenario: As a user identifying all the https links status in the website 
	Given I launched the website
	When I check all the links
	Then I should get a TestLog.txt file in base directory with status