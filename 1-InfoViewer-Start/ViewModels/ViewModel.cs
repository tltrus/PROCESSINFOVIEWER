using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InfoViewer.ViewModels
{
    public class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public delegate void MessageHandler(string message);
        public event MessageHandler Notify;
    }
}
