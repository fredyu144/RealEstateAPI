using RealEstateAPI.Models;
using System.Threading.Tasks;

namespace RealEstateAPI.Services
{
    public interface IRealEstateAPIServices
    {
        public Task<GetAddressResponse> GetAddressAsync(string address);
    }
}
