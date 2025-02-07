using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.models;

namespace PruebaTecnica.Controllers
{
    [Route("Api/Alumno")]
    [ApiController]
    public class AlumnoController : Controller
    {

        private readonly ApplicationDBContext _context;

        public AlumnoController(ApplicationDBContext context)
        {
            _context = context;
        }

        // POST: AlumnoController
        [HttpPost]
        public async Task<ActionResult> POST(Alumno alumno)
        {
            _context.Add(alumno);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // GET: AlumnoController por Id
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alumno>>> GET(int grado)
        {
            var alumnos = await _context.Alumnos
                .Where(x => x.grado == grado).
                ToListAsync();

            if (alumnos == null)
            {
                return NotFound();
            }

            return Ok(alumnos);
        }

    }
}
