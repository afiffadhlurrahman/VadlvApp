using System.Windows;

namespace VadlvApp
{
    public class WindowViewModel : BaseViewModel
    {
        #region Private Member
        
        private Window mWindow;
        
        #endregion

        #region Constructor
        
        public WindowViewModel(Window window)
        {
            mWindow = window;
        }
        
        #endregion
    }
}
