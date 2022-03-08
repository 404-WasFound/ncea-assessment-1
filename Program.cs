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

        // // Call 'game1()' to start game1, but wait time in between
        // Game.changeGame();
        // Game.game1(playerData);

        // Call 'game2()' to start game2, but wait time in between
        Game.changeGame();
        Game.game2(playerData);

        Thread.Sleep(100000);

        // Call 'game3()' to start game3, but wait time in between
        // Game.changeGame();
        // Game.game3();

    }

}