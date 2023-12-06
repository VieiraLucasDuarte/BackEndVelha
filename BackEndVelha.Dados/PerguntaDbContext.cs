using BackEndVelha.Dados.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndVelha.Dados
{
    public class PerguntaDbContext : DbContext
    {
        public PerguntaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pergunta> Pergunta { get; set; }

        public DbSet<Resposta> Resposta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=pergunta.db");
    }
}
