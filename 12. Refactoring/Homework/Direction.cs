namespace MatrixOperations
{
    /// <summary>
    /// Class representing a direction with x and y coordinates. 
    /// </summary>
    public class Direction
    {
        private int x;
        private int y;

        /// <summary>
        /// Initializes a new instance of the Direction class
        /// </summary>
        /// <param name="x">X coordinate. If positive direction is down. If negative - up</param>
        /// <param name="y">Y coordinate. If positive direction is right. If negative - left</param>
        public Direction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets value representing movement on the X axis
        /// </summary>
        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        /// <summary>
        /// Gets or sets value representing movement on the Y axis
        /// </summary>
        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }
    }
}
