using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Abstract
{
   public interface IPlayerManager
    {
        void Add(Player player);
        void Delete(Player player);
        string Update(Player player, Player newplayer);
    }

    public class Player
    {
    }
}
