using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP03SW2.Models
{
    public class Container
    {
        public int ContainerId { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public int BLId { get; set; }
        public BL BL { get; set; }

    }
}
