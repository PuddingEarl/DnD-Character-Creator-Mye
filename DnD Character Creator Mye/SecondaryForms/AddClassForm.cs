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
    partial class AddClassForm : Form
    {
        Character currentCharacter;

        public AddClassForm(Character currentCharacter)
        {
            this.currentCharacter = currentCharacter;
            InitializeComponent();
            List<Class> baseClasses = Class.returnBaseClasses();
            foreach(Class givenClass in baseClasses)
            {
                int levels = currentCharacter.findClassLevel(givenClass);
                int toBeDisplayed = levels;
                if(levels != givenClass.returnLevelCount())
                {
                    toBeDisplayed += 1;
                    listBoxClasses.Items.Add(givenClass.returnName() + " (" + toBeDisplayed.ToString() + ")");
                }
                else
                {
                    listBoxClasses.Items.Add(givenClass.returnName() + " (" + toBeDisplayed.ToString() + ") (MAX)");
                }
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string[] brokenLevel = listBoxClasses.SelectedItem.ToString().Split('(');
            string className = brokenLevel[0].Trim();
            Class nextClass = Class.findClass(className);
            if(nextClass != null)
            {

            }
        }
    }
}
