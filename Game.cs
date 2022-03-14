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

        // Use Util.getMenu() to create a title
        string title = Util.getMenu(new string[][] {new string[] {"Adventure Game"}}, "Adventure Game".Length);

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

                Util.staggeredPrint("Hmm, you failed some of the riddles", ConsoleColor.Red);
                Util.stagWait();
                Util.staggeredPrint("But you got some right so I'll let you pass", ConsoleColor.Red);

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

    public static void game2(dynamic[] playerData)
    {

        // Actions menu and indexes
        string[][] actionsMenuStr = {

            new string[] {"01", "Attack", "02", "Reason"},
            new string[] {"03", "Flee", "04", "Do Nothing"}

        };

        // Create seperate array for actions to be accessed by index input
        string[] menuActionsStr = {"Attack", "Reason", "Flee", "Do Nothing"};

        // Use Util.getMenu() to create a menu
        string actionsMenu = Util.getMenu(actionsMenuStr, 10);

        // Player settings
        int playerHealth = 20;
        int playerDamage = 3;

        // Dragon settings
        int dragonHealth = 50;
        int dragonDamage = 8;

        // Outcomes of action choices
        string[][] actionOutcomesString = {

            new string[] {$"You deal {playerDamage} damage!"},
            new string[] {"You talk about maybe just getting a coffee and leaving this battle for later... The dragon agrees and you exit the battle"},
            new string[] {"You try and run away, but the dragon stops you and eats you"},
            new string[] {"You and the dragon stare blankly at eachother..."}

        };

        // Dragon ASCII art
        string[][] asciiDragon = {

            // Use '@' to allow escape characters
            new string[] { // Colour: Red

                @" <>=======()",
                @"(/\___   /|\\          ()==========<>_",
                @"      \_/ | \\        //|\   ______/ \)",
                @"        \_|  \\      // | \_/",
                @"          \|\/|\_   //  /\/",
                @"           (**)\ \_//  /",
                @"          //_/\_\/ /  |",
                @"         @@/  |=\  \  |",
                @"              \_=\_ \ |",
                @"                \==\ \|\_",
                @"             __(\===\(  )\",
                @"            (((~) __(_/   |",
                @"                 (((~) \  /",
                @"                 ______/ /",
                @"                 '------'"

            },

            new string[] { // Colour: Grey

                @" <>=======()",
                @"(/\___   /|\\          ()==========<>_",
                @"      \_/ | \\        //|\   ______/ \)",
                @"        \_|  \\      // | \_/",
                @"          \|\/|\_   //  /\/",
                @"           (Xx)\ \_//  /",
                @"          //_/\_\/ /  |",
                @"         @@/  |=\  \  |",
                @"              \_=\_ \ |",
                @"                \==\ \|\_",
                @"             __(\===\(  )\",
                @"            (((~) __(_/   |",
                @"                 (((~) \  /",
                @"                 ______/ /",
                @"                 '------'"

            }

        };
        ConsoleColor[] asciiDragonColours = new ConsoleColor[] {ConsoleColor.Red, ConsoleColor.Yellow};

        // Lambda expression to print ascii art as colour corresponding to index
        Action<int> printAsciidragon = index => 
        {

            string final = "";

            foreach (string line in asciiDragon[index])
            {

                final += line + "\n";

            }

            Console.ForegroundColor = asciiDragonColours[index];
            Console.WriteLine(final);
            Console.ForegroundColor = ConsoleColor.White;

        };

        // Create lambda expression to get user info and action menu index from user
        Action<int> displayBattle = index =>
        {

            #region menuSetup

            // Create player info menu
            string[][] playerData = {

                new string[] {"PLAYER"},
                new string[] {$"Health: {playerHealth}"},
                new string[] {$"Damage: {playerDamage}"}

            };

            // Create dragon info menu
            string[][] dragonData = {

                new string[] {"DRAGON"},
                new string[] {$"Health: {dragonHealth}"},
                new string[] {$"Damage: {dragonDamage}"}

            };

            string dragonMenu = Util.getMenu(dragonData, 10);
            string playerMenu = Util.getMenu(playerData, 10);

            #endregion

            // Print actions menu and dragon ascii
            Console.WriteLine(dragonMenu);
            Console.ForegroundColor = asciiDragonColours[index];
            foreach (string line in asciiDragon[index])
            {

                Console.WriteLine(line);

            }

            Console.ForegroundColor = ConsoleColor.White;

            // Calculate positioning of 'playerMenu'
            string[] playerMenuLines = playerMenu.Split("\n");
            int playerMenuLen = playerMenuLines[0].Length;
            int actionsMenuLen = actionsMenu.Split("\n")[0].Length;
            int cursorX = actionsMenuLen - playerMenuLen;

            // Print each line at determined position
            foreach (string line in playerMenuLines)
            {
                Console.SetCursorPosition(cursorX, Console.CursorTop);
                Console.WriteLine(line);

            }

            // Reset cursor position
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.WriteLine(actionsMenu);

        };

        // Create lambda expression to display secondary action menu items corresponding to index of user
        Action<int> printOutcome = index =>
        {

            Console.Clear();
            // Print action outcomes at the index of the user input
            Util.staggeredPrint(actionOutcomesString[index][0]);

        };

        // 'Use Util.getMenu()' to create a boxed title
        string[][] title = {new string[] {"Dragon Battle"}};
        string boxedTitle = Util.getMenu(title, "Dragon Battle".Length);
        Console.WriteLine(boxedTitle, ConsoleColor.Magenta);

        // Welcome player
        Util.staggeredPrint($"Well hello there {playerData[0]},", ConsoleColor.DarkYellow);
        Util.stagWait();
        Util.staggeredPrint("Welcome to the second trial", ConsoleColor.DarkYellow);
        Util.stagWait();
        Util.staggeredPrint("To reach the next level, you must defeat me!", ConsoleColor.DarkYellow, 100);

        Console.Clear();

        displayBattle(0);

        int actionIndex = 0;

        // Loop through the battle scene until the user picks the right action or fails
        while (true)
        {

            Console.Write("Enter action num: ");

            try
            {

                actionIndex = int.Parse(Console.ReadLine());

                if (!Util.inRange(actionIndex, 1, 4))
                {

                    Util.staggeredPrint("Input error, please select a number between 1 and 4");

                } else
                {

                    Console.Clear();
                    // Minus 1 to get index then print outcome of choice
                    printOutcome(actionIndex - 1);
                    Util.stagWait();
                    break;

                }

            } catch (FormatException)
            {

                Util.staggeredPrint("Input error, please select a number between 1 and 4");

            }

        }

        if (actionIndex == 1 || actionIndex == 2)
        {

            // Congratulate user on passing second trial
            Console.Clear();
            Util.staggeredPrint("You passed the second trial!", ConsoleColor.Green);
            Util.stagWait();
            Util.staggeredPrint("Now onto the final trial...", ConsoleColor.Green);
            Util.stagWait();
            // End game2
            return;

        } else { 
            
            Util.staggeredPrint("Sadly you failed this trial...", ConsoleColor.Green); 
            Util.stagWait();
            Util.staggeredPrint("Thanks for playing!", ConsoleColor.Green);
            Thread.Sleep(1500);
            Environment.Exit(0);
        
        }

    }

    public static void game3(dynamic[] playerData)
    {

        // list of past user choices
        List<int> chosenDoors = new List<int> {};
        int guesses = 3;

        // Answer
        bool[] answers = {false, false, false, true, false};

        // Doors ASCII art
        string[] doorsAsciiArt = {

            "+============+   +============+   +============+   +============+   +============+",
            "|            |   |            |   |            |   |            |   |            |",
            "| +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |",
            "| | | || | | |   | | | || | | |   | | | || | | |   | | | || | | |   | | | || | | |",
            "| | | || | | |   | | | || | | |   | | | || | | |   | | | || | | |   | | | || | | |",
            "| +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |   | +-+-++-+-+ |",
            "|            |   |            |   |            |   |            |   |            |",
            "| 1      ==+ |   | 2      ==+ |   | 3      ==+ |   | 4      ==+ |   | 5      ==+ |",
            "|          ] |   |          ] |   |          ] |   |          ] |   |          ] |",
            "|            |   |            |   |            |   |            |   |            |",
            "|            |   |            |   |            |   |            |   |            |",
            "|            |   |            |   |            |   |            |   |            |",
            "|            |   |            |   |            |   |            |   |            |",
            "+============+   +============+   +============+   +============+   +============+"

        };

        // Create boxed title with Util.getMenu()
        string[][] title = {new string[] {"Door Game"}};
        string boxedTitle = Util.getMenu(title, "Door Game".Length);
        Console.WriteLine(boxedTitle, ConsoleColor.Green);

        // Welcome user to final trial and explain the game
        Util.staggeredPrint($"Well done {playerData[0]}", ConsoleColor.Green);
        Util.stagWait();
        Util.staggeredPrint("Welcome to the final trial!", ConsoleColor.Green);
        Util.stagWait();
        Util.staggeredPrint("To exit the dungeon, you must pick the right door", ConsoleColor.Green);
        Util.stagWait();
        Util.staggeredPrint("You will have 3 guesses the guess between 5 doors", ConsoleColor.Green);
        Util.stagWait();
        Util.staggeredPrint("Good luck!", ConsoleColor.Green, 100);
        Thread.Sleep(1000);

        // Start the game
        Console.WriteLine("CHOOSE A DOOR");

        // Repeat util user has used all their guesses
        while (guesses > 0)
        {

            // User door choice
            int chosenDoor = 0;

            // Print the doors ASCII art
            foreach (string line in doorsAsciiArt)
            {

                Console.WriteLine(line);

            }

            // Get user input
            Console.WriteLine("\n");
            Console.WriteLine("Choose a door (cannot be a door you have chosen prviously)");

            while (true)
            {

                Console.Write("> ");

                // Detect if user doesn't enter a number between 1 - 5, or a number in general
                try
                {

                    // Get user to pick a door
                    chosenDoor = int.Parse(Console.ReadLine());

                    if (!Util.inRange(chosenDoor, 1, 5))
                    {

                        Util.staggeredPrint("Please enter a number between 1 and 5, or a number you haven't already entered");
                        Util.stagWait();

                    } else { break; }

                } catch (FormatException)
                {

                    Util.staggeredPrint("Please only enter numbers");

                }

            }

            if (Util.inRange(chosenDoor, 1, 5) && !chosenDoors.Contains(chosenDoor))
            {

                guesses--;
                chosenDoors.Add(chosenDoor);

                if (answers[chosenDoor - 1] == true)
                {

                    Util.staggeredPrint("You got it right!");
                    Util.stagWait();
                    Util.staggeredPrint("Good job!");
                    Util.stagWait();
                    Util.staggeredPrint("Thanks for playing :)");
                    Thread.Sleep(1500);

                } else { Util.staggeredPrint($"Nope, wrong, {guesses} left"); }

            }

            Console.Clear();

        }        

    }

    public static void changeGame()
    {

        Console.Clear();
        Thread.Sleep(1500);

    }

}