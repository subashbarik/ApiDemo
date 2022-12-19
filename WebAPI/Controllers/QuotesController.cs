using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.Data.Entity;
using WebAPI.Data.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuotesController : ControllerBase
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
        [HttpGet("{id}")]
        public ActionResult<Quote> GetQuote(int id)
        {
            var quote = _context.Quotes.FirstOrDefault(x => x.Id == id);
            return quote;
        }
    }
}
