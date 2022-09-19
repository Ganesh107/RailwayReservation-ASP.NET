using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Entities
{
    public class Tickets
    {
        public int Ticketno { get; set; }
        public string Pname { get; set; }
        public string Trainname { get; set; }
        public string Ticketclass { get; set; }
        public string Gender { get; set; }
        public int Berthnumber { get; set; }
        public int Coachnumber { get; set; }
        public string Arrivaldate { get; set; }
        public int Pid { get; set; }
        public string Bookingstatus { get; set; }
    }
}
