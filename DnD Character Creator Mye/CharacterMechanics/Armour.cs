using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Armour : Equipment
    {
        public enum armourTypes { Cloth = 100, Leather = 101, Mail = 102, Plate = 103, Shield=104 };
        int type;
        int ACBonus;
        int maxDexBonus;
        int armourPenalty;
        int manaPenalty;

        static public List<Armour> armours;

        static public void prepareArmours(string armourInformation)
        {
            armours = new List<Armour>();
            string[] brokenInformation = armourInformation.Split(';');
            foreach(string information in brokenInformation)
            {
                string[] split = information.Split('/');
                if (split.Count() == 6)
                {
                    int type;
                    int ACBonus;
                    int maxDexBonus;
                    int armourPenalty;
                    int manaPenalty;
                    int.TryParse(split[1], out type);
                    int.TryParse(split[2], out ACBonus);
                    int.TryParse(split[3], out maxDexBonus);
                    int.TryParse(split[4], out armourPenalty);
                    int.TryParse(split[5], out manaPenalty);
                    armours.Add(new Armour(split[0], type, ACBonus, maxDexBonus, armourPenalty, manaPenalty));
                }
            }
        }

        static public Armour findArmour(string name)
        {
            foreach(Armour armour in armours)
            {
                if(armour.returnName() == name)
                {
                    return armour;
                }
            }
            return null;
        }

        private Armour(string name, int type, int ACBonus, int maxDexBonus, int armourPenalty, int manaPenalty)
        {
            setName(name);
            this.type = type;
            this.ACBonus = ACBonus;
            this.maxDexBonus = maxDexBonus;
            this.armourPenalty = armourPenalty;
            this.manaPenalty = manaPenalty;
        }

        public bool compareArmour(Armour toBeCompared, int dexBonus)
        {
            int value1 = returnValue(dexBonus);
            int value2 = toBeCompared.returnValue(dexBonus);
            if(value1 > value2)
            {
                return true;
            }
            else if(value2 > value1)
            {
                return false;
            }
            else if(toBeCompared.armourPenalty < armourPenalty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int returnValue(int dexBonus)
        {
            if (dexBonus > maxDexBonus)
            {
                return ACBonus + maxDexBonus;
            }
            else
            {
                return ACBonus + dexBonus;
            }
        }

        public int returnFlatBonus()
        {
            return ACBonus;
        }

        public int returnArmourShieldValue(int dexBonus, Armour shield)
        {
            int bonusCap;
            if(shield.maxDexBonus >= maxDexBonus)
            {
                bonusCap = maxDexBonus;
            }
            else
            {
                bonusCap = shield.maxDexBonus;
            }
            if (dexBonus > maxDexBonus)
            {
                return ACBonus + maxDexBonus + shield.ACBonus;
            }
            else
            {
                return ACBonus + dexBonus + shield.ACBonus;
            }

        }

        public int returnType()
        {
            return type;
        }
    }
}
