
using Leilao.ClienteBusiness.Models;
using Leilao.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.ClienteBusiness.Interfaces
{
    public interface IClienteRepository : IRepository<ClienteModel>
    {
        Task<ClienteModel> ObterClienteEndereco(Guid id);
        Task<ClienteModel> ObterClienteContatoEndereco(Guid id);
        Task<ClienteModel> ObterContatoEndereco(Guid id);
    }
}
