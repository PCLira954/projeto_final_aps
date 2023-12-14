using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Produto
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID MARCA")]
        public int IdMarca { get; set; }
        [Display(Name = "NOME")]
        public string Nome { get; set; }
        [Display(Name = "DESCRICAO")]
        public string Descricao { get; set; }
        [Display(Name = "QUANTIDADE")]
        public int Quantidade { get; set; }
        [Display(Name = "PRECO")]
        public double Preco { get; set; }

    }
}