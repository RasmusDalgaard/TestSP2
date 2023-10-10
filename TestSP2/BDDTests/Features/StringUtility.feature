Feature: StringUtility
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](BDDTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

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