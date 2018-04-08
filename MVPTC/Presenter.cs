using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTC
{
    
    public class Presenter
    {
        Model model;
        IView view;
        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;

            view.IViewDriveLoadEvent += Presenter_ViewEventLoadDrives;
            view.IViewLoadDirectories += Presenter_ViewEventLoadDirectories;
            view.IViewDirUp += Presenter_ViewEventDirUp;

        }
        private string[] Presenter_ViewEventLoadDrives(object arg1, EventArgs arg2)
        {
            return model.LoadDrives();
        }
        private string[] Presenter_ViewEventLoadDirectories(object arg1, EventArgs arg2)
        {
            return model.LoadDirectories(view.CurrentPath);

        }
        private string Presenter_ViewEventDirUp(object arg1, EventArgs arg2)
        {
            return model.DirUp(view.CurrentPath);
        }
    }
}
