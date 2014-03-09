using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VHPSierienummerPrinter
{
    public class FileFinder
    {
        public string Message{ get; set; }
        public bool Find(string relativePath)
        {
            if(string.IsNullOrEmpty(relativePath))
                return false;

            bool fileExists = true;
            string absolutePath = GetAbsolutePath(relativePath);
            if (!File.Exists(absolutePath))
            {
                //DetermineValidPart(relativePath);
                Message = string.Format("Bestand niet gevonden: {0}", absolutePath);
                fileExists = false;
            }
            return fileExists;
        }

        private string GetAbsolutePath(string relativePath)
        {
            string file = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string theDirectory = Path.GetDirectoryName(file);
            string fullPath = Path.Combine(theDirectory, relativePath);
            return fullPath;
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
