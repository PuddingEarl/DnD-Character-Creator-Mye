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

        public int getStrength()
        {
            return strength;
        }

        public void setStrength(int value)
        {
            strength = value;
        }

        public int getDexterity()
        {
            return dexterity;
        }

        public void setDexterity(int value)
        {
            dexterity = value;
        }

        public int getConstitution()
        {
            return constitution;
        }

        public void setConstitution(int value)
        {
            constitution = value;
        }

        public int getIntelligence()
        {
            return intelligence;
        }

        public void setIntelligence(int value)
        {
            intelligence = value;
        }

        public int getWisdom()
        {
            return wisdom;
        }

        public void setWisdom(int value)
        {
            wisdom = value;
        }

        public int getCharisma()
        {
            return charisma;
        }

        public void setCharisma(int value)
        {
            charisma = value;
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
    }
}
