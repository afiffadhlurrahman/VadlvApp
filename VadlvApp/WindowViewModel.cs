using System.Windows;

namespace VadlvApp
{
    public class WindowViewModel : BaseViewModel
    {
        private MainWindow mainWindow;

        public WindowViewModel(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }
    }
}