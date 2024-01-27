using ABB.Robotics.Controllers;
using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;


namespace InfoViewer.ViewModels
{
    public class RestartViewModel : ViewModel
    {
        private Controller SelectedController;

        #region RelayCommand

        // ***********************************
        //            RelayCommand
        // ***********************************

        /*
            BStart  Restart from previously stored system.
            Cold    Delete current system and start boot server.
            IStart 	Restart with current system and default settings..
            PStart 	Restart and delete programs and modules.
            SStart  Shut down
            Warm    Restart with current system and current settings.
            XStart  Restart and select another system.
         */

        private RelayCommand btnWarmStartClick;
        public RelayCommand BtnWarmStartClick
        {
            get
            {
                return btnWarmStartClick ??
                  (btnWarmStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.Warm);
                  }));
            }
        }

        private RelayCommand btnColdStartClick;
        public RelayCommand BtnColdStartClick
        {
            get
            {
                return btnColdStartClick ??
                  (btnColdStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.Cold);
                  }));
            }
        }

        private RelayCommand btnBStartClick;
        public RelayCommand BtnBStartClick
        {
            get
            {
                return btnBStartClick ??
                  (btnBStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.BStart);
                  }));
            }
        }

        private RelayCommand btnIStartClick;
        public RelayCommand BtnIStartClick
        {
            get
            {
                return btnIStartClick ??
                  (btnIStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.IStart);
                  }));
            }
        }

        private RelayCommand btnPStartClick;
        public RelayCommand BtnPStartClick
        {
            get
            {
                return btnPStartClick ??
                  (btnPStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.PStart);
                  }));
            }
        }

        private RelayCommand btnXStartClick;
        public RelayCommand BtnXStartClick
        {
            get
            {
                return btnXStartClick ??
                  (btnXStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.XStart);
                  }));
            }
        }

        private RelayCommand btnSStartClick;
        public RelayCommand BtnSStartClick
        {
            get
            {
                return btnSStartClick ??
                  (btnSStartClick = new RelayCommand(obj =>
                  {
                      Restart(ControllerStartMode.SStart);
                  }));
            }
        }

        #endregion

        private void Restart(ControllerStartMode mode)
        {
        }


        public void SetController(Controller SelectedController) => this.SelectedController = SelectedController;

    }
}
