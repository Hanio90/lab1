using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables

            double Width;
            double Length;
            double Area;
            double Height;

            String Choice = "Yes";

            //if the user chooses yes it will re run the code
            while (Choice == "Yes")
            {
                Console.WriteLine("Please enter the width");
                Width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length");
                Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of your rectangle");
                Height = double.Parse(Console.ReadLine());

                //Math 
                 Area = Length * Width;
                double perimeter = 2 * (Width + Length);
                double volume = Length * Width * Height; 

                //Writes the strings to console
                Console.WriteLine("The AREA of your rectangle is: {0}", Area);

                Console.WriteLine("The PERIMETER of your rectangle is: {0}", perimeter);

                Console.WriteLine("The VOLUME of your rectangle is {0}", volume);

                Console.WriteLine("Would you like to try again? Please Enter Yes or No");

                Choice = Console.ReadLine();


                //Gives the user a choice
                if (Choice != "Yes")
                    Choice = "No";

            }


        }


    }
}
