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
        List<Spell> knownSpells = new List<Spell>();
        List<Feat> ownedFeats = new List<Feat>();
        List<Equipment> ownedEquipment = new List<Equipment>();
        List<Class> takenClasses = new List<Class>();

        int pointBuyTotal;
        int pointBuyCurrent;

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

        public void addClassLevel(ClassLevel toBeAdded)
        {
            takenLevels.Add(toBeAdded);
            foreach(ClassLevel level in takenLevels)
            {
                if(level.returnClass() == toBeAdded.returnClass() && (level.returnLevel() + 1) == toBeAdded.returnLevel())
                {
                    BAB += (toBeAdded.returnBab() - level.returnBab());
                    fortSave += (toBeAdded.returnFort() - level.returnFort());
                    refSave += (toBeAdded.returnRef() - level.returnRef());
                    willSave += (toBeAdded.returnWill() - level.returnWill());
                }
            }
            foreach(Feat feat in toBeAdded.returnFeats())
            {
                ownedFeats.Add(feat);
            }
        }

        public void addClassLevel(ClassLevel toBeAdded, Feat chosenFeat)
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
            ownedFeats.Add(chosenFeat);
        }
    }
}
