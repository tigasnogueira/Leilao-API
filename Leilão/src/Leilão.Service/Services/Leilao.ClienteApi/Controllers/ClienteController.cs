using Leilao.ClienteBusiness.Interfaces;
using Leilao.Intefaces;
using Microsoft.AspNetCore.Routing.Matching;

namespace Leilao.ClienteApi.Controllers
{
    public class ClienteController : MainController
    {
        private readonly IClienteService _clienteService;
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository, IClienteService clienteService, INotificador notificador): base(notificador)
        {
            _clienteService = clienteService;
            _clienteRepository = clienteRepository;
        }
    }
}
