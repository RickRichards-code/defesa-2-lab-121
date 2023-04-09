using System;

namespace Mueblee
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Mueble m1 = new Mueble("mesa","madera","en L",450);
            Oficina o1 = new Oficina("blanco", "maria", "piso4");
            // SOBRECARGA DE METODO // a) el objeto Oficina, determinar la contidad total de muebles del materialX
            o1.verificar("madera");
            // SOBRECARGA DE OPERADOR b) mostrar los datos del objeto oficina (nombre, responsable, ubicacion), si alguno de sus muebles es del mismo materilal de un objeto mueble
            Console.WriteLine(o1 + m1);
            // SOBRECARGA DE METODO // c) Verificar si en el objeto Oficina exite algun mueble con el mismo nombre y material de un objeto Mueble
            if(o1.verificar(m1))
                Console.WriteLine("si exite");
            else
                Console.WriteLine("no exite");                
            
        }
    }
}