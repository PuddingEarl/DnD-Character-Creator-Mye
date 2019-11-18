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

        private string returnName()
        {
            return name;
        }
    }
}
