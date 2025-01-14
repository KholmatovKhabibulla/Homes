﻿using Homes.Api.Brokers.Storages;
using Homes.Api.Services.Foundations.Guests;
using Moq;

namespace Homes.Api.Tests.Unit.Services.Foundations.Guests
{
    public class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IGuestService guestService;

        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.guestService = new GuestService(storageBroker: this.storageBrokerMock.Object);
        }
    }
}
