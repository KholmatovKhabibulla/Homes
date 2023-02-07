using Homes.Api.Models.Foundation.Guests;
using Microsoft.EntityFrameworkCore;

namespace Homes.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        DbSet<Guest> Guests  { get; set; }
    }
}
