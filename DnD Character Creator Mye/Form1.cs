using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DnD_Character_Creator_Mye.CharacterMechanics;
using DnD_Character_Creator_Mye.SecondaryForms;

namespace DnD_Character_Creator_Mye
{
    public partial class Form1 : Form
    {
        static public Random rand = new Random();

        Character currentCharacter;
        List<Panel> skillPanels;

        public Form1()
        {
            InitializeComponent();
            NewCharacterForm.form = this;
            Character.form = this;

            #region Skill Panel Setup

            skillPanels = new List<Panel>();
            skillPanels.Add(panelAppraise);
            skillPanels.Add(panelBalance);
            skillPanels.Add(panelBluff);
            skillPanels.Add(panelClimb);
            skillPanels.Add(panelConcentration);
            skillPanels.Add(panelCraft);
            skillPanels.Add(panelDecipher);
            skillPanels.Add(panelDiplomacy);
            skillPanels.Add(panelDisableDevice);
            skillPanels.Add(panelDisguise);
            skillPanels.Add(panelEscapeArtist);
            skillPanels.Add(panelForgery);
            skillPanels.Add(panelGatherInfo);
            skillPanels.Add(panelHandleAnimal);
            skillPanels.Add(panelHeal);
            skillPanels.Add(panelHide);
            skillPanels.Add(panelIntimidate);
            skillPanels.Add(panelJump);
            skillPanels.Add(panelKnowArcana);
            skillPanels.Add(panelKnowArch);
            skillPanels.Add(panelKnowGeo);
            skillPanels.Add(panelKnowHis);
            skillPanels.Add(panelKnowLocal);
            skillPanels.Add(panelKnowMilitary);
            skillPanels.Add(panelKnowNature);
            skillPanels.Add(panelKnowNobility);
            skillPanels.Add(panelKnowReligion);
            skillPanels.Add(panelListen);
            skillPanels.Add(panelMoveSilently);
            skillPanels.Add(panelOpenLock);
            skillPanels.Add(panelPerform);
            skillPanels.Add(panelProfession);
            skillPanels.Add(panelRide);
            skillPanels.Add(panelSearch);
            skillPanels.Add(panelSenseMotive);
            skillPanels.Add(panelSleightofHand);
            skillPanels.Add(panelSpellcraft);
            skillPanels.Add(panelSpot);
            skillPanels.Add(panelSurvival);
            skillPanels.Add(panelSwim);
            skillPanels.Add(panelTumble);
            skillPanels.Add(panelUseMagicDevice);
            skillPanels.Add(panelUseRope);

            #endregion
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

            //textBoxStr.Text = "10";
            //textBoxStrBonus.Text = "+0";
            //textBoxStrPB.Text = "0";

            //textBoxDex.Text = "10";
            //textBoxDexBonus.Text = "+0";
            //textBoxDexPB.Text = "0";

            //textBoxCon.Text = "10";
            //textBoxConBonus.Text = "+0";
            //textBoxConPB.Text = "0";

            //textBoxInt.Text = "10";
            //textBoxIntBonus.Text = "+0";
            //textBoxIntPB.Text = "0";

            //textBoxWis.Text = "10";
            //textBoxWisBonus.Text = "+0";
            //textBoxWisPB.Text = "0";

            //textBoxCha.Text = "10";
            //textBoxChaBonus.Text = "+0";
            //textBoxChaPB.Text = "0";

            //textBoxPoints.Text = points.ToString();

            Skill.initializeSkills();
            Race.prepareRace();
            List<Race> races = Race.getRaces();
            foreach (Race race in races)
            {
                comboBoxRace.Items.Add(race.getName());
            }
            currentCharacter.setSkills(Skill.getSkills());
            string[] classNames = Directory.GetFiles("CharacterClasses/BaseClasses", "*.txt");
            foreach (string className in classNames)
            {
                string classFileOutput = File.ReadAllText(className);
                Class.addBaseClass(Class.unpackClass(classFileOutput));
            }
            string weaponQualities = File.ReadAllText("WeaponDetails/WeaponQualities.txt");
            WeaponQuality.initializeQualities(weaponQualities);
            string weapons = File.ReadAllText("WeaponDetails/Weapons.txt");
            Weapon.initializeWeapons(weapons);
            string armour = File.ReadAllText("WeaponDetails/Armours.txt");
            Armour.prepareArmours(armour);
            currentCharacter.updateAC();
            refreshSheet();
        }

