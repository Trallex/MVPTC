using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
namespace MVPTC
{
    public class Model
    {
        public Model()
        { }

        internal string[] LoadDrives()
        {
            List<string> readyDrives = new List<string>();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {

                if (d.IsReady)
                {
                    readyDrives.Add(d.ToString());
                }

            }
            return readyDrives.ToArray();
        }

        internal string[] LoadDirectories(string path)
        {
            if (Directory.Exists(path))
            {
                string[] dir = Directory.GetDirectories(path);
                string[] fil = Directory.GetFiles(path);
                List<string> dirs_files = new List<string>();
                foreach (String temp in dir)
                    dirs_files.Add("<d>" + temp.Remove(0, Path.GetDirectoryName(temp).Length));
                foreach (String temp in fil)
                    dirs_files.Add(temp.Remove(0, Path.GetDirectoryName(temp).Length));
                return dirs_files.ToArray();
        }
            else
            {
                Process.Start(path);
                return null;
            }
        }

        internal string DirUp(string path)
        {
                return Directory.GetParent(path).ToString();
        }
    }
}
