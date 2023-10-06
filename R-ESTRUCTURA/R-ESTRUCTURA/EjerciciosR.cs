using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_ESTRUCTURA
{
    internal class EjerciciosR
    {
       public void CalcularGeneroYFechaNacimiento()
        {
            Console.WriteLine("ingresa su curp:");
            string curp = Console.ReadLine().ToUpper();

            if (curp.Length == 18)
            {
                string genero = curp.Substring(10, 1);
                string fechaNacimiento = curp.Substring(4, 6);
                string generoCompleto = (genero == "H") ? "Masculino" : "Femenino";

                int anio = int.Parse(fechaNacimiento.Substring(0, 2));
                int mes = int.Parse(fechaNacimiento.Substring(2, 2));
                int dia = int.Parse(fechaNacimiento.Substring(4, 2));

                Console.WriteLine("Usted Es De Genero: " + generoCompleto);
                Console.WriteLine(" Y Su Fecha de Nacimiento: " + dia + "/" + mes + "/" + (anio >= 40 ? "19" : "200") + anio);
            }
            else
            {
                Console.WriteLine("La CURP ingresada no es válida.");
            }
        }
        
        public void Intervalos()
        {

        }
        
    }
    
}
