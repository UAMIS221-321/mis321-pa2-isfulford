using System;

namespace mis321_pa2_isfulford
{
    class Program
    {
        static void Main(string[] args)
        {
            int characterCount = 1;
            //automatically create 2 characters
            Character p1 = new Character();
            Character p2 = new Character();
           
            //adds username to player, makes character choice
            p1.UserName = PlayerInfo(characterCount);
            p1 = CharacterChoice(p1);
            characterCount++;
            p2.UserName = PlayerInfo(characterCount);
            p2 = CharacterChoice(p2);

            Console.WriteLine("Let us see who will go first");
            //uses randomNum to choose who goes first
            //p1 goes 1st
            if(p1.AttackStrength < p2.AttackStrength){
                while(p1.Health > 0 && p2.Health > 0){
                    double defaultHealthDeduction = .15;

                    Console.WriteLine("Player 1 Fight!");
                    //if the defender's defPower is higher than attacker's attackStrength, take 15% of their health
                    if(p2.DefensivePower > p1.AttackStrength){
                        if((p1.Name == "Jack Sparrow" && p2.Name == "Will Turner")||(p1.Name == "Will Turner" && p2.Name == "Davy Jones")
                            ||(p1.Name == "Davy Jones" && p2.Name == "Jack Sparrow")){
                            p2.Health -= (p2.Health * defaultHealthDeduction) * 1.2;
                        }
                        else{
                            p2.Health -= (p2.Health * defaultHealthDeduction);
                        }
                    }
                    else{
                        //Type Bonus
                        if((p1.Name == "Jack Sparrow" && p2.Name == "Will Turner")||(p1.Name == "Will Turner" && p2.Name == "Davy Jones")
                        ||(p1.Name == "Davy Jones" && p2.Name == "Jack Sparrow")){
                            p2.Health -= (p1.AttackStrength - p2.DefensivePower)* 1.2;
                            Console.WriteLine("I used my type bonus");
                        }
                        else{
                            p2.Health -= (p1.AttackStrength - p2.DefensivePower);
                        }
                    }
                    Console.WriteLine($"{p1.Name} {p1.attackBehavior}");
                    ViewStats(p1.Health,p2.Health);
                    
                    Console.WriteLine("Player 2 Fight!");
                    if(p1.DefensivePower > p2.AttackStrength){
                        if((p2.Name == "Jack Sparrow" && p1.Name == "Will Turner")||(p2.Name == "Will Turner" && p1.Name == "Davy Jones")
                            ||(p2.Name == "Davy Jones" && p1.Name == "Jack Sparrow")){
                            p1.Health -= (p1.Health * defaultHealthDeduction) * 1.2;
                        }
                        else{
                            p1.Health -= (p1.Health * defaultHealthDeduction);
                        }
                    }
                    else{
                        if((p2.Name == "Jack Sparrow" && p1.Name == "Will Turner")||(p2.Name == "Will Turner" && p1.Name == "Davy Jones")
                        ||(p2.Name == "Davy Jones" && p1.Name == "Jack Sparrow")){
                            p1.Health -= (p2.AttackStrength - p1.DefensivePower)* 1.2;
                        }
                        else{
                            p1.Health -= (p2.AttackStrength - p1.DefensivePower);
                        }
                    }
                    ViewStats(p1.Health,p2.Health);
                }
            }

            //p2 goes 1st
            if(p2.AttackStrength < p1.AttackStrength){
                while(p2.Health > 0 && p1.Health > 0){
                    double defaultHealthDeduction = .15;
 
                    Console.WriteLine("Player 2 Fight!");
                    //if the defender's defPower is higher than attacker's attackStrength, take 15% of their health
                     if(p1.DefensivePower > p2.AttackStrength){
                        if((p2.Name == "Jack Sparrow" && p1.Name == "Will Turner")||(p2.Name == "Will Turner" && p1.Name == "Davy Jones")
                            ||(p2.Name == "Davy Jones" && p1.Name == "Jack Sparrow")){
                            p1.Health -= (p1.Health * defaultHealthDeduction) * 1.2;
                        }
                        else{
                            p1.Health -= (p1.Health * defaultHealthDeduction);
                        }
                    }
                    else{
                        //Type Bonus
                        if((p2.Name == "Jack Sparrow" && p1.Name == "Will Turner")||(p2.Name == "Will Turner" && p1.Name == "Davy Jones")
                        ||(p2.Name == "Davy Jones" && p1.Name == "Jack Sparrow")){
                            p1.Health -= (p2.AttackStrength - p1.DefensivePower)* 1.2;
                        }
                        else{
                            p1.Health -= (p2.AttackStrength - p1.DefensivePower);
                        }
                    }
                    ViewStats(p1.Health,p2.Health);

                    Console.WriteLine("Player 1 Fight!");
                    if(p2.DefensivePower > p1.AttackStrength){
                        if((p1.Name == "Jack Sparrow" && p2.Name == "Will Turner")||(p1.Name == "Will Turner" && p2.Name == "Davy Jones")
                            ||(p1.Name == "Davy Jones" && p2.Name == "Jack Sparrow")){
                            // EXTRA (per Jeff reccommendation), add 20% on top of default 10% deduction
                            p2.Health -= (p2.Health * defaultHealthDeduction) * 1.2;
                        }
                        else{
                        p2.Health -= (p2.Health * defaultHealthDeduction);
                        }
                    }
                    else{
                        //Type Bonus
                        if((p1.Name == "Jack Sparrow" && p2.Name == "Will Turner")||(p1.Name == "Will Turner" && p2.Name == "Davy Jones")
                            ||(p1.Name == "Davy Jones" && p2.Name == "Jack Sparrow")){
                            p2.Health -= (p1.AttackStrength - p2.DefensivePower)* 1.2;
                        }
                        else{
                            p2.Health -= (p1.AttackStrength - p2.DefensivePower);
                        }
                    }
                    ViewStats(p1.Health,p2.Health);
                }
            }
                if(p1.Health <= 0){
                    Console.WriteLine($"{p2.Name} wins! Congrats {p2.UserName}");
                }
                else{
                    Console.WriteLine($"{p1.Name} wins! Congrats {p1.UserName}");
                }

        }
        public static string PlayerInfo(int characterCount){
            Console.WriteLine($"Hello Player {characterCount}! You are playing The Pirates of the Carribean");
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            return userName;

        }
        public static Character CharacterChoice(Character playerCharacter){
            Console.WriteLine("Please choose a player from the following menu");
            Console.WriteLine("1) Jack Sparrow 2) Will Turner 3) Davy Jones");
            int choice = int.Parse(Console.ReadLine());
            string tempUserName = playerCharacter.UserName;

            if(choice == 1){
                playerCharacter = new JackSparrow();
                playerCharacter.Name = "Jack Sparrow";
            }
            else if(choice == 2){
                playerCharacter = new WillTurner();
                playerCharacter.Name = "Will Turner";

            }
            else{
                playerCharacter = new DavyJones();
                playerCharacter.Name = "Davy Jones";
            }
            
            playerCharacter.UserName = tempUserName;

            
            return playerCharacter;
        }
        public static void ViewStats(double p1Health, double p2Health){
            Console.WriteLine($"Player 1 Health: {p1Health}");
            Console.WriteLine($"Player 2 Health: {p2Health}");
        }
    }
}
