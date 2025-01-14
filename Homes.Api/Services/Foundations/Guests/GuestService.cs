﻿using Homes.Api.Brokers.Storages;
using Homes.Api.Models.Foundation.Guests;
using System;
using System.Threading.Tasks;

namespace Homes.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;

        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
            throw new NotImplementedException();
    }
}
