using System;

namespace Exercise9
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        }

        public static void SwapPoints(Point point1, Point point2)
        {
            Point test = new Point(point1.x, point1.y);

            point1.x = point2.x;
            point1.y = point2.y;
            point2.x = test.x;
            point2.y = test.y;
        }
    }
}
