namespace mis321_pa2_isfulford
{
    public class JackSparrow: Character
    {
        public JackSparrow(){
            this.attackBehavior = new DistractBehavior();
        }
    }
}