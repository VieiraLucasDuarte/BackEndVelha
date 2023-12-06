using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndVelha.Dados.Models
{
    [Table("Pergunta")]
    public class Pergunta
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Descricao")]
        public string? Descricao { get; set; }

        public List<Resposta>? Respostas { get; set; }
    }
}
