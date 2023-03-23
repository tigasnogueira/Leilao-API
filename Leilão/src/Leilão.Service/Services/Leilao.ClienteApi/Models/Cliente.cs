using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Leilao.ClienteApi.Models.Enums;

namespace Leilao.ClienteBusiness.Models
{
    public class ClienteModel : EntityModel
    {
        public string Primeiro_nome { get; set; }
        public string Sobrenome { get; set; }
        public string Data_de_nascimento { get; set; }
        public  Genero Genero { get; set; }
        public Estado_Civil Estado_Civil { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Profissao { get; set; }
        public string Nome_Mae { get; set; }
        public Nacionalidade Nacionalidade { get; set; }
        public string EstadoNacionalidade { get; set; }
        public string CidadeNacionalidade { get;set; }
        public Endereco Endereco { get; set;  }
        public Contato Contato { get; set; }

    }
}
