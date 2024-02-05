using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proektik
{
    internal class Unit
    {
		private int _strength;
        private int _maxStrength;
        private int _dexterity;
        private int _maxDexterity;
        private int _inteligence;
        private int _maxInteligence;
        private int _vitality;
        private int _maxVitality;
        private int _health;
        private int _maxHealth;
        private int _mana;
        private int _maxMana;
		private int _pdamage;
		private int _armor;
		private int _mdamage;
		private int _mdefense;
		private int _crtChance;
		private int _crtDamage;

        public Unit(int strength, int maxStrength, int dexterity, int maxDexterity, int inteligence, int maxInteligence, int vitality, int maxVitality, int health, int maxHealth, int mana, int maxMana, int pdamage, int armor, int mdamage, int mdefense, int crtChance, int crtDamage)
        {
            _strength = strength;
            _maxStrength = maxStrength;
            _dexterity = dexterity;
            _maxDexterity = maxDexterity;
            _inteligence = inteligence;
            _maxInteligence = maxInteligence;
            _vitality = vitality;
            _maxVitality = maxVitality;
            _health = health;
            _maxHealth = maxHealth;
            _mana = mana;
            _maxMana = maxMana;
            _pdamage = pdamage;
            _armor = armor;
            _mdamage = mdamage;
            _mdefense = mdefense;
            _crtChance = crtChance;
            _crtDamage = crtDamage;
        }

        public int strength
		{
			get { return _strength; }
			set { _strength = value; }
		}
 
        public int maxStrength
        {
            get { return _maxStrength; }
            set { _maxStrength = value; }
        }
		
		public int dexterity
		{
			get { return _dexterity; }
			set { _dexterity = value; }
		}

		public int maxDexterity
        {
			get { return _maxDexterity; }
			set { _maxDexterity = value; }
		}
		
		public int inteligence
		{
			get { return _inteligence; }
			set { _inteligence = value; }
		}

		public int maxInteligence
        {
			get { return _maxInteligence; }
			set { _maxInteligence = value; }
		}

		public int vitality
		{
			get { return _vitality; }
			set { _vitality = value; }
		}

		public int maxVitality
		{
			get { return _maxVitality; }
			set { _maxVitality = value; }
		}

		public int health
		{
			get { return _health; }
			set { _health = value; }
		}

        public int maxHealth
        {
            get { return _health; }
            set { _health = value; }
        }
	
		public int mana
		{
			get { return _mana; }
			set { _mana = value; }
		}
		
		public int maxMana
		{
			get { return _maxMana; }
			set { _maxMana = value; }
		}
		public int pdamage
		{
			get { return _pdamage; }
			set { _pdamage = value; }
		}
        public int armor
        {
            get { return _armor; }
            set { _armor = value; }
        }
        public int mdamage
        {
            get { return _mdamage; }
            set { _mdamage = value; }
        }
        public int mdefense
        {
            get { return _mdefense; }
            set { _mdefense = value; }
        }
        public int crtChance
        {
            get { return _crtChance; }
            set { _crtChance = value; }
        }
        public int crtDamage
        {
            get { return _crtDamage; }
            set { _crtDamage = value; }
        }
    }
}
