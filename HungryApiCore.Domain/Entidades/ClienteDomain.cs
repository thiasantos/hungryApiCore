namespace HungryApiCore.Domain.Entidades
{
    public class ClienteDomain
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int IDEndereco { get; set; }
        public virtual EnderecoDomain Endereco { get; set; }
    }
}
