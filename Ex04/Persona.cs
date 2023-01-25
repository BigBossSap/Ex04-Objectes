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
            Dni = generaDNI() + lletraDNI();
        }

        public Persona(string nom, int edad, char sexo)
        {
            
            this.Nombre = nom;
            this.Edad = edad;
            this.Sexo = sexo;
        }
        public Persona(string nom, int edad, char sexo, double peso, double altura)
        {
            this.Nombre = nom;
            this.Edad = edad;
            this.Sexo = sexo;            
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni
        {
            get => dni;
            set => dni = generaDNI() + lletraDNI();
        }
        public char Sexo
        {
            get { return sexo; }
            set
            {
                if (value != 'H' || value != 'M')
                    sexo = 'H';
                else
                    sexo = value;
            }
        }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }


        public int CalcularIMC()
        {
            int resultat;

            double massa = peso / (altura * altura);

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

        public string generaDNI()
        {
            string numero = "";
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {

                numero += rnd.Next(1, 9);

            }


            return numero;
        }
        
        private string lletraDNI()
        {
           int numero = Convert.ToInt32(generaDNI());
            int modul = numero % 23;

            string[] lletres = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };

            string lletraDNI = lletres[modul];

            return lletraDNI;

        }
    }
}
