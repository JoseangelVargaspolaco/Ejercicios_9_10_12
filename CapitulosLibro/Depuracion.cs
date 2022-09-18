using System;
using System.Collections;

namespace CapitulosLibro
{
   class Depuracion
   {
      public void factorial()
      {
         int count = 0, factorial = 1;
         Console.Write("Ingrese un dijito: ");
         int dijito = Int32.Parse(Console.ReadLine());
         for (int i = 1; i <= dijito; i++)
         {
            count = count + 1; 
            factorial = factorial + count;
         }
         Console.WriteLine($"El factorial de {dijito} es {factorial}");
      }
   }
}