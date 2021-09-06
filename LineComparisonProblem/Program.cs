using System;

namespace Line_Comparision_Problem_CS
{/// <summary>
/// Template for line comparison problem
/// </summary>
    class LineComparision
    {
        //UC1 for Calculation of length using cartesian system

        //Creating distance method to calculate length of a line using two points 
        //two points are (x1,y1) & (x2,y2)
        static double distance(int x1, int y1, int x2, int y2)
        {
            //To evaluate math expression Math method() used 
            double lineLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Round method() used for rounding decimal value up to 2 digit
            double length = Math.Round(lineLength, 2);
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("line length:" + LineComparision.distance(3, 4, 4, 3));
            Console.ReadLine();
        }
    }
}