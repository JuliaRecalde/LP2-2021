using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectodeAula2021.Clases
{
    public class Lista
    {

        /* 1) Escriba un programa que inserte en orden 25 enteros al azar, del 0 al 100, en una lista
                ligada. El programa debe calcular la suma de los elementos y el promedio en punto flotante de ellos. */

        public void Numero_Random()
        {
            
            List<int> enteros = new List<int>();
            Random aleatorio = new Random();
            int num;
            int i;
            int suma = 0;
            for (i = 0; i < 25; i++)
            {
                num = aleatorio.Next(0, 101);
                enteros.Add(num);
                suma = suma + num;
            }
            float promedio = suma / 25;
            Console.WriteLine("\nLa suma de los elementos es: " + suma);
            Console.WriteLine("\nEl promedio es: " + promedio);
        }
        

        /*Escriba un programa que genere una lista ligada de 10 caracteres, y que después genere una
            copia de la lista en orden inverso. */

        public void Inverso()        //Ejercicio 2
        {
            List<string> caracter = new List<string>();
            List<string> invierte = new List<string>();
            caracter.Add("j");
            caracter.Add("u");
            caracter.Add("l");
            caracter.Add("i");
            caracter.Add("a");
            caracter.Add("r");
            caracter.Add("e");
            caracter.Add("c");
            caracter.Add("l");
            caracter.Add("d");
            caracter.Add("e");
            int i;
            for (i = 0; i < 11; i++)
            {
                invierte.Add(caracter[10 - i]);
            }
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine("\n" + caracter[i]);
            }
            Console.WriteLine("Frase invertida:");
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine("\n" + invierte[i]);
            }
        }

        public void Imprimelista()
        {
            int i;
            int j = 9;
            bool ban = false;
            List<int> enteros = new List<int>();
            for (i = 0; i < 10; i++)
            {
                enteros.Add(i + 1);
            }
            Console.WriteLine("Esta es la lista ordenada:");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(enteros[i]);
            }
            Console.WriteLine("\nEsta es la lista Invertida:");
            imprimeListaInversa(j);
            void imprimeListaInversa(int cont)
            {
                if (cont != -1)
                {
                    Console.WriteLine(enteros[cont]);
                    cont--;
                    imprimeListaInversa(cont);
                }
            }
        }



        /* (Impresión recursiva de una lista en orden inverso) Escriba una función imprimeListaInversa,
                que recursivamente despliegue los elementos de una lista en orden inverso. Utilice su función
                en un programa de prueba que genere una lista ordenada de enteros y que imprima la lista en
                orden inverso. */

        public void ImprimelistaInversa()
        {
            int i;
            int a = 4;
            
            List<int> numeros = new List<int>();
            for (i = 0; i < 5; i++)
            {
                numeros.Add(i + 1);
            }
            Console.WriteLine("Esta es la lista ordenada:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("\nLa lista invertida es:");
            imprimir(a);
            void imprimir(int cont)
            {
                if (cont != -1)
                {
                    Console.WriteLine(numeros[cont]);
                    cont--;
                    imprimir(cont);
                }
            }
        }
    }
}
