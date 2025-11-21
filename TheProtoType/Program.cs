namespace TheProtoType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool numToGuess = false;
            
            Random rnd = new Random();
            int randomNum = rnd.Next(1, 100);
            
            Console.WriteLine("Enter a number between 1 and 100");

            while (!numToGuess)
            {
                Console.WriteLine("Please enter your guess.");
                var userInput = Convert.ToInt32(Console.ReadLine());
                
                if (userInput > randomNum)
                {
                    Console.WriteLine($"Your number is too high. Try again");
                }
                else if (userInput < randomNum)
                {
                    Console.WriteLine($"Your number is too low. Try again");
                }
                else
                {
                    Console.WriteLine($"Your number is right. You win!");
                    Console.WriteLine($"The correct number was {randomNum}");
                }
            }

            Console.ReadKey();


        }
    }
}
