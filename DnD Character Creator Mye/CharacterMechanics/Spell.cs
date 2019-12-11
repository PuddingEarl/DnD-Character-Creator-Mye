using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Spell
    {
        string name;
        List<string> tags;
        List<string> owningClasses;
        int[] attributeRequirements;
        int levelRequirements;
        List<string> spellRequirements;
        List<string> skillRequirements;

        int manaCost;
        int range;
        int areaSize;
        int areaType;
        int duration;
        int durationID;
        int durationMulitplier;
        int castingTime;
        string components;
        int savingThrowID;
        bool spellResistance;
        string targets;

        string effect;

        private Spell(string spellInformation)
        {
            string[] brokenInfo = spellInformation.Split('/');
            name = brokenInfo[0];
            string[] brokenTags = brokenInfo[1].Split(',');
            tags = new List<string>();
            foreach(string tag in brokenTags)
            {
                tags.Add(tag);
            }
            int.TryParse(brokenInfo[2], out manaCost);
            int.TryParse(brokenInfo[3], out range);
            int.TryParse(brokenInfo[4], out castingTime);
            components = brokenInfo[5];
            string[] attributes = brokenInfo[6].Split(',');
            int str;
            int.TryParse(attributes[0], out str);
            int dex;
            int.TryParse(attributes[1], out dex);
            int con;
            int.TryParse(attributes[2], out con);
            int intel;
            int.TryParse(attributes[3], out intel);
            int wis;
            int.TryParse(attributes[4], out wis);
            int cha;
            int.TryParse(attributes[5], out cha);
            attributeRequirements = new int[]{ str, dex, con, intel, wis, cha };
            string[] spellReqs = brokenInfo[7].Split(',');
            if(spellReqs[0] != "")
            {
                foreach(string req in spellReqs)
                {
                    spellRequirements.Add(req);
                }
            }
            string[] skillReqs = brokenInfo[8].Split(',');
            if (skillReqs[0] != "")
            {
                foreach (string req in skillReqs)
                {
                    skillRequirements.Add(req);
                }
            }
            targets = brokenInfo[9];
            int.TryParse(brokenInfo[10], out areaSize);
            int.TryParse(brokenInfo[11], out areaType);
            int.TryParse(brokenInfo[12], out duration);
            int.TryParse(brokenInfo[13], out durationID);
            int.TryParse(brokenInfo[14], out durationMulitplier);
            int.TryParse(brokenInfo[15], out savingThrowID);
            if (brokenInfo[16] == "true")
            {
                spellResistance = true;
            }
            else
            {
                spellResistance = false;
            }
            effect = brokenInfo[17];
            string[] classes = brokenInfo[18].Split(',');
            foreach(string name in classes)
            {
                owningClasses.Add(name);
            }
            int.TryParse(brokenInfo[19], out levelRequirements);
        }
    }
}
