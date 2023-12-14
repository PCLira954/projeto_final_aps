using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using paulocesar2.Models;

namespace paulocesar2.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "NUMERODOCARTAO")]
        public string NumeroDoCartao { get; set; }
        [Display(Name = "BANDEIRA")]
        public string Bandeira { get; set; }
    }
}