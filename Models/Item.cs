using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar2.Models
{
    public class Item
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "IdITEM")]
        public int IdItem { get; set; }
        [Display(Name = "IdPRODUTO")]
        public int IdProduto { get; set; }
        [Display(Name = "PERCENTUAL")]
        public int Percentual { get; set; }
        [Display(Name = "QUANTIDADE")]
        public int Quantidade { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}