using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Armour : Equipment
    {
        public enum armourTypes { Cloth, Leather, Mail, Plate };
        int type;
        int ACBonus;
        int maxDexBonus;
        int armourPenalty;
    }
}
