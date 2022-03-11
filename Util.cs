class Util
{

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

        Random random = new Random();

        // Change text colour to 'colour' or leave as white if args not passed
        Console.ForegroundColor = colour;

        foreach (char c in text)
        {

            // Write character
            Console.Write(c);
            // Wait 150 miliseconds if 'wait' is not set
            Thread.Sleep(wait);

        }

        // test

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
    
    public static string getMenu(dynamic[][] data, int maxItemStringLength)
    {

        // Symbols
        //* ╔ . ╗ . ║ . ═ . ╝ . ╚

        // Item lenth limit
        int maxItemLength = maxItemStringLength;

        // Set corner of box
        string finalString = "╔";

        List<string> lines = new List<string> {};
        int highestLineLength = 0;

        foreach (var items in data)
        {

            // Reset line 
            string finalLine = "║ ";

            foreach (var item in items)
            {

                // Convert dynamic type to string
                string itemStr = $"{item}";

                // Limit item length
                if (itemStr.Length > maxItemLength)
                {

                    // Minus 3 to make room for "..." to indicate overflow
                    itemStr = itemStr.Substring(0, maxItemLength - 3);
                    itemStr += "...";

                    // Skip rest of code before 'AddItem:'`
                    goto AddItem;

                }
                
                if (itemStr.Length < maxItemLength)
                {

                    // Add spaces to keep spacing consistant
                    string spaces = new string(' ', maxItemLength - itemStr.Length);
                    itemStr += spaces;

                    // Skip rest of code before 'AddItem:'
                    goto AddItem;

                }
                
                if (itemStr.Length == maxItemLength)
                {
                    
                    // Skip rest of code before 'AddItem:'
                    goto AddItem;

                }

                AddItem:
                    finalLine += itemStr + " ";

            }

            // Side of box
            finalLine += "║\n";

            lines.Add(finalLine);

        }

        // Check lines length to get highest for box dimensions
        foreach (string line in lines)
        {

            // Minus 1 because .Length returns character count, not index count
            // eg: "hello".Length = 5
            if (line.Length - 1 >= highestLineLength)
            {

                highestLineLength = line.Length - 1;

            }

        }

        // Top of box

        // Add '═' to final string for each character in 'highestLineLength'
        // Add 2 to break up item for readability
        for (int x = 0 ; x < highestLineLength - 2 ; x++)
        {

            finalString += "═";

        }

        // Set corner of box and make new line
        finalString += "╗\n";

        // Add lines to box
        foreach (string line in lines)
        {

            finalString += line;

        }

        // Set corner of box
        finalString += "╚";

        // Add '═' to final string for each character in 'highestLineLength' again
        // Add 2 to break up item for readability again
        for (int x = 0 ; x < highestLineLength - 2 ; x++)
        {

            finalString += "═";

        }

        // Set corner of box
        finalString += "╝";

        return finalString;

    }

}