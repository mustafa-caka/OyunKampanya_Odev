using OyunKampanya_Odev.Abstract;
using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Concrete
{
    public class GameManager : IGameService
    {
        public void Sale(Player player, Game game)
        {
            Console.WriteLine(player.FirstName +" Kişişi " + game.GameName + " Oyununu satın aldı");

        }
    }
}
