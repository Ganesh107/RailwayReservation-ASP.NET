/* Passenger Services - contains business logic for Passenger related operations*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Railway.Datalayer;
using Railway.Entities;

namespace Railway.BusinessLayer
{
    public class PassengersService
    {
        PassengersRepository passengerRepository;
        public PassengersService()
        {
            //instantiating passengerRepository object
            passengerRepository = new PassengersRepository();
        }

        //Function to add new Passengers
        public int AddPassengers(Passengers passenger)
        {
            try
            {
                //calling AddPassengers() in PassengersRepository.cs
                return passengerRepository.AddPassengers(passenger);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to update Passenger details
        public void UpdatePassenger(Passengers passenger)
        {
            try
            {
                //calling UpdatePassenger() in PassengersRepository.cs
                passengerRepository.UpdatePassenger(passenger);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to get passenger details using userid
        public Passengers GetPassengersById(int userid)
        {
            try
            {
                //calling GetPassengersById() in PassengersRepository.cs
                return passengerRepository.GetPassengersById(userid);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to validate User
        public Passengers ValidateUser(int id,string password)
        {
            try
            {
                //calling ValidateUser() in PassengersRepository.cs
                return passengerRepository.ValidateUser(id, password);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to return Passenger id
        public int GetPassengerId(string phonenum)
        {
            try
            {
                //calling GetPassengerID in PassengersRepository.cs
                return passengerRepository.GetPassengerId(phonenum);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to check if user is already registered via phonenumber
        public bool CheckPhonenumberExists(string phno)
        {
            try
            {
                return passengerRepository.CheckPhonenumberExists(phno);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
