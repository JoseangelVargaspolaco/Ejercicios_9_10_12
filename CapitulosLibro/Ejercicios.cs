using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



// Funciones de ejecucion del programa

namespace CapitulosLibro
{
     class Ejercicios
     {
        public struct tienda
        {
            public double Precio;
            public string NombreProducto = string.Empty;

            public tienda(double Precio, string NombreProducto)
            {
                this.Precio = Precio;
                this.NombreProducto = NombreProducto;
            }

        }
        public struct MascotaDueño
        {
            public string NombreDueño = string.Empty;
            public string NombreMascota = string.Empty;

            public string Edades = string.Empty;

            public string Direccion = string.Empty;

            tienda productos = new tienda();


            public MascotaDueño(){}

            public void setNombre(string NombreDueño)
            {
                this.NombreDueño = NombreDueño;
            }

            public string getNombre(){
                return NombreDueño;
            }

            public void setNombreMascota(string NombreMascota)
            {
                this.NombreMascota = NombreMascota;
            }

            public string getNombreMascota(){
                return NombreMascota;
            }

            public void setEdades(string Edades)
            {
                this.Edades = Edades;
            }

            public string getEdades(){
                return Edades;
            }

            public void setDireccion(string Direccion)
            {
                this.Direccion = Direccion;
            }

            public string getDireccion()
            {
                return Direccion;
            }

            public void setPrecio(double Precio)
            {
                this.productos.Precio = Precio;
            }

            public double getPrecio()
            {
                return productos.Precio;
            }

            public void setNombreProducto(string NombreProducto)
            {
                this.productos.NombreProducto = NombreProducto;
            }

            public string getNombreProducto()
            {
                return productos.NombreProducto;
            }
        }
        public void mostrardata()
        { 
            MascotaDueño datos = new MascotaDueño();            

            datos.setNombre("Jose");
            datos.setNombreMascota("Rambo");
            datos.setEdades("22 y 4 años");
            datos.setDireccion("Calle del Conde de Peñalver, 16, 28006 Madrid, España");
            datos.setPrecio(2000);
            datos.setNombreProducto("Carne de res");

            Console.WriteLine($"\n<><><> Datos <><><> \n\n(-) Nombre del Dueño: {datos.getNombre()} \n(-) Nombre de la mascota: {datos.getNombreMascota()} \n(-) Edad dueño_mascota: {datos.getEdades()} \n(-) Direccion: {datos.getDireccion()} \n(-) Precio: {datos.getPrecio()} \n(-) Nombre del producto: {datos.getNombreProducto()}");
            
            Estrellas estrellas = Estrellas.Enana_amarilla;

            Console.WriteLine("(-) Estrella: " + estrellas + "\n");
            
        }

        enum Estrellas {Estrella_de_neutrones, Enana_roja, Enana_naranja, Enana_amarilla, 
        Enana_blanca, Enana_marrón, Enana_azul, Enana_negra, Subenana, Subgigante, Gigante, 
        Gigante_luminosa, Supergigante, Supergigante_luminosa, Hipergigante}
    }
}