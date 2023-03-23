using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leilao.Produto.Business.Models
{
    public class ProdutoModel : EntityModel
    {
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
