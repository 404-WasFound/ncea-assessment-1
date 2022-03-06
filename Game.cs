class Game
{

    public static dynamic[] intro()
    {

        // Initialize classes
        Random random = new Random();
        
        // Setup variables
        string[] outcomes = {"That's a cool name!", "That's a weird name"};
        ConsoleColor[] colours = {ConsoleColor.Green, ConsoleColor.Yellow};
        int[] waits = {50, 100};
        // Get a random number between 0 and 1
        int num = random.Next(0, 2);

        // ASCI title
        string title = "╔═════════════════════════════╗\n║       Adventure Game        ║\n╚═════════════════════════════╝";
        // Notify user that they can restart or exit at any time;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@"/!\ Note that you can type 'RESTART' in any input to restart the game, or 'QUIT' to exit the program /!\");
        Console.ForegroundColor = ConsoleColor.White;
        Thread.Sleep(3000);
        Console.Clear();

        // Welcome user and get their name
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(title);
        Console.ForegroundColor = ConsoleColor.White;
        Util.staggeredPrint("Why hello adventurer!", ConsoleColor.Green);
        Util.stagWait();

        Util.staggeredPrint("What is your name?", ConsoleColor.Green);
        Console.Write("> ");

        string name = Console.ReadLine();

        // Check if 'name' is empty
        if (name == "")
        {

            Util.staggeredPrint("It's not hard to type you know...", ConsoleColor.Yellow, waits[1]);
            Util.stagWait();
            Util.staggeredPrint("You'll just have to be 'Bob' then (=_=)", ConsoleColor.Yellow, waits[1]);
            name = "Bob";

        }
        
        // Clear screen and get user's age
        Console.Clear();
        Util.staggeredPrint($"{name}...");
        Util.stagWait();

        Util.staggeredPrint(outcomes[num], colours[num], waits[num]);
        Util.stagWait();

        Util.staggeredPrint("What is your age?");
        Console.Write("> ");

        string ageStr = Console.ReadLine();

        try {

            int age = int.Parse(ageStr);

            return new dynamic[] {name, age};

        // Check if nothing a number isn't entered
        } catch (FormatException) {

            Util.staggeredPrint("Whatever, you're probably 12 then", ConsoleColor.Yellow, waits[1]);
            int age = 12;

            return new dynamic[] {name, age};

        }

    }

    public static void game1(dynamic[] playerData)
    {

        // Riddles and answers
        string[] riddles = {"What has 4 legs, but no eyes?", "Why is 99 more than 100?", "What do you call a liar on the phone?"};
        string[] answers = {"toaster", "microwave", "telephony"};

        bool[] passes = new bool[3] {false, false, false};

        // TODO: Do opposite of user's input for first riddle

        string name = playerData[0];
        int age = playerData[1];
        
        Console.ForegroundColor = ConsoleColor.Red;
        Util.staggeredPrint($"Why hello {name}, ", ConsoleColor.Red);
        Util.stagWait();
        Util.staggeredPrint($"You're {age} right?", ConsoleColor.Red);
        Util.stagWait();
        Util.staggeredPrint("Yeah that's right...", ConsoleColor.Red);

        Thread.Sleep(1000);
        Util.staggeredPrint("To pass me, you must riddle me this...", ConsoleColor.Red);
        Util.stagWait();

        #region Riddles

        for (int currentRiddle = 0 ; currentRiddle < riddles.Length ; currentRiddle++)
        {

            List<bool> fails = new List<bool> {};

            // Print current riddle
            Util.staggeredPrint(riddles[currentRiddle], ConsoleColor.Cyan, 100);

            // Get an answer 3 times, if the user does not get it after 3 tries they fail
            for (int i = 0 ; i < 3 ; i++)
            {

                // Get user answer
                Console.Write("> ");
                string answer = Console.ReadLine();

                // Check if the user got the right answer
                if (answer.Contains(answers[currentRiddle]))
                {

                    Util.staggeredPrint("Wow you got it right", ConsoleColor.Red);
                    passes[currentRiddle] = true;
                    Thread.Sleep(500);
                    Console.Clear();
                    break;

                }

                else
                {

                    Util.staggeredPrint("Nope, wrong", ConsoleColor.Yellow);

                    // Check if user has failed 3 times
                    // i increments by 1 starting at 0 so 2 is the index of 3
                    if (i == 2)
                    {

                        Util.stagWait();
                        Util.staggeredPrint($"The answer was {answers[currentRiddle]}", ConsoleColor.Yellow);

                    }

                    Thread.Sleep(500);
                    Console.Clear();

                }

            }

        }

        if (passes.Contains(true))
        {

            if (passes.Contains(false))
            {

                Util.staggeredPrint("Hmm, you failed some of the riddles", ConsoleColor.Blue);
                Util.stagWait();
                Util.staggeredPrint("But you got some right so I'll let you pass", ConsoleColor.Blue);

            }

        }

        if (!passes.Contains(true))
        {

            Util.staggeredPrint("Well...", ConsoleColor.Blue);
            Util.stagWait();
            Util.staggeredPrint("You failed them all...", ConsoleColor.Blue);
            Thread.Sleep(500);
            Util.staggeredPrint("Thanks for playing :)", ConsoleColor.Yellow);
            Thread.Sleep(500);
            Environment.Exit(0);

        }

        #endregion

    }

    public static void game2()
    {

        //

    }

    public static void game3()
    {

        //

    }

    public static void changeGame()
    {

        Console.Clear();
        Thread.Sleep(1500);

    }

}