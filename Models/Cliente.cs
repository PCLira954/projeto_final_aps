using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Cliente
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "NOME")]
        public string Nome { get; set; }
    }
}