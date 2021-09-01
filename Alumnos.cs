using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    class Alumnos : ICloneable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Curso { get; set; }
        public string Tanda { get; set; }
        public Padres NombreP { get; set; }
        public Padres TelefonoP { get; set; }
        public Padres ApellidoP { get; set; }
        public Padres PadreP;

        int opc;

        public Alumnos()
        {
            PadreP = new Padres();
        }
        public void Transporte()
        {
            Console.WriteLine("Quieres estar en el transporte [1] Si [2] No");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.WriteLine($"Muy bien {Nombre} {Apellido} estas incruido en el transporte");
            }
            else
            {
                Console.WriteLine($"Entendido {Nombre} muchas gracias ");
            }
            
        }
        public void Graduaccion()
        {
            Console.WriteLine("Te vas a graduar? [1] Si [2] No");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.WriteLine($"Excelente {Nombre} {Apellido} Tu factura mensual incrementara 300 pesos mas!");
            }
            else
            {
                Console.WriteLine("Entendido muchas gracias ");
            }
        }
        public void M_Extras()
        {
            Console.WriteLine("Cual materia extra cogeras? [1] Natacion [2] Ajedrez [3] Musica [4] Baile");
            opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.WriteLine($"{Nombre} {Apellido} Natacion agregada a sus materias!");
            }
            if (opc == 2)
            {
                Console.WriteLine($"{Nombre} {Apellido} Ajedrez agregada a sus materias! ");
            }
            if (opc == 3)
            {
                Console.WriteLine($"{Nombre} {Apellido} Musica agregada a sus materias! ");
            }
            if (opc == 4)
            {
                Console.WriteLine($"{Nombre} {Apellido} Baile agregada a sus materias! ");
            }
            else
            {
                Console.WriteLine("    ");
            }
        }

        public object Clone()
        {
            //Factura clon = (Factura)MemberwiseClone();//Clonamos superficial
            //clon.Detalle = new DetalleFactura();
            //clon.Detalle.Cliente = Detalle.Cliente;
            //clon.Detalle.Monto = Detalle.Monto;
            //return clon;

            Alumnos clon = (Alumnos)MemberwiseClone();
            clon.PadreP = new Padres();
            clon.PadreP.NombreP = PadreP.NombreP;
            clon.PadreP.ApellidoP = PadreP.ApellidoP;
            clon.PadreP.TelefonoP = PadreP.TelefonoP;
            return clon;

        }
        public override string ToString()
        {
            return $" Id: {Id}\n Nombre: {Nombre}\n Apellido: {Apellido}\n Edad: {Edad}\n Curso: {Curso}\n Tanda: {Tanda}\n Nombre del Padre: {PadreP.NombreP}\n Apellido del Padre: {PadreP.ApellidoP}\n Telefono del Padre: {PadreP.TelefonoP}";
        }
    }
}
