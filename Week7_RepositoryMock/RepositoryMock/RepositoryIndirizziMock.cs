using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.RepositoryMock
{
    public class RepositoryIndirizziMock : IRepositoryIndirizzi
    {
        public static List<Indirizzo> Indirizzi = new List<Indirizzo>();

        public Indirizzo Add(Indirizzo item)
        {
            Indirizzi.Add(item);
            return item;

        }

        public bool Delete(Indirizzo item)
        {
            Indirizzi.Remove(item);
            return true;
        }

        public List<Indirizzo> GetAll()
        {
            return Indirizzi;
        }

        public Indirizzo GetById(int id)
        {
            return Indirizzi.Find(c => c.IDContatto == id);
        }

        public Indirizzo Update(Indirizzo item)
        {
            var old = Indirizzi.FirstOrDefault(c => c.IDContatto == item.IDContatto);
            old.Nome = item.Nome;
            old.Cognome = item.Cognome;
            return item;
        }
    }
}
