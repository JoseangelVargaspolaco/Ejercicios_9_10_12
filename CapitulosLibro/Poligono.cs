using System;
using System.Collections;

namespace CapitulosLibro
{
    public class Poligono
    {

        public int lado;
        public Poligono(int lado)
        {
            this.lado =  lado;
        }

        public void calcular()
        {
            Console.WriteLine($"\n Area: {lado+lado+lado+lado} \n Perimetro: {lado*lado}");
        }

        public override string ToString()
        {
            string mensaje = "";
            mensaje += "lado" + lado.ToString();

            return mensaje;
        }
    }
}