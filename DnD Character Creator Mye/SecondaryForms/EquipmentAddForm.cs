using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnD_Character_Creator_Mye.CharacterMechanics;

namespace DnD_Character_Creator_Mye.SecondaryForms
{
    partial class EquipmentAddForm : Form
    {
        Character currentCharacter;

        public EquipmentAddForm(Character currentCharacter)
        {
            InitializeComponent();
            this.currentCharacter = currentCharacter;
            foreach(Weapon weapon in Weapon.weapons)
            {
                listBoxEquipment.Items.Add(weapon.returnName());
            }
            foreach(Armour armour in Armour.armours)
            {
                listBoxEquipment.Items.Add(armour.returnName());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Weapon foundWeapon = Weapon.findWeapon(listBoxEquipment.SelectedItem.ToString());
            if(foundWeapon != null)
            {
                currentCharacter.addEquipment(foundWeapon);
                Close();
            }
            Armour foundArmour = Armour.findArmour(listBoxEquipment.SelectedItem.ToString());
            if(foundArmour != null)
            {
                currentCharacter.addEquipment(foundArmour);
                Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
