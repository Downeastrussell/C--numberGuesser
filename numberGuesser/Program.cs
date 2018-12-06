using System;

// Namespace
namespace numberGuesser
{   // Main Class
    class Program
    {   // Entry point method
        static void Main(string[] args)
        {

            GetAppInfo(); //run GetAppInfo function to get info

            GreetUser(); //ask for user name and greet

            
            while (true)
            {



                //init correct number &
                //creat a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess variable
                int guess = 0;


                //ask user for number
                Console.WriteLine("guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make sure is an accepted input variable
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.DarkYellow, "Pick a NUMBER BUDDY!!! NO FLOATS EITHER!!!");


                        //keep going
                        continue;

                    }

                    //change to int and put in guess variable
                    guess = Int32.Parse(input);

                    //compare guess to correct number
                    if (guess != correctNumber)
                    {
                        

                        PrintColorMessage(ConsoleColor.DarkRed, "WRONG! TRY AGAIN!!!");


                    }



                }

                //output success messsage


                PrintColorMessage(ConsoleColor.DarkGreen, "You are correct! CONGRATULATIONS!!!");

                //ask to play again
                Console.WriteLine("play again? [Y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }


            }
        }

        static void GetAppInfo()
        {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Russell Miller";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            //ask user name
            Console.WriteLine("what is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

        }

        //print color message

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //change text color
            Console.ForegroundColor = color;

            //inform user their input is something stupid
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }

    }   
}
