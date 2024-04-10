using Microsoft.AspNetCore.Mvc;
using SuperHero.data;
using SuperHero.Services;
namespace SuperHero.Controllers
{
    [Route("api/SuperHero")]
    [ApiController]
    public class SuperheroController : ControllerBase
    {
        private readonly ISuperHeroService _shero;

        public SuperheroController(ISuperHeroService shero) 
        {
            this._shero = shero;
        }

        [HttpGet]
        public ActionResult<List<Hero>> GetHeroes()
        {
            
            if(_shero.GetHeroes() == null) return NoContent();
            
            return Ok(_shero.GetHeroes());
            
        }

        [HttpGet("{id:int}")]

        public ActionResult<Hero> GetHero(int id)
        {
            if(id == 0) return BadRequest();
            return Ok(_shero.GetHero(id));
        }

        [HttpPost]

        public ActionResult<List<Hero>> CreateHero([FromBody] Hero newhero)
        {
            if (newhero == null) return BadRequest();
            
            _shero.AddHero(newhero);

            return Ok(Store.superheroList);
        }

        [HttpDelete("{id:int}")]

        public IActionResult DeleteHero(int id)
        {
            if(id == 0) { return BadRequest(); }
            
            _shero.DeleteHero(id);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        public IActionResult Updatedata(int id,[FromBody] Hero newHero) 
        {
            _shero.updatedata(id, newHero);
            return NoContent();
        }
    }
}
