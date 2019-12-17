using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class WeaponQuality
    {
        string name;
        string description;
        bool focus;
        static public List<WeaponQuality> qualities = new List<WeaponQuality>();

        static public void initializeQualities(string values)
        {
            string[] splitValues = values.Split(';');
            foreach(string thing in splitValues)
            {
                string[] quality = thing.Split(':');
                if(quality.Count() == 2)
                {
                    qualities.Add(new WeaponQuality(quality[0], quality[1]));
                }
            }
        }

        private WeaponQuality(string name, string description)
        {
            this.name = name.Replace("\r\n", string.Empty);
            this.description = description;
        }

        public string returnName()
        {
            return name;
        }

        static public WeaponQuality findQuality(string name)
        {
            foreach(WeaponQuality quality in qualities)
            {
                if(quality.name == name)
                {
                    return quality;
                }
            }
            return null;
        }
    }
}
