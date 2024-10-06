using System.Security.Cryptography.X509Certificates;

namespace NumbersGameLab3
{
    //Camilla Söderman
    // Class .Net24
    // October 2024
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 20;
            Random random = new Random();
            int number = random.Next(minNumber, maxNumber);
            
            int maxGuesses = 5;
            int guessesLeft = 5;
            bool rightGuess = false;
        
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            while (!(guessesLeft == 0 || rightGuess)) //Run as long as there are guesses left of the user did not guess right
            {
                int userGuess = ValidateUserGuess(minNumber, maxNumber); // Uses method ValidateUserGuess to check if number and between min/max number
                
                Console.WriteLine();
                
                Console.WriteLine($"Du gissade {userGuess}");

                if (userGuess > number) // If user guess whas higher than random number
                {
                    Console.WriteLine("Tyvärr, var det för högt!");
                    guessesLeft--;
                    Console.WriteLine($"Du har nu {guessesLeft} gissningar kvar.");
                }
                else if (userGuess < number) // If user guess whas lower than random number
                {
                    //Console.WriteLine($"Du gissade {userGuess}");
                    Console.WriteLine("Tyvärr, var det för lågt!");
                    guessesLeft--;
                    Console.WriteLine($"Du har nu {guessesLeft} gissningar kvar.");
                }
                rightGuess = CheckGuess(number, userGuess); //Check if the user guessed right
                if (rightGuess)
                {
                    Console.WriteLine($"Du gissade {userGuess}, min siffra är {number}, du gissade rätt!\n" +
                        $"Det tog {(maxGuesses - guessesLeft) +1} försök\n" +
                        $"Bra jobbat!");
                }
                Console.WriteLine();
                

            }

            if (guessesLeft == 0 && !rightGuess) // If the all the guesses are made and the user did not guess right
                {
                    Console.WriteLine($"Du har förbrukat alla dina gissningar,svaret var: {number}, bättre lycka nästa gång!");
                }

            }
        
        private static bool CheckGuess(int number, int guess) // Check if user input matches random number
        {
           return number == guess;
            
        }
        public static int ValidateUserGuess(int minNumber, int maxNumber) // Check if user input is a number and if it is between min and max numbers
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int guess))
                {
                    if (guess > 0 && guess <= maxNumber) // If guess is above 0 and smaller than max number
                    {
                        return guess;
                    }
                    Console.WriteLine($"Du råkade skriva en siffra utanför spannet, pröva igen!\n" +
                        $"Skriv en siffra mellan {minNumber} och {maxNumber}.");
                }
                else
                {
                    Console.WriteLine("Du har angett något annat än en siffra, försök igen! :)"); // If not a number
                }
            }
        }
            
        }
      
    }

