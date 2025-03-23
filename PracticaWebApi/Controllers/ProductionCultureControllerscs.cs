using Microsoft.AspNetCore.Mvc;
using PracticaWebApi.Interface;
using PracticaWebApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PracticaWebApi.Model.ProductionCulturecs;

namespace PracticaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CultureController : ControllerBase
    {
        private readonly IProductionCultureRepository _productionCultureRepository;

        public CultureController(IProductionCultureRepository productionCultureRepository)
        {
            _productionCultureRepository = productionCultureRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Culture>>> GetCultures()
        {
            var cultures = await _productionCultureRepository.GetCultureAsync();
            return Ok(cultures);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Culture>> GetCultureById(string id)
        {
            var culture = await _productionCultureRepository.GetCultureByIdAsync(id);
            if (culture == null) return NotFound();
            return Ok(culture);
        }
    }
}
