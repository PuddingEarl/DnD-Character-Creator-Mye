using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Character
    {
        string name;
        List<ClassLevel> takenLevels = new List<ClassLevel>();
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;
        List<Skill> skills;
        int hp;
        int mana;
        Race race;
        int manaRegen;
        int AC;
        int BAB;
        int meleeAttack;
        int rangedAttack;
        int fortSave;
        int refSave;
        int willSave;
        List<Spell> knownSpells;
        List<Feat> ownedFeats;
        List<Equipment> ownedEquipment;

        int pointBuyTotal;
        int pointBuyCurrent;

        public Character(int pointBuyValue, string name)
        {
            strength = 10;
            dexterity = 10;
            constitution = 10;
            intelligence = 10;
            wisdom = 10;
            charisma = 10;
            pointBuyTotal = pointBuyValue;
            this.name = name;
        }

        public int[] getAttributes()
        {
            return new int[] { strength, dexterity, constitution, intelligence, wisdom, charisma };
        }

        public void setAttributes(int[] values)
        {
            strength = values[0];
            dexterity = values[1];
            constitution = values[2];
            intelligence = values[3];
            wisdom = values[4];
            charisma = values[5];
        }

        public void spendPoint(int pointsSpent)
        {
            pointBuyCurrent += pointsSpent;
        }

        public int checkPoint()
        {
            return pointBuyCurrent;
        }

        public int checkPointCap()
        {
            return pointBuyTotal;
        }

        public Race getRace()
        {
            return race;
        }

        public void setRace(Race race)
        {
            this.race = race;
        }
    }
}
