namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Used to extract file name or extension
    /// </summary>
    public static class FileNameExtractor
    {
        /// <summary>
        /// Gets the extension of the given file
        /// </summary>
        /// <param name="fileName">Name of the file including the extension</param>
        /// <returns>Returns file extension</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Gets the extension of the given file
        /// </summary>
        /// <param name="fileName">Name of the file including the extension</param>
        /// <returns>Returns file name</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot);
            return fileNameWithoutExtension;
        }
    }
}
