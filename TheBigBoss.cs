namespace mis321_pa2_isfulford
{
    public class TheBigBoss: Character
    {
        public TheBigBoss(){
            this.AttackStrength = AttackStrength + 20;
            this.attackBehavior = new SwordBehavior();
        }
    }
}