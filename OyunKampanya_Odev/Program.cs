using OyunKampanya_Odev.Concrete;
using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Id = 1,
                FirstName = "Mustafa",
                LastName = "CAKA",
                NationalNumber = 123456789,
                BirthYear = 1992,

            };

            Game game = new Game()
            {
                Id = 1,
                GameName = "FİFA",
                GamePrice = 100,

            };

            Offer offer = new Offer()
            {
                Id = 1,
                OfferName = "Sezon Sonu İndirimi",
                OfferDescription = "Bu Fırsat kaçmaz",
                DiscountRate = 80,

            };

            PlayerManager playerManager = new PlayerManager(new RealCheckPlayerManager());
            playerManager.Add(player);
            playerManager.Delete(player);
            playerManager.Update(player);

            GameManager gameManager = new GameManager();
            gameManager.Sale(player, game);

            OfferManager offerManager = new OfferManager();

            offerManager.OfferAdd(offer, game);
            offerManager.OfferDelete(offer, game);
            offerManager.OfferUpdate(offer, game);

            Console.ReadLine();
        }


    }
}
