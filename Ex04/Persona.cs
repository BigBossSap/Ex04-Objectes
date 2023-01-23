using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Persona
    {
        string nombre;
        int edad;
        string dni;
        char sexo;
        double peso;
        double altura;


        public Persona()
        {
            Dni = "000000000A";
            Sexo = 'H';
        }

        public Persona(string nom, int edad, char sexo)
        {
            Dni = "000000000A";
            this.Nombre = nom;
            this.Edad = edad;
            this.Sexo = sexo;
        }
        public Persona(string nom, int edad, char sexo, string dni,double peso, double altura)
        {          
            this.Nombre = nom;
            this.Edad = edad;
            this.Sexo = sexo;
            this.dni = dni;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni; set => dni = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }


        public int CalcularIMC()
        {
            int resultat;

            double massa = peso/(altura * altura);

            if (massa < 20)
                resultat = -1;
            else if (massa >= 20 && massa <= 25)
                resultat = 0;
            else
                resultat = 1;

            return resultat;
        }

        public bool EsMayorDeEdad()
        {
            bool resultat = false;
            if (edad >= 18)
                resultat = true;
            return resultat;
        }

        private void ValidarSexo(char sexo)
        {
            if (sexo != 'H' && sexo != 'M')
                this.sexo = 'H';

        }

        public void Mostrar()
        {
            ValidarSexo(sexo);
            Console.WriteLine($"{nombre},{edad},{sexo},{dni},{peso},{altura}");
        }
    }
}
