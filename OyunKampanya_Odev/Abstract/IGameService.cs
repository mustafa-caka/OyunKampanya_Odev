using OyunKampanya_Odev.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunKampanya_Odev.Abstract
{
    public interface IGameService
    {
        void Sale(Player player, Game game);
    }
}
