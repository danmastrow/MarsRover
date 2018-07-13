namespace MarsRover
{
    using System.Collections.Generic;
    using System.IO;
    using System;

    /// <summary>Utility class to manage the IO File Operations.</summary>
    public static class FileManager
    {
        /// <summary>Reads a file into a list of strings.</summary>
        /// <param name="filePath">The full path of the file to read.</param>
        /// <returns>Returns the file's contents.</returns>
        /// <exception cref="ArgumentNullException">Thrown if the filepath parameter is null.</exception>
        /// <exception cref="FileNotFoundException">Thrown if the file is not found.</exception>
        public static IList<string> ReadFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                var message = "A valid file path must be provided.";
                throw new ArgumentNullException(filePath, message);
            }

            if (!File.Exists(filePath))
            {
                var message = "The file does not exist.";
                throw new FileNotFoundException(message, filePath);
            }

            return File.ReadAllLines(filePath);
        }

    }
}