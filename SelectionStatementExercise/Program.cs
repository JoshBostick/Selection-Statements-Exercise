namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1 and 1000");
            
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userGuess;
            var counter = 0;
            do
            {
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess == favNumber)
                {
                    Console.WriteLine($"{userGuess} is Correct!");
                }
                else if (userGuess > favNumber)
                {
                    Console.WriteLine("Too High");
                }
                else
                {
                    Console.WriteLine("Too Low");
                }
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"You have guessed {counter} time");
                }
                else if (userGuess == favNumber)
                {
                    Console.WriteLine($"It took you {counter} guesses.");
                }
                else
                {
                    Console.WriteLine($"You have guessed {counter} times");
                }
                                
            } while (userGuess != favNumber);
        }   
    }
}
