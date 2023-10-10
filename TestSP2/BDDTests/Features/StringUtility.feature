Feature: StringUtility

@mytag
Scenario: Reverse string
	Given the input is a string
	When the reverse method is called
	Then the input string should be reversed

@mytag
Scenario: Capitalize string
	Given the input is a string
	When the capitalize method is called
	Then the input string should be capitalized

@mytag
Scenario: Lowercase string
	Given the input is a string
	When the lowercase method is called
	Then the input string should be lowercase