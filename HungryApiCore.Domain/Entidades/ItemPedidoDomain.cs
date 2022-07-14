using System.Collections.Generic;

namespace HungryApiCore.Domain.Entidades
{
    public class ItemPedidoDomain
    {
        public int ID { get; set; }
        public int IDPedido { get; set; }
        public virtual PedidoDomain Pedido { get; set; }
        public IList<SaborPizzaDomain> Sabor { get; set; }
    }
}
