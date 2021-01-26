using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    class CampingManager
    {
        public void CampaignAdd(Campaign campaign)
        {

            Console.WriteLine("FIRSAT İNDİRİMLERİ BASLADI!");
        }
        public void CampaignDeleted(Campaign campaign)
        {
            Console.WriteLine("KAMPANYA BULUNMAMAKTADIR");
        }
    }

    public class Campaign
    {
    }
}
