using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Character_Creator_Mye.CharacterMechanics
{
    class Character
    {
        string name;
        List<ClassLevel> takenLevels = new List<ClassLevel>();
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;
        List<Skill> skills;
        int hp;
        int mana;
        Race race;
        int manaRegen;
        int AC;
        int BAB;
        int meleeAttack;
        int rangedAttack;
        int fortSave;
        int refSave;
        int willSave;
        List<int> proficiencies = new List<int>();
        List<Spell> knownSpells = new List<Spell>();
        List<Feat> ownedFeats = new List<Feat>();
        List<Equipment> ownedEquipment = new List<Equipment>();
        List<Class> takenClasses = new List<Class>();
        List<int> levelUpAttributeBonuses = new List<int>();

        int pointBuyTotal;
        int pointBuyCurrent;

        static public Form1 form;

        public Character(int pointBuyValue, string name)
        {
            strength = 10;
            dexterity = 10;
            constitution = 10;
            intelligence = 10;
            wisdom = 10;
            charisma = 10;
            pointBuyTotal = pointBuyValue;
            this.name = name;
        }

        public int[] getAttributes()
        {
            return new int[] { strength, dexterity, constitution, intelligence, wisdom, charisma };
        }

        public void setAttributes(int[] values)
        {
            strength = values[0];
            dexterity = values[1];
            constitution = values[2];
            intelligence = values[3];
            wisdom = values[4];
            charisma = values[5];
        }

        public void spendPoint(int pointsSpent)
        {
            pointBuyCurrent += pointsSpent;
        }

        public int checkPoint()
        {
            return pointBuyCurrent;
        }

        public int checkPointCap()
        {
            return pointBuyTotal;
        }

        public Race getRace()
        {
            return race;
        }


        //This method changes the character's race, and sets up their new skills. Need to add feats later.
        public void setRace(Race race)
        {
            //This section indexes all class skills that are from classes, and then removes racial skills not added by one or more classes.
            if(this.race != null)
            {
                List<Skill> classSkills = new List<Skill>();
                foreach (Class characterClass in takenClasses)
                {
                    Skill.fuseList(classSkills, characterClass.returnSkills());
                }

                List<Skill> previousRaceSkill = this.race.getSkills();
                hp -= this.race.getHP();
                mana -= this.race.getMana();

                foreach (Skill skill in this.race.getSkills())
                {
                    if (Skill.findSkills(skill.returnName(), classSkills) == null)
                    {
                        Skill.findSkills(skill.returnName(), skills).setClassSkill(false);
                    }
                }
            }

            //This section sets the race and new class skills of the race.
            this.race = race;
            hp += race.getHP();
            mana += race.getMana();
            foreach(Skill skill in race.getSkills())
            {
                Skill.findSkills(skill.returnName(), skills).setClassSkill(true);
            }
        }

        public List<Skill> getSkills()
        {
            return skills;
        }

        public void setSkills(List<Skill> skills)
        {
            this.skills = skills;
        }

        public List<ClassLevel> returnClassLevels()
        {
            return takenLevels;
        }

        public int findClassLevel(Class givenClass)
        {
            int levelCount = 0;
            foreach(ClassLevel level in takenLevels)
            {
                if(level.returnClass() == givenClass)
                {
                    levelCount += 1;
                }
            }
            return levelCount;
        }

        public int getHP()
        {
            return hp;
        }

        public int getMana()
        {
            return mana;
        }

        public int getBAB()
        {
            return BAB;
        }

        public int getAC()
        {
            return AC;
        }

        public int getFort()
        {
            return fortSave;
        }

        public int getRef()
        {
            return refSave;
        }

        public int getWill()
        {
            return willSave;
        }

        public int getManaRegen()
        {
            return manaRegen;
        }


        public List<Feat> returnOwnedFeats()
        {
            return ownedFeats;
        }

        public void addClassLevel(ClassLevel toBeAdded)
        {
            addClassLevelBase(toBeAdded);
            form.refreshSheet();
        }

        public void addClassLevel(ClassLevel toBeAdded, Feat chosenFeat)
        {
            addClassLevelBase(toBeAdded);
            ownedFeats.Add(chosenFeat);
            form.refreshSheet();
        }

        public void addClassLevel(ClassLevel toBeAdded, int attributeBonus)
        {
            addClassLevelBase(toBeAdded);
            levelUpAttributeBonuses.Add(attributeBonus);
            form.refreshSheet();
        }

        public void addClassLevel(ClassLevel toBeAdded, Feat chosenFeat, int attributeBonus)
        {
            addClassLevelBase(toBeAdded);
            levelUpAttributeBonuses.Add(attributeBonus);
            ownedFeats.Add(chosenFeat);
            form.refreshSheet();
        }

        private void addClassLevelBase(ClassLevel toBeAdded)
        {
            takenLevels.Add(toBeAdded);
            foreach (ClassLevel level in takenLevels)
            {
                if (level.returnClass() == toBeAdded.returnClass() && (level.returnLevel() + 1) == toBeAdded.returnLevel())
                {
                    BAB += (toBeAdded.returnBab() - level.returnBab());
                    fortSave += (toBeAdded.returnFort() - level.returnFort());
                    refSave += (toBeAdded.returnRef() - level.returnRef());
                    willSave += (toBeAdded.returnWill() - level.returnWill());
                }
            }
            foreach (Feat feat in toBeAdded.returnFeats())
            {
                ownedFeats.Add(feat);
            }
            if (toBeAdded.returnLevel() == 1)
            {
                foreach (Skill skill in toBeAdded.returnClass().returnSkills())
                {
                    skill.setClassSkill(true);
                }
                foreach(int ID in toBeAdded.returnClass().returnProficiency())
                {
                    if(proficiencies.Contains(ID) == false)
                    {
                        proficiencies.Add(ID);
                    }
                }
                BAB += toBeAdded.returnBab();
                fortSave += toBeAdded.returnFort();
                refSave += toBeAdded.returnRef();
                willSave += toBeAdded.returnWill();
            }
            hp += toBeAdded.returnHP();
            mana += toBeAdded.returnMana();
        }

        public List<int> returnLevelUpBonuses()
        {
            return levelUpAttributeBonuses;
        }

        public void addEquipment(Equipment equipment)
        {
            ownedEquipment.Add(equipment);
            form.refreshSheet();
        }

        public List<Equipment> returnEquipment()
        {
            return ownedEquipment;
        }

        public void updateAC()
        {
            int dexBonus = form.checkBonusValue(dexterity);
            Armour bestArmour = null;
            foreach(Equipment equipment in ownedEquipment)
            {
                if(equipment is Armour)
                {
                    Armour tempArmour = (Armour)equipment;
                    if(proficiencies.Contains(tempArmour.returnType()))
                    {
                        if (bestArmour == null)
                        {
                            bestArmour = tempArmour;
                        }
                        else
                        {
                            if (tempArmour.compareArmour(bestArmour, dexBonus))
                            {
                                bestArmour = tempArmour;
                            }
                        }
                    }
                }
            }
            if(bestArmour != null)
            {
                AC = 10 + bestArmour.returnValue(dexBonus);
            }
            else
            {
                AC = 10 + dexBonus;
            }
        }
    }
}
