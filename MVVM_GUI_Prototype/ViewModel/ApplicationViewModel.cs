using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MVVM_GUI_Prototype.View;

namespace MVVM_GUI_Prototype.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        UserControl CurrentPage;
        UserControl _LoginView;

        public ApplicationViewModel()
        {
            _LoginView = new LoginView();
            CurrentPage = _LoginView;
        }


        
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion // INotifyPropertyChanged Members
    }
}
