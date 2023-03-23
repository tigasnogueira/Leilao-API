using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.ClienteBusiness.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Task Adicionar(ClienteModel produto);
        Task Atualizar(ClienteModel produto);
        Task Remover(Guid id);
    }
}
