using Microsoft.EntityFrameworkCore;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.RepositoryEF.RepositoryEF
{
    public class RepositoryContattiEF : IRepositoryContatti
    {
        public Contatto Add(Contatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Contatti.Add(item);
                ctx.SaveChanges();
            }
            return item;
        }

        public bool Delete(Contatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Contatti.Remove(item);
                ctx.SaveChanges();
            }
            return true;
        }

        public List<Contatto> GetAll()
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Contatti.Include(c => c.Indirizzo).ToList();
            }
        }

        public Contatto GetById(int id)
        {
            using (var ctx = new MasterContext())
            {
                return ctx.Contatti.Include(c => c.Indirizzo).FirstOrDefault(c => c.IDContatto == id);
            }
        }

        public Contatto Update(Contatto item)
        {
            using (var ctx = new MasterContext())
            {
                ctx.Contatti.Update(item);
                ctx.SaveChanges();
            }
            return item;
        }
    }
}
