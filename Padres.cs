using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType
{
    public class Padres : ICloneable
    {
        public string NombreP { get; set; }
        public string ApellidoP { get; set; }
        public int Cedula { get; set; }
        public int TelefonoP { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Direccion { get; set; }


        public void InfoPersonal()
        {
            Console.WriteLine($"Mi cedula de identidad es {Cedula} y tengo {Edad} años, el proximo año cumplo {Edad + 1}");
        }
        public void DiaLibre()
        {
            Console.WriteLine($"{NombreP} Mis dias libres son los viernes y sabados");
        }
        public void AsocDepadres()
        {
            Console.WriteLine("Quieres Pertenecer a la asociacion de padres? [1] Si [2] No");
            int opc = int.Parse(Console.ReadLine());

            if (opc == 1)
            {
                Console.WriteLine($"Excelente {NombreP} {ApellidoP} estas agregado a la Asoc. De padres");
            }
            else
            {
                Console.WriteLine("Entendido muchas gracias ");
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $" Nombre: {NombreP}\n Apellido: {ApellidoP}\n Cedula: {Cedula}\n Telefono: {TelefonoP}\n Edad: {Edad}\n Nacionalidad: {Nacionalidad}\n Direccion: {Direccion}";
        }
    }
}
