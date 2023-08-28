using System;

namespace NumeroEspecial
{
    class Program
    {
        static bool EsEspecial(int numero)
        {
            // Criterio 1: Es divisible entre 5.
            if (numero % 5 != 0)
            {
                return false;
            }

            // Criterio 2: No es divisible entre 2 ni 3.
            if (numero % 2 == 0 || numero % 3 == 0)
            {
                return false;
            }

            // Criterio 3: La suma de sus dígitos es mayor a 10.
            int sumaDigitos = 0;
            foreach (char digitoChar in numero.ToString())
            {
                sumaDigitos += int.Parse(digitoChar.ToString());
            }
            if (sumaDigitos <= 10)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bienvenido, ingrese un número para saber si es un número especial o no. Un número es especial si cumple con los siguientes criterios: --Es divisible entre 5. --No es divisible entre 2 ni 3. --La suma de sus dígitos es mayor a 10. ingresar número:");
                string entrada = Console.ReadLine();
                int numero = int.Parse(entrada);

                if (EsEspecial(numero))
                {
                    Console.WriteLine("¡El número es especial!");
                }
                else
                {
                    Console.WriteLine("El número no es especial.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor, ingrese solamente números.");
            }
        }
    }
}

