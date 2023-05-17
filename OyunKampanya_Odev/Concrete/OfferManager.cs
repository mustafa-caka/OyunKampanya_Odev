using OyunKampanya_Odev.Abstract;
using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Concrete
{
    public class OfferManager : IOfferService
    {
        public void OfferAdd(Offer offer, Game game)
        {
            Console.WriteLine("Kampanya eklendi." + offer.OfferName);
        }

        public void OfferDelete(Offer offer, Game game)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void OfferUpdate(Offer offer, Game game)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

    }
}
