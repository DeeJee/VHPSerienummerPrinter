using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace VHPSerienummerPrinter.RecentlyOpenedFiles
{
    [DebuggerDisplay("{FileName}")]
    public class RecentFile
    {

        public RecentFile()
        {
        }

        public RecentFile(string fileName)
        {
            _filename = fileName;
        }

        private string _filename;
        public string FileName
        {
            get { return _filename; }
            set { _filename = value; }
        }

        public override bool Equals(object obj)
        {
            RecentFile file = obj as RecentFile;
            if (file == null)
            {
                return false;
            }

            if (file.FileName.Equals(this.FileName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return FileName.GetHashCode();
        }
    }
}
