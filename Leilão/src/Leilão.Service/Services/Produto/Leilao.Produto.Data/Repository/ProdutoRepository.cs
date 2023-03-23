using Leilao.Intefaces;
using Leilao.Produto.Business.Interfaces;
using Leilao.Produto.Business.Models;
using Leilao.Produto.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Produto.Data.Repository
{
    public class ProdutoRepository : Repository<ProdutoModel>, IProdutoRepository
    {
        public ProdutoRepository(MyDbContext context) : base(context)
        {
        }
    }
}
