using ProvaWeek7_CassanoValentina.Core.Entities;
using ProvaWeek7_CassanoValentina.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.Master
{
    public interface IRepositoryIndirizzi: IRepository<Indirizzo>
    {
        public Indirizzo GetById(int id);
    }
}
