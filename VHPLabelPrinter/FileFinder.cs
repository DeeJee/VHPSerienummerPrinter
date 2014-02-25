using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VHPSierienummerPrinter
{
    public class FileFinder
    {
        public bool Find(string path)
        {
            if(string.IsNullOrEmpty(path))
                return false;

            bool fileExists = true;
            if (!File.Exists(path))
            {
                DetermineValidPart(path);
                fileExists = false;
            }
            return fileExists;
        }

        private void DetermineValidPart(string path)
        {
            string file = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string theDirectory = Path.GetDirectoryName(file);
            string fullPath = Path.Combine(theDirectory, path);
            string[] directories = fullPath.Split(Path.DirectorySeparatorChar);            
        }
        /// <summary>
        /// The part of the path that exists
        /// </summary>
        public string ValidPart{ get; set; }
    }
}
