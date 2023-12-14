using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Pagamento
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "IDPAGAMENTO")]
        public int IdPagamento { get; set; }
        [Display(Name = "DATALIMITE")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "VALOR")]
        public double Valor { get; set; }
        [Display(Name = "PAGO")]
        public bool Pago { get; set; }
    }
}