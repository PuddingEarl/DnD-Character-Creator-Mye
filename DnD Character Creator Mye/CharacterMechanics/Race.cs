using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Race
    {
        string name;
        //Order of attributes is Str, Dex, Con, Int, Wis, Cha
        int[] racialAttributeBonuses;
        int racialHP;
        int racialMana;
        List<Skill> bonusSkills;
        List<Feat> racialFeats;
        List<Spell> racialsSpells;

        static List<Race> races = new List<Race>();

        public static void prepareRace()
        {
            //*****************NOTE FOR FUTURE ME******************
            //Skills need to be added to races when the list is in
            //*****************NOTE FROM PAST ME******************

            races.Add(new Race("Human", new int[] { 0, 0, 0, 0, 0, 0 }, 48, 24));
            races[0].racialFeats.Add(new Feat("Human Racial Bonuses", "Grants the Human a permanent +1 to chosen attribute, as well as an additional feat at level 1.", null, null, 0, false, null, 0, true, false, false, false, false, Feat.getFeatList()));
            //This will need to be extended out in the future, when I start to implement Feats and learn all the things that are needed. Also when I work out how to cleanly add that skill bonus.
            races.Add(new Race("Dwarf", new int[] { 0, 0, 2, 0, 0, -1 }, 54, 18));
            races[1].racialFeats.Add(new Feat("Dwarf Racial Bonuses", "Dwarves have a +4 racial bonus on checks to resist being bullrushed or tripped while they are standing on the ground. Dwarves have an innate 5(15) points of Earth Resistance.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            races.Add(new Race("FireBorn", new int[] { 2, 0, 0, 0, 0, -1 }, 60, 18));
            races[2].racialFeats.Add(new Feat("Fireborn Racial Bonuses", "Fireborn have an innate 5 (15) points of Fire Resistance.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            //Add the Burning Hands spell when spells are added.
            races.Add(new Race("Frostborn", new int[] { 0, 0, -1, 0, 2, 0 }, 48, 30));
            races[3].racialFeats.Add(new Feat("Frostborn Racial Bonuses", "Frostborn have an innate 5 (15) points of Frost Resistance. Frostborn have a swim speed of 60 feet.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            //Add the Sleep spell when spells are added.
            races.Add(new Race("Galeborn", new int[] { 0, 2, 0, 0, -1, 0 }, 54, 24));
            races[4].racialFeats.Add(new Feat("Galeborn Racial Bonuses", "Galeborn have an innate 5 (15) points of Shock Resistance. Galeborn have a fly speed of 15 feet.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            //Ponder if Featherfall is the best spell Galeborn could have. Add add it anyway when spells are added. Never address this question again in the future but wonder about it constantly.
            races.Add(new Race("High Elf", new int[] { 0, 0, -1, 2, 0, 0 }, 42, 36));
            races[5].racialFeats.Add(new Feat("High Elf Racial Bonuses", "High elves gain a +1 to attribute modifiers while casting Arcane spells. If the spell has an[Arcane] tag, high elves gain a +2 to attribute modifiers instead.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            races.Add(new Race("Night Elf", new int[] { 0, 2, -1, 0, 0, 0 }, 42, 30));
            races[6].racialFeats.Add(new Feat("Night Elf Racial Bonuses", "Night elves gain a +10 circumstance bonus to Hide checks while they're in the shadows, and at night. Night elves gain the Track feat.", null, null, 0, false, null, 0, false, false, false, false, false, null));
            //Put track here when you add it to the program.
        }

        public Race(string name, int[] attributes, int HP, int mana)
        {
            this.name = name;
            racialAttributeBonuses = attributes;
            racialHP = HP;
            racialMana = mana;
            racialFeats = new List<Feat>();
        }

        public static List<Race> getRaces()
        {
            return races;
        }

        public static Race findRace(string name)
        {
            foreach(Race race in races)
            {
                if(race.name == name)
                {
                    return race;
                }
            }
            return null;
        }

        public string getName()
        {
            return name;
        }

        public int[] getAttributeBonuses()
        {
            return racialAttributeBonuses;
        }

        public int getAttributeBonus(int attributeID)
        {
            if(attributeID <= 5 && attributeID >= 0)
            {
                return racialAttributeBonuses[attributeID];
            }
            else
            {
                return -10;
            }
        }
    }
}
