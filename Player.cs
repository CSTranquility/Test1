using System;
namespace Test
{
    public class Player
    {
        private int age; 
        private int strength;
        private int agility;
        private int intelligence;
        private int points;

       
        public Player()
        {
            Age = 18;
            Strength = 0;
            Agility = 0;
            Intelligence = 0;
            Points = 10;
                
        }
        public Player(int age, int strength, int agility,int intelligence,int points)
        {
            Age = age;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Points = points;

        }
        public int Age
        {
            get;
            set;
        }
        
        public int Strength 
        {
            get;
            set;
        }
        public int Agility
        {
            get;
            set;
        }
        public int Intelligence
        {
            get;
            set;
        }
        public int Points
        {
            get;
            set;
        }
    }
}
