// 3 Riddles
// 1 Battle
// 3 Doors

public class Program
{

    public static void Main(string[] args)
    {

        // Setup console settings
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        
        // Call '.Clear()' to set terminal to all DarkBlue
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;

        // Setup variables
        dynamic[] playerData = new dynamic[2] {"", 0};

        //Call 'intro()' to start game
        // playerData = Game.intro();

        // Test threading
        string[][] testData = new string[][] {

            new string[] {"INDEX", "TITLE", "DESC"},
            new string[] {"01", "poo", "stinky"},
            new string[] {"02", "fard", "deadly"},
            new string[] {"03", "number 2", "same as poo"},
            new string[] {"04", "1", "2"},
            new string[] {"05", "1", "3"},
            new string[] {"06", "1", "4"}

        };

        string testTable = Util.getMenu(testData, 10);

        Console.WriteLine(testTable);


        //

        int index = int.Parse(Console.ReadLine());
        int item = int.Parse(Console.ReadLine());
        Console.WriteLine(testData[index][item]);
        Thread.Sleep(10000);

        //
    

        //Call 'game1()' to start game1, but wait time in between
        // Game.changeGame();
        // Game.game1(playerData);

        // // Call 'game2()' to start game2, but wait time in between
        // Game.changeGame();
        // Game.game2();

        // // Call 'game3()' to start game3, but wait time in between
        // Game.changeGame();
        // Game.game3();

        // Reach end of Program.readKeys()

    }

}