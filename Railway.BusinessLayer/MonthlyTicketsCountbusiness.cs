using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Datalayer;

namespace Railway.BusinessLayer
{
    public class MonthlyTicketsCountbusiness
    {
        MonthlyTicketsCountRepository monthlyTicketsCountRepository;
        public MonthlyTicketsCountbusiness()
        {
            monthlyTicketsCountRepository = new MonthlyTicketsCountRepository();
        }

        //function to set limit of newly registerd users
        public void AddNewUser(int userid)
        {
            try
            {
                monthlyTicketsCountRepository.AddNewUser(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //function to get september ticket count
        public int GetSeptemberTicketCount(int userid)
        {
            try
            {
                return monthlyTicketsCountRepository.GetSeptemberTicketCount(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update september limit
        public void UpdateSeptemberlimit(int userid)
        {
            try
            {
                monthlyTicketsCountRepository.UpdateSeptemberlimit(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //function to get october ticket count
        public int GetOctoberTicketCount(int userid)
        {
            try
            {
                return monthlyTicketsCountRepository.GetOctoberTicketCount(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update october limit
        public void UpdateOctoberlimit(int userid)
        {
            try
            {
                monthlyTicketsCountRepository.UpdateOctoberlimit(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //function to get November ticket count
        public int GetNovemberTicketCount(int userid)
        {
            try
            {
                return monthlyTicketsCountRepository.GetNovemberTicketCount(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update November limit
        public void UpdateNovemberlimit(int userid)
        {
            try
            {
                monthlyTicketsCountRepository.UpdateNovemberlimit(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //function to get December ticket count
        public int GetDecemberTicketCount(int userid)
        {
            try
            {
                return monthlyTicketsCountRepository.GetDecemberTicketCount(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to update December limit
        public void UpdateDecemberlimit(int userid)
        {
            try
            {
                monthlyTicketsCountRepository.UpdateDecemberlimit(userid);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
