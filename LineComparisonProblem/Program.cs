using System;

namespace Line_Comparision_Problem_CS
{/// <summary>
/// Template for line comparison problem
/// </summary>
    class LineComparision
    {
        //UC3 for comparing lengths of two lines

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
        public static void comparingLines(string len1, string len2)
        {
            if (len1.CompareTo(len2) > 0)
            {
                Console.WriteLine("Line1 is greater than line2");
            }
            else if (len1.CompareTo(len2) < 0)
            {
                Console.WriteLine("Line1 is lesser than line2");
            }
            else
            {
                Console.WriteLine("Both lines are equal");
            }
        }
        static void Main(string[] args)
        {
            //Initializing two lines(line1,line2) by calling distance method
            double line1 = LineComparision.distance(3, 4, 4, 3);
            double line2 = LineComparision.distance(4, 5, 8, 3);

            LineComparision.comparingLines(line1.ToString(), line2.ToString());
            Console.ReadLine();
        }
    }
}