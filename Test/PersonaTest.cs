using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2.Test
{
    public static class PersonaTest
    {
        public static void Persona_CalcularIMC_ReturnInt()
        {
            try
            {
                // Declarar

                Persona persona1 = new Persona("Mauro", 20, 44703730, 'H', 70, 186);



                // Iniciar

                int result = persona1.calcularIMC(persona1.peso, persona1.altura);

                // Afirmar

                Console.WriteLine($"CalcularIMC: " + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public static void Persona_EsMayorDeEdad_ReturnBool()
        {
            try
            {
                // Declarar

                Persona persona1 = new Persona("Mauro", 20, 44703730, 'H', 70, 186);



                // Iniciar

                bool result = persona1.esMayorDeEdad(persona1.edad);

                // Afirmar

                Console.WriteLine($"Es mayor de edad: " + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public static void Persona_ValidarSexo_ReturnChar()
        {
            try
            {
                // Declarar

                Persona persona1 = new Persona("Mauro", 20, 44703730, 'H', 70, 186);



                // Iniciar

                char result = persona1.validarSexo(persona1.sexo);

                // Afirmar

                Console.WriteLine($"Validar sexo: " + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public static void Persona_toString_ReturnString()
        {
            try
            {
                // Declarar

                Persona persona1 = new Persona("Mauro", 20, 44703730, 'H', 70, 186);



                // Iniciar

                string result = persona1.toString(persona1.nombre, persona1.edad,persona1.dni,persona1.sexo,persona1.peso,persona1.altura);

                // Afirmar

                Console.WriteLine($"Datos de la persona: " + result);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }
    }
}
