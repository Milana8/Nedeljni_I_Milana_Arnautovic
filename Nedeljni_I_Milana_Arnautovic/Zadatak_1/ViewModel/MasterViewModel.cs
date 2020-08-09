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
    class MasterViewModel : ViewModelBase
    {

        MasterView view;
        Service service = new Service();
        Validation validation = new Validation();

        public MasterViewModel(MasterView view)
        {
            this.view = view;

        }




        #region Properties
        private vwAdministrator administrator;
        public vwAdministrator Administrator
        {
            get
            {
                return administrator;
            }
            set
            {
                administrator = value;
                OnPropertyChanged("Administrator");
            }
        }
        #endregion

        #region Commands
        private ICommand save;
        /// <summary>
        /// Save command
        /// </summary>
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());
                }
                return save;
            }
        }
        private void SaveExecute()
        {
            if (String.IsNullOrEmpty(administrator.FirstName) ||
                String.IsNullOrEmpty(administrator.Surname) ||
                String.IsNullOrEmpty(administrator.JMBG) ||
                String.IsNullOrEmpty(administrator.Username) ||
                String.IsNullOrEmpty(administrator.Pasword) ||
                 String.IsNullOrEmpty(administrator.Gender) ||
                  String.IsNullOrEmpty(administrator.Residence) ||
                   String.IsNullOrEmpty(administrator.MarriageStatus) ||
                   String.IsNullOrEmpty(administrator.AdministratorType)
                     )
            {
                MessageBox.Show("Please fill all fields.");
            }
            else

                try
                {
                    //if (!Validation.IsValid(Administrator.JMBG))
                    //{
                    //    MessageBox.Show("JMBG is not valid");
                    //    return;
                    //}
                    //else if (!Validation.PasswordValidation(Administrator.Pasword))
                    //{
                    //    MessageBox.Show("Password Hint must contain at least 5 caracters. Try again");
                    //    return;
                    //}
                    Administrator.ExpirationDate = DateTime.Now.AddDays(7);

                    MessageBoxResult result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (result == MessageBoxResult.Yes)
                    {
                        bool isUpdateAdministrator = service.AddAdministrator(Administrator);
                        if (isUpdateAdministrator == true)
                        {
                            MessageBox.Show("Administratoris registered.", "Notification", MessageBoxButton.OK);
                            view.Close();
                        }
                        else
                        {
                            MessageBox.Show("Administrator is not registered.", "Notification", MessageBoxButton.OK);
                            view.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
        }




        private bool CanSaveExecute()
        {
            return true;
        }


        // Cancel Button
        private ICommand cancel;
        public ICommand Cancel
        {
            get
            {
                if (cancel == null)
                {
                    cancel = new RelayCommand(param => CancelExecute(), param => CanCancelExecute());
                }
                return cancel;
            }
        }
        private void CancelExecute()
        {
            try
            {
                LoginView login = new LoginView();
                view.Close();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanCancelExecute()
        {
            return true;
        }
        #endregion
    }
}