using WebAPI.Data.Entity;

namespace WebAPI.Data.Repository
{
    public class QuoteRepository
    {
        private readonly DemoApiContext _context;

        public QuoteRepository(DemoApiContext context)
        {
            _context = context;
        }
        public List<Quote> GetQuotes()
        {   
            return _context.Quotes.ToList();
        }
    }
}
