/* AdminService - contains business logic for admin related operations*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Datalayer;
using Railway.Entities;

namespace Railway.BusinessLayer
{
    public class AdminService
    {
        AdminRepository adminRepository;
        public AdminService()
        {
            //instantiating adminRepository object
            adminRepository = new AdminRepository();
        }

        //Function to add new admins
        public void NewAdmin(Admins admin)
        {
            try
            {
                //calling NewAdmin() in AdminRepository.cs
                adminRepository.NewAdmin(admin);
            }
            catch (Exception)
            {

                throw;
            }      
        }

        //Funvtion to delete admins
        public void DeleteAdmin(int adminid)
        {
            try
            {
                //calling DeleteAdmin() in AdminRepository.cs
                adminRepository.DeleteAdmin(adminid);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to update admin details
        public void UpdateAdmin(Admins admin)
        {
            try
            {
                //calling UpdateAdmin() in AdminRepository.cs 
                adminRepository.UpdateAdmin(admin);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to retrive all admin details
        public List<Admins> GetAllAdmins()
        {
            try
            {
                //calling GetAllAdmins() in AdminRepository.cs
                return adminRepository.GetAllAdmins();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to validate admin
        public Admins ValidateAdmin(int id, string password)
        {
            try
            {
                return adminRepository.ValidateAdmin(id, password);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
