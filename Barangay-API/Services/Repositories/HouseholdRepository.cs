using Barangay_API.Data;
using Barangay_API.Entities;
using Barangay_API.Services.Interface;

namespace Barangay_API.Services.Repositories
{
    public class HouseholdRepository: Repository,IHouseholdRepository
    {
        public HouseholdRepository(BarangayContext context) : base(context)
        {
        }
        public async Task<List<Household>> List()
        {
           return _context.Households.ToList();
        }
    }
}
