using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_Session8
{
    class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // Default constructor
        public Point3D() : this(0, 0, 0)
        {
        }

        // Constructor with X and Y
        public Point3D(int x, int y) : this(x, y, 0)
        {
        }

        // Constructor with X, Y and Z
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        // Overload ==
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.X == p2.X &&
                   p1.Y == p2.Y &&
                   p1.Z == p2.Z;
        }

        // Overload !=
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }

        // IComparable
        public int CompareTo(object obj)
        {
            Point3D other = (Point3D)obj;

            int result = X.CompareTo(other.X);

            if (result == 0)
            {
                result = Y.CompareTo(other.Y);
            }

            return result;
        }

        // ICloneable
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}

