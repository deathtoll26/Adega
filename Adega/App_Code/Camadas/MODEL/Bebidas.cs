using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adega.Camadas.MODEL
{
   public  class Bebida
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float preço { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
    }
}
