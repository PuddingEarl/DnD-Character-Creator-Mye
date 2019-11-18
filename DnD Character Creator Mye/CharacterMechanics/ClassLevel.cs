using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class ClassLevel
    {
        int level;
        int babBonus;
        int fortSave;
        int refSave;
        int willSave;
        List<Feat> features;


        public ClassLevel(string data)
        {
            string[] brokenData = data.Split(',');
            int level;
            int.TryParse(brokenData[0], out level);
            this.level = level;
            int babBonus;
            int.TryParse(brokenData[1], out babBonus);
            this.babBonus = babBonus;
            int fortSave;
            int refSave;
            int willSave;
            int.TryParse(brokenData[2], out fortSave);
            int.TryParse(brokenData[3], out refSave);
            int.TryParse(brokenData[4], out willSave);
            this.fortSave = fortSave;
            this.refSave = refSave;
            this.willSave = willSave;

            features = new List<Feat>();
            foreach(string x in brokenData)
            {
                features.Add(new Feat(x));
            }

        }

    }
}
