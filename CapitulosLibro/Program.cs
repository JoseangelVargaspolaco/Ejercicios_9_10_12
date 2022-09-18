using System;

 // Este programa visualizar y ejecutar algunos ejercicios propuestos, (capitulo 1,2,3,4) del libro Guia-Total-del-Programador

namespace CapitulosLibro
{
    class Program
    {

          // Menu principal donde se ejecutaran las funciones localizadas en el Ejercicio.cs
          
          public static void Main(String[] args)
          {
               Console.Clear(); // Limpiar la pantalla para la ejecucion del programa
               
               int operador = 0, lado = 20;

               Depuracion n1 = new Depuracion(); // Llamando a las funciones de ejecucion 
               Ejercicios n2 = new Ejercicios();
               Inventario n3 = new Inventario();
               Poligono n4 = new Poligono(lado);
                

               do{

                    Console.Write("\n -----------MENU-----------\n\n 1) Capitulo #12 Ejercicios todos \n 2) Capitulo #10 Ejercicio todos \n 3) Capitulo #9 Ejercicio todos (Inventario) \n 4) Capitulo #12 Ejercicio todos \n 5) Salir\n\n   ---Selecciona una opcion: ");
                    operador = Int16.Parse(Console.ReadLine());
                    Console.Clear();

                    switch(operador)
                    {
                         case 1:
                              Console.Clear();
                              n1.factorial();
                              Console.ReadKey(); 
                              Console.Clear();
                              break;
                         case 2:
                              Console.Clear();
                              n4.calcular();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 3:
                              Console.Clear();
                              n3.visualizar();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 4:
                              Console.Clear();
                              n2.mostrardata();
                              Console.ReadKey();
                              Console.Clear();
                              break;
                         case 5: 
                              Console.Clear();
                              break;
                         default:
                              Console.Clear();
                              break;
                    }

               }while(operador != 5);
          }
     }
}