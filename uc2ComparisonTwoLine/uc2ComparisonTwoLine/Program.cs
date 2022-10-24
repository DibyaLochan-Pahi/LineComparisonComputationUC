using System;

namespace uc2ComparisonTwoLine
{
    class Program
    {
        //Constructor For Print Headings
        public Program()
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            Console.WriteLine("-----------------------------------------------");
        }

        // Method for Calculating Distance of Line


        public static double Distance(double c1, double c2, double d1, double d2)
        {
            var temp1 = Math.Pow((c2 - c1), 2);
            var temp2 = Math.Pow((d2 - d1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            return result;
        }

        // Main Method For Input Line coordinate Value and Comparision between them

        static void Main(string[] args)
        {
            Program hello = new Program();

            //input First Line Coordinates

            Console.WriteLine("Please enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            var finalResult1 = Distance(x1, y1, x2, y2);

            //input second Line Coordinates

            Console.WriteLine("Please enter a1 and b1 coordinates: ");
            var a1 = Convert.ToDouble(Console.ReadLine());
            var b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a2 and b2 coordinates: ");
            var a2 = Convert.ToDouble(Console.ReadLine());
            var b2 = Convert.ToDouble(Console.ReadLine());
            var finalResult2 = Distance(a1, b1, a2, b2);
            
            //Comparison Between Two Line

            if (finalResult1 == finalResult2)
            {
                Console.WriteLine("\nLine-1 and Line-2 are equals.");
            }
            else
            {
                Console.WriteLine("Line-1 and Line-2 are not equals.");
            }
            Console.WriteLine("Length of first Line = " + finalResult1);
            Console.WriteLine("Length of second Line = " + finalResult2);
        }
    }
}
