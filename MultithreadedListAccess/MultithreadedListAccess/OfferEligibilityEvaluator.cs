using MultithreadedListAccess.Models;
using MultithreadedListAccess.Utils;
using System.Collections.Concurrent;

namespace MultithreadedListAccess
{
    internal class OfferEligibilityEvaluator
    {
        private readonly ConcurrentBag<Offer> Offers;
        private int count = 0;

        public OfferEligibilityEvaluator()
        {
            Offers = Helper.GetOffersList();
        }

        public bool Evaluate(User user)
        {
            if (count % 100 == 0)
            {
                Offers.Clear();

                foreach (Offer offer in Helper.GetOffersList())
                {
                    Offers.Add(offer);
                }

                count++;
            }

            foreach (Offer offer in Offers)
            {
                if (user.IsGamePassSubscriber ||
                    (user.HoursPlayed > offer.HoursPlayed && offer.IsAVailableForGamePass))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
