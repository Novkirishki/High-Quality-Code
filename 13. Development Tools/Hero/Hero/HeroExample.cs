namespace Hero
{
    /// <summary>
    /// Class for example of the Hero class
    /// </summary>
    public class HeroExample
    {
        /// <summary>
        /// Main method for testing Hero class
        /// </summary>
        /// <param name="args">Arguments array</param>
        public static void Main(string[] args)
        {
            Hero pesho = new Hero(50, 14, 180);
            Hero ivan = new Hero(33, 28, 230);

            pesho.Fight(ivan);
        }
    }
}
