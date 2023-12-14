using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using paulocesar2.Models;

namespace paulocesar2.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "BANCO")]
        public int Banco { get; set; }
        [Display(Name = "NOME DO BANCO")]
        public string NomeDoBanco { get; set; }
    }
}