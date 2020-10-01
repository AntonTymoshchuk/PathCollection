using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCollection
{
    public class DirectoryScheme
    {
        private List<DirectoryScheme> childrenDirectorySchemes;
        private List<string> childrenFilePaths;
        private string path;
        private DateTime lastWriteTime;

        private void Update()
        {
            DirectoryInfo currentDirectoryInfo = new DirectoryInfo(path);

            DirectoryInfo[] childrenDirectoryInfos = currentDirectoryInfo.GetDirectories();
            FileInfo[] childrenFileInfos = currentDirectoryInfo.GetFiles();

            if (childrenDirectoryInfos.Length>childrenDirectorySchemes.Count)
            {
                for (int i=0;i<childrenDirectorySchemes.Count;i++)
                {

                }
            }
        }

        public void Check(DateTime checkTime)
        {
            if (!lastWriteTime.Equals(checkTime))
            {
                lastWriteTime = Directory.GetLastWriteTime(path);
                Update();
            }
        }
    }
}
