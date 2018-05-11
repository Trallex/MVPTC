using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTC
{
    public interface IView
    {
        event Func<object, EventArgs, string[]> IViewDriveLoadEvent;
        event Func<object, EventArgs, string[]> IViewLoadDirectories;
        event Func<object, EventArgs, string> IViewDirUp;
        event Func<string, bool> ButtonClicked;

        void Error(string text);

        string SourcePath { get; set; }
        string TargetPath { get; set; }
        string SelectedItem { get; set; }
    }
}
