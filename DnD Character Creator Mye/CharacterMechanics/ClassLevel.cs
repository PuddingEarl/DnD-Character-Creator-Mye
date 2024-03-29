﻿using System;
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
        List<Feat> optionFeatures;
        Class owningClass;
        int HPGain;
        int manaGain;

        public ClassLevel(string data)
        {
            string[] brokenData = data.Split('=');
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

            string[] brokenFeatures = brokenData[5].Split('+');
            features = new List<Feat>();
            foreach(string x in brokenFeatures)
            {
                if(x != " ")
                {
                    features.Add(new Feat(x));
                }
            }
            optionFeatures = new List<Feat>();
            string[] brokenOptions = brokenData[6].Split('+');
            foreach(string x in brokenOptions)
            {
                if (x != " ")
                {
                    optionFeatures.Add(new Feat(x));
                }
            }

        }

        public void setClass(Class owningClass)
        {
            this.owningClass = owningClass;
            HPGain = owningClass.rollHP();
            manaGain = owningClass.rollMana();
        }

        public Class returnClass()
        {
            return owningClass;
        }

        public int returnLevel()
        {
            return level;
        }

        public int returnBab()
        {
            return babBonus;
        }

        public int returnFort()
        {
            return fortSave;
        }

        public int returnRef()
        {
            return refSave;
        }

        public int returnWill()
        {
            return willSave;
        }

        public List<Feat> returnFeats()
        {
            return features;
        }

        public List<Feat> returnOptions()
        {
            return optionFeatures;
        }

        public int returnHP()
        {
            return HPGain;
        }

        public int returnMana()
        {
            return manaGain;
        }

    }
}
