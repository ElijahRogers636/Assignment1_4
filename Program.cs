namespace Assignment1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a "class" named “Point” and 2 data members: X and Y coordinate.
            //    Declare 2 points: P1 and P2. Determine if P2 is to the right or left of P1 or on same axis , by comparing the x xoordinates.
            //    ( if p1.x is more than p2.x , it is to the right )

            Point P1 = new Point(10, 15);
            Point P2 = new Point(20, 15);

            CompareXaxisPosition(P1.x, P2.x);

            P1.x = 20;
            P2.x = 10;

            CompareXaxisPosition(P1.x, P2.x);

            P1.x = 10;
            P2.x = 10;

            CompareXaxisPosition(P1.x, P2.x);

        }

        // Method compares the position of two points on the x-axis 
        static void CompareXaxisPosition(double x1, double x2)
        {
            if (x1 > x2)
            {
                Console.WriteLine("\nSecond point is to the left of the first point on the x-axis");
            }
            else if (x1 == x2)
            {
                Console.WriteLine("\nBoth points are at the same position on the x-axis");
            }
            else
            {
                Console.WriteLine("\nSecond point is to the right of the first point on the x-axis");
            }
        }
    }
}
