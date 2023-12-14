using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Transportadora
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID TRANSPORTADORA")]
        public int IdTransportadora { get; set; }
        [Display(Name = "NOME")]
        public string Nome { get; set; }
    }
}