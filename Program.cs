using System;
using System.IO;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {

            Alumnos Alumnos0 = new Alumnos();

                Alumnos0.Id = 001;
                Alumnos0.Nombre = "keury";
                Alumnos0.Apellido = "Lendof";
                Alumnos0.Edad = 18;
                Alumnos0.Curso = "6to bachiller";
                Alumnos0.Tanda = "Matutino";

                Alumnos0.PadreP.NombreP = "Juan";
                Alumnos0.PadreP.ApellidoP = "Toribio";
                Alumnos0.PadreP.TelefonoP = 333;



            Alumnos Alumnos1 = Alumnos0.Clone() as Alumnos;

                Alumnos1.Id = 002;
                Alumnos1.Nombre = "alberto";
                Alumnos1.Apellido = "diaz";
                Alumnos1.Edad = 20;
                Alumnos1.Curso = "3ro bachiller";
                Alumnos1.Tanda = "Vespertino";

                Alumnos1.PadreP.NombreP = "Francisco";
                Alumnos1.PadreP.ApellidoP = "Ramos";
                Alumnos1.PadreP.TelefonoP = 0674564;


            Alumnos Alumnos2 = Alumnos0.Clone() as Alumnos;

                Alumnos2.Id = 003;
                Alumnos2.Nombre = "fernando";
                Alumnos2.Apellido = "perez";
                Alumnos2.Edad = 30;
                Alumnos2.Curso = "5to bachiller";
                Alumnos2.Tanda = "Domingos";

                Alumnos2.PadreP.NombreP = "Guillermo";
                Alumnos2.PadreP.ApellidoP = "Marte";
                Alumnos2.PadreP.TelefonoP = 3454;


            Alumnos Alumnos3 = Alumnos0.Clone() as Alumnos;

                Alumnos3.Id = 004;
                Alumnos3.Nombre = "Wendys";
                Alumnos3.Apellido = "Ortiz";
                Alumnos3.Edad = 40;
                Alumnos3.Curso = "6to bachiller";
                Alumnos3.Tanda = "Noche";

                Alumnos3.PadreP.NombreP = "Enemencio";
                Alumnos3.PadreP.ApellidoP = "Peralta";
                Alumnos3.PadreP.TelefonoP = 0674564;




            Padres padres0 = new Padres();

                padres0.NombreP = Alumnos0.PadreP.NombreP;
                padres0.ApellidoP = Alumnos0.PadreP.ApellidoP;
                padres0.Cedula = 040543;
                padres0.TelefonoP = Alumnos0.PadreP.TelefonoP;
                padres0.Edad = 23;
                padres0.Nacionalidad = "Republica Dominicana";
                padres0.Direccion = "La villa panamericana";

            
            Padres padres1 = padres0.Clone() as Padres;

                padres1.NombreP = Alumnos1.PadreP.NombreP;
                padres1.ApellidoP = Alumnos1.PadreP.ApellidoP;
                padres1.Cedula = 2343;
                padres1.TelefonoP = Alumnos1.PadreP.TelefonoP;
                padres1.Edad = 30;
                padres1.Nacionalidad = "Haiti";
                padres1.Direccion = "Puerto Principe";


            Padres padres2 = padres0.Clone() as Padres;

                padres2.NombreP = Alumnos2.PadreP.NombreP;
                padres2.ApellidoP = Alumnos2.PadreP.ApellidoP;
                padres2.Cedula = 35353;
                padres2.TelefonoP = Alumnos2.PadreP.TelefonoP;
                padres2.Edad = 45;
                padres2.Nacionalidad = "Dominican";
                padres2.Direccion = "Puerto Plata";


            Padres padres3 = padres0.Clone() as Padres;


               padres3.NombreP = Alumnos3.PadreP.NombreP;
               padres3.ApellidoP = Alumnos3.PadreP.ApellidoP;
               padres3.Cedula = 09323;
               padres3.TelefonoP = Alumnos3.PadreP.TelefonoP;
               padres3.Edad = 45;
               padres3.Nacionalidad = "Dominicano";
               padres3.Direccion = "Ocoa";
               



            Console.WriteLine("____Padre Principal____");
            Console.WriteLine(padres0.ToString());
            padres0.InfoPersonal();
            padres0.DiaLibre();
            padres0.AsocDepadres();
            Console.WriteLine(" ");
            Console.WriteLine("____Padre Clon 1____");
            Console.WriteLine(padres1.ToString());
            padres1.InfoPersonal();
            padres1.DiaLibre();
            padres1.AsocDepadres();
            Console.WriteLine(" ");
            Console.WriteLine("____Padre Clon 2____");
            Console.WriteLine(padres2.ToString());
            padres2.InfoPersonal();
            padres2.DiaLibre();
            padres2.AsocDepadres();
            Console.WriteLine(" ");
            Console.WriteLine("____Padre Clon 3____");
            Console.WriteLine(padres3.ToString());
            padres3.InfoPersonal();
            padres3.DiaLibre();
            padres3.AsocDepadres();
            Console.WriteLine(" ");


            Console.WriteLine("____Alumno Principal____");
            Console.WriteLine(Alumnos0.ToString());
            Alumnos0.Transporte();
            Alumnos0.Graduaccion();
            Alumnos0.M_Extras();
            Console.WriteLine(" ");

            Console.WriteLine("____Alumno Clon 1____");
            Console.WriteLine(Alumnos1.ToString());
            Alumnos1.Transporte();
            Alumnos1.Graduaccion();
            Alumnos1.M_Extras();
            Console.WriteLine(" ");

            Console.WriteLine("____Alumno Clon 2____");
            Console.WriteLine(Alumnos2.ToString());
            Alumnos2.Transporte();
            Alumnos2.Graduaccion();
            Alumnos2.M_Extras();
            Console.WriteLine(" ");

            Console.WriteLine("____Alumno Clon 3____");
            Console.WriteLine(Alumnos3.ToString());
            Alumnos3.Transporte();
            Alumnos3.Graduaccion();
            Alumnos3.M_Extras();

            Console.ReadKey();


            TextWriter Escribe = new StreamWriter("Text.txt");

            Escribe.WriteLine("*******************Padre Principal*******************");
            Escribe.WriteLine(padres0.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Alumno Principal*******************");
            Escribe.WriteLine(Alumnos0.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Padre Clon*******************");
            Escribe.WriteLine(padres1.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Alumno Clon*******************");
            Escribe.WriteLine(Alumnos1.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Padre Clon 2*******************");
            Escribe.WriteLine(padres2.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Alumno Clon 2*******************");
            Escribe.WriteLine(Alumnos2.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Padre Clon 3*******************");
            Escribe.WriteLine(padres3.ToString());
            Escribe.WriteLine(" ");
            Escribe.WriteLine("*******************Alumno Clon 3*******************");
            Escribe.WriteLine(Alumnos3.ToString());
            Escribe.Close();

            Console.WriteLine("El archivo txt se guardo en la carpeta debug del proyecto!!!");

            Console.ReadKey();
        }
    }
}
