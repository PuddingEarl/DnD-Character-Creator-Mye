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
        int manaPenalty;

        static public List<Armour> armours;

        static public void prepareArmours(string armourInformation)
        {
            armours = new List<Armour>();
            string[] brokenInformation = armourInformation.Split(';');
            foreach(string information in brokenInformation)
            {
                int type;
                int ACBonus;
                int maxDexBonus;
                int armourPenalty;
                int manaPenalty;
                string[] split = information.Split('/');
                int.TryParse(split[1], out type);
                int.TryParse(split[2], out ACBonus);
                int.TryParse(split[3], out maxDexBonus);
                int.TryParse(split[4], out armourPenalty);
                int.TryParse(split[5], out manaPenalty);
                armours.Add(new Armour(split[0], type, ACBonus, maxDexBonus, armourPenalty, manaPenalty));
            }
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
    }
}
