using Leilao.ClienteBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.ClienteBusiness.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Task Adicionar(ClienteModel cliente);
        Task Atualizar(ClienteModel cliente);
        Task Remover(Guid id);
    }
}
