namespace mis321_pa2_isfulford
{
    public class DavyJones: Character
    {
        public DavyJones(){
            this.attackBehavior = new CannonFireBehavior();
        }
    }
}