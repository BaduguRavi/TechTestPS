Feature: Search
	As a user I want to check the search functionality

@SmokeTest
Scenario: As a user I want to search careers in a search field
	Given AS a user I enter Careers in searchfield
	When I click on search
	Then It should navigate me to a screen where i see recent posts advanced searchfield etc