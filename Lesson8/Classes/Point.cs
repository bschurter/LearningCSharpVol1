using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    readonly struct Point
    {
        #region PointLocation Enum
        public enum PointLocation
        {
            Unknown = -1, Origin, XAxis, YAxis, QuadrantI, QuadrantII, QuadrantIII, QuadrantIV
        }
        #endregion PointLocation Enum

        #region Fields and Properties
        // These are immutable - cannot be changed after the constructor call!
        public readonly double X = 0;
        public readonly double Y = 0;
        #endregion Fields and Properties

        #region Constructors
        /// <summary>
        /// Create a new Point object using default values
        /// </summary>
        /// <remarks>Default constructor</remarks>
        public Point() { }

        /// <summary>
        /// Create a new Point object given all field values
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <remarks>Fully-parameterized constructor</remarks>
        public Point(double x, double y)
        {
            X = x;
            this.Y = y;  // this is superfluous in this case
        }

        /// <summary>
        /// Create a new point using the values from another
        /// </summary>
        /// <param name="other">The point to copy</param>
        /// <remarks>Copy constructor</remarks>
        public Point(Point other)
        {
            X = other.X;
            Y = other.Y;
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// String representation of the point
        /// </summary>
        /// <returns>String representation of the point</returns>
        public override string ToString()
        {
            return $"({X}, {Y}): {GetLocation()}";
        }

        public PointLocation GetLocation()
        {
            return this switch
            {
                { X: 0, Y: 0 } => PointLocation.Origin,
                { Y: 0 } => PointLocation.XAxis,
                { X: 0 } => PointLocation.YAxis,
                { X: > 0, Y: > 0 } => PointLocation.QuadrantI,
                { X: < 0, Y: > 0 } => PointLocation.QuadrantII,
                { X: < 0, Y: < 0 } => PointLocation.QuadrantIII,
                { X: > 0, Y: < 0 } => PointLocation.QuadrantIV,
                _ => PointLocation.Unknown
            };
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns>Distance between two points</returns>
        /// <remarks>For internal use only</remarks>
        private static double GetDistanceInternal(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        /// <summary>
        /// Calculates the distance between two points
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        /// <returns>Distance between two points</returns>
        /// <remarks>Makes use of internal GetDistanceInternal method</remarks>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistanceInternal(p1, p2);
        }

        /// <summary>
        /// Calculates the distance between this point and another point
        /// </summary>
        /// <param name="other">The other point</param>
        /// <returns>Distance between this point and another point</returns>
        /// <remarks>Makes use of internal GetDistanceInternal method</remarks>
        public double GetDistance(Point other)
        {
            //return Math.Sqrt(Math.Pow(this.X - other.X, 2) + Math.Pow(this.Y - other.Y, 2));
            return GetDistanceInternal(this, other);
        }
        #endregion Methods
    }

}
