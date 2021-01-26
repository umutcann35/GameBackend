using GameBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    class PlayerManager
    {
        public void Add(Player player)
        {
            Console.WriteLine("Kullanici Eklendi"+player.FirstName+" "+player.LastName+" "+player.Id);
        }
        public void Delete(Player player)
        {
            Console.WriteLine("Kullanici Silindi:" + player.FirstName + " " + player.LastName + " " + player.Id);
        }
        public void UpDate(Player player)
        {
            Console.WriteLine("Kullanici Güncellendi!" + player.FirstName + " " + player.LastName + " " + player.Id);
        }
    }
}
