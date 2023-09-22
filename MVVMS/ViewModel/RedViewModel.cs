using System;
using System.Windows.Input;

namespace MVVMS.ViewModel
{
    public class RedViewModel
    {
        public ICommand ChangePageCMD { get; private set; }

        public RedViewModel()
        {
            ChangePageCMD = new DelegateCommand(ChangePage);
        }

        private void ChangePage()
        {
            ((App)App.Current).ChangeUserControl(typeof(BlueViewModel));
        }
    }
}
