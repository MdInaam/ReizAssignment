using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Prompt the user to enter the hours
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the hours (1-12): ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int hours = int.Parse(Console.ReadLine());

            // Check if the entered integer is less than 1 or more than 12
            if (hours < 1 || hours > 12)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid hour input. Please enter a value between 1 and 12.");
                Console.ResetColor();
                continue; // Restart the loop to get valid input
            }

            // Prompt the user to enter the minutes
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter the minutes (0-59): ");
            Console.ForegroundColor = ConsoleColor.Blue;
            int minutes = int.Parse(Console.ReadLine());

            // Check if the entered integer is less than 0 or more than 59
            if (minutes < 0 || minutes > 59)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid minute input. Please enter a value between 0 and 59.");
                Console.ResetColor();
                continue; // Restart the loop to get valid input
            }

            // Calculate the degrees between the hour hand and minute hand
            double hourAngle = (hours % 12 + minutes / 60.0) * 30;  // Each hour mark is 30 degrees
            double minuteAngle = minutes * 6;  // Each minute mark is 6 degrees

            double angleDiff = Math.Abs(hourAngle - minuteAngle);
            double lesserAngle = Math.Min(360 - angleDiff, angleDiff);

            // Display the calculation
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("┌────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                │");
            Console.Write("│  The lesser angle between the hour and minute hands is: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{lesserAngle,-5}°");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" │");
            Console.WriteLine("│                                                                │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────┘");
            Console.ResetColor();

            // Ask the user if they want to rerun the program
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Do you want to calculate again? (Y/N): ");
            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine().Trim().ToUpper();

            if (response != "Y")
                break; // Exit the loop if the user does not want to rerun
            Console.Clear(); // Clear the console screen for the next run
        }
    }
}