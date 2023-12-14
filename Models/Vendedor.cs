using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Vendedor
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID VENDEDOR")]
        public int IdVendedor { get; set; }
        [Display(Name = "NOME")]
        public string Nome { get; set; }
    }
}