        public void refreshSheet()
        {
            refreshEquipment();
            refreshAttributes();
            refreshFeats();
            refreshSkill();
            refreshClassList();
            refreshSecondaryAttributes();
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
                currentCharacter.updateAC();
                refreshSheet();
            }

        }

        //This method updates the displayed attributes to include racial modifiers. It is to be applied after every change made to the base attributes. When races are added, a consideration for sub 10 attributes should be made but that's a later me problem.
        private void refreshAttributes()
        {
            int[] currentValues = currentCharacter.getAttributes();
            int[] racialBonuses = new int[] { 0, 0, 0, 0, 0, 0 };
            if (currentCharacter.getRace() != null)
            {
                racialBonuses = currentCharacter.getRace().getAttributeBonuses();
            }
            int[] levelUpBonuses = new int[] { 0, 0, 0, 0, 0, 0 };
            foreach(int value in currentCharacter.returnLevelUpBonuses())
            {
                if(value >= 0 && value <= 5)
                {
                    levelUpBonuses[value] += 1;
                }
            }

            int str = currentValues[0] + racialBonuses[0] + levelUpBonuses[0];
            textBoxStr.Text = str.ToString();
            textBoxStrBonus.Text = "+" + checkBonusValue(str).ToString();
            textBoxStrPB.Text = checkPointsSpent(currentValues[0]).ToString();
            if(textBoxStrPB.Text == "1000")
            {
                textBoxStrPB.Text = "0";
            }

            int dex = currentValues[1] + racialBonuses[1] + levelUpBonuses[1];
            textBoxDex.Text = dex.ToString();
            textBoxDexBonus.Text = "+" + checkBonusValue(dex).ToString();
            textBoxDexPB.Text = checkPointsSpent(currentValues[1]).ToString();
            if (textBoxDexPB.Text == "1000")
            {
                textBoxDexPB.Text = "0";
            }

            int con = currentValues[2] + racialBonuses[2] + levelUpBonuses[2];
            textBoxCon.Text = con.ToString();
            textBoxConBonus.Text = "+" + checkBonusValue(con).ToString();
            textBoxConPB.Text = checkPointsSpent(currentValues[2]).ToString();
            if (textBoxConPB.Text == "1000")
            {
                textBoxConPB.Text = "0";
            }

            int intel = currentValues[3] + racialBonuses[3] + levelUpBonuses[3];
            textBoxInt.Text = intel.ToString();
            textBoxIntBonus.Text = "+" + checkBonusValue(intel).ToString();
            textBoxIntPB.Text = checkPointsSpent(currentValues[3]).ToString();
            if (textBoxIntPB.Text == "1000")
            {
                textBoxIntPB.Text = "0";
            }

            int wis = currentValues[4] + racialBonuses[4] + levelUpBonuses[4];
            textBoxWis.Text = wis.ToString();
            textBoxWisBonus.Text = "+" + checkBonusValue(wis).ToString();
            textBoxWisPB.Text = checkPointsSpent(currentValues[4]).ToString();
            if (textBoxWisPB.Text == "1000")
            {
                textBoxWisPB.Text = "0";
            }

            int cha = currentValues[5] + racialBonuses[5] + levelUpBonuses[5];
            textBoxCha.Text = cha.ToString();
            textBoxChaBonus.Text = "+" + checkBonusValue(cha).ToString();
            textBoxChaPB.Text = checkPointsSpent(currentValues[5]).ToString();
            if (textBoxChaPB.Text == "1000")
            {
                textBoxChaPB.Text = "0";
            }

            textBoxPoints.Text = (currentCharacter.checkPointCap() - currentCharacter.checkPoint()).ToString();

        }

