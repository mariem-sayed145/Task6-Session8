using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Session8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // First Project 

            Console.WriteLine("Enter P1:");

            Console.Write("X (TryParse): ");
            int x1;

            while (!int.TryParse(Console.ReadLine(), out x1))
            {
                Console.Write("Invalid! Enter X again: ");
            }

            Console.Write("Y (Parse): ");
            string yInput1 = Console.ReadLine();
            int y1 = int.Parse(yInput1);

            Console.Write("Z (Convert): ");
            string zInput1 = Console.ReadLine();
            int z1 = Convert.ToInt32(zInput1);

            Point3D P1 = new Point3D(x1, y1, z1);


            Console.WriteLine("\nEnter P2:");

            Console.Write("X (Parse): ");
            string xInput2 = Console.ReadLine();
            int x2 = int.Parse(xInput2);

            Console.Write("Y (Convert): ");
            string yInput2 = Console.ReadLine();
            int y2 = Convert.ToInt32(yInput2);

            Console.Write("Z (TryParse): ");
            int z2;

            while (!int.TryParse(Console.ReadLine(), out z2))
            {
                Console.Write("Invalid! Enter Z again: ");
            }

            Point3D P2 = new Point3D(x2, y2, z2);


            Console.WriteLine("\nP1 = " + P1);
            Console.WriteLine("P2 = " + P2);

            Console.WriteLine("--------------------------------------------------------------------------");


            // try == 
            Point3D Point1 = new Point3D(10, 20, 30);
            Point3D Point2 = new Point3D(10, 20, 30);

            if (Point1 == Point2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            // output --> Not Equal 
            //Does it work properly?
            //No , Because P1 and P2 are two different object references. The default == comparison does not compare the X, Y, and Z values of Point3D objects
            


            // Operator Overloading
            Console.WriteLine("-------------------------------------------------------------------------");

            Point3D Point01 = new Point3D(10, 20, 30);
            Point3D Point02 = new Point3D(10, 20, 30);

            if (Point01 == Point02)
            {
                Console.WriteLine("Point01 and Point02 are equal");
            }
            else
            {
                Console.WriteLine("Point01 and Point02 are not equal");
            }

            Console.WriteLine("-------------------------------------------------------------------------");

            // output --> Point01 and Point02 are equal  

            // Sorting based on x , y 
            Point3D[] points = {

            new Point3D(5, 20, 10),
            new Point3D(2, 30, 40),
            new Point3D(5, 10, 50),
            new Point3D(2, 10, 60) };

            Console.WriteLine("Before Sorting:");

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            Array.Sort(points);

            Console.WriteLine("\nAfter Sorting:");

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            // clone 
            Point3D P01 = new Point3D(10, 20, 30);

            Point3D P02 = (Point3D)P01.Clone();

            Console.WriteLine("P01: " + P01);
            Console.WriteLine("P02: " + P02);

            Console.WriteLine("-------------------------------------------------------------------------");



            // Socend Project

            Console.WriteLine("Math : \n ");

            Maths maths = new Maths();

            Console.WriteLine(Maths.Add(10, 5));
            Console.WriteLine(Maths.Subtract(10, 5));
            Console.WriteLine(Maths.Multiply(10, 5));
            Console.WriteLine(Maths.Divide(10, 5));

            Console.WriteLine("-------------------------------------------------------------------------");


            // Third PROJECT 

            Console.WriteLine("duration : \n ");

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

        }
    }
}
