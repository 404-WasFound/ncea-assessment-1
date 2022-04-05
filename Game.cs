class Game
{

    public static dynamic[] Intro()
    {

        // Initialize classes
        Random random = new Random();

        // Setup variables
        string[] outcomes = new string[2] {"That's a cool name!", "That's a weird name"};
        ConsoleColor[] colours = new ConsoleColor[2] {ConsoleColor.Green, ConsoleColor.Yellow};
        int[] waits = new int[2] {50, 100};
        string name = "";

        // Get a random number between 0 and 1
        int num = random.Next(0, 2);

        // Use Util.GetMenu() to create a title
        string title = Util.GetMenu(new string[][]
            {new string[] {"Adventure Game"}}, "Adventure Game".Length);

        // Welcome user and get their name
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(title);
        Console.ForegroundColor = ConsoleColor.White;
        Util.StaggeredPrint("Why hello adventurer!", ConsoleColor.Green);
        Util.StagWait();

        Util.StaggeredPrint("What is your name?", ConsoleColor.Green);
        Console.Write("> ");

        name = Console.ReadLine();

        // List of bools to detect if there are numbers name
        List<bool> containsNums = new List<bool> {};

        // Check if there are any numbers in name
        foreach (char c in name)
        {

            try
            {

                int.Parse(c.ToString());
                containsNums.Add(true);

            } catch (FormatException)
            {

                containsNums.Add(false);

            }

        }

        // Check if 'name' is empty or that there are numbers in the name
        if (name == "" || containsNums.Contains(true))
        {

            Util.StaggeredPrint("It's not hard to type a proper name you know...",
                                ConsoleColor.Yellow, waits[1]);
            Util.StagWait();
            Util.StaggeredPrint("You'll just have to be 'Bob' then (=_=)",
                                ConsoleColor.Yellow, waits[1]);
            name = "Bob";

        }


        // Clear screen and get user's age
        Console.Clear();
        Util.StaggeredPrint($"{name}...");
        Util.StagWait();

        Util.StaggeredPrint(outcomes[num], colours[num], waits[num]);
        Util.StagWait();

        Util.StaggeredPrint("What is your age?");
        Console.Write("> ");

        string ageStr = Console.ReadLine();

        try {

            long age = int.Parse(ageStr);

            return new dynamic[] {name, age};

        // Check if nothing a number isn't entered
        } catch (FormatException) {

            Util.StaggeredPrint("Whatever, you're probably 12 then",
                                ConsoleColor.Yellow, waits[1]);
            long age = 12;

            return new dynamic[] {name, age};

        }

    }

    public static bool Game1(dynamic[] playerData)
    {

        // Riddles and answers
        string[] riddles = {"What has 4 legs, but no eyes?",
                            "Why is 99 more than 100?",
                            "What do you call a liar on the phone?"};
        string[] answers = {"toaster", "microwave", "telephony"};

        bool[] passes = new bool[3] {false, false, false};

        // TODO: Do opposite of user's input for first riddle

        string name = playerData[0];
        long age = playerData[1];

        Console.ForegroundColor = ConsoleColor.Red;
        Util.StaggeredPrint($"Why hello {name}, ", ConsoleColor.Red);
        Util.StagWait();
        Util.StaggeredPrint($"You're {age} right?", ConsoleColor.Red);
        Util.StagWait();
        Util.StaggeredPrint("Yeah that's right...", ConsoleColor.Red);

        Thread.Sleep(1000);
        Util.StaggeredPrint("To pass me, you must riddle me this...",
                            ConsoleColor.Red);
        Thread.Sleep(1000);

        #region Riddles

        for (int currentRiddle = 0 ; currentRiddle < riddles.Length ;
            currentRiddle++)
        {

            // List of failed riddles
            List<bool> fails = new List<bool> {};

            // Get an answer 3 times, if the user does not get it after 3 tries they fail
            for (int i = 0 ; i < 3 ; i++)
            {

                // Get user answer
                Util.StaggeredPrint(riddles[currentRiddle],
                                    ConsoleColor.Cyan, 10);
                Console.Write("> ");
                string answer = Console.ReadLine();

                // Check if the user got the right answer
                if (answer.Contains(answers[currentRiddle]))
                {

                    Util.StaggeredPrint("Wow you got it right",
                                        ConsoleColor.Red);
                    passes[currentRiddle] = true;
                    Thread.Sleep(500);
                    Console.Clear();
                    break;

                }

                else
                {

                    Util.StaggeredPrint("Nope, wrong", ConsoleColor.Yellow);

                    // Check if user has failed 3 times
                    // i increments by 1 starting at 0 so 2 is the index of 3
                    if (i == 2)
                    {

                        Util.StagWait();
                        Util.StaggeredPrint($"The answer was {answers[currentRiddle]}",
                                            ConsoleColor.Yellow);

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

                Util.StaggeredPrint("Hmm, you failed some of the riddles",
                                    ConsoleColor.Red);
                Util.StagWait();
                Util.StaggeredPrint("But you got some right so I'll let you pass",
                                    ConsoleColor.Red);
                return true;

            }

            else
            {

                Util.StaggeredPrint("Wow you got them all right, good job!",
                                    ConsoleColor.Red);
                Util.StagWait();
                Util.StaggeredPrint("I'll let you pass then", ConsoleColor.Red);
                return true;

            }

        }

        if (!passes.Contains(true))
        {

            Util.StaggeredPrint("Well...", ConsoleColor.Blue);
            Util.StagWait();
            Util.StaggeredPrint("You failed them all...", ConsoleColor.Blue);
            Thread.Sleep(500);
            Util.StaggeredPrint("Thanks for playing :)", ConsoleColor.Yellow);
            Thread.Sleep(500);
            return false;

        }

        #endregion

        return false;

    }

    public static bool Game2(dynamic[] playerData)
    {

        // Actions menu and indexes
        string[][] actionsMenuStr = {

            new string[] {"01", "Attack", "02", "Reason"},
            new string[] {"03", "Flee", "04", "Do Nothing"}

        };

        // Create seperate array for actions to be accessed by index input
        string[] menuActionsStr = {"Attack", "Reason", "Flee", "Do Nothing"};

        // Use Util.GetMenu() to create a menu
        string actionsMenu = Util.GetMenu(actionsMenuStr, 10);

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
        string[] asciiDragon = {

            // Use '@' to allow escape characters

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


        };

        // Lambda expression to print ascii art as colour corresponding to index
        Action<int> printAsciidragon = index =>
        {

            string final = "";

            foreach (string line in asciiDragon)
            {

                final += line + "\n";

            }

            Console.ForegroundColor = ConsoleColor.Red;
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

            string dragonMenu = Util.GetMenu(dragonData, 10);
            string playerMenu = Util.GetMenu(playerData, 10);

            #endregion

            // Print actions menu and dragon ascii
            Console.WriteLine(dragonMenu);
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (string line in asciiDragon)
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
            Util.StaggeredPrint(actionOutcomesString[index][0]);

        };

        // 'Use Util.GetMenu()' to create a boxed title
        string[][] title = {new string[] {"Dragon Battle"}};
        string boxedTitle = Util.GetMenu(title, "Dragon Battle".Length);
        Console.WriteLine(boxedTitle, ConsoleColor.Magenta);

        // Welcome player
        Util.StaggeredPrint($"Well hello there {playerData[0]},",
                            ConsoleColor.DarkYellow);
        Util.StagWait();
        Util.StaggeredPrint("Welcome to the 2nd trial",
                            ConsoleColor.DarkYellow);
        Util.StagWait();
        Util.StaggeredPrint("To reach the next level, you must defeat me!",
                            ConsoleColor.DarkYellow, 100);

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

                if (!Util.InRange(actionIndex, 1, 4))
                {

                    Util.StaggeredPrint("Input error, please select a number between 1 and 4");

                } else
                {

                    Console.Clear();
                    // Minus 1 to get index then print outcome of choice
                    printOutcome(actionIndex - 1);
                    Util.StagWait();
                    break;

                }

            } catch (FormatException)
            {

                Util.StaggeredPrint("Input error, please select a number between 1 and 4");

            }

        }

        if (actionIndex == 1 || actionIndex == 2)
        {

            // Congratulate user on passing second trial
            Console.Clear();
            Util.StaggeredPrint("You passed the 2nd trial!",
                                ConsoleColor.Green);
            Util.StagWait();
            Util.StaggeredPrint("Now onto the 3rd...",
                                ConsoleColor.Green);
            Util.StagWait();
            // End game2
            return true;

        } else {

            Util.StaggeredPrint("Sadly you failed this trial...",
                                ConsoleColor.Green);
            Util.StagWait();
            Util.StaggeredPrint("Thanks for playing!", ConsoleColor.Green);
            Thread.Sleep(1500);
            return false;

        }

    }

    public static bool Game3(dynamic[] playerData)
    {

        // list of past user choices
        List<int> totalGuesses = new List<int> {};

        bool acceptedGuess = false;
        int guess = 0;

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

        // Create boxed title with Util.GetMenu()
        string[][] title = {new string[] {"Door Game"}};
        string boxedTitle = Util.GetMenu(title, "Door Game".Length);
        Console.WriteLine(boxedTitle, ConsoleColor.Green);

        // Welcome user to final trial and explain the game
        Util.StaggeredPrint($"Well done {playerData[0]}", ConsoleColor.Green);
        Util.StagWait();
        Util.StaggeredPrint("Welcome to the 3rd trial!", ConsoleColor.Green);
        Util.StagWait();
        Util.StaggeredPrint("To pass me, you must pick the right door",
                            ConsoleColor.Green);
        Util.StagWait();
        Util.StaggeredPrint("You will have 3 guesses to guess between 5 doors",
                            ConsoleColor.Green);
        Util.StagWait();
        Util.StaggeredPrint("Good luck!", ConsoleColor.Green, 100);
        Thread.Sleep(1000);

        // Start the game

        // Repeat util user has used all their guesses
        int guesses = 3;

        while (guesses > 0)
        {

            while (!acceptedGuess)
            {

                Console.Clear();

                // Print door ASCII art
                foreach (string line in doorsAsciiArt)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(line);

                }

                // Get user input
                Console.Write("Enter a number between 1 and 5 (Note that you cannot enter the same number twice)\n> ");

                try
                {

                    guess = int.Parse(Console.ReadLine());
                    acceptedGuess = true;

                } catch (FormatException)
                {

                    Util.StaggeredPrint("Please only enter numbers",
                                        ConsoleColor.Yellow);
                    acceptedGuess = false;

                }

            }

            // Check if user guess is between 1 and 5
            if (Util.InRange(guess, 1, 5))
            {

                if (!totalGuesses.Contains(guess))
                {

                    if (answers[guess - 1] == true)
                    {

                        Console.Clear();
                        Util.StaggeredPrint("Well done!", ConsoleColor.Green);
                        Util.StagWait();
                        Util.StaggeredPrint("You completed the 3rd trial!",
                           ConsoleColor.Green);
                        Thread.Sleep(1500);
                        return false;

                    } else
                    {

                        Util.StaggeredPrint("Nope, wrong door",
                                            ConsoleColor.Yellow);
                        Util.StagWait();
                        guesses--;
                        Util.StaggeredPrint($"You have {guesses} guesses left",
                                            ConsoleColor.Yellow);
                        Util.StagWait();
                        Console.Clear();
                        totalGuesses.Add(guess);
                        acceptedGuess = false;

                    }

                } else
                {

                    Util.StaggeredPrint($"You already guessed {guess}",
                                        ConsoleColor.Yellow);
                    Util.StagWait();
                    acceptedGuess = false;

                }

            }

            if (!Util.InRange(guess, 1, 5))
            {

                Util.StaggeredPrint("Please only enter numbers between 1 and 5",
                                    ConsoleColor.Yellow);
                acceptedGuess = false;

            }

            if (guesses == 0)
            {

                return false;

            }

        }

        return false;

    }

    public static bool Game4(dynamic[] playerData)
    {

        // Use DateTime class to get the current date
        DateTime today = DateTime.Today;

        // User Random class to get a random number
        Random random = new Random();

        // Create a title using Util.GetMenu()
        string title = Util.GetMenu(new string[][] {new string[] {"Quiz"}}, 4);

        // Turn the day into 
        string todayStr = $"{today.ToString("dd/MM")}";

        // Array of questions
        string[] questions = new string[5] {

            "What is the capital city of Japan?",
            "What year did humans land on the moon?",
            @"When was the game 'Among Us' released?",
            "How many bones does a human have?",
            "What is the date today?"

        };

        // Correct answers
        string[] answers = new string[5] {

            "Tokyo",
            "1969",
            "2018",
            "206",
            todayStr

        };

        // Wrong answers
        string[][] altAnswers = new string[5][] {

            new string[] {answers[0], "Vietnam", "Hong Kong", "Kyoto", "China"},
            new string[] {answers[1], "1968", "1869", "2012", "1967"},
            new string[] {answers[2], "2019", "2015", "2020", "2021"},
            new string[] {answers[3], "207", "205", "306", "208"},
            new string[] {answers[4], "19/04/2022", "20/02/2022", "02/07/1886", "24/12/1994"}

        };

        // Variable setup
        List<int[]> allRanIndexes = new List<int[]> {};
        string[][] finalStrList = new string[][] {};
        int userAnswer = 0;
        int answerIndex = 0;
        int wrong = 0;

        // Welcome the user
        Util.StaggeredPrint($"Welcome to the final trial, {playerData[0]}", ConsoleColor.DarkCyan);
        Util.StagWait();
        Util.StaggeredPrint("To finish the dungoeon...", ConsoleColor.DarkCyan);
        Util.StagWait();
        Util.StaggeredPrint("You must...", ConsoleColor.DarkCyan);
        Util.StagWait();
        Util.StaggeredPrint("Do a quiz! 😁", ConsoleColor.DarkCyan);
        Util.StagWait();

        // Create 5 arrays of 5 random indexes from 0 - 4
        for (int i = 0 ; i<5 ; i++)
        {

            List<int> randomIndexes = new List<int> {};

            for (int x = 0 ; x<5 ; x++)
            {

                while (true)
                {

                    // Get a random number between 0 and 4
                    int randomIndex = random.Next(0, 5);

                    if (!randomIndexes.Contains(randomIndex))
                    {

                        randomIndexes.Add(randomIndex);
                        break;

                    }

                }

            }

            allRanIndexes.Add(randomIndexes.ToArray());

        }

        // Display and ask questions
        for (int questionCount = 0 ; questionCount<5 ; questionCount++)
        {

            // Array of questions with random placements
            string[] questionsStrArray = new string[5] {

                $"1 - {altAnswers[questionCount][allRanIndexes[questionCount][0]]}",
                $"2 - {altAnswers[questionCount][allRanIndexes[questionCount][1]]}",
                $"3 - {altAnswers[questionCount][allRanIndexes[questionCount][2]]}",
                $"4 - {altAnswers[questionCount][allRanIndexes[questionCount][3]]}",
                $"5 - {altAnswers[questionCount][allRanIndexes[questionCount][4]]}"

            };

            // Display question
            Util.StaggeredPrint(questions[questionCount], ConsoleColor.DarkCyan, 10);
            Util.StagWait();

            foreach (string line in questionsStrArray)
            {

                Console.WriteLine(line);

                // Split the line to get the answer
                string splitLineAns = line.Split(" - ")[1];

                // Check if it is the right answer
                if (answers[questionCount] == splitLineAns)
                {

                    // Get index of answer
                    answerIndex = Array.FindIndex(questionsStrArray, ind => ind.Contains(answers[questionCount]));

                }

            }

            while (true)
            {

                Console.Write("> ");
                string userAnswerStr = Console.ReadLine();

                try
                {

                    userAnswer = int.Parse(userAnswerStr);

                    if (!Util.InRange(userAnswer, 1, 5))
                    {

                        // Purposely create a FormatException so it is caught and prints the error
                        int ph = int.Parse("x");

                    } else { break; }

                } catch (FormatException)
                {

                    Util.StaggeredPrint("Please enter a number between 1 and 5");
                    continue;

                }

            }

            if (userAnswer - 1 == answerIndex)
            {

                Util.StaggeredPrint("Correct", ConsoleColor.DarkCyan);
                Console.WriteLine($"!!{userAnswer}!! RIGHT ({answerIndex})");

            } else
            {

                Util.StaggeredPrint("Nope, wrong", ConsoleColor.DarkCyan);
                Console.WriteLine($"!!{userAnswer}!! WRONG ({answerIndex})");
                wrong++;

            }

            Thread.Sleep(500);
            Console.Clear();

        }

        // Check if the player got atleast 3 or more wrong
        if (wrong >= 3)
        {

            Util.StaggeredPrint("Sorry, but you failed too many questions", ConsoleColor.DarkCyan);
            Util.StagWait();
            Util.StaggeredPrint("Thanks for playing", ConsoleColor.DarkCyan);
            Util.StagWait();

            return false;

        }

        // When the user finishes the dungeon
        else
        {

            Util.StaggeredPrint("Well done!", ConsoleColor.DarkCyan);
            Util.StagWait();
            Util.StaggeredPrint("You finished the dungeon", ConsoleColor.DarkCyan);
            Util.StagWait();
            Util.StaggeredPrint("Thanks for playing!", ConsoleColor.DarkCyan);
            Util.StagWait();

            return false;

        }

    }

    public static bool Outro()
    {

        // Ask user if they want to play again
        Util.StaggeredPrint("Do you want to play again? (Y/N)",
                            ConsoleColor.Green);
        Console.Write("> ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "y")
        {

            return true;

        }

        // If they don't enter y or an expected value, the game will just stop
        else
        {

            return false;

        }

    }

    public static void ChangeGame()
    {

        // Clear console and wait time inbetween games
        Console.Clear();
        Thread.Sleep(1500);

    }

}
