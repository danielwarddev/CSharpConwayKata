# C# Kata: Conway's Game of Life

## Challenge

### Description

The Game of Life (an example of a cellular automaton) is played on an infinite two-dimensional rectangular grid of cells. Each cell can be either alive or dead. The status of each cell changes each turn of the game (also called a generation) depending on the statuses of that cell's 8 neighbors. Neighbors of a cell are cells that touch that cell, either horizontal, vertical, or diagonal from that cell.

The initial pattern is the first generation. The second generation evolves from applying the rules simultaneously to every cell on the game board, i.e. births and deaths happen simultaneously. Afterwards, the rules are iteratively applied to create future generations. For each generation of the game, a cell's status in the next generation is determined by a set of rules. These simple rules are as follows:

### The requirements - the birth rule, death rule, and survival rule

- The birth rule states that any empty, or "dead", cell with precisely three "live" neighbours (i.e. full cells) will become live itself in the next generation. 
- The death rule has two statements: isolation and overcrowding. In isolation, any live cell with zero or one neighbours will die in the next generation. In overcrowding, any live cell with four or more neighbours also dies in the next generation.  
- The survival rule states that any live cell with two or three neighbours will remain alive into the next generation. 

## The project

### IDE

Visual Studio, Visual Studio Code, and Jetbrains Rider are common IDE choices for C#. Use whichever you are comfortable with.

If you are not sure which to use, I recommend Visual Studio Community Edition, as it's free and doesn't require any extra setup. Rider is paid, and while Visual Studio Code is also free, it requires extra setup with the C# Dev Kit extension.

### Base project

The base project is pretty barebones. It includes an example HelloWorldService and its tests. These are placed in two different projects; one for the real code and one for the tests. These are solely to demonstrate what a common C# solution structure looks like, as well as how to use some of the included libraries.

There are 4 libraries included in the base project:
- [xUnit](https://xunit.net/). The testing library
- [NSubstitue](https://nsubstitute.github.io/). The mocking library
- [AutoFixture](https://autofixture.github.io/). A library for creating fake data so that you don't have to create a bunch of fake classes or factories for your test data
- [FluentAssertions](https://fluentassertions.com/). Provides assertion methods that read more like English and gives more meaningful error messages than the Assert class

You don't have to use these libraries if you prefer not to, or you can use different ones instead. They're meant to give a full starting point for the kata without the need to install any packages.

### Building & testing

You might notice that the non-testing project is a library, rather than a console app, so it can't actually be ran. This means that any code execution will have to be performed by running tests. Running tests will build the project for you.

To run xUnit tests in Visual Studio, you can:
- Right-click the test name and choose "Run tests" from the menu
- Right-click the class name and choose "Run tests" from the menu
- Open the Test Explorer and run individual tests or suites from there (search for it in the top search bar if it's not open already)

You can also run `dotnet test` in the console. You can filter tests this way, as well, but it's a bit more work than using the UI: https://learn.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests?pivots=xunit
