using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona("Sergi",17,'H',"41581196W",50,1.71);

            if (persona.CalcularIMC() == -1)
                Console.WriteLine("Skinny");
            else if (persona.CalcularIMC() == 0)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Fatty");

            Console.WriteLine(persona.EsMayorDeEdad());
            
            persona.Mostrar();


        }
    }
}
