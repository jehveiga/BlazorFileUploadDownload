using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorFileUploadDownload.Domain.Entities
{
    public class Game
    {
        [Key]
        [Column("id")]
        [Ignore]
        public int Id { get; set; }

        [Name("Nome do Produto")]
        [Column("nome")]
        public string? Nome { get; set; }

        [Name("Preco Produto")]
        [Column("preco", TypeName = "decimal(7, 2)")]
        public decimal Preco { get; set; }
    }
}
