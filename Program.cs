using System;
using Matematica;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número: ");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            var numero2 = int.Parse(Console.ReadLine());
            var calculadora = new Calculadora();
            var resultado = calculadora.Sumar(numero1, numero2);
            var resultadoDividir = calculadora.Dividir(numero1, numero2);
            var resultadoMultiplicar = calculadora.Multiplicar(numero1, numero2);
            var resultadoRestar = calculadora.Resta(numero1, numero2);
            var resultadoPotenciar = calculadora.Potencia(numero1, numero2);
            var resultadoPotenciaCuadrada = calculadora.PotenciaCuadrada(numero1);
            var resultadoRaiz = calculadora.Raiz(numero1);
            var resultadoInversa = calculadora.Inversa(numero1);

            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.WriteLine("El resultado de la divicion es: " + resultadoDividir);
            Console.WriteLine("El resultado de la multiplicacion es: " + resultadoMultiplicar);
            Console.WriteLine("El resultado de la resta es: " + resultadoRestar);
            Console.WriteLine(numero1 + " Elevado a la potencia " + numero2 + " es " + resultadoPotenciar);
            Console.WriteLine(numero1 + " Elevado al cuadrada es: " + resultadoPotenciaCuadrada);
            Console.WriteLine("la raiz cuadrada de : " + numero1 + " es: " + resultadoRaiz);
            Console.WriteLine("La inversa de " + numero1 + " es:  " + resultadoInversa);
            Console.ReadLine();
        }
    }
}
