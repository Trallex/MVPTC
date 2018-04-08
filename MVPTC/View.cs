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
            pannel1.PannelDriveLoadEvent += VE_LoadDrives;
            pannel2.PannelDriveLoadEvent += VE_LoadDrives;
            pannel1.PannelLoadDirEvent += VE_LoadDirectories;
            pannel2.PannelLoadDirEvent += VE_LoadDirectories;
            pannel1.PannelItemSelectAction += VA_ItemSelect;
            pannel2.PannelItemSelectAction += VA_ItemSelect;
            pannel1.PannelDirUp += VA_DirUp;
            pannel2.PannelDirUp += VA_DirUp;
        }

        public string CurrentPath { get; set; }
        public string TargetPath { get; set; }
        public string SelectedItem { get; set; }

        public string VA_DirUp(object arg, EventArgs arg2)
        {
           return IViewDirUp(arg, arg2);
        }

        public string[] VE_LoadDrives(object arg, EventArgs arg2)
        {
            return IViewDriveLoadEvent(arg, arg2);
        }

        public string[] VE_LoadDirectories(object arg, EventArgs arg2)
        {
            CurrentPath = arg.ToString();
            return IViewLoadDirectories(arg, arg2);
        }

        public void VA_ItemSelect(object sender, EventArgs e)
        {
            Pannel pannel = sender as Pannel;
            if (pannel.Name == "pannel1")
            {
                pannel2.ClearSelection();
                CurrentPath = pannel1.CurrentPath;
                TargetPath = pannel2.CurrentPath;
                SelectedItem = pannel1.SelectedDir;

            }
            else if(pannel.Name == "pannel2")
            {
                pannel1.ClearSelection();
                CurrentPath = pannel2.CurrentPath;
                TargetPath = pannel1.CurrentPath;
                SelectedItem = pannel2.SelectedDir;
            }
        }

        #region iview implementations
        public event Func<object, EventArgs, string[]> IViewDriveLoadEvent;
        public event Func<object, EventArgs, string[]> IViewLoadDirectories;
        public event Func<object, EventArgs, string> IViewDirUp;

        #endregion
    }
}
