using System;
using System.Collections.Generic;

namespace DeweyDecimalTrainingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dewey Decimal Training App!");

            while (true)
            {
                Console.WriteLine("Choose a task:");
                Console.WriteLine("a. Replacing books");
                Console.WriteLine("b. Identifying areas (Not implemented)");
                Console.WriteLine("c. Finding call numbers (Not implemented)");

                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        ReplaceBooksTask();
                        break;
                    case 'b':
                        Console.WriteLine("This task is not implemented.");
                        break;
                    case 'c':
                        Console.WriteLine("This task is not implemented.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }

        static void ReplaceBooksTask()
        {
            List<string> callNumbers = GenerateCallNumbers();

            Console.WriteLine("Reorder the following call numbers in ascending order:");
            DisplayCallNumbers(callNumbers);

            List<string> userOrder = GetUserInput(callNumbers.Count);

            bool isCorrectOrder = CheckOrder(callNumbers, userOrder);

            if (isCorrectOrder)
            {
                Console.WriteLine("Congratulations! You got the order right.");
                // Implement your gamification feature here.
            }
            else
            {
                Console.WriteLine("Oops! Your order is incorrect. Keep practicing!");
            }
        }

        static List<string> GenerateCallNumbers()
        {
            // Generate and return a list of 10 different call numbers.
            // For the sake of this example, let's use some random call numbers.
            List<string> callNumbers = new List<string>
            {
                "005.73 JAM", "100.12 DOE", "300.45 SMI", "500.89 LEE",
                "600.34 WIL", "700.01 JON", "200.76 HAN", "400.67 PER",
                "800.23 KIN", "900.56 GOM"
            };

            return callNumbers;
        }

        static void DisplayCallNumbers(List<string> callNumbers)
        {
            foreach (string callNumber in callNumbers)
            {
                Console.WriteLine(callNumber);
            }
        }

        static List<string> GetUserInput(int count)
        {
            List<string> userOrder = new List<string>();

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter call number {i + 1}: ");
                userOrder.Add(Console.ReadLine());
            }

            return userOrder;
        }

        static bool CheckOrder(List<string> correctOrder, List<string> userOrder)
        {
            // Compare the user's order with the correct order.
            for (int i = 0; i < correctOrder.Count; i++)
            {
                if (correctOrder[i] != userOrder[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
