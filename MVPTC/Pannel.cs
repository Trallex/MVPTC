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
        private string[] directories;


        public string[] Drives
        {
            get { return drives; }
            set
            {
                drives = value;
                comboBoxDrive.Items.Clear();
                if (drives != null)
                {
                    foreach (string d in drives)
                    {
                        comboBoxDrive.Items.Add(d);
                    }
                }
            }
        }

        public string[] Directories
        {
            get { return directories; }
            set
            {
                directories = value;
                if (directories != null)
                    listBoxComponents.Items.AddRange(directories);
            }
        }


        public string CurrentPath
        {
            get { return textBoxPath.Text; }
            set
            {
                if (value != null && value.Contains("<d>") )
                {
                    int index = value.IndexOf("<");
                    textBoxPath.Text = value.Remove(index, 3);
                }
                else textBoxPath.Text = value;
            }
        }
        public string Selected
        {
            get
            {   if (listBoxComponents.SelectedItem != null)
                {
                    if (listBoxComponents.SelectedItem.ToString().Contains("<d>"))
                    {
                        int index = listBoxComponents.SelectedItem.ToString().IndexOf("<");
                        return listBoxComponents.SelectedItem.ToString().Remove(index, 3);
                    }
                    else return listBoxComponents.SelectedItem.ToString();
                }
                else return null;
            }
            set { }
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
                listBoxComponents.Items.Clear();
                Directories = PannelLoadDirEvent(this.CurrentPath, e);
            }
        }

        public event Func<object, EventArgs, string[]> PanelEventLoadDrives;
        private void loadDrives(object sender, EventArgs e)
        {
            if (PanelEventLoadDrives != null)
            {
                Drives = PanelEventLoadDrives(sender, e);

            }
        }

        public event Action<object, EventArgs, bool> PannelItemSelectAction;
        public void ItemSelect(object sender, EventArgs e)
        {
            
            ListBox listbox = sender as ListBox;
            if (listbox != null)
            {
                if (listBoxComponents.SelectedItem != null)
                {
                    PannelItemSelectAction(this, e, false);
                }
                else
                {
                    PannelItemSelectAction(this, e, true);
                }
            }
            else
            {
                PannelItemSelectAction(this, e, true);
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
            ItemSelect(sender, e);
        }

        public event Func<object, EventArgs, string> PannelDirUp;
        private void buttonBack_Click(object sender, EventArgs e)
        {            
            CurrentPath = PannelDirUp(this.CurrentPath, e);
            ItemSelect(sender, e);
        }
        
        public void Re(object sender, EventArgs e)
        {
            PathChanged(sender, e);
        }

    }
}
