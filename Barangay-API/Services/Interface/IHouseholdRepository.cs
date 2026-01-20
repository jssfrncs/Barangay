using Barangay_API.Entities;

namespace Barangay_API.Services.Interface
{
    public interface IHouseholdRepository
    {
        Task<List<Household>> List();
    }
}
