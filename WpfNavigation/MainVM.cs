using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfNavigation
{
    public class MainVM : ViewModelBase
    {
        RelayCommand _showPage1Cmd;

        RelayCommand _showPage2Cmd;

        public RelayCommand ShowPage1
        {
            get
            {
                if (_showPage1Cmd == null)
                    _showPage1Cmd = new RelayCommand(() =>
                    {
                        
                    });

                return _showPage1Cmd;
            }
        }

        public RelayCommand ShowPage2
        {
            get
            {
                if (_showPage2Cmd == null)
                    _showPage2Cmd = new RelayCommand(() =>
                    {

                    });

                return _showPage2Cmd;
            }
        }
    }
}
