using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Railway.Entities;
using System.Data.SqlClient;
using System.Configuration;

namespace Railway.Datalayer
{
    public class TicketrateRepository
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;
        public int GetTicketRate(string ticketclass)
        {
            int rate = 0;
            try
            {
                string query = $"select price from Ticketrates where ticketclass='{ticketclass}'";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                rate = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rate;
        }
    }
}

