using System;
using Inventario;
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

namespace ConvertirMoneda
{
    class Moneda
    {
        public void Convertir(double dolares, out double euros, out double pesos)
        {
            euros = dolares * 0.89;
            pesos = dolares * 1.19;
        }
    }
}

namespace Calificaciones
{
    class CalcularCalificaciones
    {
        public void CalcularPromedio(int[] notas, out double promedio)
        {
            int suma = 0;
            foreach (var nota in notas)
            {
                suma += nota;
            }
            promedio = (double)suma / notas.Length;
        }
        
        public void ActualizarCalificacion(ref int nota, int nueavaNota)
        {
            nota = nueavaNota;
        }
    }
}

namespace Inventario
{
    class GestionInventario
    {
        private int[] stock = {10, 20, 30, 15, 25};
        private double[] precios = {5,0, 10,0, 15,0, 7,5, 12,5};
        
        public void ActualizarStock(ref int cantidad, int cambio)
        {
            cantidad += cambio;
            if (cantidad < 0)
            {
                cantidad = 0;
            }
        }
        
        public void ObtenerResumen(out int totalProductos, out double valorTotal)
        {
            totalProductos = 0;
            valorTotal = 0;
            for (int i = 0; i < stock.Length; i++)
            {
                totalProductos += stock[i];
                valorTotal += stock[i] * precios[i];
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Stock: ");
            for (int i = 0; i < stock.Length; i++)
            {
                Console.WriteLine($"Producto {i + 1}: {stock[i]} unidades - Precio: {precios[i]:F2} c/u");
            }
        }
    }
}

namespace Banco
{
    class CuentaBancaria
    {
        private string titular;
        private double saldo;
        
        public CuentaBancaria(string titular, double saldoInicial)
        {
            this.titular = titular;
            saldo = saldoInicial;
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Se ha depositado {cantidad:C} en tu cuenta. Nuevo saldo: {saldo:C}");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("No tienes suficiente dinero en tu cuenta");
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad:C} de tu cuenta. Nuevo saldo: {saldo:C}");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Titular: {titular} - Saldo: {saldo:C}");
        }
    }
}

namespace CuentaBancaria
{
    class CuentaNueva
    {
        private string titular; 
        private double saldo;

        public string Titular { get; private set; }
        public double Saldo { get; private set;}

        public CuentaNueva(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo = saldo >= 0 ? saldo : throw new ArgumentException("El saldo no puede ser negativo");
        }

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine($"Se ha depositado {cantidad:C} en tu cuenta. Nuevo saldo: {saldo:C}");
        }

        public void Retirar(double cantidad)
        {
            if (cantidad > saldo)
            {
                Console.WriteLine("No tienes suficiente dinero en tu cuenta");
            }
            else
            {
                saldo -= cantidad;
                Console.WriteLine($"Se ha retirado {cantidad:C} de tu cuenta. Nuevo saldo: {saldo:C}");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Titular: {titular} - Saldo: {saldo:C}");
        } 
    }
}

namespace Main
{
    class Program
    {
        /*
        static double PedirNumero(string mensaje)
        {
            double valor;
            bool esValido;

            do
            {
                Console.WriteLine(mensaje);
                esValido = double.TryParse(Console.ReadLine(), out valor);
                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);

            return valor;
        }
        */
        /*
        static void ObtenerDatos(out int edad, out string nombre)
        {
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            bool esValido;
            do
            {   
                Console.WriteLine("Ingrese su edad: ");
                esValido = int.TryParse(Console.ReadLine(), out edad) || edad >= 0;
                if (!esValido)
                {
                    Console.WriteLine("Ingrese un numero valido!");
                }
            } while (!esValido);
        }
        */
        /*
        static void Duplicar(ref int numero)
        {
            numero *= 2;
        }
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
            CuentaBancaria.CuentaNueva cuenta = new CuentaBancaria.CuentaNueva("Miguel", 1000);
            cuenta.MostrarInformacion();
            cuenta.Depositar(500);
            cuenta.Retirar(300);
            cuenta.Retirar(20000);
            
            cuenta.MostrarInformacion();
            /*
            Banco.CuentaBancaria cuenta = new Banco.CuentaBancaria("Miguel", 1000);
            cuenta.MostrarSaldo();
            cuenta.Depositar(1500);
            cuenta.Retirar(7000);
            cuenta.Retirar(1000);
            /*
            Inventario.GestionInventario inventario = new Inventario.GestionInventario();
            inventario.MostrarInventario();

            int cantidadProducto2 = 20;
            Console.WriteLine("\nAñadiendo 10 unidades al producto 2");
            inventario.ActualizarStock(ref cantidadProducto2, 10);
            Console.WriteLine($"Nuevo stock del producto 2: {cantidadProducto2}");
            
            Console.WriteLine("\nVendiendo 5 unidades del producto 2");
            inventario.ActualizarStock(ref cantidadProducto2, -5);
            Console.WriteLine($"Nuevo stock del producto 2: {cantidadProducto2}");
            
            inventario.ObtenerResumen(out int totalProductos, out double valorTotal);
            Console.WriteLine($"Total de productos: {totalProductos} \nValor total: {valorTotal:F2}");
            */
            /*
            Calificaciones.CalcularCalificaciones cal = new Calificaciones.CalcularCalificaciones();
            int[] notas = new int[5];
            for (int i = 0; i < notas.Length; i++)
            {
                bool esValido;
                do
                {
                    Console.WriteLine($"Ingrese la nota {i + 1}: ");
                    esValido = int.TryParse(Console.ReadLine(), out notas[i]) && notas[i] >= 0 && notas[i] <= 20;
                    if (!esValido)
                    {
                        Console.WriteLine("Ingrese un numero valido!");
                    }
                } while (!esValido);
            }


            cal.CalcularPromedio(notas, out double promedio);
            Console.WriteLine($"Promedio: {promedio:F2}");

            Console.WriteLine("Ingrese el indice de la nota a actualizar (1-5): ");
            int indice;
            bool indiceValido = int.TryParse(Console.ReadLine(), out indice) && indice >= 1 && indice <= 5;
            if (indiceValido)
            {
                Console.WriteLine("Ingrese la nueva nota: ");
                int nuevaNota;
                bool nuevaNotaValida = int.TryParse(Console.ReadLine(), out nuevaNota) && nuevaNota >= 0 && nuevaNota <= 20;
                if (nuevaNotaValida)
                {
                    cal.ActualizarCalificacion(ref notas[indice - 1], nuevaNota);
                    Console.WriteLine("Nota actualizada!");

                    cal.CalcularPromedio(notas, out promedio);
                    Console.WriteLine($"Promedio: {promedio:F2}");
                }
                else
                {
                    Console.WriteLine("Ingrese una nota valida!");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un indice valido!");
            }
            */
            /*
            ConvertirMoneda.Moneda moneda = new ConvertirMoneda.Moneda();
            double euros, pesos;
            double dolares = PedirNumero("Ingrese el valor en dolares: ");
            moneda.Convertir(dolares, out euros, out pesos);
            Console.WriteLine($"Dolares: {dolares:F2} Valor en euros: {euros:F2} \nValor en pesos: {pesos:F2}");
            */
            /*
            int edad;
            string nombre;
            ObtenerDatos(out edad, out nombre);
            Console.WriteLine($"Nombre: {nombre} \nEdad: {edad}");
            */
            /*
            int valor = 10;
            Console.WriteLine($"Valor inicial: {valor}");

            Duplicar(ref valor);
            Console.WriteLine($"Valor final: {valor}");

            /*
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