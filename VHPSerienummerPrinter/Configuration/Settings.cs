using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using NLog;
using System.Reflection;

namespace VHPSerienummerPrinter.Configuration
{
    [Serializable]
    public class Settings
    {
        private static Logger Log = LogManager.GetCurrentClassLogger();
        private static string SettingsFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");

        private static UserSettings settings;
       
        public static LabelSettings Label
        {
            get
            {
                Init();
                return settings.Label;
            }
        }
        public static BatchLabelSettings BatchLabel
        {
            get
            {
                Init();
                return settings.Titellabel;
            }
        }

        public static void Init()
        {
            if (settings != null)
            {
                return;
            }
            if (File.Exists(SettingsFile))
            {
                Log.Info("Loading file {0}", SettingsFile);
                using (FileStream stream = new FileStream(SettingsFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));                    
                    settings = (UserSettings)serializer.Deserialize(stream);
                }
                Log.Info("Settingsfile loaded");
            }
            else
            {
                Log.Info("Creating new settingsfile {0}", SettingsFile);
                settings = new UserSettings();
                //CreateNewSettings();
            }
        }

        //private static Settings CreateNewSettings()
        //{
        //    return new Settings
        //    {
        //        Label = new LabelSettings
        //        {
        //            ComponentType = "",
        //            NumberOfProjectLabels = 1,
        //            OverleveringAbsoluut = 1,
        //            Overleveringrelatief = 1,
        //            PrinterSettings = new PrinterSettings
        //            {
        //                SpecificPaper = "62mm x 29mm",
        //                SpecificPrinter = "Brother QL-500",
        //                UseSpecificPaper = true,
        //                UseSpecificPrinter = true
        //            }
        //        },
        //        Paspoort = new PaspoortSettings
        //        {
        //            PrinterSettings = new PrinterSettings
        //            {
        //                UseSpecificPrinter = true,
        //                SpecificPrinter = "aap",
        //                UseSpecificPaper = true,
        //                SpecificPaper = "noot"
        //            }
        //        }
        //    };
        //}

        public static void Save()
        {
            using (StreamWriter file = File.CreateText(SettingsFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserSettings));
                serializer.Serialize(file, settings);
            }
        }
    }
}
