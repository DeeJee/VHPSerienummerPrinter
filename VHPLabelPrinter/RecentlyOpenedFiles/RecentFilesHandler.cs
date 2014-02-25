using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.IO.IsolatedStorage;
using System.IO;
using System.Xml.Serialization;
using System.Collections;
using VHPSerienummerPrinter.RecentlyOpenedFiles;

namespace VHPSerienummerPrinter.RecentlyOpenedFiles
{
    public class RecentFilesHandler
    {
        private const string RecentFilesStorage = "RecentFiles.xml";

        public static RecentFiles GetRecentlyOpenedFiles()
        {
            if(!File.Exists(RecentFilesStorage))
                return new RecentFiles();

             using (TextReader reader = new StreamReader(RecentFilesStorage))
            {
                XmlSerializer xs = new XmlSerializer(typeof(RecentFiles));
                return  xs.Deserialize(reader) as RecentFiles;
            }            
        }

        public static void StoreRecentlyOpenedFiles(RecentFiles files)
        {
            using (FileStream stream = new FileStream(RecentFilesStorage, FileMode.OpenOrCreate))
            {
                XmlSerializer ser = new XmlSerializer(typeof(RecentFiles));
                ser.Serialize(stream, files);
                stream.Close();                
            }            
        }

        public static void Add(string fileName)
        {
            RecentFiles files = GetRecentlyOpenedFiles();
            files.Add(fileName);
            StoreRecentlyOpenedFiles(files);
        }
    }
}
