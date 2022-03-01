using mis321_pa2_isfulford.Interfaces;
namespace mis321_pa2_isfulford
{
    public class SwordBehavior: IAttack
    {
        public void Attack(){
            System.Console.WriteLine("Clink!\n");
        }
    }
}