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
        int racialStrengthBonus;
        int racialDexterityBonus;
        int racialConstitutionBonus;
        int racialIntelligenceBonus;
        int racialWisdomBonus;
        int racialCharismaBonus;
        int racialHP;
        int racialMana;
        List<Skill> bonusSkills;
        List<Feat> racialFeats;
    }
}
