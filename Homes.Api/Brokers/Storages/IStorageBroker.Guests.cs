using Homes.Api.Models.Foundation.Guests;
using System.Threading.Tasks;

namespace Homes.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        public ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
