using ProvaWeek7_CassanoValentina.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProvaWeek7_CassanoValentina
{
    public class Contatto
    {

        public int IDContatto { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public List<Contatto> Contatti { get; set; } = new List<Contatto>();

        public Indirizzo Indirizzo { get; set; }



    }
    }
