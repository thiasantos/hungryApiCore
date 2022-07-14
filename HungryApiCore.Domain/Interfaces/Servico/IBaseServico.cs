using System.Collections.Generic;

namespace HungryApiCore.Domain.Interfaces.Servico
{
    public interface IBaseServico<Entity>
    {
        void Insert(Entity param);
        IList<Entity> Listar();
    }
}
