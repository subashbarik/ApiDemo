using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Entity;
using WebAPI.Data.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotesController:ControllerBase
    {
        private readonly DemoApiContext _context;

        public QuotesController(DemoApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Quote> GetQuotes()
        {
            return _context.Quotes.ToList();
        }
    }
}
