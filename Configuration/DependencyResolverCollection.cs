using HungryApiCore.Domain.Interfaces.Servico;
using HungryApiCore.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace hungryApiCore.Configuration
{
    public static class DependencyResolverCollection
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IClienteServico, ClienteServico>();
            services.AddScoped<IEnderecoServico, EnderecoServico>();
            services.AddScoped<IItemPedidoServico, ItemPedidoServico>();
            services.AddScoped<IPedidoServico, PedidoServico>();
            services.AddScoped<ISaborPizzaServico, SaborPizzaServico>();
        }
    }
}
