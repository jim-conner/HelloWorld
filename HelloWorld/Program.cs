using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
  
            //passing cmd line arg to console app
            if (args.Length == 0)
            {
                // Display message to user to provide parameters.
                System.Console.WriteLine("Dude, you need to enter parameter values.");
                Console.Read();
                    // ^ Keeps the console window open after the program has run.

            }
            else
            {
                string name;
                {
                    Console.WriteLine("Please enter your name...");
                    name = Console.ReadLine();
                    Console.WriteLine($"Okay, {name}. Please choose a greeting...");
                }

                // Loop through array to list args parameters.
                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write(args[i] + Environment.NewLine);
                }
                var greetingChoice = Console.ReadLine();
                if (greetingChoice == args[0])
                {
                    Console.WriteLine("Well, how all ya'll doin'?");
                }
                if (greetingChoice == args[1])
                {
                    Console.WriteLine("'elo guvnah");
                }if (greetingChoice == args[2])
                {
                    Console.WriteLine("Alors, qu'est que tu en veux?");
                }
                
                Console.WriteLine($"So {name}, what's your favorite color?");
                var favColor = Console.ReadLine();
                var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

                Random rnd = new Random();
                int index = rnd.Next(animals.Length);

                Console.WriteLine($"How would you like to own a {favColor} {animals[index]}?");
                Console.ReadLine();

                Console.WriteLine($"Now press Enter to see at a list of animals...");
                Console.Read();
                foreach (var animal in animals)
                    if (animal.Length >= 5)
                    {
                        Console.WriteLine(animal);
                    }



            }
        }
    }
}

