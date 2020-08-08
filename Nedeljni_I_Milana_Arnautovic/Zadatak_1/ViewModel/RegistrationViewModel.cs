using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zadatak_1.Command;
using Zadatak_1.View;

namespace Zadatak_1.ViewModel
{
    class RegistrationViewModel : ViewModelBase
    {
        RegistrationView view;

        public RegistrationViewModel(RegistrationView view)
        {
            this.view = view;
        }

        private ICommand managerReg;

        public ICommand ManagerReg
        {
            get
            {
                if (managerReg == null)
                {
                    managerReg = new RelayCommand(param => ManagerRegExecute(), param => CanManagerRegExecute());
                }
                return managerReg;
            }
        }

        public bool CanManagerRegExecute()
        {
            return true;
        }

        public void ManagerRegExecute()
        {
            ManagerRegView managerRegView = new ManagerRegView();
            managerRegView.ShowDialog();
        }

        private ICommand employeeReg;

        public ICommand EmployeeReg
        {
            get
            {
                if (employeeReg == null)
                {
                    employeeReg = new RelayCommand(param => EmployeeRegExecute(), param => CanEmployeeRegExecute());
                }
                return employeeReg;
            }
        }

        public bool CanEmployeeRegExecute()
        {
            return true;
        }

        public void EmployeeRegExecute()
        {
            EmployeeRegView employeeRegView = new EmployeeRegView();
            employeeRegView.ShowDialog();
        }


    }
}
