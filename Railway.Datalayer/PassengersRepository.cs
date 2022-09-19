/* Passengers repository - Performs Passenger related Database operations*/

using Railway.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Datalayer
{
    public  class PassengersRepository
    {
        //Connection object Initialization
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Railwayconnection"].ConnectionString);
        SqlCommand cmd = null;

        //Function to Add new passengers
        public int AddPassengers(Passengers passenger)
        {
            int rows_returned = 0;
            try
            {
                //Parametrized query 
                string query = "insert into passengers values(@pname,@dob,@addresses,@phonenumber,@passwords)";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pname",passenger.Pname);
                cmd.Parameters.AddWithValue("@dob", passenger.Dob);
                cmd.Parameters.AddWithValue("addresses", passenger.Address);
                cmd.Parameters.AddWithValue("@phonenumber", passenger.Phonenumber);
                cmd.Parameters.AddWithValue("@passwords", passenger.Passwords);
                rows_returned = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return rows_returned;
        }

        //Function to update Passenger details
        public void UpdatePassenger(Passengers passenger)
        {
            try
            {
                string query = "update passengers set pname=@pname,dob=@dob,addresses=@addresses,phonenumber=@phonenumber,passwords=@passwords where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", passenger.Userid);
                cmd.Parameters.AddWithValue("@pname", passenger.Pname);
                cmd.Parameters.AddWithValue("@dob", passenger.Dob);
                cmd.Parameters.AddWithValue("@addresses", passenger.Address);
                cmd.Parameters.AddWithValue("@phonenumber", passenger.Phonenumber);
                cmd.Parameters.AddWithValue("@passwords", passenger.Passwords);
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

        //Function to get passenger details using userid
        public Passengers GetPassengersById(int userid)
        {
            Passengers passengers = new Passengers(); //Object to store retrieved passengers data

            try
            {
                string query = "select * from passengers where userid=@userid";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid",userid);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    passengers.Userid = (int)dr["userid"]; //Object to integer conversion
                    passengers.Pname = dr["pname"].ToString(); //Object to string conversion
                    passengers.Dob = dr["dob"].ToString();
                    passengers.Address = dr["addresses"].ToString();
                    passengers.Phonenumber = dr["phonenumber"].ToString();
                    passengers.Passwords = dr["passwords"].ToString();
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
            return passengers;
        }

        //Function to retrive user based on UserID and password
        public Passengers ValidateUser(int id,string password)
        {
            Passengers passenger = new Passengers(); //stores users with given userid and password
            SqlDataReader dr = null;
            try
            {
                string query = "select * from passengers where userid=@userid and passwords=@passwords";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userid", id);
                cmd.Parameters.AddWithValue("@passwords", password);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        passenger.Userid = (int) dr["userid"];
                        passenger.Pname = dr["pname"].ToString();
                        passenger.Passwords = dr["passwords"].ToString();
                    }
                }
                else
                {
                    passenger.Passwords = null;
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
            return passenger;
        }

        //Function to return Passenger id based on phone number
        public int GetPassengerId(string phonenum)
        {
            int userid = 0;
            try
            {
                string query = "select userid from passengers where phonenumber=@phonenumber";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phonenumber", phonenum);
                userid = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return userid;
        }

        //Function to check if user is already registered via phonenumber
        public bool CheckPhonenumberExists(string phno)
        {
            try
            {
                string query = "select phonenumber from passengers where phonenumber=@phonenumber";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@phonenumber", phno);
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
    }
}
