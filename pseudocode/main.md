## Game file
    Create a function called "intro" that returns a multi-type ARRAY

        Welcome the user
        Ask for their name and store it as a string and call it "name"
        Ask for their age and store it as an integer and call it "age"

        Create a 1D multi-type array with a length of 2 containing (name, age) called "playerData"

        Return {playerData}



    Create a function called "game1" that returns a boolean

        Create a 1D string array with a length of 3 containing 3 riddles called "riddles"
        Create a 1D string array with a length of 3 containing 3 answers called "answers"
        Create a 1D boolean array with a length of 3 containing (false, false, false) called "passes"

        Welcome the user

        Create a for loop that loops over the length of {riddles} as currentRiddle

            Create a boolean list called fails

            Create a for loop that loops over 3 times as i

                Print {riddles} at the index of {i}

                Ask for an answer and store it as an string and call it "answer"

                Check if the user got the riddle right

                    Add true to {passes}

                    Break from the loop

                Else

                    Print "Wrong"

                    Check if {i} equals 2

                        Print the right answer

        Check if {passes} contains true

            Check if {passes} contains false

                Tell the user that they failed some of the riddles, but they still pass

                Return true

            Else

                Tell the user that they got all the answers right

                Return true

        Else

            Tell the user they failed

            Return false

        Return false



    Create a function called "game2" that returns a boolean

        Create a 2D string array with a length of 2 containing (("01", "Attack", "02", "Reason"), ("03", "Flee", "04", "Do Nothing")) and call it "actionsMenuStr"
        Create a 1D string array with a length of 4 containing ("Attack", "Reason", "Flee", "Do Nothing") and call it "menuActionsStr"
        Create a string containing all the {menuActionsStr} items and call it "outcomes"
        Create a 1D string array with a length of 4 containing 4 outcomes for each item in {menuActionsStr}

        Create a lambda expression to print {outcomes} at the index of the user input that takes an integer as a parameter and returns nothing called "printOutcome"

        Welcome the user

        Create a while loop with the condition of true

            Get an integer from the user and store it as and integer called "actionIndex"

            Check if {actionIndex} is in range between 1 and 4

                If it isn't, print "error"

                Else call printOutcome() that takes {actionIndex - 1} and break out the loop

        Check if {actionIndex} equals 1 or 2

            Tell the user they passed

            Return true

        Else

            Tell the user they failed

            Return false



    Create a function called "game3" that returns a boolean

        Create an 1D integer list called "totalGuesses"
        Create a boolean containing false and call it "acceptedGuess"
        Create integer containing 0 and call it "guess"
        Create a 1D boolean array containing 5 booleans, one of which is true and the rest are false and call it "answers"

        Welcome the user

        Create an integer containing 3 and call it "guesses"

        Create a while loop with the condition of {guesses > 0}

            Create a while loop with the condition of {!acceptedGuess}

                Set {guess} to user input

                Check if {guess} is in range between 1 and 5

                    Check if {totalGuesses} doesn't contain {guess}

                        Check if {answers} at the index of {guess - 1} equals true

                            Tell the user they win

                            Return false

                        Else

                            Tell the user they were Wrong

                            take 1 away from {guesses}

                            Add {guess} to {totalGuesses}

                            Set {acceptedGuess} to false

                    Else

                        Tell the user they already guesses {guess}

                        Set {acceptedGuess} to false

                Else

                    Tell the user they have to enter a number between 1 and 5

                    Set {acceptedGuess} to false

                Check if {guesses} equals 0

                    Return false

            Return false



    Create a fucntion called "game4" that returns a boolean

        Welcome the user

        Create a 1D string array with a length of 5 containing 5 different questions called "questions"
        Create a 1D string array with a length of 5 containing 5 different answers to {questions} called "answers"
        Create a 2D string array with a length of 5 containing 5 different 1D arrays containing 5 strings, the index of 0 will equal the right answer called "altAnswers"

        Create a 2D int list with a length of 5 and call it "allRanIndexes"

        Create a for loop that loops over the length of 5

            Create a 1D int list containing numbers 1 - 5 in a random order, each number only appears once, call it "ranIndexes"

            Add {ranIndexes} to {allRanIndexes}

        Create a for loop that loops over each 1D int array in {allRanIndexes}

            Create a 1D string array containing strings containing {altAnswers} at the index of the {1D int array} at the index of 0, 1, 2, 3, and 4 and call it "questionsStrArray"

            Create a for loop that loops over each string in {questionsStrArray}
            
                print the string
                
                get the index of the answer
                
            Create a while loop with the condition of {true}
            
                Create a string that takes user input and call it "userAnswer"
                
                Check if {userAnswer} is a number between 1 and 5
                
                    Print and error if not
                    Else break from the loop
                    
                Check if {userAnswer - 1} is equal to {answerIndex}
                
                    Tell the user they got it right
                    
                Else
                
                    Tell the user they got it wrong
                    
            Check if the user got 3 or more questions wrong
            
                If they did print an error and restart the game and return {true}
                
                IF they didn't print a congratulations message and return {false}



    Create a function called "outro" that returns a boolean

        Ask the user if they want to play again

        If they do return true

        Else return false



## Main File

    Create a boolean called "loop" and set it to false

    Create a while loop with the condition of loop

        Set loop to Game.intro()
        Clear the screen

        Set loop to Game.intro()
        Clear the screen

        Set loop to Game.intro()
        Clear the screen

        Set loop to Game.intro()
        Clear the screen

        Set loop to Game.intro()
        Clear the screen

    Set loop to Game.outro()
