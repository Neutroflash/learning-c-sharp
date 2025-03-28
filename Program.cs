using System;

namespace Exercise1
{
    class PersonAgeChecker
    {
        public void Question()
        {
            Console.WriteLine("Cual es tu nombre? : ");
            var name = Console.ReadLine();
            int edad;
            bool esValido;

            do
            {
                Console.WriteLine("Cual es tu edad? : ");
                esValido = int.TryParse(Console.ReadLine(), out edad);

                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);

            Console.WriteLine(edad >= 18 ? $"{name}, eres mayor de edad" : $"{name}, eres menor de edad");
            
            Console.WriteLine($"Contando de 1 a {edad}");
            for (int i = 1; i <= edad; i++)
            {
                Console.WriteLine(i);
            }

            switch (edad)
            {
                case int e when e >= 18 && e <21 :
                    Console.WriteLine($"{name}, Puedes Votar");
                    break;
                case int e when e >= 21:
                    Console.WriteLine($"{name}, Puedes Votar y tomar");
                    break;
                default:
                    Console.WriteLine($"{name}, No puedes Votar ni Tomar");
                    break;
            }
        }
    }
}

namespace Exercise2
{
    class Calculate
    {
        public void ResolveCalculate()
        {
            Console.WriteLine("Cual es tu nombre? : ");
            var name = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine($"Hola {name}, Bienvenido a la calculadora de IMC!");
            
            double peso, altura;
            bool esValido;
            
            do
            {
                Console.WriteLine("Dame tu peso en kg: ");
                esValido = double.TryParse(Console.ReadLine(), out peso) && peso > 0;

                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);
        
            do
            {
                Console.WriteLine("Dame tu altura en metros: ");
                esValido = double.TryParse(Console.ReadLine(), out altura) && altura > 0;

                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);
            
            double imc = peso / Math.Pow(altura, 2);
            
            Console.WriteLine($"Datos de la persona \n Nombre: {name} \n Peso: {peso} \n Altura: {altura} \n Imc: {imc:F2}");
            switch (imc)
            {
                case double e when e <= 18.5 :
                    Console.WriteLine($"{name}, tienes bajo peso");
                    break;
                case double e when e >= 18.5 && e <= 24.9 :
                    Console.WriteLine($"{name}, tienes peso normal");
                    break;
                case double e when e >= 25 && e <= 29.9:
                    Console.WriteLine($"{name}, tienes sobrepeso");
                    break;
                case double e when e >= 30:
                    Console.WriteLine($"{name}, tienes obesidad");
                    break;
            }
            Console.WriteLine("Gracias por usar la calculadora de IMC");
        }
    }
}

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercise1.PersonAgeChecker example = new Exercise1.PersonAgeChecker();
            example.Question();
            */
            
            Exercise2.Calculate example2 = new Exercise2.Calculate();
            example2.ResolveCalculate();
        }
    }
}