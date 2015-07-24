namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Class representing a figure
    /// </summary>
    public static class Figure
    {
        /// <summary>
        /// Gets or sets figure Width
        /// </summary>
        public static double Width { get; set; }

        /// <summary>
        /// Gets or sets figure Height
        /// </summary>
        public static double Height { get; set; }

        /// <summary>
        /// Gets or sets figure Depth
        /// </summary>
        public static double Depth { get; set; }                

        /// <summary>
        /// Calculates the volume of the figure
        /// </summary>
        /// <returns>Returns the volume</returns>
        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        /// <summary>
        /// Calculates the main diagonal of the figure
        /// </summary>
        /// <returns>Returns diagonal length</returns>
        public static double CalcMainDiagonal()
        {
            double distance = DistanceCalculator.CalcDistanceBetweenPoints3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the diagonal of the front side of the figure
        /// </summary>
        /// <returns>Returns diagonal length</returns>
        public static double CalcFrontDiagonal()
        {
            double distance = DistanceCalculator.CalcDistanceBetweenPoints2D(0, 0, Width, Height);
            return distance;
        }

        /// <summary>
        /// Calculates the diagonal of the base of the figure
        /// </summary>
        /// <returns>Returns diagonal length</returns>
        public static double CalcBaseDiagonal()
        {
            double distance = DistanceCalculator.CalcDistanceBetweenPoints2D(0, 0, Width, Depth);
            return distance;
        }

        /// <summary>
        /// Calculates the diagonal of the left/right side of the figure
        /// </summary>
        /// <returns>Returns diagonal length</returns>
        public static double CalcSideDiagonal()
        {
            double distance = DistanceCalculator.CalcDistanceBetweenPoints2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
