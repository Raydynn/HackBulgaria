using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.IO;namespace _14.DungeonsAndLizards
{
    class Program
    {
        static void Main()
        {
            string level1Map = File.ReadAllText("Level1.txt");
            Console.WriteLine(level1Map);
        }
    }
}
