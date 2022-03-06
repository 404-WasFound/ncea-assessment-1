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

        // Call 'intro()' to start game
        // playerData = Game.intro();

        // Test threading
        string[][] testData = new string[][] {

            new string[] {"INDEX", "TITLE", "DESC"},
            new string[] {"", "poo", "stinky"},
            new string[] {"", "fard", "deadly"},
            new string[] {"", "number 2", "same as poo"},
            new string[] {"", "1", "2"},
            new string[] {"", "1", "3"},
            new string[] {"", "1", "4"}

        };

        string testTable = Util.getMenu(testData, 10);

        Console.WriteLine(testTable);


        int currentIndex = 0;

        while (true)
        {

            if (Util.getKey(ConsoleKey.UpArrow))
            {

                currentIndex--;

                for (int i = 0 ; i < testData.Length ; i++)
                {

                    if (i == currentIndex)
                    {

                        testData[i][0] = ">";

                    } else { testData[i][0] = ""; }

                }

            } else if (Util.getKey(ConsoleKey.DownArrow))
            {

                currentIndex++;

                for (int i = 0 ; i < testData.Length ; i++)
                {

                    if (i == currentIndex)
                    {

                        testData[i][0] = ">";

                    } else { testData[i][0] = ""; }

                }

            }

            Console.Clear();
            testTable = Util.getMenu(testData, 10);
            Console.WriteLine(testTable);

        }

        // //Call 'game1()' to start game1, but wait time in between
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