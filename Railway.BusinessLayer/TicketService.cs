using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Datalayer;
using Railway.Entities;

namespace Railway.BusinessLayer
{
    public class TicketService
    {
        TicketRepository ticketRepository;
        public TicketService()
        {
            ticketRepository = new TicketRepository();
        }

        //Function to add ticket details
        public void AddTicket(string pname ,string trainname, int age, string ticketclass, string gender, int berthno, int coachno, string arrrivaldate, int pid, string status)
        {
            try
            {
                ticketRepository.AddTicket(pname,trainname,age,ticketclass,gender,berthno,coachno,arrrivaldate,pid,status);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Function to view booked ticket
        public DataTable ViewTicket(int userid)
        {
            try
            {
                return ticketRepository.ViewTicket(userid);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
