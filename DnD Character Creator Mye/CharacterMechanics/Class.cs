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
            string[] levels = brokenString[8].Split('#');
            List<ClassLevel> classLevels = new List<ClassLevel>();
            foreach(string level in levels)
            {
                classLevels.Add(new ClassLevel(level));
            }

            toBeReturned = new Class(name, classLevels, skillGain, hitPointGainDice, hitPointGainStatic, manaGainDice, manaGainStatic, skillList, proficiency);
            foreach(ClassLevel level in classLevels)
            {

            }
            return toBeReturned;
        }

        static public void addBaseClass(Class givenClass)
        {
            baseClasses.Add(givenClass);
        }


        public Class(string name, List<ClassLevel> levels, int skillGain, int hitPointGainDice, int hitPointGainStatic, int manaGainDice, int manaGainStatic, List<Skill> skillList, List<int> proficiencyIDs)
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
        }

        public List<Skill> returnSkills()
        {
            return skillList;
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
    }
}
