using Entity;

namespace Leilao.ClienteBusiness.Models
{
    public class Endereco : EntityModel
    {
        public Guid ClienteId { get; set; }
        public string CEP { get; set; }
        public string TipoLongradouro { get; set; }
        public string Longradouro { get; set; } 
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }


        // EF Relation 
        public ClienteModel Cliente { get; set; }
    }
}