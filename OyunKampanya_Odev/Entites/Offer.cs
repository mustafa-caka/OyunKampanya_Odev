using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Entites
{
    public class Offer
    {
        public int Id { get; set; }

        public string OfferName { get; set; }

        public string OfferDescription { get; set; }

        public float DiscountRate { get; set; }
    }
}
