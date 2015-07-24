namespace Abstraction
{
    using System;

    /// <summary>
    /// Class representing a rectangle
    /// </summary>
    public class Rectangle : Figure
    {
        private double width;
        private double height;      

        /// <summary>
        /// Initializes a new instance of the Rectangle class
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Gets or sets rectangle width. Value must be positive
        /// </summary>
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width has to be a positive number");
                }

                this.width = value;
            }
        }

        /// <summary>
        /// Gets or sets rectangle height. Value must be positive
        /// </summary>
        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height has to be a nonneagtive number");
                }

                this.height = value;
            }
        }

        /// <summary>
        /// Calculates the perimeter of the rectangle
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Calculates the surface of the rectangle
        /// </summary>
        /// <returns>Surface</returns>
        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
