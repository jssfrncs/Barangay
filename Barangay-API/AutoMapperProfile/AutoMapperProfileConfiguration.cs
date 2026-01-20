using AutoMapper;
using System.Data;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Barangay_API.AutoMapperProfile
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("My Profile")
        {
        }

        private AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {


        }
    }
}
