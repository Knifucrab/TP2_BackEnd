using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Persona
    {
        public string nombre = "";
        public int edad;
        public float dni;
        public char sexo;
        public float peso;
        public float altura;




        //Constructor
        public Persona()
        {

        }

        public Persona(string Nombre, int Edad, char Sexo)
        {
            nombre = Nombre;
            edad = Edad;
            sexo = Sexo;
        }

        public Persona(string Nombre, int Edad, float DNIParam, char Sexo, float Peso, float Altura)
        {
            nombre = Nombre;
            edad = Edad;
            dni = DNIParam;
            sexo = Sexo;
            peso = Peso;
            altura = Altura;

        }

        // Metodos
        public int calcularIMC(float peso, float altura)
        {
            float altura_exponencial_2 = altura/100 * altura/100;
            float imc = peso / altura_exponencial_2;
            if (imc < 20)
            {
                return -1;
            }
            else if (imc is >= 20 and <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public bool esMayorDeEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char validarSexo(char sexo)
        {
            if(sexo == 'H')
            {
                return 'H';
            } else if(sexo == 'M')
            {
                return 'M';
            } else if(sexo == 'N')
            {
                return 'N';
            }
            else
            {
                return 'H';
            }
        }

        public string toString(string nombre,
        int edad,
        float dni,
        char sexo,
        float peso,
        float altura)
        {
            string imc;
            string mayorEdad;
            sexo = validarSexo(sexo);

            if (calcularIMC(peso, altura) == -1)
            {
                imc = "Esta por debajo de su peso ideal";

            }
            else if(calcularIMC(peso, altura) == 0)
            {
                imc = "Se encuentra en su peso ideal";
            }
            else
            {
                imc = "Tiene sobrepeso";
            }

            if (esMayorDeEdad(edad) == true)
            {
                mayorEdad = "Verdadero";
            }
            else
            {
                mayorEdad = "Falso";
            }


            return $"Nombre: {nombre}\n" +
                $"Edad: {edad}\n" +
                $"DNI: {dni}\n" +
                $"Sexo validado: {sexo}\n" +
                $"Peso: {peso}\n" +
                $"Altura: {altura}cm\n" +
                $"IMC: {imc}\n" +
                $"Es mayor de edad: {mayorEdad}";

            /*

        Console.WriteLine(
            $"Nombre: {nombre}\n" +
            $"Edad: {edad}\n" +
            $"DNI: {dni}\n" +
            $"Sexo validado: {sexo}\n" +
            $"Peso: {peso}\n" +
            $"Altura: {altura}cm\n" +
            $"IMC: {imc}\n" +
            $"Es mayor de edad: {mayorEdad}");
            */
        }

    }
}


