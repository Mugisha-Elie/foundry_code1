using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1: Check if a number is Even or Odd");
            Console.WriteLine("2: Check if a number is Positive or Negative");
            Console.WriteLine("3: Exit");
            Console.Write("Enter your choice (1, 2 or 3): ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    Console.Write("Enter a number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 % 2 == 0)
                        Console.WriteLine($"{num1} is Even.");
                    else
                        Console.WriteLine($"{num1} is Odd.");
                    break;

                case 2:
                    

                case 3:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }

        } while (choice != 3);
    }
}