        private void refreshSecondaryAttributes()
        {
            if(currentCharacter != null)
            {
                textBoxHP.Text = currentCharacter.getHP().ToString();
                textBoxAC.Text = currentCharacter.getAC().ToString();
                textBoxMana.Text = currentCharacter.getMana().ToString();
                textBoxManaRegen.Text = currentCharacter.getManaRegen().ToString();
                textBoxBAB.Text = currentCharacter.getBAB().ToString();
                textBoxFort.Text = currentCharacter.getFort().ToString();
                textBoxRef.Text = currentCharacter.getRef().ToString();
                textBoxWill.Text = currentCharacter.getWill().ToString();
            }
        }

        //This method checks the attribute bonus
        public int checkBonusValue(int value)
        {
            int toBeReturned;
            toBeReturned = (value - 10) / 2;
            return toBeReturned;
        }

        private void randomizeAttributes()
        {
            Random rand = new Random();
            while(currentCharacter.checkPoint() != currentCharacter.checkPointCap())
            {
                changeAttributes(rand.Next(0, 6), rand.Next(1, 4));
            }
        }

        private void randomizeFavoredAttribute()
        {
            Random rand = new Random();
            int favoredAttribute = rand.Next(0, 6);
            int secondaryAttribute = favoredAttribute;
            while(secondaryAttribute == favoredAttribute)
            {
                secondaryAttribute = rand.Next(0, 6);
            }
            int tertiaryAttribute = secondaryAttribute;
            while(tertiaryAttribute == secondaryAttribute || tertiaryAttribute == favoredAttribute)
            {
                tertiaryAttribute = rand.Next(0, 6);
            }
            changeAttributes(favoredAttribute, 8);
            changeAttributes(secondaryAttribute, 6);
            changeAttributes(tertiaryAttribute, 4);
            while (currentCharacter.checkPoint() != currentCharacter.checkPointCap())
            {
                changeAttributes(rand.Next(0, 6), 1);
            }
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

        #region Skills

        private void refreshSkill()
        {
            if(currentCharacter != null)
            {
                if(checkBoxSkillToggle.Checked == true)
                {
                    foreach(Panel panel in skillPanels)
                    {
                        panel.Show();
                    }
                }
                else
                {
                    foreach(Panel panel in skillPanels)
                    {
                        panel.Hide();
                        List<Skill> skills = currentCharacter.getSkills();
                        foreach (Skill skill in skills)
                        {
                            string name = skill.returnName();
                            if (name != null && skill.getClassSkill())
                            {
                                switch (name)
                                {
                                    case "Appraise":
                                        panelAppraise.Show();
                                        break;
                                    case "Balance":
                                        panelBalance.Show();
                                        break;
                                    case "Bluff":
                                        panelBluff.Show();
                                        break;
                                    case "Climb":
                                        panelClimb.Show();
                                        break;
                                    case "Concentration":
                                        panelConcentration.Show();
                                        break;
                                    case "Craft":
                                        panelCraft.Show();
                                        break;
                                    case "Decipher Script":
                                        panelDecipher.Show();
                                        break;
                                    case "Diplomacy":
                                        panelDiplomacy.Show();
                                        break;
                                    case "Disable Device":
                                        panelDisableDevice.Show();
                                        break;
                                    case "Disguise":
                                        panelDisguise.Show();
                                        break;
                                    case "Escape Artist":
                                        panelEscapeArtist.Show();
                                        break;
                                    case "Forgery":
                                        panelForgery.Show();
                                        break;
                                    case "Gather Info":
                                        panelGatherInfo.Show();
                                        break;
                                    case "Handle Animal":
                                        panelHandleAnimal.Show();
                                        break;
                                    case "Heal":
                                        panelHeal.Show();
                                        break;
                                    case "Hide":
                                        panelHide.Show();
                                        break;
                                    case "Intimidate":
                                        panelIntimidate.Show();
                                        break;
                                    case "Jump":
                                        panelJump.Show();
                                        break;
                                    case "Knowledge:Arcana":
                                        panelKnowArcana.Show();
                                        break;
                                    case "Knowledge:Architecture and Engineering":
                                        panelKnowArch.Show();
                                        break;
                                    case "Knowledge:Geography":
                                        panelKnowGeo.Show();
                                        break;
                                    case "Knowledge:History":
                                        panelKnowHis.Show();
                                        break;
                                    case "Knowledge:Local":
                                        panelKnowLocal.Show();
                                        break;
                                    case "Knowledge:Military":
                                        panelKnowMilitary.Show();
                                        break;
                                    case "Knowledge:Nature":
                                        panelKnowNature.Show();
                                        break;
                                    case "Knowledge:Nobility":
                                        panelKnowNobility.Show();
                                        break;
                                    case "Knowledge:Religion":
                                        panelKnowReligion.Show();
                                        break;
                                    case "Listen":
                                        panelListen.Show();
                                        break;
                                    case "Move Silently":
                                        panelMoveSilently.Show();
                                        break;
                                    case "Open Lock":
                                        panelOpenLock.Show();
                                        break;
                                    case "Perform":
                                        panelPerform.Show();
                                        break;
                                    case "Profession":
                                        panelProfession.Show();
                                        break;
                                    case "Ride":
                                        panelRide.Show();
                                        break;
                                    case "Search":
                                        panelSearch.Show();
                                        break;
                                    case "Sense Motive":
                                        panelSenseMotive.Show();
                                        break;
                                    case "Sleight of Hand":
                                        panelSleightofHand.Show();
                                        break;
                                    case "Spellcraft":
                                        panelSpellcraft.Show();
                                        break;
                                    case "Spot":
                                        panelSpot.Show();
                                        break;
                                    case "Survival":
                                        panelSurvival.Show();
                                        break;
                                    case "Swim":
                                        panelSwim.Show();
                                        break;
                                    case "Tumble":
                                        panelTumble.Show();
                                        break;
                                    case "Use Magic Device":
                                        panelUseMagicDevice.Show();
                                        break;
                                    case "Use Rope":
                                        panelUseRope.Show();
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Feats

        private void refreshFeats()
        {
            if(currentCharacter != null)
            {
                listBoxFeats.Items.Clear();
                foreach(Feat feat in currentCharacter.returnOwnedFeats())
                {
                    listBoxFeats.Items.Add(feat.returnName());
                }
            }
        }

        #endregion

        #region Classes

        private void refreshClassList()
        {
            if(currentCharacter != null)
            {
                listBoxClasses.Items.Clear();
                List<Class> classNames = new List<Class>();
                foreach (ClassLevel levels in currentCharacter.returnClassLevels())
                {
                    if (classNames.Contains(levels.returnClass()) == false)
                    {
                        classNames.Add(levels.returnClass());
                    }
                }
                foreach (Class relevantClass in classNames)
                {
                    listBoxClasses.Items.Add(relevantClass.returnName() + " (" + currentCharacter.findClassLevel(relevantClass) + ")");
                }
            }
        }

        #endregion

        #region Equipment

        private void refreshEquipment()
        {
            listBoxArmour.Items.Clear();
            listBoxWeapons.Items.Clear();
            foreach(Equipment equipment in currentCharacter.returnEquipment())
            {
                if(equipment is Weapon)
                {
                    //This is bad. Check how to improve it in the near future.
                    //Weapon temp = (Weapon)equipment;
                    listBoxWeapons.Items.Add(equipment.returnName());
                }
                else if(equipment is Armour)
                {
                    listBoxArmour.Items.Add(equipment.returnName());
                }
            }
            currentCharacter.updateAC();
        }

        #endregion

        private void comboBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCharacter.setRace(Race.findRace(comboBoxRace.SelectedItem.ToString()));
            refreshSheet();
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            switch(comboBoxRandomizationMethods.SelectedItem.ToString())
            {
                case "Default":
                    randomizeAttributes();
                    break;
                case "Minmax":
                    randomizeFavoredAttribute();
                    break;
            }
        }

        private void checkBoxSkillToggle_CheckedChanged(object sender, EventArgs e)
        {
            refreshSkill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            AddClassForm newForm = new AddClassForm(currentCharacter);
            newForm.Show();
        }

        private void listBoxFeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Feat feat in currentCharacter.returnOwnedFeats())
            {
                if(feat.returnName() == listBoxFeats.SelectedItem.ToString())
                {
                    richTextBoxFeatDescription.Text = feat.returnDescription();
                }
            }
        }

        private void buttonAddEquip_Click(object sender, EventArgs e)
        {
            EquipmentAddForm form = new EquipmentAddForm(currentCharacter);
            form.Show();
        }
    }
}
