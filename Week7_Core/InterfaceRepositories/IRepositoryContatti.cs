using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaWeek7_CassanoValentina.Core.InterfaceRepositories
{
    public interface  IRepositoryContatti: IRepository<Contatto>
    {
        public Contatto GetById(int id);
    }
}
