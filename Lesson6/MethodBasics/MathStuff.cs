using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodBasics
{
    static class MathStuff
    {
        /// <summary>
        /// Calculates the area of a circle with the given radius
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <returns>Area of the circle</returns>
        public static double CalculateCircleArea(double radius)
        {
            // Local function to determine if radius is valid
            bool IsRadiusValid(double radius)
            {
                return (radius >= 0) ? true : false;
            }

            if (!IsRadiusValid(radius))
            {
                return 0;
            }

            double area = Math.PI * radius * radius;
            return area;
        }

        /// <summary>
        /// Calculates the area of a circle with the given radius
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <returns>Area of the circle</returns>
        public static float CalculateCircleArea(float radius)
        {
            float area = (float)Math.PI * radius * radius;
            return area;
        }

        /// <summary>
        /// Calculates the circumference of a circle with the given radius
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <returns>Circumference of the circle</returns>
        public static double CalculateCircleCircumference(double radius)
        {
            double cir = 2.0 * Math.PI * radius;
            return cir;
        }
    }
}
