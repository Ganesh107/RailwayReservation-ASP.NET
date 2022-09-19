/* Traininfo repository - Performs Trains related Database operations*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Railway.Entities;
using System.Configuration;
using System.Diagnostics;
using System.Data;
using System.Globalization;

namespace Railway.Datalayer
{
    public class TraininfoRepository
    {
        //Connection object Initialization
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;

        //Function to add new Trains
        public void AddTrains(Traininfo train)
        {
            try
            {
                string query = "insert into traininfo values(@trainnumber,@trainname,@startloc,@endloc,@arrivaltime,@departuretime,@arrivaldate,@Ac2tier,@sleeper,@Ac3tier,@Tatkal,@ladies)";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@trainnumber", train.Trainnumber);
                cmd.Parameters.AddWithValue("@trainname", train.Trainname);
                cmd.Parameters.AddWithValue("@startloc", train.Startloc);
                cmd.Parameters.AddWithValue("@endloc", train.Endloc);
                cmd.Parameters.AddWithValue("@arrivaltime", train.Arrivaltime);
                cmd.Parameters.AddWithValue("@departuretime", train.Departuretime);
                cmd.Parameters.AddWithValue("@arrivaldate", train.Arrivaldate);
                cmd.Parameters.AddWithValue("@Ac2tier", train.Ac2tier);
                cmd.Parameters.AddWithValue("@sleeper", train.Sleeper);
                cmd.Parameters.AddWithValue("@Ac3tier", train.Ac3tier);
                cmd.Parameters.AddWithValue("@Tatkal", train.Tatkal);
                cmd.Parameters.AddWithValue("@ladies", train.Ladies);
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

        //Function to delete train details
        public void DeleteTrains(int trainnumber)
        {
            try
            {
                string query = "delete from traininfo where trainnumber=@trainnumber";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@trainnumber", trainnumber);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to get All train details
        public List<Traininfo> GetAlltrains()
        {
            List<Traininfo> trains = new List<Traininfo>();
            try
            {
                string query = "select * from traininfo";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Traininfo train = new Traininfo();
                    train.Trainnumber = (int)dr["trainnumber"];
                    train.Trainname = dr["trainname"].ToString();
                    train.Startloc = dr["startloc"].ToString();
                    train.Endloc = dr["endloc"].ToString();
                    train.Arrivaltime = dr["arrivaltime"].ToString();
                    train.Departuretime = dr["departuretime"].ToString();
                    train.Arrivaldate = dr["arrivaldate"].ToString();
                    train.Ac2tier = (int)dr["Ac2tier"];
                    train.Sleeper = (int)dr["sleeper"];
                    train.Ac3tier = (int)dr["Ac3tier"];
                    train.Tatkal = (int)dr["Tatkal"];
                    train.Ladies = (int)dr["ladies"];
                    trains.Add(train);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally 
            {
                conn.Close ();
            }
            return trains;
        }

        //Function to update train details
        public void UpdateTraininfo(int trainnumber,string trainname,string startloc,string endloc,string arrivaltime,string departuretime,string arrivaldate,int ac2tier,int sleeper,int ac3tier,int tatkal,int ladies)
        {
            try
            {
                string query = "update traininfo set trainname=@trainname,startloc=@startloc,endloc=@endloc,arrivaltime=@arrivaltime,departuretime=@departuretime,arrivaldate=@arrivaldate,Ac2tier=@Ac2tier,sleeper=@sleeper,Ac3tier=@Ac3tier,Tatkal=@Tatkal,ladies=@ladies where trainnumber=@trainnumber";
                conn.Open();
                cmd = new SqlCommand(@query, conn);
                cmd.Parameters.AddWithValue("@trainnumber", trainnumber);
                cmd.Parameters.AddWithValue("@trainname", trainname);
                cmd.Parameters.AddWithValue("@startloc", startloc);
                cmd.Parameters.AddWithValue("@endloc", endloc);
                cmd.Parameters.AddWithValue("@arrivaltime", arrivaltime);
                cmd.Parameters.AddWithValue("@departuretime", departuretime);
                cmd.Parameters.AddWithValue("@arrivaldate", arrivaldate);
                cmd.Parameters.AddWithValue("@Ac2tier", ac2tier);
                cmd.Parameters.AddWithValue("@sleeper", sleeper);
                cmd.Parameters.AddWithValue("@Ac3tier", ac3tier);
                cmd.Parameters.AddWithValue("@Tatkal", tatkal);
                cmd.Parameters.AddWithValue("@ladies", ladies) ;
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

        //Function to check if trainnumber already exist
        public bool CheckIfTrainnumberExists(int trainnumber)
        {
            try
            {
                string query = "select * from traininfo where trainnumber=@trainnumber";
                conn.Open();
                cmd = new SqlCommand (query, conn);
                cmd.Parameters.AddWithValue("@trainnumber", trainnumber);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
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
        }

        //Function to get Train details using starting location, ending location and date
        public DataTable FilterTrains(string start_loc,string end_loc,string date)
        {
            DataTable trains_datatable = new DataTable();
            try
            {
                String query = $"select * from traininfo where startloc='{start_loc}' and endloc='{end_loc}' and arrivaldate='{date}'";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(trains_datatable);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return trains_datatable;
        }

        //Function to update train seats - Ac-2tier
        public void UpdateSeats(int quantity, int trainnumber)
        {
            try
            {
                string query = $"update traininfo set Ac2tier = Ac2tier-{quantity} where trainnumber={trainnumber}";
                conn.Open();
                cmd = new SqlCommand(query, conn);
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

        //Function to update train seats - Ac-3tier
        public void UpdateAc3TierSeats(int quantity, int trainnumber)
        {
            try
            {
                string query = $"update traininfo set Ac3tier = Ac3tier-{quantity} where trainnumber={trainnumber}";
                conn.Open();
                cmd = new SqlCommand(query, conn);
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

        //Function to update train seats - sleeper class
        public void UpdateSleeperSeats(int quantity, int trainnumber)
        {
            try
            {
                string query = $"update traininfo set sleeper = sleeper-{quantity} where trainnumber={trainnumber}";
                conn.Open();
                cmd = new SqlCommand(query, conn);
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

        //Function to update train seats - Tatkal class
        public void UpdateTatkalSeats(int quantity, int trainnumber)
        {
            try
            {
                string query = $"update traininfo set Tatkal = Tatkal-{quantity} where trainnumber={trainnumber}";
                conn.Open();
                cmd = new SqlCommand(query, conn);
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

        //Function to update train seats - ladies class
        public void UpdateLadiesSeats(int quantity, int trainnumber)
        {
            try
            {
                string query = $"update traininfo set ladies = ladies-{quantity} where trainnumber={trainnumber}";
                conn.Open();
                cmd = new SqlCommand(query, conn);
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
