using SamuraiList;
using Weapons;
namespace MainProgram
{

    class Program
    {
        static void Main(string[] args)
        {
            var warrior1 = new Samurai(new Sword());
            warrior1.Attack("Vijay");
            Console.WriteLine();

            var warrior2 = new Samurai(new Hammer());
            warrior2.Attack("Vijay");
            Console.WriteLine();

            var warrior3 =new Samurai(new Jump());
            warrior3.Attack("Vijay");
            Console.WriteLine();

            var warrior4 = new Sumo(new Sword());
            warrior4.Attack("Vijay");
            Console.WriteLine();

            var warrior5 = new Sumo(new Jump());
            warrior5.Attack("Vijay");
            Console.WriteLine();

        }
    }
}