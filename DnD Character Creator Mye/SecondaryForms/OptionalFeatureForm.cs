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
    partial class OptionalFeatureForm : Form
    {
        List<Feat> choices;
        AddClassForm classForm;
        ClassLevel levelUp;

        public OptionalFeatureForm(List<Feat> choices, AddClassForm classForm, ClassLevel levelUp)
        {
            InitializeComponent();
            this.choices = choices;
            foreach(Feat feat in choices)
            {
                comboBoxNames.Items.Add(feat.returnName());
            }
            this.classForm = classForm;
            this.levelUp = levelUp;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool done = false;
            foreach(Feat feat in choices)
            {
                if(feat.returnName() == comboBoxNames.SelectedItem.ToString())
                {
                    classForm.setChosenFeat(feat);
                    classForm.sendCharacterLevelUp(levelUp);
                    done = true;
                }
            }
            if(done)
            {
                Close();
            }
        }

        private void comboBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Feat feat in choices)
            {
                if(feat.returnName() == comboBoxNames.SelectedItem.ToString())
                {
                    richTextBox1.Text = feat.returnDescription();
                }
            }
        }
    }
}
