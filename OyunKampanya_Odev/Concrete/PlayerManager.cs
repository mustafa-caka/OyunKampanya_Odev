using OyunKampanya_Odev.Abstract;
using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private readonly IRealPlayerCheck realPlayerCheck;
        public PlayerManager(IRealPlayerCheck realPlayerCheck)
        {

            this.realPlayerCheck = realPlayerCheck;

        }

        public void Add(Player player)
        {
            if (realPlayerCheck.Check(player))
            {
                Console.WriteLine("Oyuncu kaydedildi." + player.FirstName);
            }
            else
            {
                Console.WriteLine("Başarısız. Kaydedilmedi.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Oyuncu Güncellendi.");
        }
    }
}
