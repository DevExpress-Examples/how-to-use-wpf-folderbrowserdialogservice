using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;

namespace FolderBrowserDialogServiceSample.ViewModel {
    public class FolderBrowserDialogViewModel : ViewModelBase {
        public string Description { get { return GetValue<string>(); } set { SetValue(value); } }
        public bool ShowNewFolderButton { get { return GetValue<bool>(); } set { SetValue(value); } }
        public string ResultPath { get { return GetValue<string>(); } set { SetValue(value); } }
        public IFolderBrowserDialogService FolderBrowserDialogService { get { return GetService<IFolderBrowserDialogService>(); } }

        public FolderBrowserDialogViewModel() {
            ShowNewFolderButton = true;
        }
        [Command]
        public void ShowDialog() {
            if (FolderBrowserDialogService.ShowDialog())
                ResultPath = FolderBrowserDialogService.ResultPath;
        }
    }
}
