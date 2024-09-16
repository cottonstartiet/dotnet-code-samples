using MultithreadedListAccess.Models;
using System.Collections.Concurrent;

namespace MultithreadedListAccess.Utils
{
    internal class Helper
    {
        internal static ConcurrentBag<Offer> GetOffersList()
        {
            ConcurrentBag<Offer> offers = [];

            for (int i = 0; i < 2000; i++)
            {
                offers.Add(new Offer()
                {
                    Id = i,
                    Name = $"Offer {i}",
                    IsAVailableForGamePass = i % 2 == 0,
                    HoursPlayed = i * 10
                });
            }

            return offers;
        }

        internal static ConcurrentBag<User> GetUsersList()
        {
            ConcurrentBag<User> users = [];

            for (int i = 0; i < 20000; i++)
            {
                users.Add(new User()
                {
                    Id = i,
                    Name = $"User {i}",
                    IsGamePassSubscriber = i % 2 == 0,
                    HoursPlayed = i * 2
                });
            }

            return users;
        }
    }
}
