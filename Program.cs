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
                Console.WriteLine("Ingresa el nombre de la colonia");
                miproveedor[i].direccion.Colonia=Console.ReadLine();
                Console.WriteLine("Ingresa el número interior");
                miproveedor[i].direccion.numInterior =short.Parse(Console.ReadLine());
            }

            for( int i=0; i<miproveedor.Length;i++)
            {
                Console.WriteLine("Proveedor: {0} - {1} \n Colonia: {2}",i, miproveedor[i].nombre, miproveedor[i].direccion.Colonia);
                
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
        public Direccion direccion;
    }

    public struct Direccion
    {
        public string Colonia;
        public short numInterior;
    }

}
