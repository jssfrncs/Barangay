using Barangay_API.Data;

namespace Barangay_API.Services
{
    public class Repository
    {

        protected readonly BarangayContext _context;
        public Repository(BarangayContext context)
        {
            _context = context;
        }
    }
}
