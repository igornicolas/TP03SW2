using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP03SW2.Models
{
    public class BL
    {
        public int BLId { get; set; }
        public int Numero { get; set; }
        public string Consignee { get; set; }
        public string Navio { get; set; }
        public List<Container> Containers { get; } = new List<Container>();


    
    }
}
