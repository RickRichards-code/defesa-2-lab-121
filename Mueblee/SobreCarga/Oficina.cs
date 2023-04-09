using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;

namespace Mueblee
{
    public class Oficina
    {
        private String nombre, respconsable, ubiacion;
        private int nroMuebles;
        private String[,] datos = new string[50, 3];
        private int[] cantidad = new int[50];


        public Oficina(string nombre, string respconsable, string ubiacion)
        {
            this.nombre = nombre;
            this.respconsable = respconsable;
            this.ubiacion = ubiacion;
            this.nroMuebles = 5;
            this.datos[0, 0] = "meza"; // nombre
            this.datos[1, 0] = "closed"; // nombre  ------------
            this.datos[2, 0] = "armario"; // nombre 
            this.datos[3, 0] = "estante"; // nombre --------------
            this.datos[4, 0] = "meza"; // nombre 
            this.datos[0, 1] = "roble"; // material
            this.datos[1, 1] = "madera"; // material --------------
            this.datos[2, 1] = "platico"; // material
            this.datos[3, 1] = "madera"; // material --------------
            this.datos[4, 1] = "metal"; // material
            this.cantidad[0] = 43; // cantidad
            this.cantidad[1] = 1000; // cantidad     --------------
            this.cantidad[2] = 23; // cantidad
            this.cantidad[3] = 2000; // cantidad     --------------
            this.cantidad[4] = 10; // cantidad
        }

        // SOBRECARGA DE METODO
        // a) el objeto Oficina, determinar la contidad total de muebles del materialX 
        public void verificar(String materialX)
        {
            Console.WriteLine(
                "---- SOBRECARGA DE METODO // a) el objeto Oficina, determinar la contidad total de muebles del materialX  ----");
            int c = 0;
            for (int i = 0; i < nroMuebles; i++)
            {
                if (datos[i, 1].Equals(materialX))
                    c=c+cantidad[i];
            }

            Console.WriteLine("los muebles del material " + materialX + ", son: " + c);
        }
        // getters
        public string Nombre => nombre;

        public string Respconsable => respconsable;

        public string Ubiacion => ubiacion;

        public int NroMuebles => nroMuebles;

        public string[,] Datos => datos;

        public int[] Cantidad => cantidad;

        // SOBRECARGA DE METODO
        // c) Verificar si en el objeto Oficina exite algun mueble con el mismo nombre y material de un objeto Mueble
        public bool verificar(Mueble b)
        {
            Console.WriteLine("---- SOBRECARGA DE METODO // c) Verificar si en el objeto Oficina exite algun mueble con el mismo nombre y material de un objeto Mueble  ----");
            int c = 0;
            for (int i=0; i<nroMuebles;i++)
            {
                if (datos[i, 0].Equals(b.Nombre) && datos[i, 1].Equals(b.Material))
                {
                    return true;
                }
            }
            return false;
        }
    } 
}