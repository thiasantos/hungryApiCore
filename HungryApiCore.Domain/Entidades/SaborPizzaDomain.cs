using System;
using System.Collections.Generic;

namespace HungryApiCore.Domain.Entidades
{
    public class SaborPizzaDomain
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Decimal Quantidade { get; set; }
        public Decimal Valor { get; set; }
        public virtual IList<ItemPedidoDomain> ItensPedido { get; set; }
    }
}
