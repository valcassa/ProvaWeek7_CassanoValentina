using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.Core.Entities
{
    public class Indirizzo : Contatto
    {
        public int IDIndirizzo { get; set; }
        public string TipoIndirizzo {get; set;}
        public string Via { get; set; }
        public string Città { get; set; }
        public int CAP { get; set; }
        public string Provincia { get; set; }
        public string Nazione { get; set; }

        public Contatto Contatto;
      }


}
