using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    class CharacterStats
    {
        int Strength { get; set; }
        int Health { get; set; }
        int Energy { get; set; }

        int FarmingSkill { get; set; }
        int FishingSkill { get; set; }
        int CookingSkill { get; set; }

        public CharacterStats()
        {

        }
    }
}
