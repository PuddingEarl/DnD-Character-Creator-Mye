﻿using System;
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

        public Skill(string name, int attribute)
        {
            this.name = name;
            associatedAttribute = attribute;
        }

        private string returnName()
        {
            return name;
        }
    }
}
