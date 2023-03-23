using Intefaces;
using Leilao.Intefaces;
using Leilao.Produto.Business.Interfaces;
using Leilao.Produto.Business.Services;
using Leilao.Produto.Data.Context;
using Leilao.Produto.Data.Repository;

namespace Leilão.Produto.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MyDbContext>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<INotificador, Notificador>();


            return services;
        }
    }
}
