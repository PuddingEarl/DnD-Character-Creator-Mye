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
using DnD_Character_Creator_Mye.SecondaryForms;

namespace DnD_Character_Creator_Mye
{
    public partial class Form1 : Form
    {
        Character currentCharacter;

        public Form1()
        {
            InitializeComponent();
            NewCharacterForm.form = this;
        }

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCharacterForm characterForm = new NewCharacterForm();
            characterForm.Show();
        }

        public void createCharacter(int points, string name)
        {
            currentCharacter = new Character(points, name);
            textBoxName.Text = name;

            textBoxStr.Text = "10";
            textBoxStrBonus.Text = "+0";
            textBoxStrPB.Text = "0";

            textBoxDex.Text = "10";
            textBoxDexBonus.Text = "+0";
            textBoxDexPB.Text = "0";

            textBoxCon.Text = "10";
            textBoxConBonus.Text = "+0";
            textBoxConPB.Text = "0";

            textBoxInt.Text = "10";
            textBoxIntBonus.Text = "+0";
            textBoxIntPB.Text = "0";

            textBoxWis.Text = "10";
            textBoxWisBonus.Text = "+0";
            textBoxWisPB.Text = "0";

            textBoxCha.Text = "10";
            textBoxChaBonus.Text = "+0";
            textBoxChaPB.Text = "0";

            textBoxPoints.Text = points.ToString();

            Race.prepareRace();
            List<Race> races = Race.getRaces();
            foreach (Race race in races)
            {
                comboBoxRace.Items.Add(race.getName());
            }
        }

        #region Attributes


        //This method checks if the new value for an attribute is valid, and if so returns the total point cost of the next attribute value.
        private int checkPointsSpent(int newValue)
        {
            switch (newValue)
            {
                case 10:
                    return 0;
                case 11:
                    return 1;
                case 12:
                    return 2;
                case 13:
                    return 3;
                case 14:
                    return 4;
                case 15:
                    return 6;
                case 16:
                    return 8;
                case 17:
                    return 11;
                case 18:
                    return 14;
                case 19:
                    return 18;
                case 20:
                    return 22;

            }

            return 1000;
        }

        //This method changes an attribute for point buy purposes. It should only be run out of the +/- buttons.
        private void changeAttributes(int attributeID, int changeValue)
        {
            int[] currentValues = currentCharacter.getAttributes();
            int previousPointsValue = checkPointsSpent(currentValues[attributeID]);
            int pointsSpent = checkPointsSpent(currentValues[attributeID] + changeValue);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentValues[attributeID] += changeValue;
                currentCharacter.setAttributes(currentValues);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                refreshAttributes();
            }

        }

        //This method updates the displayed attributes to include racial modifiers. It is to be applied after every change made to the base attributes. When races are added, a consideration for sub 10 attributes should be made but that's a later me problem.
        private void refreshAttributes()
        {
            int[] currentValues = currentCharacter.getAttributes();
            int[] racialBonuses = currentCharacter.getRace().getAttributeBonuses();
            int str = currentValues[0] + racialBonuses[0];
            textBoxStr.Text = str.ToString();
            textBoxStrBonus.Text = "+" + checkBonusValue(str).ToString();
            textBoxStrPB.Text = checkPointsSpent(str).ToString();

            int dex = currentValues[1] + racialBonuses[1];
            textBoxDex.Text = dex.ToString();
            textBoxDexBonus.Text = "+" + checkBonusValue(dex).ToString();
            textBoxDexPB.Text = checkPointsSpent(dex).ToString();

            int con = currentValues[2] + racialBonuses[2];
            textBoxCon.Text = con.ToString();
            textBoxConBonus.Text = "+" + checkBonusValue(con).ToString();
            textBoxConPB.Text = checkPointsSpent(con).ToString();

            int intel = currentValues[3] + racialBonuses[3];
            textBoxInt.Text = intel.ToString();
            textBoxIntBonus.Text = "+" + checkBonusValue(intel).ToString();
            textBoxIntPB.Text = checkPointsSpent(intel).ToString();

            int wis = currentValues[4] + racialBonuses[4];
            textBoxWis.Text = wis.ToString();
            textBoxWisBonus.Text = "+" + checkBonusValue(wis).ToString();
            textBoxWisPB.Text = checkPointsSpent(wis).ToString();

            int cha = currentValues[5] + racialBonuses[5];
            textBoxCha.Text = cha.ToString();
            textBoxChaBonus.Text = "+" + checkBonusValue(cha).ToString();
            textBoxChaPB.Text = checkPointsSpent(cha).ToString();

            textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();

        }

        //This method checks the attribute bonus
        private int checkBonusValue(int value)
        {
            int toBeReturned;
            toBeReturned = (value - 10) / 2;
            return toBeReturned;
        }


        private void buttonPlusStrength_Click(object sender, EventArgs e)
        {
            changeAttributes(0, 1);
        }

       

        private void buttonMinusStrength_Click(object sender, EventArgs e)
        {
            changeAttributes(0, -1);
        }

        private void buttonPlusDex_Click(object sender, EventArgs e)
        {
            changeAttributes(1, 1);
        }

        private void buttonMinusDex_Click(object sender, EventArgs e)
        {
            changeAttributes(1, -1);
        }

        private void buttonPlusCon_Click(object sender, EventArgs e)
        {
            changeAttributes(2, 1);
        }

        private void buttonMinusCon_Click(object sender, EventArgs e)
        {
            changeAttributes(2, -1);
        }

        private void buttonPlusInt_Click(object sender, EventArgs e)
        {
            changeAttributes(3, 1);
        }

        private void buttonMinusInt_Click(object sender, EventArgs e)
        {
            changeAttributes(3, -1);
        }

        private void buttonPlusWis_Click(object sender, EventArgs e)
        {
            changeAttributes(4, 1);
        }

        private void buttonMinusWis_Click(object sender, EventArgs e)
        {
            changeAttributes(4, -1);
        }

        private void buttonPlusCha_Click(object sender, EventArgs e)
        {
            changeAttributes(5, 1);
        }

        private void buttonMinusCha_Click(object sender, EventArgs e)
        {
            changeAttributes(5, -1);
        }

        #endregion

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCharacter.setRace(Race.findRace(comboBoxRace.SelectedItem.ToString()));
        }
    }
}
