using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Weapon : Equipment
    {
        public enum weaponTypes { Dagger, OHSword, THSword, OHMace, THMace, OHAxe, THAxe, Staff, Polearm, Bow, Crossbow, Thrown, Entangling, Wand };
        int type;
        int diceNumber;
        int diceValue;
        int critValue;
        int critRange;
        int range;
        List<WeaponQuality> weaponQualities;
    }
}
