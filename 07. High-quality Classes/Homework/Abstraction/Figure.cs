namespace Abstraction
{
    using System;

    /// <summary>
    /// Abstract class for a figure
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Calculates the perimeter of a figure
        /// </summary>
        /// <returns>Returns the perimeter</returns>
        public abstract double CalcPerimeter();

        /// <summary>
        /// Calculates the surface of a figure
        /// </summary>
        /// <returns>Returns the surface</returns>
        public abstract double CalcSurface(); 
    }
}
