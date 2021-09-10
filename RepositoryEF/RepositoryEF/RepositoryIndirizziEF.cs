using Microsoft.EntityFrameworkCore;
using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using ProvaWeek7_CassanoValentina.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.RepositoryEF.RepositoryEF
{
    public class RepositoryIndirizziEF : IRepositoryIndirizzi
    {
        public Indirizzo Add(Indirizzo item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Indirizzi.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Indirizzo item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Indirizzi.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Indirizzo> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Indirizzi.Include(i => i.Contatti).ToList();
            }
        }

        public Indirizzo GetById(int id)
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Indirizzi.Include(i => i.Contatti).FirstOrDefault(c => c.IDContatto == id);
            }
        }

        public Indirizzo Update(Indirizzo item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Indirizzi.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
