using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPTC
{
    public partial class Pannel : UserControl
    {
        public Pannel()
        {
            InitializeComponent();
        }
       
        private string[] drives;
        private string[] files;
        private string[] directories;


        public string[] Drives
        {
            get { return drives; }
            set { drives = value; }
        }
        public string CurrentPath
        {
            get { return textBoxPath.Text; }
            set
            {
                if (value.Contains("<d>"))
                {
                    int index = value.IndexOf("<");
                    textBoxPath.Text = value.Remove(index, 3);
                }
                else textBoxPath.Text = value;
            }
        }
        public string SelectedDir
        {
            get
            {   
                if (listBoxComponents.SelectedItem.ToString().Contains("<d>"))
                {
                    int index = listBoxComponents.SelectedItem.ToString().IndexOf("<");
                    return listBoxComponents.SelectedItem.ToString().Remove(index, 3);
                }

                else return listBoxComponents.SelectedItem.ToString();
            }
            set { }
        }
        public string[] Files
        {
            get { return files; }
            set { files = value; }
        }
        public string[] Directories
        {
            get { return directories; }
            set { directories = value; }
        }


        public event Func<object, EventArgs, string[]> PannelDriveLoadEvent;
        public void listDrives(object sender, EventArgs e)
        {
            if (PannelDriveLoadEvent != null)
            {
                Drives = PannelDriveLoadEvent(sender, e);
                comboBoxDrive.Items.Clear();
                comboBoxDrive.Items.AddRange(Drives);
            }
        }
        private void changeDrive(object sender, EventArgs e)
        {
            ComboBox drives = sender as ComboBox;
            textBoxPath.Text = drives.SelectedItem.ToString();
        }
        public event Func<object, EventArgs, string[]> PannelLoadDirEvent;
        public void PathChanged(object sender, EventArgs e)
        {
            if (PannelLoadDirEvent != null) 
            {
                Directories = PannelLoadDirEvent(this.CurrentPath, e);
                if (Directories != null)
                {
                    listBoxComponents.Items.Clear();
                    foreach(String temp in Directories)
                    {
                        listBoxComponents.Items.Add(temp);
                    }
                }
            }
        }

        public event Func<object, EventArgs, string> PannelDirUp;
        public void DirUp(object sender, EventArgs e)
        {
            if (PannelDirUp != null)
            {
                CurrentPath = PannelDirUp(sender, e);
            }
        }

        public event Action<object, EventArgs> PannelItemSelectAction;
        public void ItemSelect(object sender, EventArgs e)
        {
            ListBox listbox = sender as ListBox;
            if (listBoxComponents.SelectedItem != null)
            {
                PannelItemSelectAction(this, e);
            }
        }

        public void ClearSelection()
        {
            listBoxComponents.ClearSelected();
        }

        private void ExecutePath(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
            {
                CurrentPath = CurrentPath + listBox.SelectedItem.ToString();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (CurrentPath.Length > 3)
                CurrentPath = PannelDirUp(sender, e);
        }
    }
}
