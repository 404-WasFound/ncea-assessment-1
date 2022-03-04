# NCEA Assesment 1

**C# Conventions:**
- https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

**Project Documentation / Outline:**
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

## Version 2

**27/02/2022**
- Restarted project as code was messy and badly-formatted.
- Created `Program`, `Util`. and `Game` classes.
- Created `Util.staggeredPrint(string text, ConoleColor colour=ConsoleColour.White, int wait=150)`