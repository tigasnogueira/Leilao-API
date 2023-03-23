using AutoMapper;
using Leilao.Produto.Api.ViewModels;
using Leilao.Produto.Business.Models;

namespace Leilão.Produto.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<ProdutoModel, ProdutoViewModel>().ReverseMap();
        }
    }
}
