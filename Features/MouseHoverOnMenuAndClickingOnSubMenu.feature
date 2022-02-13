Feature: MouseHoverOnMenuAndClickingOnSubMenu
	
	Checking the menu items while doing a mouse hover and clicking the item

@SmokeTest
Scenario: As a user I want to check menu items doing a mouse hover action and clicking a submenu item
	Given As a user I lauched the website
	When I do perform mouse hover action on Customer Support and I see a submenu item
	Then I should click on that submenu item

