using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Markfy.Models
{
    [Table("tblLoja")]
    public class Loja
    {
        [Key]
        [Column("Id")]
        public long IdLoja { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }

        public List<Produto>? Produtos { get; set; }
    }
}
