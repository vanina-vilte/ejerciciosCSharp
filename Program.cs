using System;

namespace primerPrograma
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //tp1();
            //tp2();
            //tp3();
            //tp4(); 
            //tp5();
            //tp6();
            /*static void tp1()
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }*/

            /*static void tp2()
            {
                int numero = 0;
                do
                {
                    Console.WriteLine("Introduzca un número por teclado que sea mayor a 1");
                    numero = int.Parse(Console.ReadLine());
                } while (numero < 2);

                for (int i = 1; i <= numero; i++)
                {
                    Console.WriteLine(i);
                }
                
            }*/
            
            /*static void tp3()
            {
                int numero2 = 0;
                int sumatoria = 0;
                do
                {
                    Console.WriteLine("Introduzca números por teclado");
                    numero2 = int.Parse(Console.ReadLine());
                    sumatoria = sumatoria + numero2;

                } while (numero2 != 0);

                for (int i = 0; i <= numero2; i++)
                {
                    Console.WriteLine("La suma de los números ingresados es: " + sumatoria);
                }*/

            /*static void tp4()
            {
                int ladoMayor = 0;
                int ladoInterior1 = 0;
                int ladoInterior2 = 0;

                Console.WriteLine("Introduzca un valor para lado 1");
                int lado1 = int.Parse(Console.ReadLine());
                if (lado1 > ladoMayor)
                {
                    ladoMayor = lado1;
                }

                Console.WriteLine("Introduzca un valor para lado 2");
                int lado2 = int.Parse(Console.ReadLine());
                if (lado2 > ladoMayor)
                {
                    ladoMayor = lado2;
                    ladoInterior1 = lado1;
                }
                else
                {
                    ladoInterior1 = lado2;
                }

                Console.WriteLine("Introduzca un valor para lado 3");
                int lado3 = int.Parse(Console.ReadLine());
                if (lado3 > ladoMayor)
                {
                    ladoMayor = lado3;
                }
                else
                {
                    ladoInterior2 = lado3;
                }

                int ladosInteriores = ladoInterior1 + ladoInterior2;

                if (ladosInteriores < ladoMayor)
                {
                    Console.WriteLine("No es un triangulo, porque suma de sus dos lados inferiores tiene que ser mayor al lado superior.");
                }
                else if ((lado1 == lado2) &&  (lado2 == lado3))
                {
                    Console.WriteLine("Es un triangulo equilátero");
                }
                else if ((lado1 == lado2) || (lado2 == lado3) || (lado1 == lado3))
                {
                    Console.WriteLine("Es un triangulo isósceles");
                }
                else
                {
                    Console.WriteLine("Es un triangulo escaleno");
                }
            }*/

          /*static void tp5()
            {
                string palabra = string.Empty;
                do
                {
                    Console.WriteLine("Introduzca una palabra de no más de 20 caracteres");
                    palabra = Console.ReadLine();
                    

                } while (palabra.Length > 20);

                int sumatoria = 0;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == 'a' || palabra[i] == 'e' || palabra[i] == 'i' || palabra[i] == 'o' || palabra[i] == 'u')
                    {
                        sumatoria++;
                    }
                   
                }

                Console.WriteLine("Usted a utilizado " + sumatoria + " vocales");
            }*/

            /*static void tp6()
            {
                int numero1 = 0;
                int numero2 = 0;

                Console.WriteLine("Introduzca el número que desee utilizar como dividendo");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduzca el número que desee utilizar como divisor");
                numero2 = int.Parse(Console.ReadLine());

                int resultado = numero1 / numero2;

                Console.WriteLine("El resultado de la división es: " + resultado);
            }*/

        }
    }
}

