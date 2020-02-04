using System;

namespace Player_Character
{
    public class MyUnit
    {

        protected int HP = 100;

        public string Weapon = "Weapon equipped";

        public int WeaponAttack = 10;

        public int MagicAttack = 5;

        public int skills = 1;
        
        public MyUnit(int skills)
        {
         
            if(skills == 1)
            {
                Console.WriteLine("This unit's skill is Rally Spectrum");
            }

            else if(skills == 2)
            {
                Console.WriteLine("This unit's skill is Rightful King");
            }

            else
            {
                Console.WriteLine("This unit's skill is Aether");
            }
        
        }
        
       
       
    

        
    }
}







