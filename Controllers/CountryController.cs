using CountryService.DAL;
using CountryService.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CountryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        //Create = HTTP Post
        //Update = HTTP PUT
        //Get(search,type) = GET
        //GetById = GET
        //Delete = PUT
        private readonly CountryContext _context;

        public CountryController(CountryContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var countrys = await _context.Country.ToListAsync();
            return Ok(countrys);
        }       
    }
}
