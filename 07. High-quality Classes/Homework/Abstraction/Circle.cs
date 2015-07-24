namespace Abstraction
{
    using System;

    /// <summary>
    /// Class representing a circle
    /// </summary>
    public class Circle : Figure
    {
        private double radius;

        /// <summary>
        /// Initializes a new instance of the Circle class
        /// </summary>
        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Gets or sets radius of the circle. Value must be positive
        /// </summary>
        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius has to be a positive number");
                }

                this.radius = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the circle
        /// </summary>
        /// <returns>Returns the perimeter</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the circle
        /// </summary>
        /// <returns>Returns the surface</returns>
        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
