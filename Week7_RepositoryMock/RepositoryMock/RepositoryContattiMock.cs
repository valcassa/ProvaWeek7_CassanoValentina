using ProvaWeek7_CassanoValentina;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.RepositoryMock
{
    class RepositoryContattiMock : IRepositoryContatti
    {

        public static List<Contatto> Contatti = new List<Contatto>(); 

        public Contatto Add(Contatto item)
        {
            if (Contatti.Count() == 0)
            {
                item.IDContatto = 1;
            }
            else
            {
                item.IDContatto = Contatti.Max(x => x.IDContatto) + 1;
            }

            var indirizzo = RepositoryIndirizziMock.Indirizzi.FirstOrDefault(i => i.IDContatto == item.IDContatto);
            item.Indirizzo = indirizzo;
            
            indirizzo.Contatti.Add(item);

            Contatti.Add(item);
            return item;
        }

        public bool Delete(Contatto item)
        {
            Contatti.Remove(item);
            return true;
        }

        public List<Contatto> GetAll()
        {
            return Contatti.ToList();
        }

        public Contatto GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.IDContatto == id);
        }

        public Contatto Update(Contatto item)
        {
            var old = GetById(item.IDContatto);
            old.Indirizzo = item.Indirizzo;
            return item;
        }
    }
}
