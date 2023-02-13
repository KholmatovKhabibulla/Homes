using EFxceptions;
using Homes.Api.Models.Foundation.Guests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Homes.Api.Brokers.Storages
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString =
                this.configuration.GetConnectionString(name: "BloggingDatabase");

            optionsBuilder.UseSqlServer(connectionString);
        }
        public override void Dispose() { }

        public ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
            throw new System.NotImplementedException();
        }
    }
}
