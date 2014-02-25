using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.RecentlyOpenedFiles
{
    public class RecentFiles : IEnumerable<RecentFile>
    {
        private Queue<RecentFile> list = new Queue<RecentFile>();

        public void Add(object o)
        {
            RecentFile file = (RecentFile)o;
            if (!list.Contains(file))
            {
                if (list.Count == 4)
                { //eerst de laatste wissen
                    list.Dequeue();
                }
                list.Enqueue(file);
            }
        }

        public void Add(string filename)
        {
            RecentFile file = new RecentFile(filename);
            if (!list.Contains(file))
            {
                if (list.Count == 4)
                { //eerst de laatste wissen
                    list.Dequeue();
                }
                list.Enqueue(file);
            }
        }

        public List<string> GetList()
        {
            List<string> newlist = new List<string>();
            foreach (RecentFile file in list)
            {
                newlist.Add(file.FileName);
            }
            return newlist;
        }

        public RecentFile[] Files
        {
            get
            {
                RecentFile[] newlist = new RecentFile[list.Count];
                int index = 0;
                foreach (RecentFile file in list)
                {
                    newlist[index] = file;
                    index++;
                }
                return newlist;
            }
            set
            {
                foreach (RecentFile file in value)
                {
                    list.Enqueue(file);
                }
            }
        }


        #region IEnumerable<RecentFile> Members

        public IEnumerator<RecentFile> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return (IEnumerator<RecentFile>)list;
        }

        #endregion
    }
}
