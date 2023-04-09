using System;

namespace Mueblee
{
    public class Mueble
    {
        private String nombre, material, forma;
        private double preceio;

        public Mueble(string nombre, string material, string forma, double preceio)
        {
            this.nombre = nombre;
            this.material = material;
            this.forma = forma;
            this.preceio = preceio;
        }
        public static String operator +(Oficina a, Mueble b)
        {
            Console.WriteLine("---- SOBRECARGA DE OPERADOR b) mostrar los datos del objeto oficina (nombre, responsable, ubicacion), si alguno de sus muebles es del mismo materilal de un objeto mueble ----");
            for (int i = 0; i < a.NroMuebles; i++)
            {
                if (a.Datos[i,1].Equals(b.Material))
                {
                    return ("nombre: " + a.Nombre + "\nresponsable: " + a.Respconsable + "\nubicacion: " + a.Ubiacion);
                }
            }
            return "no hay ningun muebles con el mismo material";
        }
        
        // getters
        public string Nombre => nombre;

        public string Material => material;

        public string Forma => forma;

        public double Preceio => preceio;
    }
}