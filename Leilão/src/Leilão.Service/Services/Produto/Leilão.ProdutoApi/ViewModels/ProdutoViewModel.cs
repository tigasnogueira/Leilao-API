using System.ComponentModel.DataAnnotations;

namespace Leilao.Produto.Api.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }

        //public string foto { get; set; }
        public string Edital { get; set; }
        public string Comitentes { get; set; }

        public string Meta { get; set; }

        public string Acressimo { get; set; }

        public string Natureza { get; set; }

        public string Descricao { get; set; }
        public string ValorInicial { get; set; }

    }
}
