# NCEA Assesment 1

## Project Outline

**Conventions**
- [C# Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

**Details**
- C#
- Quiz style as a text-based adventure game

# Commits

## Version 1

**24/02/2022**
- Created `Program`, `Util`, `GameClass`, `Table`, `Util`, and `Item` classes.
- Created `data/classes.json` to hold game classes data.

**25/02/2022**
- Created `Util.staggeredPrint()` and `Util.getMenu()`.
- Created `Table.getMenu()`.
- Removed `Table.cs` and moved `Table.getMenu()` to `Util.getMenu()`.

**26/02/2022**
- Created `data/items.json` and `data/rooms.json`.
- Created `Util.getJsonData(string filename)`.

## Version 2

**27/02/2022**
- Restarted project as code was messy and badly-formatted.
- Created `Program`, `Util`, and `Game` classes.
- Created `Util.staggeredPrint(string text, ConsoleColor colour=ConsoleColour.White, int wait=50)`.
- Created `Util.stagWwait()`.
- Created `Util.inRange(int num, int min, int max)`.

**28/02/2022**
- Created `Game.intro()`, `Game.game1()`, `Game.game2()`, and `Game.game3()`.
    - Game 1: 3 Riddles
    - Game 2: 1 Battle against a monster
    - Game 3: 5 Doors to choose from, only 1 is correct, user has 3 chances
- Created `Util.inputError()`.
    - Prints error for unexpected input.

**01/03/2022**
- Finished `Game.game1()`.
    - 3 Riddles, quits game if fails all 3.
- Created `Game.changeGame()`.
    - Clears console and resets console foreground colour.

**02/03/2022**