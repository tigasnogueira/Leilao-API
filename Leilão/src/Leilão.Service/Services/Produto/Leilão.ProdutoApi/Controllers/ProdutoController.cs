using AutoMapper;
using Leilao.Intefaces;
using Leilao.Produto.Api.ViewModels;
using Leilao.Produto.Business.Interfaces;
using Leilao.Produto.Business.Models;
using Microsoft.AspNetCore.Mvc;
using Entity;

namespace Leilão.Produto.Api.Controllers
{
    [Route("api/Produtos")]
    public class VeiculoController : MainController
    {
        public readonly IProdutoRepository _repository;
        public readonly IProdutoService _service;
        public IMapper _mapper;

        public VeiculoController(IProdutoRepository produtoRepository, IProdutoService produtoService,
            IMapper mapper, INotificador notificador) : base(notificador)
        {
            _repository = produtoRepository;
            _service = produtoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            var produto = _mapper.Map<IEnumerable<ProdutoViewModel>>(await _repository.ObterTodos());
            return produto;
        }


        [HttpGet("{id:guid}")]
        // [Authorize]
        public async Task<ActionResult<ProdutoViewModel>> ObterpPorId(Guid id)
        {
            var produto = _mapper.Map<ProdutoViewModel>(await _repository.ObterPorId(id));

            if (produto == null) return NotFound();

            return produto;
        }


        [HttpPost]
        public async Task<ActionResult<ProdutoViewModel>> Adicionar(ProdutoViewModel produto)
        {
            if (!ModelState.IsValid) return CostumResponse(ModelState);

            await _repository.Adicionar(_mapper.Map<ProdutoModel>(produto));

            return CostumResponse(produto);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ProdutoViewModel>> Atualizar(Guid id, ProdutoViewModel produto)
        {
            if (id != produto.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CostumResponse(produto);
            }

            if (!ModelState.IsValid) return CostumResponse(ModelState);

            await _service.Atualizar(_mapper.Map<ProdutoModel>(produto));

            return CostumResponse(produto);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ProdutoViewModel>> Excluir(Guid id)
        {
            var produtoViewModel = await _repository.ObterPorId(id);


            if (produtoViewModel == null) return NotFound();

            await _repository.Remover(id);

            return CostumResponse(produtoViewModel);
        }

        
    }
}
