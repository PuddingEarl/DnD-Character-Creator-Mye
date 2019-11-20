using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Skill
    {
        static List<Skill> skills = new List<Skill>();
        private string name;
        private int value;
        private int associatedAttribute;
        private bool classSkill;

        static public void initializeSkills()
        {
            skills.Add(new Skill("Appraise", 3));
            skills.Add(new Skill("Balance", 1));
            skills.Add(new Skill("Bluff", 5));
            skills.Add(new Skill("Climb", 0));
            skills.Add(new Skill("Concentration", 2));
            skills.Add(new Skill("Craft", 3));
            skills.Add(new Skill("Decipher Script", 3));
            skills.Add(new Skill("Diplomacy", 5));
            skills.Add(new Skill("Disable Device", 3));
            skills.Add(new Skill("Disguise", 5));
            skills.Add(new Skill("Escape Artist", 1));
            skills.Add(new Skill("Forgery", 3));
            skills.Add(new Skill("Gather Info", 5));
            skills.Add(new Skill("Handle Animal", 5));
            skills.Add(new Skill("Heal", 4));
            skills.Add(new Skill("Intimidate", 5));
            skills.Add(new Skill("Jump", 0));
            skills.Add(new Skill("Knowledge:Arcana", 3));
            skills.Add(new Skill("Knowledge:Architecture and Engineering", 3));
            skills.Add(new Skill("Knowledge:Geography", 3));
            skills.Add(new Skill("Knowledge:History", 3));
            skills.Add(new Skill("Knowledge:Local", 3));
            skills.Add(new Skill("Knowledge:Military", 3));
            skills.Add(new Skill("Knowledge:Nature", 3));
            skills.Add(new Skill("Knowledge:Nobility", 3));
            skills.Add(new Skill("Knowledge:Religion", 3));
            skills.Add(new Skill("Listen", 4));
            skills.Add(new Skill("Move Silently", 1));
            skills.Add(new Skill("Open Lock", 1));
            skills.Add(new Skill("Perform", 5));
            skills.Add(new Skill("Profession", 4));
            skills.Add(new Skill("Ride", 1));
            skills.Add(new Skill("Search", 3));
            skills.Add(new Skill("Sense Motive", 4));
            skills.Add(new Skill("Sleight of Hand", 1));
            skills.Add(new Skill("Spellcraft", 3));
            skills.Add(new Skill("Spot", 4));
            skills.Add(new Skill("Survival", 4));
            skills.Add(new Skill("Swim", 0));
            skills.Add(new Skill("Tumble", 1));
            skills.Add(new Skill("Use Magic Device", 5));
            skills.Add(new Skill("Use Rope", 1));
        }

        static public List<Skill> getSkills()
        {
            return skills;
        }

        static public Skill findSkills(string name)
        {
            foreach(Skill skill in skills)
            {
                if(skill.returnName() == name)
                {
                    return skill;
                }
            }
            return null;
        }

        static public Skill findSkills(string name, List<Skill> skills)
        {
            foreach (Skill skill in skills)
            {
                if (skill.returnName() == name)
                {
                    return skill;
                }
            }
            return null;
        }

        static public List<Skill> fuseList(List<Skill> list1, List<Skill> list2)
        {
            List<Skill> toBeReturned = new List<Skill>();
            foreach(Skill skill in list1)
            {
                toBeReturned.Add(skill);
            }
            foreach(Skill skill in list2)
            {
                if(findSkills(skill.returnName(), toBeReturned) == null)
                {
                    toBeReturned.Add(skill);
                }
            }

            return toBeReturned;

        }

        public Skill(string name, int attribute)
        {
            this.name = name;
            associatedAttribute = attribute;
        }

        public string returnName()
        {
            return name;
        }

        public string returnSkillInput(bool isClass)
        {
            string toBeReturned = null;
            if (isClass == true || isClass == false && classSkill == true)
            {
                string attribute = null;
                switch (associatedAttribute)
                {
                    case 0:
                        attribute = "(STR)";
                        break;
                    case 1:
                        attribute = "(DEX)";
                        break;
                    case 2:
                        attribute = "(CON)";
                        break;
                    case 3:
                        attribute = "(INT)";
                        break;
                    case 4:
                        attribute = "(WIS)";
                        break;
                    case 5:
                        attribute = "(CHA)";
                        break;
                }
                toBeReturned = name + " " + attribute + ": " + value.ToString();
            }
            return toBeReturned;
        }

        public void setClassSkill(bool newValue)
        {
            classSkill = newValue;
        }

        public bool getClassSkill()
        {
            return classSkill;
        }
    }
}
