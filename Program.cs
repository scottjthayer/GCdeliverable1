using System;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the MilHip unit converter!");

            bool loopRun = true;
            while (loopRun)
            {
                Console.WriteLine("\nPlease enter an amount and type of measurement (memes, fidget spinners, inch, or foot)");
                Console.WriteLine("Inch will convert to fidget spinners and vise versa. Foot will convert to memes and vise versa\n");
                
                Console.Write("Amount: ");
                string userAmount = Console.ReadLine().ToLower();
                Console.Write("Type: ");
                string userType = Console.ReadLine();

                double userDouble = double.Parse(userAmount);
               

                Console.WriteLine($"Great, you entered {userDouble} {userType}.\n");

                double convAmount = 0;

                if (userType == "inch")
                {
                    convAmount = userDouble * 3.5;
                    Console.WriteLine($"{userDouble} {userType} converts to {convAmount} fidget spinners\n");
                }

                else if (userType == "fidget spinners")
                {
                    convAmount = userDouble / 3.5;
                    Console.WriteLine($"{userDouble} {userType} converts to {convAmount} inches\n");
                }

                else if (userType == "foot")
                {
                    convAmount = userDouble * 5;
                    Console.WriteLine($"{userDouble} {userType} converts to {convAmount} memes\n");
                }

                else if (userType == "memes")
                {
                    convAmount = userDouble / 5;
                    Console.WriteLine($"{userDouble} {userType} converts to {convAmount} foot\n");
                }

                else
                {
                    Console.WriteLine("You have entered an invalid conversion type. Please Try again");
                }

                Console.WriteLine("Would you like to do another calculation? Please enter 'y' for yes or any other key to exit program");
                string moreConv = Console.ReadLine();
                string userConv = moreConv.ToLower();

                if (userConv == "y")
                {
                    loopRun = true;
                }

                else
                {
                    loopRun = false;
                    Console.WriteLine("\nThank you for using the MilHip Conversion App! Tell your friends.");
                }
            }
            
        }
    }
}
