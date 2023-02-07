# Introduction 

Please, provide solution using C#. If you are up to the challenge, you can also try to provide solution using any other functional programming language, that would be an advantage, but in this case also try to use functional approach.

Write a program (and prove that it works, we expect you to write automated tests) that: Given a text file, count the occurrence of each unique word in the file.

For example, a file containing the string “Go do that thing that you do so well” should find these counts:

1: Go
2: do
2: that
1: thing
1: you
1: so
1: well

Note that focus here is not just on solving the task, but also on how you do it, e.g. which cases you consider in the scope, which programming principles you follow, how you test, document it etc. We on purpose make formulation of the task a bit vague, so you have a freedom to decide on how you do it.

# Solution
Solution is implemented using C#, .NET 7 

# Getting Started
Solution structure
1.	WordsCounting - counting logic
2.	WordsCounting.Console - Command line utility
3.	WordsCounting.Tests - unit tests

# Build and Test
To run the WordsCounting.Console go to the folder WordsCounting.Console and perform next command:

    dotnet run --project WordsCounting.Console.csproj


It is also possible to perform the application in docker container. To do this go to root folder and perform

    run-in-container.bat
