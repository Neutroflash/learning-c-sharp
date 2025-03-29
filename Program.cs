using System;
using Operaciones;

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

namespace Functions
{
    class Function
    {
        public void Saludar()
        {
            Console.WriteLine("Ingrese un nombre: ");
            var name = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine($"Hola! {name}");
        }
    }
}

namespace Calcular
{
    class CalcularAreaCirculo 
    {
        public double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

namespace Operaciones
{
    class Operar()
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public double Sum(double x, double y)
        {
            return x + y;
        }

        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
    }
}

namespace Mensaje
{
    class MostrarMensaje
    {
        public void Mostrar(string texto)
        {
            Console.WriteLine($"Texto: {texto}");
        }

        public void Mostrar(int numero)
        {
            Console.WriteLine($"Numero: {numero}");
        }

        public void Mostrar(string texto, int numero)
        {
            Console.WriteLine($"Texto: {texto} \n Numero: {numero}");
        }
    }
}

namespace Calculadora
{
    class Calcular
    {
        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }
        
        public int Multiplicar(int x, int y, int z)
        {
            return x * y * z;
        }
    }  
}

namespace Main
{
    class Program
    {
        /*
        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}");
        }
        */
        
        /*
        static int Suma(int a, int b)
        {
            return a + b;
        }
        */
        
        /*
        static void MostrarMensaje(string mensaje = "Sin mensaje")
        {
            Console.WriteLine(mensaje);
        }
        */
        
        static void Main(string[] args)
        {
            Calculadora.Calcular calc = new Calculadora.Calcular();
            Console.WriteLine($"Multiplicación de enteros: {calc.Multiplicar(10, 20)}");
            Console.WriteLine($"Multiplicacion de decimales: {calc.Multiplicar(10.5, 20.5)}");
            Console.WriteLine($"Multiplicacion de enteros: {calc.Multiplicar(10, 20, 30)}");
            
            /*
            Mensaje.MostrarMensaje mensaje = new Mensaje.MostrarMensaje();
            mensaje.Mostrar("Hola");
            mensaje.Mostrar(10);
            mensaje.Mostrar("Hola", 10);
            /*
        
            Operaciones.Operar op = new Operaciones.Operar();
            Console.WriteLine(op.Sum(10, 20, 30));
            Console.WriteLine(op.Sum(5,3));
            Console.WriteLine(op.Sum(2.5, 3.5));
            /*
             
            Exercise1.PersonAgeChecker example = new Exercise1.PersonAgeChecker();
            example.Question();
            */
            
            /*
            Exercise2.Calculate example2 = new Exercise2.Calculate();
            example2.ResolveCalculate();
            */
            
            /*
            Functions.Function saludo = new Functions.Function();
            saludo.Saludar();
            */
            
            //Saludar("Miguel");
            
            
            /*
            int resultado = Suma(10, 20);
            Console.WriteLine($"El resultado es {resultado}");
            */
            
            /*
            MostrarMensaje();
            MostrarMensaje("Hola Mundo!");
            */
            
            /*
            Calcular.CalcularAreaCirculo newCalculo = new Calcular.CalcularAreaCirculo();
            double radio;
            bool esValido;

            do
            {
                Console.WriteLine("Ingrese el radio: ");
                esValido = double.TryParse(Console.ReadLine(), out radio) && radio > 0;
                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);
            
            double area = newCalculo.Area(radio);
            Console.WriteLine($"Area: {area:F2}");
            */
        }
    }
}