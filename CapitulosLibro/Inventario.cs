using System;
using System.Linq;
using System.Text;

namespace CapitulosLibro
{
    class Estudiantes
    {

        private string nombre = "Mario";
        private string apellido = "Santiago";
        private int edad = 20;
        private string estadocivil = "Soltero";
        private string Tiposangre = "A+";
        private string direccion = "Calle del Conde de Peñalver, 16, 28006 Madrid, España";

        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getnombre()
        {
            return nombre;
        }

        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getapellido()
        {
            return apellido;
        }

        public void setedad(int edad)
        {
            this.edad = edad;
        }

        public int getedad()
        {
            return edad;
        }

        public void setestadocivil(string estadocivil)
        {
            this.estadocivil = estadocivil;
        }

        public string getestadocivil()
        {
            return estadocivil;
        }

        public void setTiposangre(string Tiposangre)
        {
            this.Tiposangre = Tiposangre;
        }

        public string getTiposangre()
        {
            return Tiposangre;
        }

        public void setdireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getdireccion()
        {
            return direccion;
        }
        public void Mostrar()
        {
            Console.WriteLine(getnombre() + getapellido() + getedad() + 
            getdireccion() + getestadocivil() + getTiposangre());
        }
    } 

    class Inventario
    {
        private string referencia;
        private int cantidad;
        public void setReferencia(string a){referencia = a;}  
        public void setCantidad(int e){cantidad = e;}

        public string getReferencia(){return referencia;}
        public int getCantidad(){return cantidad;}    
        public void visualizar()
        {
            string referencia;
            int cantidad;
            Inventario a1 = new Inventario();
            Console.WriteLine("Ingrese una refencia de productos: ");
            referencia = Console.ReadLine();
            a1.setReferencia(referencia);
            Console.WriteLine("Ingrese cantidad: ");
            cantidad = Int32.Parse(Console.ReadLine());
            a1.setCantidad(cantidad);

            Console.WriteLine(getReferencia() + getCantidad());
            
            Estudiantes s = new Estudiantes();
            s.Mostrar();  
        }
    }
}