using System;
using System.Collections.Generic;

namespace HungryApiCore.Domain.Entidades
{
    public class PedidoDomain
    {
        public int ID { get; set; }
        public int? IDCliente { get; set; }
        public virtual ClienteDomain Cliente { get; set; }
        public int? IDEndereco { get; set; }
        public virtual EnderecoDomain Endereco { get; set; }
        public DateTime DataPedido { get; set; }
        public IList<ItemPedidoDomain> Itens { get; set; }
    }
}
