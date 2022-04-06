// https://github.com/404-wasfound/ncea-asesment-1

//? CODE CONVENTIONS: Pascal case classes
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
            // Set terminal to all black
            Console.BackgroundColor = ConsoleColor.Black;

            // Clear the screen
            Console.ForegroundColor = ConsoleColor.White;

            // Array of player data
            //? CODE CONVENTIONS: Camel case variables
            dynamic[] playerData = new dynamic[2] {"", 0};

            // Start game
            // Returns playerData
            playerData = Game.Intro();

            // Start game1 and reset console
            Game.ChangeGame();
            loop = Game.Game1(playerData);

            // Start game2 and reset console
            Game.ChangeGame();
            loop = Game.Game2(playerData);

            // Start game3 and reset console
            Game.ChangeGame();
            loop = Game.Game3(playerData);

            // Start game3 and reset console
            Game.ChangeGame();
            loop = Game.Game4(playerData);

        }

        // End of the game
        loop = Game.Outro();

    }

}
