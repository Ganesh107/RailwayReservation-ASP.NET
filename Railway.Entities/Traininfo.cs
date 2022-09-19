using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Entities
{
    public class Traininfo
    {
        public int Trainnumber { get; set; }
        public string Trainname { get; set; }
        public string Startloc { get; set; }
        public string Endloc { get; set; }
        public string Arrivaltime { get; set; }
        public string Departuretime { get; set; }
        public string Arrivaldate { get; set; }
        public int Ac2tier { get; set; }
        public int Sleeper { get; set; }
        public int Ac3tier { get; set; }
        public int Tatkal { get; set; }
        public int Ladies { get; set; }
    }
}
