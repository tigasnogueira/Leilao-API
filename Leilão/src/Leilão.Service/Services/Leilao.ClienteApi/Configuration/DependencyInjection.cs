using Intefaces;
using Leilao.ClienteApi.Context;
using Leilao.ClienteApi.Interfaces;
using Leilao.ClienteApi.Repository;
using Leilao.ClienteApi.Services;
using Leilao.ClienteBusiness.Interfaces;
using Leilao.Intefaces;

namespace Leilao.ClienteApi.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ClienteDbContext>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<IContatoService, ContatoService>();

            return services;
        }
    }
}
