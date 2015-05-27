Racing Car Katas
=================

In this repository you'll find starting code for four distinct problems. They could be code you inherited from a legacy code-base. Now you want to write unit tests for them, and that is harder than it needs to be. All of the code snippets fail to follow one or more of the SOLID principles.

For each exercise, there is only one class you are interested in writing tests for right now. As a first step, try to get some kind of test in place before you change the class at all. Identify why the class is hard to write tests for, and which SOLID principles are not being followed. 

When you have some kind of test to lean on, refactor the code and make it testable. Take care when refactoring not to alter the functionality, or change interfaces which other client code may rely on. (Imagine there is client code in another repository that you can't see right now). Add more tests to cover the functionality of the particular class you've been asked to get under test. 

Apply the unit testing style and framework you are most comfortable with. You can choose to use stubs or mocks or none at all. If you do, you are free to use the mocking tool that you prefer.

1. **TirePressureMonitoringSystem exercise**:  write the unit tests for the Alarm class.

The Alarm class is designed to monitor tire pressure and set an alarm if the pressure falls outside of the expected range. The Sensor class provided for the exercise fakes the behaviour of a real tire sensor, providing random but realistic values. Note that there is a MockAlarm and a StubAlarm class provided in the "tests" folder. The purpose of these is purely to demonstrate how a mock and a stub look, you won't need them to complete the exercise.

2. **UnicodeFileToHtmTextConverter exercise**: write the unit tests for the UnicodeFileToHtmTextConverter class.

The UnicodeFileToHtmTextConverter class is designed to reformat a plain text file for display in a browser. For the Python and Java versions, there is an additional class "HtmlPagesConverter" which is slightly harder to get under test. It not only converts text in a file to html, it also supports pagination. It's meant as a follow up exercise.

3. **TicketDispenser exercise**: write the unit tests for the TicketDispenser.

The TicketDispenser class is designed to be used to manage a queuing system in a shop. There may be more than one ticket dispenser but the same ticket should not be issued to two different customers.

4. **TelemetrySystem exercise**: write the unit tests for the TelemetryDiagnosticControls class.

The responsibility of the TelemetryDiagnosticControls class is to establish a connection to the telemetry server (through the TelemetryClient), send a diagnostic request and successfully receive the response that contains the diagnostic info. The TelemetryClient class provided for the exercise fakes the behavior of the real TelemetryClient class, and can respond with either the diagnostic information or a random sequence. The real TelemetryClient class would connect and communicate with the telemetry server via tcp/ip.

5. **Braking exercise**: (note this exercise is still being developed) Write the unit tests for the Brake class, and all the various braking strategies.

6. **Leaderboard exercise**: (note this exercise is still being developed) Write the unit tests for the Leaderboard class. This class can generate driver and country rankings based on results from a number of races.

## Get going quickly with Cyber-Dojo

You can quickly and easily get going with these problems using the cyber-dojo tool. Click on the relevant link below
to create a new cyber-dojo practice id with the problem set up ready for your dojo.

1. TirePressureMonitoringSystem in [C#](http://cyber-dojo.org/forker/fork/E21AEC276D?avatar=buffalo&tag=2), [Java](http://cyber-dojo.org/forker/fork/C23B9C?avatar=buffalo&tag=1)
2. UnicodeFileToHtmlTextConverter in [C#](http://cyber-dojo.org/forker/fork/9C9DB9?avatar=raccoon&tag=2), [Java](http://cyber-dojo.org/forker/fork/C2BC8A?avatar=buffalo&tag=5)


## TDD with Mock Objects: Design Principles and Emerging Properties

This was originally a fork of Luca Minudel's repo. He was using it for a study of TDD and Design principles. I am using it as a repository for storing exercises useful for people wishing to improve their skills with TDD and SOLID principles. Please look at my blog post ["SOLID principles and TDD"](http://coding-is-like-cooking.info/2012/09/solid-principles-and-tdd/) for background reading, or my book ["The Coding Dojo Handbook"](http://leanpub.com/codingdojohandbook).

- When you've had a go at these exercises yourself, you could look at the [proposed solutions] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/tree/master/TDDMicroExercises.ProposedSolution) in C#, Java, Javascript. If you've done the exercises in Python, you might be interested in my blog post ["SOLID exercises in Python"](http://coding-is-like-cooking.info/2012/09/solid-exercises-in-python/).

- For background reading about Luca's study, see the [paper] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/Paper/mockobjects_emergingproperties.pdf?raw=true) and the [presentation] (https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples/blob/master/Slides/TDD-SOLID.pdf?raw=true) from Luca's own repo.

