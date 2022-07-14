using HungryApiCore.Data.Context;
using HungryApiCore.Data.Repository;
using HungryApiCore.Domain.Interfaces.Repository;
using HungryApiCore.Domain.Interfaces.Servico;
using HungryApiCore.Servico;
using Microsoft.Extensions.DependencyInjection;

namespace hungryApiCore.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ContextHungry>();

            services.AddScoped<IClienteServico, ClienteServico>();
            services.AddScoped<IEnderecoServico, EnderecoServico>();
            services.AddScoped<IItemPedidoServico, ItemPedidoServico>();
            services.AddScoped<IPedidoServico, PedidoServico>();
            services.AddScoped<ISaborPizzaServico, SaborPizzaServico>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IItemPedidoRepository, ItemPedidoRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<ISaborPizzaRepository, SaborPizzaRepository>();

            return services;
        }
    }
}
