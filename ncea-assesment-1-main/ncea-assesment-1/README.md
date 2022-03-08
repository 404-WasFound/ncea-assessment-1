![Long bay college logo](https://www.longbaycollege.com/wp-content/uploads/2020/09/Long_Bay_College_Logo_Tag2-1024x141.png)

# NCEA Assesment 1

## Project Outline

**Conventions**
- [C# Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

**Details**
- C#
- Quiz style as a text-based adventure game

**Pseudocode**
- farded

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
    - Prints each character at a time on the same line.
- Created `Util.stagWait()`.
    - Waits appropriate time between lines of `staggeredPrint()`.
- Created `Util.inRange(float num, float min, float max)`.
    - Checks if `num` is between `min` and `max`.

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
- Increased miss input detection.
    - Unentered fields are now countered for.

**03/03/2022 - 05/03/2022**
- Better formatting implemented in `README.md`.
    - Includes titles, dates, descriptions, outline, tables, and subtitles, and subdescriptions.

**06/03/2022**
- Created `Util.getMenu(dynamic[][] data, int maxItemStringLength)` and `Util.getKey(ConsoleKey key)`.
    - Formatted text tables that are made up of columns and rows with titles.
    - Gets key input and return true/false (only for specified keys defined at start)

**07/03/2022**
- Created `Game.game2(dynamic[] playerData)`.
    - User fights a dragon as the second challenge

**08/03/2022**
- Added ASCII art for battle and menus / HUD in `Game.game2()`.
    - Creates a 1 - 4 action choice menu, displays dragon ASCII art, displays player and dragon stats.

**Debugging**
| Field | Expected Type | Input | Expected Output | Recived Output | Errors | Date |
| ----- | ------------- | ----- | --------------- | -------------- | ------ | ---- |