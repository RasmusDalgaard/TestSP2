# TestSP2

## Reflections

### 1.1 Computer Mouse  
Identify the types of testing you would perform on a computer mouse, to make sure that it is of the higest quality.  

I would perform Unit Testing on each of the individual parts of the mouse (mouse1, mouse2, scroll wheel, sensor etc.) Then I would perform Tntegration Tests to make sure, that the individual parts of the mouse actually work together (movement of mouse while scrolling and clicking).  
Usability Testing could also be a great choice to ensure that the design works as intended and that the user can give feedback about improvements or things that just didn't work that well.  

Acceptance Testing helps identifying if the business requirements are met and are essential in making sure that the product is capable of performing the required tasks and thereby maintaining the higest quality.  

Furthermore, Performance Testing could also help ensuring the higesht quality of mouse by testing its durability but also its performance during high workloads. 

### 1.2 Catastrophic Failure  
Find a story where a software system defect had a bad outcome. Describe what happened. Can you find a test that would have prevented it?  

EDS Child Support System in 2004. The system was badly designed, tested and implemented. So pretty much every part of the development process was not up to par. They registered over 1000 issues with many of them being unsolveable.  
Generally, it is vital to discover bugs and errors as early as possible to minimize the effect on the entire system and the cost of having to fix them.  

In regard to this system defect(s), it would have helped massively if the analysis of the domain and the following design of the system had been more thorough. Often times most errors occur in the early phases of development because not enough time and effort is put into the analysis and design phase. Ironically this is the phases where developers can prevent a lot of the future issues and bugs, or at least make it easier for themselves to fix them if they occur. It makes sense that the implementation also fails if the analysis and design isn't sufficient for the developers to actually provide something of value during implementation.

Furthermore, early software testing and use of agile practises could help avoiding these kinds of failures. 

## Two Katas  
Complete the following using BDD.  

[TwoKatas](https://github.com/RasmusDalgaard/TestSP2/tree/main/TestSP2/TwoKatas)

### String Utility  
Use BDD to create a string utility with the following methods:  
* Reverse string (aBc -> cBa)
* Capitalize string (aBC -> ABC)
* Lowercase string (aBc -> abc)

Don't use any built-in string utility – create your own. Remember, the exercise here is to
use BDD, not to deliver a working utility without tests. If there are no tests in the
solution, it won’t be accepted.  

[String Utility](https://github.com/RasmusDalgaard/TestSP2/tree/main/TestSP2/TwoKatas/StringUtility.cs)  

[BDD StringUtility Feature](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/BDDTests/Features/StringUtility.feature)  

[BDD String Utility Step Definitions](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/BDDTests/StepDefinitions/StringUtilityStepDefinitions.cs)  

### Bowling Game Kata  
Complete the Bowling Game Kata using BDD. The slides can be found here:  
http://butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt  

[Bowling Game](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/TwoKatas/BowlingGame.cs)  

[Bowling Game Test](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/BowlingGameTests/BowlingGameTest.cs)  

[BDD Bowling Game Feature](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/BDDTests/Features/BowlingGame.feature)  

[BDD Bowling Game Step Definitions](https://github.com/RasmusDalgaard/TestSP2/blob/main/TestSP2/BDDTests/StepDefinitions/BowlingGameStepDefinitions.cs)  

## Investigation Of Tools  

### JUnit 5  
Investigate JUnit 5 (Jupiter). Explain the following, and how they are useful.  
* @tag

Is used for filtering testcases from test suites. Can be used in a test plan by only executing testcases with specific tags.  

* @Disabled

Disables the annotated test method or class and will not be executed.  

* @RepeatedTest

Is used for repeating a test any amount of times.  

* @BeforeEach, @AfterEach

Is used when a method should be executed before each and every method in the test class.  

Is used when a method should be executed after each and every method in the test class.

* @BeforeAll, @AfterAll

Is used when a method should be executed one time before all methods in the test class have been executed.    

Is used when a method should be executed one time after all methods in the test class have been executed.  

* @DisplayName

Is just a custom display name for the test method or class.  


* @Nested

Is used for creating nested classes, so that multiple test classes can be run from the parent class.  

* assumeFalse, assumeTrue

Is used for validating wether the given assumption is false and if it is the test then resumes. Otherwise it aborts the test.  

Is used for validating wether the given assumption is true and if it is the test then resumes. Otherwise it aborts the test.

### Mocking Frameworks  
Investigate mocking frameworks for your preferred language. Choose at least two
frameworks, and answer the questions. (One could be Mockito, which we saw in class.)  

(Javascript)  

Unmock vs Nock

* What are their similarities?

They are almost identical in notation and have similar APIs. 

* What are their differences?

Unmock can use dynamic mocks and spies which Nock can't. 

* Which one would you prefer, if any, and why?

Unmock because it has more features which could be valuable. Especially dynamic mocks. 
