using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPTC
{
    public partial class View : Form, IView
    {
        public View()
        {
            InitializeComponent();
            pannel1.PanelEventLoadDrives += VE_LoadDrives;
            pannel2.PanelEventLoadDrives += VE_LoadDrives;
            pannel1.PannelLoadDirEvent += VE_LoadDirectories;
            pannel2.PannelLoadDirEvent += VE_LoadDirectories;
            pannel1.PannelItemSelectAction += VA_ItemSelect;
            pannel2.PannelItemSelectAction += VA_ItemSelect;
            pannel1.PannelDirUp += VA_DirUp;
            pannel2.PannelDirUp += VA_DirUp;
        }

        public string SourcePath { get; set; }
        public string TargetPath { get; set; }
        public string SelectedItem { get; set; }
        public bool Panel1Active { get; set; }
        public bool Panel2Active { get; set; }

        public event Func<object, EventArgs, string[]> IViewDriveLoadEvent;
        public string[] VE_LoadDrives(object arg, EventArgs arg2)
        {
            return IViewDriveLoadEvent(arg, arg2);
        }

        public event Func<object, EventArgs, string[]> IViewLoadDirectories;
        public string[] VE_LoadDirectories(object arg, EventArgs arg2)
        {
            return IViewLoadDirectories(arg, arg2);
        }

        public event Func<object, EventArgs, string> IViewDirUp;
        public string VA_DirUp(object arg, EventArgs arg2)
        {
            return IViewDirUp(arg, arg2);
        }


        public void VA_ItemSelect(object sender, EventArgs e, bool path)
        {
            Pannel pannel = sender as Pannel;

            if (path) SelectedItem = null;
            else
            {
                if (pannel.Name == "pannel1")
                {
                    pannel2.ClearSelection();
                    Panel1Active = true;
                    Panel2Active = false;

                }
                else if (pannel.Name == "pannel2")
                {
                    pannel1.ClearSelection();
                    Panel2Active = true;
                    Panel1Active = false;
                }
            }
        }
   
        public event Func<string, bool> ButtonClicked;
        public void ClickAction(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if(Panel1Active)
            {
                SourcePath = pannel1.CurrentPath;
                TargetPath = pannel2.CurrentPath;
                SelectedItem = pannel1.SelectedDir;
            }
            else if (Panel2Active)
            {
                SourcePath = pannel2.CurrentPath;
                TargetPath = pannel1.CurrentPath;
                SelectedItem = pannel2.SelectedDir;
            }
            if(SelectedItem!=null)
            {
                if(b.Text == "Delete")
                {
                    if (ButtonClicked(b.Text))
                    {
                        if (Panel1Active)
                            pannel1.Re(sender, e);
                        else if (Panel2Active)
                            pannel2.Re(sender, e);
                    }
                }
                else if(TargetPath !="")
                {
                    if(ButtonClicked(b.Text))
                    {
                        pannel1.Re(sender, e);
                        pannel2.Re(sender, e);
                    }
                }
            }            
        }
        public void Error(string text)
        {
            MessageBox.Show(text);
        }
    }
}
