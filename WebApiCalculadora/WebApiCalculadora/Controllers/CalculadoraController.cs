using Microsoft.AspNetCore.Mvc;
using WebApiCalculadora.Data;
using WebApiCalculadora.Models;

namespace WebApiCalculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        private readonly CálculosDbContext _context;

        public CalculadoraController(CálculosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _context.Calculadora2.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _context.Calculadora2.Find(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Calculadora2 calculo)
        {
            if (ModelState.IsValid)
            {
                _context.Calculadora2.Add(calculo);
                _context.SaveChanges();
                return Ok(calculo);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Calculadora2 calculo)
        {
            var existing = _context.Calculadora2.Find(id);
            if (existing == null) return NotFound();

            existing.Numero1 = calculo.Numero1;
            existing.Numero2 = calculo.Numero2;
            existing.Operacion = calculo.Operacion;
            existing.Resultado = calculo.Resultado;
            existing.Fecha = calculo.Fecha;

            _context.SaveChanges();
            return Ok(existing);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = _context.Calculadora2.Find(id);
            if (item == null) return NotFound();

            _context.Calculadora2.Remove(item);
            _context.SaveChanges();
            return NoContent();
        }
    }
}

