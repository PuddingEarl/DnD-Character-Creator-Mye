using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Class
    {
        string name;
        List<ClassLevel> levels;
        int skillGain;
        int hitPointGainDice;
        int hitPointGainStatic;
        int manaGainDice;
        int manaGainStatic;
        List<Skill> skillList;
        List<int> proficiencyIDs;
        List<Spell> learnableSpells;
        int level1Spells;
        int levelUpSpellGain;

        static List<Class> baseClasses = new List<Class>();
        static List<Class> prestigeClasses = new List<Class>();


        //Unpack Class builds classes out of .txt files.
        static public Class unpackClass(string line)
        {
            Class toBeReturned = null;
            string[] brokenString = line.Split('/');
            string name = brokenString[0];
            string[] skills = brokenString[1].Split(',');
            List<Skill> skillList = new List<Skill>();
            foreach(string skillName in skills)
            {
                Skill relevantSkill = Skill.findSkills(skillName);
                if(relevantSkill != null)
                {
                    skillList.Add(relevantSkill);
                }
            }
            int skillGain;
            int.TryParse(brokenString[2], out skillGain);
            int hitPointGainDice;
            int hitPointGainStatic;
            int.TryParse(brokenString[3], out hitPointGainDice);
            int.TryParse(brokenString[4], out hitPointGainStatic);
            int manaGainDice;
            int manaGainStatic;
            int.TryParse(brokenString[5], out manaGainDice);
            int.TryParse(brokenString[6], out manaGainStatic);
            List<int> proficiency = new List<int>();
            string[] IDs = brokenString[7].Split(',');
            foreach(string ID in IDs)
            {
                int temp;
                if(int.TryParse(ID, out temp))
                {
                    proficiency.Add(temp);
                }
            }
            int level1Spells;
            int spellGain;
            int.TryParse(brokenString[8], out level1Spells);
            int.TryParse(brokenString[9], out spellGain);
            string[] levels = brokenString[10].Split('#');
            List<ClassLevel> classLevels = new List<ClassLevel>();
            foreach(string level in levels)
            {
                classLevels.Add(new ClassLevel(level));
            }

            toBeReturned = new Class(name, classLevels, skillGain, hitPointGainDice, hitPointGainStatic, manaGainDice, manaGainStatic, skillList, proficiency, level1Spells, spellGain);
            foreach(ClassLevel level in classLevels)
            {
                level.setClass(toBeReturned);
            }
            return toBeReturned;
        }

        static public void addBaseClass(Class givenClass)
        {
            baseClasses.Add(givenClass);
        }


        public Class(string name, List<ClassLevel> levels, int skillGain, int hitPointGainDice, int hitPointGainStatic, int manaGainDice, int manaGainStatic, List<Skill> skillList, List<int> proficiencyIDs, int level1Spells, int spellGain)
        {
            this.name = name;
            this.levels = levels;
            this.skillGain = skillGain;
            this.skillList = skillList;
            this.hitPointGainDice = hitPointGainDice;
            this.hitPointGainStatic = hitPointGainStatic;
            this.manaGainDice = manaGainDice;
            this.manaGainStatic = manaGainStatic;
            this.proficiencyIDs = proficiencyIDs;
            this.level1Spells = level1Spells;
            levelUpSpellGain = spellGain;
        }

        public List<Skill> returnSkills()
        {
            return skillList;
        }

        public List<int> returnProficiency()
        {
            return proficiencyIDs;
        }

        public string returnName()
        {
            return name;
        }

        static public Class findClass(string name)
        {
            foreach(Class searchedClass in baseClasses)
            {
                if(searchedClass.name == name)
                {
                    return searchedClass;
                }
            }
            foreach(Class searchedClass in prestigeClasses)
            {
                if (searchedClass.name == name)
                {
                    return searchedClass;
                }
            }
            return null;
        }

        public ClassLevel returnClassLevel(int levelNumber)
        {
            if(levelNumber < levels.Count())
            {
                return levels[levelNumber];
            }
            return null;
        }

        public int returnLevelCount()
        {
            return levels.Count();
        }

        static public List<Class> returnBaseClasses()
        {
            return baseClasses;
        }
        
        static public List<Class> returnPrestigeClasses()
        {
            return prestigeClasses;
        }

        public int rollHP()
        {
            int toBeReturned;
            toBeReturned = hitPointGainStatic;
            toBeReturned += Form1.rand.Next(1, hitPointGainDice + 1);
            toBeReturned += Form1.rand.Next(1, hitPointGainDice + 1);
            return toBeReturned;
        }

        public string returnHPValue()
        {
            return "2d" + hitPointGainDice.ToString() + " + " + hitPointGainStatic.ToString(); 
        }

        public int rollMana()
        {
            int toBeReturned = manaGainStatic;
            toBeReturned += Form1.rand.Next(1, manaGainDice + 1);
            return toBeReturned;
        }

        public string returnManaValue()
        {
            return "1d" + manaGainDice.ToString() + " + " + manaGainStatic.ToString();
        }

        public int returnSkillGain()
        {
            return skillGain;
        }
    }
}
