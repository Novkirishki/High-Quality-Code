namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Used to calculate distance between two points
    /// </summary>
    public static class DistanceCalculator
    {
        /// <summary>
        /// Calculates distance between points in two dimensions
        /// </summary>
        /// <param name="x1">First point x coordinate</param>
        /// <param name="y1">First point y coordinate</param>
        /// <param name="x2">Second point x coordinate</param>
        /// <param name="y2">Second point y coordinate</param>
        /// <returns>Returns distance between points</returns>
        public static double CalcDistanceBetweenPoints2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Calculates distance between points in three dimensions
        /// </summary>
        /// <param name="x1">First point x coordinate</param>
        /// <param name="y1">First point y coordinate</param>
        /// <param name="z1">First point z coordinate</param>
        /// <param name="x2">Second point x coordinate</param>
        /// <param name="y2">Second point y coordinate</param>
        /// <param name="z2">Second point z coordinate</param>
        /// <returns>Returns distance between points</returns>
        public static double CalcDistanceBetweenPoints3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }
    }
}
