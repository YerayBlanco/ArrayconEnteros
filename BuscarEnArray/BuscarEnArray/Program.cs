using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarEnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int ndatos = 0;

            while (ndatos == 0)
            {
                try
                {
                    Console.WriteLine("Indica el número de datos que quieres introducir en el array:");
                    ndatos = int.Parse(Console.ReadLine());
                    //Con este bucle, vamos añadiendo datos (i), hasta llenarse el espacio que hemos declarado para los mismos (ndatos). Recordad que la posición que ocupan los datos en un array comeinza en la pos 0. Es por eso que  i comienza en 0, es menos que ndatos y se suma uno cada vez que añadimos i++.
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato no válido. Introduce un número");
                }

            }
            float[] array = new float[ndatos];
            
            for (int i = 0; i < ndatos; i++)
            {
                try
                {
                    Console.WriteLine($"Introduce el número{ i + 1 } : ");
                    array[i] = float.Parse(Console.ReadLine());



                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato no válido. Introduce un número");
                    i--;
                    continue;

                }
            }

            buscar();

           // Con este bucle, recorremos todo el array anteriormente definido, hasta que encontremos la coincidenciencia de i con numerobuscado, entonces la variable encontrado cambiara de false a true, saliendo del for.try{
            void buscar()
            {
                bool encontrado = false;

                try
                {
                    Console.WriteLine("Introduce el número que desea buscar: ");
                    float numerobuscado = float.Parse(Console.ReadLine());
                    for (int i = 0; i < ndatos; i++)
                    {
                        if (array[i] == numerobuscado)
                        {
                            encontrado = true;
                            break;
                        }


                    }

                    if (encontrado == true)
                    {
                        Console.WriteLine($"El numero {numerobuscado} se encuentra en la lista");
                    }
                    else
                    {
                        Console.WriteLine($"El numero {numerobuscado} no se encuentra en la lista");
                    }

                    Console.WriteLine("Presiona cualquier tecla para salir");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato no valido");
                    Console.ReadKey();
                }
            }
          
        }
    }
}
