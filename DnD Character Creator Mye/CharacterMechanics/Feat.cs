using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Feat
    {
        string name;
        string description;
        List<Feat> requiredFeats;
        int[] attributeRequirements;
        int requiredLevel;
        bool requiresSpell;
        List<Skill> requiredSkills;
        int requiredBAB;

        bool selectsAttribute;
        bool selectsWeapon;
        bool selectsArmour;
        bool selectsShield;
        bool selectsSpell;
        bool selectsSkill;

        List<Feat> enabledBonusFeats;
        List<Skill> skillsBuffed;
        int skillBuffValue;
        List<Weapon> weaponsBuffed;
        int weaponHitBuff;
        int weaponDamageBuff;
        List<Armour> armourBuffed;
        int armourACBuff;
        int armourDexPenaltyReduction;
        int armourPenaltyReduction;
        List<Spell> spellsBuffed;
        int manaCostReduction;
        int damageBuff;


        static List<Feat> availableFeats = new List<Feat>();

        //*************************************************NOTE TO FUTURE ME*************************************************
        //Implement the trickiest feats first, and add the code needed to make them all work before you touch anything simple.
        //*************************************************NOTE FROM PAST ME*************************************************

        public Feat(string name, string description, List<Feat> requiredFeats, int[] attributeRequirements, int requiredLevel, bool requiresSpell, List<Skill> requiredSkills, int requiredBAB, bool selectsAttribute, bool selectsWeapon, bool selectsArmour, bool selectsShield, bool selectsSpell, List<Feat> enabledBonusFeats)
        {
            this.name = name;
            this.description = description;
            this.requiredFeats = requiredFeats;
            this.attributeRequirements = attributeRequirements;
            this.requiredLevel = requiredLevel;
            this.requiresSpell = requiresSpell;
            this.requiredSkills = requiredSkills;
            this.requiredBAB = requiredBAB;

            this.selectsAttribute = selectsAttribute;
            this.selectsWeapon = selectsWeapon;
            this.selectsArmour = selectsArmour;
            this.selectsShield = selectsShield;
            this.selectsSpell = selectsSpell;

            this.enabledBonusFeats = enabledBonusFeats;
        }

        public Feat(string data)
        {
            string[] splitData = data.Split('-');
            name = splitData[0];
            description = splitData[1];
        }

        public static List<Feat> getFeatList()
        {
            return availableFeats;
        }

        
    }
}
