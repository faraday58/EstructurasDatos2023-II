using System;

namespace EstructurasDatos2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Proveedor [] miproveedor = new Proveedor[2];
            for(int i=0; i < miproveedor.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre del proveedor: ");
                miproveedor[i].nombre = Console.ReadLine();
                Console.WriteLine(" Ingresa el Teléfono: ");
                miproveedor[i].telefono = Console.ReadLine();
            }

            for( int i=0; i<miproveedor.Length;i++)
            {
                Console.WriteLine("Proveedor: {0} - {1}",i, miproveedor[i].nombre);
            }


           /* miproveedor.nombre = "Pepito";
            miproveedor.telefono = "5525231425";

            Console.WriteLine("Nombre: {0}", miproveedor.nombre);
            Console.WriteLine("Teléfono: {0}", miproveedor.telefono);
           */
            Console.ReadLine();
                
             

        }
    }

    public struct Proveedor
    {
        public string nombre;
        public string telefono;


    }

}
