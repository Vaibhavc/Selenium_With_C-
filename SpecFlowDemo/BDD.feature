Feature: GoogleSearch

Scenario: Verify link on search result
	Given user launches the app 
	And searches for "Infostretch"
	Then verifies the infostretch link in search results 
