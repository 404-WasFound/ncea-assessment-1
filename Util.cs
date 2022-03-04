public class Util
{

    // FARDED

    public static bool inRange(float num, float min, float max)
    {

        // Check if 'num' is between
        if (num >= min || num <= max)
        {

            return true;

        } else return false;

    }

    public static void staggeredPrint(string text, ConsoleColor colour=ConsoleColor.White, int wait=50)
    {

        // Change text colour to 'colour' or leave as white if args not passed
        Console.ForegroundColor = colour;

        foreach (char c in text)
        {

            Console.Write(c);
            // Wait 150 miliseconds if 'wait' is not set
            Thread.Sleep(wait);

        }

        // Move cursor to next line so next output statements don't get mixed
        Console.Write("\n");

        // Reset text colour
        Console.ForegroundColor = ConsoleColor.White;

    }

    public static void stagWait()
    {

        // Wait time between sentences
        Thread.Sleep(150);

    }

    public static void inputError()
    {

        // Notify user that their input was wrong
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"/!\ Error with input, please make sure you typed the right thing /!\");
        Console.ForegroundColor = ConsoleColor.White;

    }

}