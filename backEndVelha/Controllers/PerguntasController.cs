using BackEndVelha.Dados;
using BackEndVelha.Dados.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backEndVelha.Controllers
{
    [ApiController]
    [Route("api/perguntas")]
    public class PerguntasController : ControllerBase
    {
        private readonly PerguntaDbContext _context;

        public PerguntasController(PerguntaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Pergunta> Get()
        {
            return _context.Pergunta.Include(p => p.Respostas).ToList();
        }
    }
}
