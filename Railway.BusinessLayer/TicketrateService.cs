using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Railway.Entities;
using Railway.Datalayer;

namespace Railway.BusinessLayer
{
    public class TicketrateService
    {
        TicketrateRepository ticketrateRepository;
        public TicketrateService()
        {
            ticketrateRepository = new TicketrateRepository();
        }

        public int GetTicketRate(string ticketclass)
        {
            try
            {
                return ticketrateRepository.GetTicketRate(ticketclass);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
