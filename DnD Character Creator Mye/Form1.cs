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

        //This method updates the displayed attributes to include racial modifiers. It is to be applied after every change made to the base attributes
        private void refreshAttributes()
        {

        }


        private void buttonPlusStrength_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getStrength();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setStrength(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxStr.Text = (currentValue + 1).ToString();
                textBoxStrPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

       

        private void buttonMinusStrength_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getStrength();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setStrength(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxStr.Text = (currentValue - 1).ToString();
                textBoxStrPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonPlusDex_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getDexterity();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setDexterity(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxDex.Text = (currentValue + 1).ToString();
                textBoxDexPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonMinusDex_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getDexterity();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setDexterity(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxDex.Text = (currentValue - 1).ToString();
                textBoxDexPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonPlusCon_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getConstitution();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setConstitution(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxCon.Text = (currentValue + 1).ToString();
                textBoxConPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonMinusCon_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getConstitution();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setConstitution(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxCon.Text = (currentValue - 1).ToString();
                textBoxConPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonPlusInt_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getIntelligence();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setIntelligence(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxInt.Text = (currentValue + 1).ToString();
                textBoxIntPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonMinusInt_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getIntelligence();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setIntelligence(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxInt.Text = (currentValue - 1).ToString();
                textBoxIntPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonPlusWis_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getWisdom();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setWisdom(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxWis.Text = (currentValue + 1).ToString();
                textBoxWisPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonMinusWis_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getWisdom();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setWisdom(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxWis.Text = (currentValue - 1).ToString();
                textBoxWisPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonPlusCha_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getCharisma();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue + 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setCharisma(currentValue + 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxCha.Text = (currentValue + 1).ToString();
                textBoxChaPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        private void buttonMinusCha_Click(object sender, EventArgs e)
        {
            int currentValue = currentCharacter.getCharisma();
            int previousPointsValue = checkPointsSpent(currentValue);
            int pointsSpent = checkPointsSpent(currentValue - 1);
            if (pointsSpent != 1000 && pointsSpent - previousPointsValue <= (currentCharacter.checkPointCap() - currentCharacter.checkPoint()))
            {
                currentCharacter.setCharisma(currentValue - 1);
                currentCharacter.spendPoint(pointsSpent - previousPointsValue);
                textBoxCha.Text = (currentValue - 1).ToString();
                textBoxChaPB.Text = pointsSpent.ToString();
                textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();
            }
            refreshAttributes();
        }

        #endregion
    }
}
