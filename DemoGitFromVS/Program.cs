using System;

namespace Jeje
{
    class Program
    {
        static void Main(string[] args)
        {
            var Saludo = new Hola();
            Console.WriteLine("Hola " + Saludo.Greeting);
        }
        public class Hola
        {
            public string Greeting { get; set; }
            public Hola()
            {
                Greeting = "Mundo";
            }
        }
    }
}