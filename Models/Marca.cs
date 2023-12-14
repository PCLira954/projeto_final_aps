using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Marca
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "IdMARCA")]
        public int IdMarca { get; set; }
        [Display(Name = "NOME")]
        public string Nome { get; set; }
        [Display(Name = "DESCRICAO")]
        public string Descricao { get; set; }
    }
}