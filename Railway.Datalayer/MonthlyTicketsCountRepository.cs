using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Entities;
using System.Globalization;
using System.ComponentModel;

namespace Railway.Datalayer
{
    public class MonthlyTicketsCountRepository
    {
        //Connection object Initialization
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;

        //function to set limit of newly registerd users
        public void AddNewUser(int userid)
        {
            try
            {
                string query = $"insert into MonthlyTicketsCount values({userid},{0},{0},{0},{0})";
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //function to get september limit
        public int GetSeptemberTicketCount(int userid)
        {
            int monthly_count = 0;
            try
            {
                string query = "select September from MonthlyTicketsCount where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", userid);
                monthly_count = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return monthly_count;
        }

        //Function to update september limit
        public void UpdateSeptemberlimit(int userid)
        {
            try
            {
                string query = $"update MonthlyTicketsCount set september=september+{1} where userid={userid}";
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //function to get october limit
        public int GetOctoberTicketCount(int userid)
        {
            int monthly_count = 0;
            try
            {
                string query = "select October from MonthlyTicketsCount where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", userid);
                monthly_count = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return monthly_count;
        }

        //Function to update October limit
        public void UpdateOctoberlimit(int userid)
        {
            try
            {
                string query = $"update MonthlyTicketsCount set october=october+{1} where userid={userid}";
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //function to get November limit
        public int GetNovemberTicketCount(int userid)
        {
            int monthly_count = 0;
            try
            {
                string query = "select November from MonthlyTicketsCount where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", userid);
                monthly_count = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return monthly_count;
        }

        //Function to update November limit
        public void UpdateNovemberlimit(int userid)
        {
            try
            {
                string query = $"update MonthlyTicketsCount set november=november+{1} where userid={userid}";
                cmd = new SqlCommand(query, conn);
                conn.Open();
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

        //function to get December limit
        public int GetDecemberTicketCount(int userid)
        {
            int monthly_count = 0;
            try
            {
                string query = "select December from MonthlyTicketsCount where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", userid);
                monthly_count = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return monthly_count;
        }

        //Function to update December limit
        public void UpdateDecemberlimit(int userid)
        {
            try
            {
                string query = $"update MonthlyTicketsCount set december=december+{1} where userid={userid}";
                cmd = new SqlCommand(query, conn);
                conn.Open();
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
    }
}
