// https://github.com/404-wasfound/ncea-asesment-1

// Intro        2q
// 3 Riddles    3-9q (6q average)
// 1 Battle     1-3q (2q average)
// 5 Doors      3q

public class Program
{

    public static void Main(string[] args)
    {

        // Loop boolean for game loop
        bool loop = true;

        // Main game loop
        while (loop)
        {

            // Setup console settings
            Console.BackgroundColor = ConsoleColor.Black;

            // Call '.Clear()' to set terminal to all DarkBlue
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            // Setup dynamic array that can only take 2 items
            dynamic[] playerData = new dynamic[2] {"", 0};

            //Call 'intro()' to start game
            playerData = Game.intro();

            // Call 'game1()' to start game1, but wait time in between
            Game.changeGame();
            loop = Game.game1(playerData);

            // Call 'game2()' to start game2, but wait time in between
            Game.changeGame();
            loop = Game.game2(playerData);

            // Call 'game3()' to start game3, but wait time in between
            Game.changeGame();
            loop = Game.game3(playerData);

        }

        // Call 'outro()' to ask the user if they want to play again
        loop = Game.outro();

    }

}
