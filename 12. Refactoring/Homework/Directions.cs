namespace MatrixOperations
{
    /// <summary>
    /// Static class containing directions fro movement
    /// </summary>
    public static class Directions
    {
        /// <summary>
        /// Contains directions for movement on a board. 
        /// First direction is the current cell. 
        /// The others start from bottom right and repeat clockwise
        /// </summary>
        public static readonly Direction[] BoardDirections = new Direction[]
        {
            new Direction(0, 0),
            new Direction(1, 1),
            new Direction(1, 0),
            new Direction(1, -1),
            new Direction(0, -1),
            new Direction(-1, -1),
            new Direction(-1, 0),
            new Direction(-1, 1),
            new Direction(0, 1)
        };
    }
}
