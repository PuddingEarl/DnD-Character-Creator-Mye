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
    }
}
