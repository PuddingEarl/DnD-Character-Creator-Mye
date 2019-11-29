﻿using System;
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
        ClassLevel currentlyChosenLevel;

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
            int currentLevel = currentCharacter.returnClassLevels().Count();
            if(currentLevel%2 == 1)
            {
                comboBoxAttribute.Items.Add("Strength");
                comboBoxAttribute.Items.Add("Dexterity");
                comboBoxAttribute.Items.Add("Constituion");
                comboBoxAttribute.Items.Add("Intelligence");
                comboBoxAttribute.Items.Add("Wisdom");
                comboBoxAttribute.Items.Add("Charisma");
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(currentlyChosenLevel != null)
            {
                if((currentlyChosenLevel.returnOptions().Count() != 0 && chosenFeat != null) || currentlyChosenLevel.returnOptions().Count() == 0)
                {
                    sendCharacterLevelUp(currentlyChosenLevel);
                    Close();
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] brokenLevel = listBoxClasses.SelectedItem.ToString().Split('(');
            if (brokenLevel.Count() == 2)
            {
                className = brokenLevel[0].Trim();

                Class nextClass = Class.findClass(className);
                if (nextClass != null)
                {
                    currentlyChosenLevel = nextClass.returnClassLevel(currentCharacter.findClassLevel(nextClass));
                    if(currentlyChosenLevel != null)
                    {
                        if(currentlyChosenLevel.returnOptions().Count() != 0)
                        {
                            comboBoxOptionalFeature.Items.Clear();
                            foreach(Feat feat in currentlyChosenLevel.returnOptions())
                            {
                                comboBoxOptionalFeature.Items.Add(feat.returnName());
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxOptionalFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentlyChosenLevel != null)
            {
                foreach (Feat feat in currentlyChosenLevel.returnOptions())
                {
                    if (feat.returnName() == comboBoxOptionalFeature.SelectedItem.ToString())
                    {
                        richTextBoxFeatureDescription.Text = feat.returnDescription();
                        chosenFeat = feat;
                    }
                }
            }
        }
    }
}
