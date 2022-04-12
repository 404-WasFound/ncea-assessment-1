![Long bay college logo](https://www.longbaycollege.com/wp-content/uploads/2020/09/Long_Bay_College_Logo_Tag2-1024x141.png)

# NCEA Assessment 1

## Project Outline

### Conventions
- [C# Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Evidence of these
    - `Program.cs` (line `3` & `25`)
    - `Util.cs` (line `4` & `22`)
        
### Details
- C#
- Quiz style as a text-based adventure game
- 
### Pseudocode
- [Pseudocode](https://github.com/404-WasFound/ncea-assessment-1/blob/main/pseudocode/main.md)

### How to run
- Download the repository / code
- Download `Dotnet` from [here](https://dotnet.microsoft.com/en-us/download)
- Extract the downloaded `zip file`
- Open `*/*/ncea_assessment-1/` in `CMD` / `Powershell`
- Run `dotnet run program.cs`

## Commits

### Version 1

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

### Version 2

**27/02/2022**
- Restarted project as code was messy and badly-formatted.
- Created `Program`, `Util`, and `Game` classes.
- Created `Util.StaggeredPrint(string text, ConsoleColor colour=ConsoleColour.White, int wait=50)`.
    - Prints each character at a time on the same line.
- Created `Util.StagWait()`.
    - Waits appropriate time between lines of `StaggeredPrint()`.
- Created `Util.InRange(float num, float min, float max)`.
    - Checks if `num` is between `min` and `max`.

**28/02/2022**
- Created `Game.Intro()`, `Game.Game1()`, `Game.Game2()`, and `Game.Game3()`.
    - Game 1: 3 Riddles
    - Game 2: 1 Battle against a monster
    - Game 3: 5 Doors to choose from, only 1 is correct, user has 3 chances
- Created `Util.inputError()`.
    - Prints error for unexpected input.

**01/03/2022**
- Finished `Game.Game1()`.
    - 3 Riddles, quits game if fails all 3.
- Created `Game.ChangeGame()`.
    - Clears console and resets console foreground colour.

**02/03/2022**
- Increased miss input detection.
    - Unentered fields are now countered for.

**03/03/2022 - 05/03/2022**
- Better formatting implemented in `README.md`.
    - Includes titles, dates, descriptions, outline, tables, and subtitles, and sub-descriptions.

**06/03/2022**
- Created `Util.GetMenu(dynamic[][] data, int maxItemStringLength)` and `Util.GetKey(ConsoleKey key)`.
    - Formatted text tables that are made up of columns and rows with titles.
    - Gets key input and return true/false (only for specified keys defined at start)

**07/03/2022**
- Created `Game.Game2(dynamic[] playerData)`.
    - User fights a dragon as the second challenge

**08/03/2022**
- Added ASCII art for battle and menus / HUD in `Game.Game2()`.
    - Creates a 1 - 4 action choice menu, displays dragon ASCII art, displays player and dragon stats.

**09/03/2022**
- Created actions and better battle scene in `Game.Game2()`.
    - Displays 4 different actions

**10/03/2022**
- Created outcomes for actions in `Game.Game2()`.
    - Has a total of 4 main options and 16 sub-options.

**12/03/2022**
- Edited battle scene and outcomes in `Game.Game2()`.
    - Now only has 4 options and outcomes.

**14/03/2022**
- Created outcomes for unexpected inputs in `Game.Game2()`.
    - Numbers that aren't between `1` and `4` are now countered for.
    - Non-numbers are now countered for.

**16/03/2022**
- Added replay system to game so user can exit or play again at the end of the program.
    - Uses a `while` loop with a `bool` condition that is set to the return of `Game.Game1()` to `Game.Game3()`

**19/03/2022**
- Used `Atom Editor` to limit line length and make code more readable.
    - Tested pushing to github with `Atom Editor`.

**21/03/2022 - 28/03/2022**
- Worked on pseudocode.

### Version 3

**29/03/2022**
- Added `Game.Game4()`.
    - It will be a quiz with 5 questions with 5 randomized answers each.

**30/03/2022**
- Started making a random answer indexer in `Game.Game4()`.
    - Sorts the answers in a random order.

**01/04/2022**
- Improved random answer indexer in `Game.Game4()`.

**02/04/2022**
- Reset random indexer and made it more efficient in `Game.Game4()`.
    - pass

**03/04/2022**
- Created an answer index finder and user input in `Game.Game4()`.
    - Gets user input (int 1 - 5) and checks if it equals the answer index.

**04/04/2022**
- Improved comments and corrected `Game` methods return values.
    - `Game.Game1()` to `Game.Game4()` now return the correct `bool` depending on the outcome.

**05/04/2022**
- Code finished


### Testing

| Field       | Expected Type | Input          | Expected Output | Recived Output | Errors                        | Date       |
|-------------|---------------|----------------|-----------------|----------------|-------------------------------|------------|
| name        | string        | "abc"          | "abc"           | "abc"          | None                          | 28/02/2022 |
| name        | string        | 123            | Custom Error    | "123"          | Doesn't detect integers       | 28/02/2022 |
| name        | string        | 123            | Custom Error    | Custom Error   | None                          | 28/02/2022 |
| name        | string        | ""             | Custom Error    | Custom Error   | None                          | 29/02/2022 |
| age         | int           | 123            | 123             | 123            | None                          | 01/03/2022 |
| age         | int           | "abc"          | Custom Error    | Error          | Doesn't detect strings        | 01/03/2022 |
| age         | int           | "abc"          | Custom Error    | Custom Error   | None                          | 01/03/2022 |
| age         | int           | ""             | Custom Error    | Custom Error   | None                          | 02/03/2022 |
| answer      | string        | "test"         | "Fail"          | Error          | Quits program if answer wrong | 05/03/2022 |
| answer      | string        | "test"         | "Fail"          | "Fail"         | None                          | 05/03/2022 |
| answer      | string        | 123            | "Fail"          | "Fail"         | None                          | 05/03/2022 |
| answer      | string        | "right answer" | "Pass"          | "Pass"         | None                          | 06/03/2022 |
| actionIndex | int (1 - 4)   | 1              | "Pass"          | "Pass"         | None                          | 07/02/2022 |
| actionIndex | int (1 - 4)   | 5              | Custom Error    | Error          | Doesn't detect boundary cases | 07/02/2022 |
| actionIndex | int (1 - 4)   | 5              | Custom Error    | Custom Error   | None                          | 07/02/2022 |
| actionIndex | int (1 - 4)   | "abc"          | Custom Error    | Custom Error   | None                          | 08/02/2022 |
| guess       | int (1 - 5)   | 1              | "Pass"          | "Pass"         | None                          | 10/02/2022 |
| guess       | int (1 - 5)   | 6              | Custom Error    | Custom Error   | None                          | 11/02/2022 |
| guess       | int (1 - 5)   | "abc"          | Custom Error    | Custom Error   | None                          | 12/02/2022 |
| guess       | int (1 - 5)   | 0              | Custom Error    | Custom Error   | None                          | 12/02/2022 |
| userAnswer  | int (1 - 5)   | 1              | "Pass"          | "Pass"         | None                          | 02/03/2022 |
| userAnswer  | int (1 - 5)   | 6              | Custom Error    | Custom Error   | None                          | 03/03/2022 |
| userAnswer  | int (1 - 5)   | "abc"          | Custom Error    | Custom Error   | None                          | 03/03/2022 |
| userAnswer  | int (1 - 5)   | 0              | Custom Error    | Custom Error   | None                          | 04/03/2022 |
| playAgain   | string        | "y"            | Return true     | Return true    | None                          | 14/02/2022 |
| playAgain   | string        | "n"            | Return false    | Return false   | None                          | 14/02/2022 |
| playAgain   | string        | "x"            | Return false    | Return false   | None                          | 14/02/2022 |
| playAgain  | string        | 1              | Return false    | Return false   | None                          | 14/02/2022 |


### Debugging
| Error | Fix | Date |
| -- | -- | -- |
| Cannot implicitly convert type `'string[]'` to `'string'` | Created for loop that loops through each `string` and appends them to a new `string` | 03/02/2022 |
| `;` expected | Added `;` at the end of line | 09/02/2022 |
| Only assignment, call, increment, decrement, await, and new `object` expressions can be used as a statement (`for` -> `foreach`) | Change `for` loop to `foreach` loop | 13/02/2022 |
| `;` expected | Added ; at the end of line | 14/02/2022 |
| Cannot implicitly convert type `'long'` to `'int'` | Changed variable to `long` | 16/02/2022 |
| `;` expected | Added `;` at the end of line | 21/02/2022 |
| `;` expected | Added `;` at the end of line | 21/02/2022 |
| Cannot implicitly convert type `'string'` to `'int'` | Created a system to check for `ints` then convert them | 24/02/2022 |
| Cannot implicitly convert type `'string[]'` to `'string'` | Created for loop that loops through each `string` and appends them to a new `string` | 24/02/2022 |
| `;` expected | Added `;` at the end of line | 28/02/2022 |
| There is no argument given that corresponds to the required formal parameter `'playerData'` of `'Game.Game1(dynamic[])'` | Added `playerData` as a parameter | 30/02/2022 |
| The modifier `'public'` is not valid for this item | Added `}` to close off method | 01/03/2022 |
| Represents text as a sequence of `UTF-16` code units. | Added `"` to end of string | 02/03/2022 |
