using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HungryApiCore.Domain.Interfaces.Repository
{
    public interface IBaseRepository<Entity>
    {
        void Insert(Entity param);
        IQueryable<Entity> Listar();
    }
}
