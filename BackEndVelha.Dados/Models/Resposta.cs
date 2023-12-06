using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndVelha.Dados.Models
{
    [Table("Resposta")]
    public class Resposta
    {
        [Key]
        [Column("Id")]
        public  int Id { get; set; }

        [Column("Descricao")]
        public string? Descricao { get; set; }

        [Column("Certa")]
        public string? Certa { get; set; }

        [Column("PerguntaId")]
        public int PerguntaId { get; set; }
    }
}
