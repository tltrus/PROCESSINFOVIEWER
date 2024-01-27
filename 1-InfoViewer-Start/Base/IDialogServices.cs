using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoViewer.Base
{
    public interface IDialogServices
    {
        void Message(string message, string caption);

        void Error(string message, string caption);

        bool? Question(string message, string caption);
    }
}
