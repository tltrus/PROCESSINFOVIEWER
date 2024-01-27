using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InfoViewer.Base
{
    public class DialogServices : IDialogServices
    {
        public void Error(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        public void Message(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }

        public bool? Question(string message, string caption)
        {
            var res = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
            {
                return true;
            }
            else if (res == MessageBoxResult.No)
            {
                return false;
            }
            else
            {
                return null;
            }
        }
    }
}
