using Barangay_API.Entities;
using Barangay_API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Barangay_API.Controllers
{
    [Route("api/household")]
    [ApiController]
    [Produces("application/json")]
    public class HouseholdController : Controller
    {
        private readonly IHouseholdRepository _householdRepository;
        public HouseholdController(IHouseholdRepository householdRepository)
        {
            _householdRepository = householdRepository;
        }
        [HttpGet]
        public async Task<List<Household>> List()
        {
           return await _householdRepository.List();
        }
    }
}
