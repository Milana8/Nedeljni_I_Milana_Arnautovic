using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak_1.Model;

namespace Zadatak_1
{
   public class Service
    {
        public List<tblUser> GetAllUsers()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<tblUser> list = new List<tblUser>();
                    list = (from x in context.tblUsers select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblEmployee> GetAllEmployees()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<tblEmployee> list = new List<tblEmployee>();
                    list = (from x in context.tblEmployees select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<vwEmployee> GetAllEmployeesView()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<vwEmployee> list = new List<vwEmployee>();
                    list = (from x in context.vwEmployees select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblManager> GetAllManagers()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<tblManager> list = new List<tblManager>();
                    list = (from x in context.tblManagers select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<vwManager> GetAllManagersView()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<vwManager> list = new List<vwManager>();
                    list = (from x in context.vwManagers select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<tblAdministrator> GetAllAdministrators()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<tblAdministrator> list = new List<tblAdministrator>();
                    list = (from x in context.tblAdministrators select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public List<vwAdministrator> GetAllAdministratorView()
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    List<vwAdministrator> list = new List<vwAdministrator>();
                    list = (from x in context.vwAdministrators select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return null;
            }
        }

        public bool AddAdministrator(vwAdministrator administrator)
        {
            try
            {
                using (Nedeljni_IEntities context = new Nedeljni_IEntities())
                {
                    tblUser user = new tblUser
                    {
                        Gender = administrator.Gender,
                        JMBG = administrator.JMBG,
                        Residence = administrator.Residence,
                        MarriageStatus = administrator.MarriageStatus,
                        FirstName = administrator.FirstName,
                        Pasword = administrator.Pasword,
                        Surname = administrator.Surname,
                        Username = administrator.Username
                    };
                    context.tblUsers.Add(user);
                    context.SaveChanges();
                    administrator.UserID = user.UserID;
                    tblAdministrator newAdministrator = new tblAdministrator
                    {
                        UserID = user.UserID,
                        ExpirationDate = administrator.ExpirationDate,
                        AdministratorType = administrator.AdministratorType
                    };
                    context.tblAdministrators.Add(newAdministrator);
                    context.SaveChanges();
                    administrator.AdministratorID = newAdministrator.AdministratorID;
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception" + ex.Message.ToString());
                return false;
            }
        }
    }
}
