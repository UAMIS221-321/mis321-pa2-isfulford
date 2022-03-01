using System;
using mis321_pa2_isfulford.Interfaces;
namespace mis321_pa2_isfulford
{
    public class Character
    {
        public string UserName{get;set;}
        public string Name{get;set;}
        public int MaxPower{get;set;}
        public double Health{get;set;}
        public int AttackStrength{get;set;}
        public int DefensivePower{get;set;}
        public IAttack attackBehavior{get;set;}
    
        public Character(){
            MaxPower = RandomNum();
            Health = 100;
            AttackStrength = MaxPowerRandomNum(MaxPower);
            DefensivePower = MaxPowerRandomNum(MaxPower);

        }
        public int RandomNum(){
            // Random random = new Random();
            // //random number btwn 1 and 100
            // int num = random.Next(1,100);
            int num = new Random().Next(1,100);

            return num;
        }
        public int MaxPowerRandomNum(int MaxPower){
            Random random = new Random();
            int maxNum = random.Next(1,MaxPower);

            return maxNum;
        }
        
    }
}