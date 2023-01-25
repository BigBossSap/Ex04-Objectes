using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            //Persona persona = new Persona("Sergi", 17, 'l');

            //if (persona.CalcularIMC() == -1)
            //    Console.WriteLine("Skinny");
            //else if (persona.CalcularIMC() == 0)
            //    Console.WriteLine("Normal");
            //else
            //    Console.WriteLine("Fatty");

            //Console.WriteLine(persona.EsMayorDeEdad());

            //persona.Mostrar();

            //persona.generaDNI();
            string nom;
            double peso,altura;
            int edat;
            char sexo;
            Console.WriteLine("nom: ");
            nom = Console.ReadLine();
            Console.WriteLine("edat: ");
            edat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sexo H/M: ");
            sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Peso: ");              
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Persona persona = new Persona(nom, edat,sexo,peso,altura);
            Persona persona2 = new Persona(nom, edat, sexo);
            Persona persona3 = new Persona();


            if (persona.CalcularIMC() == -1)
                Console.WriteLine("Debajo del peso ideal");
            else if (persona.CalcularIMC() == 0)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Encima del peso ideal");

          if (persona.EsMayorDeEdad())
                Console.WriteLine("La persona 1 es major d'edat");
          else
                Console.WriteLine("La persona 1 es menor d'edat");


            if (persona2.CalcularIMC() == -1)
                Console.WriteLine("Debajo del peso ideal");
            else if (persona2.CalcularIMC() == 0)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Encima del peso ideal");

            if (persona2.EsMayorDeEdad())
                Console.WriteLine("La persona 2 es major d'edat");
            else
                Console.WriteLine("La persona 2 es menor d'edat");

            if (persona3.CalcularIMC() == -1)
                Console.WriteLine("Debajo del peso ideal");
            else if (persona3.CalcularIMC() == 0)
                Console.WriteLine("Normal");
            else
                Console.WriteLine("Encima del peso ideal");

            if (persona3.EsMayorDeEdad())
                Console.WriteLine("La persona 3 es major d'edat");
            else
                Console.WriteLine("La persona 3 es menor d'edat");


            Console.WriteLine();

            persona.Mostrar();
            persona2.Mostrar();
            persona3.Mostrar();






        }
    }
}
