Feature: MethodAddTests
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@MathLib @Add
Scenario: Add two numbers
	Given a first number 3 
	And a second number 4
	When the two numbers are added
	Then the result should be 7
