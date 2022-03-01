using mis321_pa2_isfulford.Interfaces;
namespace mis321_pa2_isfulford
{
    public class CannonFireBehavior: IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Boom!");
        }
    }
}