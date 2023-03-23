using Intefaces;
using Leilao.Intefaces;
using Leilao.Produto.Business.Interfaces;
using Leilao.Produto.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Produto.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(ProdutoModel produto)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(ProdutoModel produto)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
