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
                    if (File.Exists(path))
                        Process.Start(path);
                    return null;
                }          
        }

        internal string DirUp(string path)
        {
            if (Path.GetDirectoryName(path) == null)
                return "";
            else
                return Directory.GetParent(path).ToString();        
        }



        internal bool Move(string source, string destination)
        {
            if (Directory.Exists(source))
            {
                if (Directory.GetDirectoryRoot(source) == Directory.GetDirectoryRoot(destination))
                    Directory.Move(source, destination);
                else
                {
                    DirCopy(source, destination, true);
                    Directory.Delete(source, true);
                }

            }
            else
                File.Move(source, destination);
           return true;
        }

        internal bool Delete(string source)
        {
                if (Directory.Exists(source))
                {
                    Directory.Delete(source, true);
                }
                else
                {
                    File.Delete(source);
                }
            return true;
        }

        internal bool Copy(string source, string destination)
        {
            if (Directory.Exists(source))
                DirCopy(source, destination, true);
            else
                File.Copy(source, destination);
            return true;
        }

        private static void DirCopy(string source, string destination, bool subDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(source);
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);
            if(subDir)
            {
                foreach(DirectoryInfo subD in dirs)
                {
                    string temppath = Path.Combine(destination, subD.Name);
                    DirCopy(subD.FullName, temppath, subDir);
                }
            }
            FileInfo[] files = directoryInfo.GetFiles();
            foreach(FileInfo file in files)
            {
                string temp = Path.Combine(destination, file.Name);
                file.CopyTo(temp, false);
            }

        }



 


        
    }
}
