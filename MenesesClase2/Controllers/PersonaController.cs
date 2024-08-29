using MenesesClase2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MenesesClase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        // POST api/<PersonaController>
        [HttpPost]
        public List<Persona> Post(Persona persona)
        {

            List<Persona> lista = new List<Persona>();

            for (int i = 0; i < 10; i++)
            {
                lista.Add(persona);
            }
            return lista;

        }
    }
}
