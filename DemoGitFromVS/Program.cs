using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGitFromVS
{
    class Program
    {
        public string Greeting;

        public Program()
        {
            Greeting = "Mundo";
        }
        static void Main(string[] args)
        {
            Program x = new Program();
            Console.WriteLine($"Hola {x.Greeting}");
            Console.ReadLine();
        }
    }
}
