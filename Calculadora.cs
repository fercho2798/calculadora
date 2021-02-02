using System;

namespace Matematica
{
    public class Calculadora
    {
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }
        public int Dividir(int dividiendo1, int dividiendo2)
        {
            return dividiendo1 / dividiendo2;
        }
        public int Multiplicar(int multiplicando1, int multiplicando2)
        {
            return multiplicando1 * multiplicando2;
        }
        public int Resta(int restando1, int restando2)
        {
            return restando1 - restando2;
        }
        public int Potencia(int potenciando1, int potenciando2)
        {
          return potenciando1 ^ potenciando2;
        }
        public int PotenciaCuadrada(int potenciando)
        {
            return potenciando * potenciando;
        }

        public double Raiz(double raiz)
        {
            return Math.Sqrt(raiz);

        }
        public double Inversa(double inversando)
        {
            return 1 / inversando;
        }
    }
}
