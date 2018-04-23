using System.Windows;

namespace FolderBrowserDialogServiceSample {
    public partial class App : Application {
        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);
            DevExpress.Xpf.Core.ApplicationThemeHelper.SaveApplicationThemeName();
        }

        private void OnAppStartup_UpdateThemeName(object sender, StartupEventArgs e) {
            DevExpress.Xpf.Core.ApplicationThemeHelper.UpdateApplicationThemeName();
        }
    }
}
