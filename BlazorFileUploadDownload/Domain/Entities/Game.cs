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

        [Column("nome")]
        public string? Nome { get; set; }

        [Column("preco", TypeName = "decimal(7, 2)")]
        public decimal Preco { get; set; }
    }
}
