using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.Model;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class LoginViewModel : ViewModelBase
    {
        LoginView view;
        public vwAdministrator Administrator { get; set; }
        public vwManager Manager { get; set; }
        public vwEmployee Employee { get; set; }

        #region Constructors

        public LoginViewModel(LoginView view)
        {
            this.view = view;

        }
        #endregion

        #region Property

        private string userName;
        public string UserName
        {

            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        #endregion

        #region Commands
        private ICommand login;
        /// <summary>
        /// Command login
        /// </summary>
        public ICommand Login
        {
            get
            {
                if (login == null)
                {
                    login = new RelayCommand(LoginExecute);
                }
                return login;
            }
            set { login = value; }
        }
        /// <summary>
        /// Method for checking username and password
        /// </summary>
        /// <param name="o"></param>
        private void LoginExecute(object o)
        {
            try
            {
                string password = (o as PasswordBox).Password;
                if (userName == "WPFMaster" && password == "WPFAccess")
                {

                    MasterView masterView = new MasterView();
                    masterView.ShowDialog();
                }

                
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private ICommand registration;

        public ICommand Registration
        {
            get
            {
                if (registration == null)
                {
                    registration = new RelayCommand(param => RegistrationExecute(), param => CanRegistrationExecute());
                }
                return registration;
            }
        }

        public bool CanRegistrationExecute()
        {
            return true;
        }

        public void RegistrationExecute()
        {
            RegistrationView registrationView = new RegistrationView();
            registrationView.ShowDialog();
        }


        #endregion
    }
}