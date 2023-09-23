using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Test
{
    public static class ElectrodomesticoTest
    {
        public static void Electrodomestico_ComprobarColor_ReturnBool()
        {
            try
            {
                // Declarar
                // Electrodomestico persona = new Persona();
                Lavadora lavadora1 = new Lavadora(29, 50, "rojo", 0, 'D');



                // Iniciar

                bool result =  lavadora1.ComprobarColor(lavadora1.color);

                // Afirmar

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                
            }
        }

        public static void Electrodomestico_ValidarConsumoEnergetico_ReturnBool()
        {
            try
            {
                // Declarar
                // Electrodomestico persona = new Persona();
                Lavadora lavadora1 = new Lavadora(29, 50, "rojo", 0, 'D');



                // Iniciar

                bool result = lavadora1.ValidarConsumoEnergetico(lavadora1.consumoEnergetico);

                // Afirmar

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public static void Electrodomestico_PrecioFinal_ReturnDouble()
        {
            try
            {
                // Declarar
                // Electrodomestico persona = new Persona();
                Lavadora lavadora1 = new Lavadora(29, 50, "rojo", 0, 'D');



                // Iniciar

                double result = lavadora1.precioFinal(lavadora1.carga, lavadora1.consumoEnergetico, lavadora1.peso,lavadora1.precio);

                // Afirmar

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public static void Electrodomestico_TelevisorPrecioFinal_ReturnDouble()
        {
            try
            {
                // Declarar
                // Electrodomestico persona = new Persona();
                Television televisor1 = new Television(100, 50,"rojo", 'D', 45);



                // Iniciar

                double result = televisor1.precioFinal(televisor1.resolucion, televisor1.consumoEnergetico,televisor1.peso, televisor1.precio);

                // Afirmar

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }

}
