/* Admin repository - Performs Admin related Database operations*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Railway.Entities;

namespace Railway.Datalayer
{
    public class AdminRepository
    {
        //Connection object Initialization
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;

        //Function to add new admins
        public void NewAdmin(Admins admin)
        {
            try
            {
                //Parametrized query 
                string query = "insert into admins values(@username,@passwords)";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", admin.Username);
                cmd.Parameters.AddWithValue("passwords", admin.Passwords);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        //Function to delete admins
        public void DeleteAdmin(int adminid)
        {
            try
            {
                string query = "delete from admins where adminid=@adminid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adminid", adminid);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        //Function to update Admin details
        public void UpdateAdmin(Admins admin)
        {
            try
            {
                string query = "update admins set username=@username,passwords=@passwords where adminid=@adminid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adminid", admin.Adminid);
                cmd.Parameters.AddWithValue("@username", admin.Username);
                cmd.Parameters.AddWithValue("@passwords",admin.Passwords);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        //Function to get all admin details
        public List<Admins> GetAllAdmins()
        {
            List<Admins> admins = new List<Admins>(); //List To store retrieved admin data

            try
            {
                string query = "select * from admins";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Admins admin = new Admins();
                    admin.Adminid = (int) dr["adminid"]; //Object to integer conversion
                    admin.Username = dr["username"].ToString(); //Object to string conversion
                    admin.Passwords = dr["passwords"].ToString();
                    admins.Add(admin);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return admins;
        }

        //Function to retrive Admin data based on UserID and password
        public Admins ValidateAdmin(int id, string password)
        {
            Admins admin = new Admins(); //stores admins with given userid and password
            SqlDataReader dr = null;
            try
            {
                string query = "select * from admins where adminid=@adminid and passwords=@passwords";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@adminid", id);
                cmd.Parameters.AddWithValue("@passwords", password);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        admin.Adminid = (int)dr["adminid"];
                        admin.Username = dr["username"].ToString();
                        admin.Passwords = dr["passwords"].ToString();
                    }
                }
                else
                {
                    admin.Passwords = null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return admin;
        }
    }
}
