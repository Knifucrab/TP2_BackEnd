namespace TP2

{
    using TP2.Test;
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tests unitarios de los metodos de Lavadora y Televisor");
            Console.ReadLine();
            ElectrodomesticoTest.Electrodomestico_ComprobarColor_ReturnBool();
            ElectrodomesticoTest.Electrodomestico_ValidarConsumoEnergetico_ReturnBool();
            ElectrodomesticoTest.Electrodomestico_PrecioFinal_ReturnDouble();
            ElectrodomesticoTest.Electrodomestico_TelevisorPrecioFinal_ReturnDouble();

            Console.WriteLine("Tests unitarios de Persona");
            Console.ReadLine();
            PersonaTest.Persona_CalcularIMC_ReturnInt();
            PersonaTest.Persona_EsMayorDeEdad_ReturnBool();
            PersonaTest.Persona_ValidarSexo_ReturnChar();
            PersonaTest.Persona_toString_ReturnString();


            /*
                Persona persona = new Persona();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Nombre: ");
                persona.Nombre =Console.ReadLine();

                Console.WriteLine("Edad: ");
                persona.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("DNI: ");
                persona.Dni = float.Parse(Console.ReadLine());

                Console.WriteLine("Sexo (H: hombre, M: mujer, N: no binario): ");
                persona.Sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Peso (en kg): ");
                persona.Peso = float.Parse(Console.ReadLine());

                Console.WriteLine("Altura (en metros): ");
                persona.Altura = float.Parse(Console.ReadLine());

                Console.WriteLine("\nDatos de la persona: \n");
                persona.toString(persona.Nombre, persona.Edad, persona.Dni, persona.Sexo, persona.Peso, persona.Altura);
            */

        }
    }
}

