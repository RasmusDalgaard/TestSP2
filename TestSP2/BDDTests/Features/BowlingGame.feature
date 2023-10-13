Feature: BowlingGame

@Strike
Scenario: Strike
	Given fresh bowling game
	When the player knocks down 10 pins with one roll
	And then the player rolls the next two balls and hits 6 pins and 4 pins
	Then the score should be 30

@Spare
Scenario: Spare
	Given new game
	When the player knocks down 6 pins with the first roll and 4 with the second roll 
	And then the player knocks down 4 pins on the next roll
	Then total score should be 18

@GutterGame
Scenario: Gutter Game
	Given bowling game
	When player rolls 20 times and hits 0 pins
	Then final score should be 0
