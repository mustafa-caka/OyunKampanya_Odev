using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Abstract
{
    public interface IOfferService
    {
        void OfferAdd(Offer offer, Game game);
        void OfferUpdate(Offer offer, Game game);
        void OfferDelete(Offer offer, Game game);

    }
}
