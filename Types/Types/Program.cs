using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int x = 11;

            //Console.WriteLine($"Size of the int is {sizeof(int)}");
            //Console.WriteLine($"Size of the double is {sizeof(double)}");
            //Console.WriteLine($"Type of the var is {x.GetType()}");

            UserNameService usr = new UserNameService();
            Console.WriteLine($"Type of the var y is {usr.GetType()}");

            Console.WriteLine($"Please enter your character name: ");
            var name = Console.ReadLine();
            name = usr.LowerName(name);
            Console.WriteLine($"Name is lowered {name}");

            //int z = "7";
            //string number = 7;
            //int z1 = int.Parse("7");
            //int.TryParse("11", out int ab);
            Console.ReadLine();
        }
    }
}
