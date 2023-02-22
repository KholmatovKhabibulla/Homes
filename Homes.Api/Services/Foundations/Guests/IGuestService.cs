using Homes.Api.Models.Foundation.Guests;
using System.Threading.Tasks;

namespace Homes.Api.Services.Foundations.Guests
{
    public interface IGuestService
    {
        ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
