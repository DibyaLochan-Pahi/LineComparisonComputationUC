using System;

namespace uc1lengthOfLine
{
    class Program
    {
        //Print Welcome Heading
        public Program()
        {
            Console.WriteLine("Welcom To Line Comparison Computation Program ");
            Console.WriteLine("----------------------------------------------");
        }
        //Calculate Length of Line
        public static double Distance(double x1, double x2, double y1, double y2)
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }
        //Input Value and Print The Result
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Please enter x1 coordinate: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y1 coordinate:  ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter x2 coordinate: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter y2 coordinate: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double finalResult = Distance(x1, y1, x2, y2);
            Console.WriteLine("Distance between two points :  " + finalResult);

        }
    }
}
