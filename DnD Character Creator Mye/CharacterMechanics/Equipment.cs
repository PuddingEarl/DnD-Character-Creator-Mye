﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Equipment
    {
        string name;
        int value;

        public string returnName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

    }
}
