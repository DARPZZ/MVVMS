using System;
using System.Windows.Input;

namespace MVVMS.ViewModel
{
    public class BlueViewModel
    {
        public ICommand ChangePageCMD { get; private set; }

        public BlueViewModel()
        {
            ChangePageCMD = new DelegateCommand(ChangePage);
        }

        private void ChangePage()
        {
            ((App)App.Current).ChangeUserControl(typeof(RedViewModel));
        }
    }
}
