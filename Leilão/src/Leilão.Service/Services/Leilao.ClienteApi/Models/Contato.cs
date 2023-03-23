using Entity;

namespace Leilao.ClienteBusiness.Models
{
    public class Contato : EntityModel
    {
        public Guid ClienteId { get; set; }
        public int Celular { get; set; }
        public int Residencial { get; set; }

        public ClienteModel Cliente { get; set; }
    }
}