using System;

namespace RectangularPrism
{
    class Program
    {
        private int length;
        private int width;
        private int height;
        static void Main(string[] args)
        {
            Rectangle RectPrism = new Rectangle();
            Console.WriteLine("1- Get Rectangle Length");
            Console.WriteLine("2- Change Rectangle Length");
            Console.WriteLine("3- Get Rectangle Width");
            Console.WriteLine("4- Change Rectangle Width");
            Console.WriteLine("5 - Get Rectangle Height");
            Console.WriteLine("6- Change Rectangle Height");
            Console.WriteLine("7- Get Rectangle Volume");
            Console.WriteLine("8- Exit");


            Console.WriteLine("Please select an option to get started");
            string uInput = Console.ReadLine();
            if (uInput != "1" ||
                uInput != "2" ||
                uInput != "3" ||
                uInput != "4" ||
                uInput != "5" ||
                uInput != "6" ||
                uInput != "7" ||
                uInput != "8"
                )
            {
                Console.WriteLine("Please select a valid option");
            }

            #region Switch Statement
            switch (uInput)
            {
                case "1":
                    Console.WriteLine("The Length of your rectangle is: " + RectPrism.GetLength());
                    break;
                case "2":
                    Console.WriteLine("Enter the new length of your Rectangle: ");
                    int length = RectPrism.SetLength(int.Parse(Console.ReadLine()));
                    break;
                case "3":
                    Console.WriteLine("The Width of your rectangle is: " + RectPrism.GetWidth());
                    break;
                case "4":
                    Console.WriteLine("Enter the new width of your Rectangle: ");
                    int width = RectPrism.SetWidth(int.Parse(Console.ReadLine()));
                    break;
                case "5":
                    Console.WriteLine("The Height of your Rectangle is: " + RectPrism.GetHeight());
                    break;
                case "6":
                    Console.WriteLine("Enter the new height of your Rectangle: ");
                    int height = RectPrism.SetHeight(int.Parse(Console.ReadLine()));
                    break;
                case "7":
                    Console.WriteLine("The Volume of your Rectangle is: " + RectPrism.GetVolume());
                    break;
                case "8":
                    Console.WriteLine("Exit...");
                    break;
                default:
                    break;
            }
            #endregion

        }

    }
}
