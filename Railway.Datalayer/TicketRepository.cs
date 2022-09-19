using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Railway.Entities;
using System.Configuration;
using System.ComponentModel;
using System.Data;

namespace Railway.Datalayer
{
    public class TicketRepository
    {
        //Connection object Initialization
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;

        //Function to add ticket details
        public void AddTicket(string pname, string trainname, int age, string ticketclass, string gender, int berthno, int coachno, string arrrivaldate, int pid, string status)
        {
            try
            {
                string query = "insert into tickets values(@pname,@trainname,@age,@ticketclass,@gender,@berthnumber,@coachnumber,@arrivaldate,@pid,@bookingstatus)";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pname", pname);
                cmd.Parameters.AddWithValue("@trainname", trainname);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@ticketclass", ticketclass);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@berthnumber", berthno);
                cmd.Parameters.AddWithValue("@coachnumber", coachno);
                cmd.Parameters.AddWithValue("@arrivaldate", arrrivaldate);
                cmd.Parameters.AddWithValue("@pid", pid);
                cmd.Parameters.AddWithValue("@bookingstatus", status);
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

        //Function to get display ticket details
        public DataTable ViewTicket(int userid)
        {
            DataTable ticket = new DataTable();
            try
            {
                string query = $"select * from tickets where pid={userid}";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(ticket);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return ticket;
        }
    }
}
