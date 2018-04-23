using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;

namespace FolderBrowserDialogServiceSample.ViewModels
{
    [POCOViewModel]
    public class FolderBrowserDialogViewModel {
        public virtual string Description { get; set; }
        public virtual bool ShowNewFolderButton { get; set; }
        public virtual string ResultPath { get; set; }
        protected virtual IFolderBrowserDialogService FolderBrowserDialogService { get { return this.GetService<IFolderBrowserDialogService>(); } }

        public FolderBrowserDialogViewModel() {
            ShowNewFolderButton = true;
        }
        public void ShowDialog() {
            if (FolderBrowserDialogService.ShowDialog())
                ResultPath = FolderBrowserDialogService.ResultPath;
        }
    }
}