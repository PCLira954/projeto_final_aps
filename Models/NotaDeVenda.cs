using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "IdPAGAMENTO")]
        public int IdPagamento { get; set; }
        [Display(Name = "IdTRANSPORTADORA")]
        public int IdTransportadora { get; set; }
        [Display(Name = "IdVENDEDOR")]
        public int IdVendedor { get; set; }
        [Display(Name = "IdCLIENTE")]
        public int IdCliente { get; set; }
        [Display(Name = "DATA")]
        public DateTime Data { get; set; }
        [Display(Name = "TIPO")]
        public bool Tipo { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}