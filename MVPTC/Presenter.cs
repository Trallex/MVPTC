using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            view.ButtonClicked += Presenter_ButtonClicked;

        }
        private bool Presenter_ButtonClicked(string option)
        {
            try
            {
                switch (option)
                {
                    case "Copy":
                        return model.Copy(view.SourcePath + view.SelectedItem, view.TargetPath + view.SelectedItem);
                    case "Delete":
                        return model.Delete(view.SourcePath + view.SelectedItem);
                    case "Move":
                        return model.Move(view.SourcePath + view.SelectedItem, view.TargetPath + view.SelectedItem);
                    default:
                        return false;
                }
            }
            catch (IOException ioexc) { view.Error(ioexc.Message); }
            catch (System.UnauthorizedAccessException accesexc) { view.Error(accesexc.Message); }
            catch (System.ArgumentException argexc) { view.Error(argexc.Message); }
            return false;
        }

        private string[] Presenter_ViewEventLoadDirectories(object arg1, EventArgs arg2)
        {
            try
            {
                return model.LoadDirectories(arg1.ToString());
            }
            catch (System.ComponentModel.Win32Exception winexc) { view.Error(winexc.Message); }
            catch (System.InvalidOperationException invalidexc) { view.Error(invalidexc.Message); }
            catch (System.UnauthorizedAccessException accesexc) { view.Error(accesexc.Message); }
            return null;
        }

        private string[] Presenter_ViewEventLoadDrives(object arg1, EventArgs arg2)
        {
            return model.LoadDrives();
        }
       
        private string Presenter_ViewEventDirUp(object arg1, EventArgs arg2)
        {
            try
            {
                return model.DirUp(arg1.ToString());
            }
            catch (System.ArgumentException argexc) { view.Error(argexc.Message); }
            catch (System.UnauthorizedAccessException accesexc) { view.Error(accesexc.Message); }
            return null;
        }

    }
}
