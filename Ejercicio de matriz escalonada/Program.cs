using System;

namespace Ejercicio_de_matriz_escalonada
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, j, numAlumnos, salones;
            double sumaCali = 0, sumaAlumnos = 0, promedio, califMin = 10, califMax = 0;

            //Pedimos el número de salones
            Console.Write("Ingrese el número de salones: ");
            salones = Convert.ToByte(Console.ReadLine());
            
            double[][] calificaciones = new double[salones][];

            //Console.WriteLine("ingrese el numero de alumnos: ");
            //numAlumnos = Convert.ToByte(Console.ReadLine());


            for (i = 0; i < salones; i++)
            {

                Console.WriteLine("Ingrese el número de alumnos para el salon {0}:", i);
                numAlumnos = Convert.ToByte(Console.ReadLine());

                //alumnos totales
                sumaAlumnos += numAlumnos;

                //instanciamos las matrices internas
                calificaciones[i] = new double[numAlumnos];

            }
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("salon {0}:", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("ingrese la calificación del alumno {0}", i);
                    Console.WriteLine("Ingrese la calificacion: ");
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                    sumaCali += calificaciones[i][j];
                }

            }

            promedio = sumaCali / sumaAlumnos;

            for (i = 0; i < salones; i++)
            {

                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] < califMin)
                    {
                        califMin = calificaciones[i][j];
                    }
                }


            }

            for (i = 0; i < salones; i++)
            {
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    if (calificaciones[i][j] > califMax)
                    {
                        califMax = calificaciones[i][j];
                    }
                }
            }

            //mostramos las calificaciones de cada alumno
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("salon {0}:", i);
                for (j = 0; j < calificaciones[i].Length; j++)
                {
                    Console.WriteLine("El alumno {0}, tiene calificación {1}", j, calificaciones[i][j]);
                }

            }

            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("La calificacion mínima es: {0}", califMin);
            Console.WriteLine("La calificacion máxima es: {0}", califMax);

        }
    }
}
