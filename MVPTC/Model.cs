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
            try
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
            } catch (System.UnauthorizedAccessException) { return null; }
        }

        internal string DirUp(string path)
        {
            if(Directory.GetParent(path).ToString()!=null)
                return Directory.GetParent(path).ToString();
            return path;
        }

        internal void Move(string source, string destination)
        {
            Console.WriteLine("Move" + source + "to " + destination);
        }

        internal void Copy(string source, string destination)
        {
            Console.WriteLine("Copy " + source + " to " + destination);
            if (Directory.Exists(source)) 
            {
                CopyDir(source, destination, true);
            }
            else
            {
                try   
                {
                    File.Copy(source, destination);                    
                }
                catch (IOException) { } 
                catch (System.UnauthorizedAccessException) { } 
                catch (System.ArgumentException) { }
            }
        }



        internal void Delete(string source)
        {
            Console.WriteLine("Delete" + source );
            try
            {
                if(Directory.Exists(source))
                {
                    Directory.Delete(source, true);
                }
                else
                {
                    File.Delete(source);
                }
            }
            catch (IOException) { } 
            catch (System.UnauthorizedAccessException) { }
            catch (System.ArgumentException) { }
        }

        internal void Decide(object but, string source, string destination)
        {
            Button button = but as Button;
            switch(button.Text)
            {
                case "Copy":
                    Copy(source, destination);
                    break;
                case "Move":
                    Move(source, destination);
                    break;
                case "Delete":
                    Delete(source);
                    break;

            }
        }


        private static void CopyDir(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name); //'System.IO.IOException -> when the filename exist!!
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    CopyDir(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
