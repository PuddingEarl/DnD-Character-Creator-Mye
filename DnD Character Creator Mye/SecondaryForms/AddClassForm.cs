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
        Feat chosenFeat;
        string className;

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
            if(brokenLevel.Count() == 2)
            {
                className = brokenLevel[0].Trim();

                Class nextClass = Class.findClass(className);
                if (nextClass != null)
                {
                    ClassLevel addedLevel = nextClass.returnClassLevel(currentCharacter.findClassLevel(nextClass));
                    if (addedLevel != null)
                    {
                        if(addedLevel.returnOptions().Count() != 0)
                        {
                            OptionalFeatureForm newForm = new OptionalFeatureForm(addedLevel.returnOptions(), this, addedLevel);
                            newForm.Show();
                        }
                        else
                        {
                            sendCharacterLevelUp(addedLevel);
                        }
                    }
                }
            }
        }

        public void setChosenFeat(Feat feat)
        {
            chosenFeat = feat;
        }

        public void sendCharacterLevelUp(ClassLevel level)
        {
            if(chosenFeat == null)
            {
                currentCharacter.addClassLevel(level);
                Close();
            }
            else
            {
                currentCharacter.addClassLevel(level, chosenFeat);
                Close();
            }
        }
    }
}
