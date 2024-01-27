using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.IOSystemDomain;
using ABB.Robotics.Controllers.RapidDomain;
using ABB.Robotics.Controllers;
using InfoViewer.View;
using InfoViewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using InfoViewer.Base;

namespace InfoViewer.View
{
    public partial class MainWindow : Window
    {
        public ApplicationViewModel AppViewModel;
        public RestartViewModel RestartViewModel;


        public const string ERR_UNEXPECT_TXT = "Непредвиденная ошибка: ";


        public MainWindow()
        {
            InitializeComponent();

            AppViewModel            = new ApplicationViewModel(this);
            RestartViewModel        = new RestartViewModel();

            DataContext = AppViewModel;
        }

        // FindControllers
        private void Cbox_Controllers_DropDownOpened(object sender, EventArgs e)
        {

        }

        #region ГЛАВНОЕ МЕНЮ

        // Restarting
        private void RestartWindowShow_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RestartWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) { }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //AppViewModel.GetControllers();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void MessageNotify(string message) => MessageBox.Show(message);


        #region Menu Click

        // EXIT
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        // ABOUT
        private void AboutWindowShow_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AboutWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) { }

        #endregion


    }

}
