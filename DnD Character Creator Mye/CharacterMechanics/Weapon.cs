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
        string name;
        List<WeaponQuality> weaponQualities;

        static public List<Weapon> weapons = new List<Weapon>();

        static public void initializeWeapons(string weaponInformation)
        {
            weapons = new List<Weapon>();
            string[] brokenInformation = weaponInformation.Split(';');
            foreach(string info in brokenInformation)
            {
                string[] splitWeapon = info.Split('/');
                if(splitWeapon.Count() == 7)
                {
                    int type;
                    int.TryParse(splitWeapon[1], out type);
                    int critValue;
                    int.TryParse(splitWeapon[3], out critValue);
                    int critRange;
                    int.TryParse(splitWeapon[4], out critRange);
                    int range;
                    int.TryParse(splitWeapon[5], out range);
                    weapons.Add(new Weapon(splitWeapon[0], type, splitWeapon[2], critValue, critRange, range, splitWeapon[6]));
                }
            }
        }

        private Weapon(string name, int type, string dice, int critValue, int critRange, int range, string qualities)
        {
            this.name = name;
            this.type = type;
            string[] brokenDice = dice.Split('d');
            int.TryParse(brokenDice[0], out diceNumber);
            int.TryParse(brokenDice[1], out diceValue);
            this.critValue = critValue;
            this.critRange = critRange;
            this.range = range;
            string[] brokenQualities = qualities.Split(',');
            weaponQualities = new List<WeaponQuality>();
            foreach(string quality in brokenQualities)
            {
                WeaponQuality toBeAdded = WeaponQuality.findQuality(quality);
                if(toBeAdded != null)
                {
                    weaponQualities.Add(toBeAdded);
                }
            }
        }
    }
}
