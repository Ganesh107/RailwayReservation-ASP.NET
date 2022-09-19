/* TraininfoService - contains business logic for admin related operations*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Entities;
using Railway.Datalayer;
using System.Data;

namespace Railway.BusinessLayer
{
    public class TraininfoService
    {
        TraininfoRepository traininfoRepository;
        public TraininfoService()
        {
            //instantiating TraininfoRepository object
            traininfoRepository = new TraininfoRepository();
        }

        //Function to add new Trains
        public void AddTrains(Traininfo train)
        {
            try
            {
                //calling AddTrains() in TraininfoRepository.cs
                traininfoRepository.AddTrains(train);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to delete train details
        public void DeleteTrains(int trainnumber)
        {
            try
            {
                //calling DeleteTrains() in TraininfoRepository.cs
                traininfoRepository.DeleteTrains(trainnumber);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to get All train details
        public List<Traininfo> GetAlltrains()
        {
            try
            {
                //calling GetAlltrains() in TraininfoRepository.cs
                return traininfoRepository.GetAlltrains();
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update train details
        public void UpdateTraininfo(int trainnumber, string trainname, string startloc, string endloc, string arrivaltime, string departuretime, string arrivaldate, int ac2tier, int sleeper, int ac3tier, int tatkal, int ladies)
        {
            try
            {
                //calling UpdateTraininfo() in TraininfoRepository.cs
                traininfoRepository.UpdateTraininfo(trainnumber, trainname, startloc, endloc, arrivaltime, departuretime, arrivaldate, ac2tier, sleeper, ac3tier, tatkal, ladies);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to check if trainnumber already exist
        public bool CheckIfTrainnumberExists(int trainnumber)
        {
            try
            {
                //calling datalayer function
                return traininfoRepository.CheckIfTrainnumberExists(trainnumber);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Function to get Train details using starting location and ending location
        public DataTable FilterTrains(string start_loc, string end_loc, string date)
        {
            try
            {
                //calling datalayer function
                return traininfoRepository.FilterTrains(start_loc, end_loc, date);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update train Ac2tier-seats
        public void UpdateSeats(int quantity, int trainnumber)
        {
            traininfoRepository.UpdateSeats(quantity, trainnumber);
        }

        //Function to update train Ac3tier-seats
        public void UpdateAc3TierSeats(int quantity, int trainnumber)
        {
            traininfoRepository.UpdateAc3TierSeats(quantity, trainnumber);
        }

        //Function to update train sleeper-seats
        public void UpdateSleeperSeats(int quantity, int trainnumber)
        {
            traininfoRepository.UpdateSleeperSeats(quantity, trainnumber);
        }

        //Function to update train seats - Tatkal class
        public void UpdateTatkalSeats(int quantity, int trainnumber)
        {
            traininfoRepository.UpdateTatkalSeats(quantity, trainnumber);
        }

        //Function to update train seats - ladies class
        public void UpdateLadiesSeats(int quantity, int trainnumber)
        {
            traininfoRepository.UpdateLadiesSeats(quantity, trainnumber);
        }
    }
}
