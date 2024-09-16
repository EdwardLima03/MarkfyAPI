using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Markfy.Models
{
    [Table("tblProduto")]
    public class Produto
    {
        [Key]
        [Column("Id")]
        public long Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string Marca { get; set; }
        public TamanhoEnum Tamanho { get; set; }
        public int Estoque { get; set; }
    }

    public enum TamanhoEnum
    {
        Pequeno,
        Medio,
        Grande
    }
}
