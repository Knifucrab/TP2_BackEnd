using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public abstract class Electrodomestico
    {
        public double precio;
        public string color = "";
        public char consumoEnergetico;
        public int peso;

        //Constructor

        public Electrodomestico()
        {

        }
        public Electrodomestico(double precio, string color, char consumoEnergetico, int peso)
        {
            precio = 0;
            color = "null";
            consumoEnergetico = 'A';
            peso = 0;
        }

        // Metodos
        public bool ValidarConsumoEnergetico(char letra)
        {
            if(letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'F' || letra == 'E')
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ComprobarColor(string color)
        {
            Console.WriteLine(color);
            Console.ReadLine();

            if(color == "blanco" || color == "negro" || color == "rojo" || color == "azul" || color == "verde")
            {
                return true;
            }
            else { return false; }
        }

        public double precioFinal(char consumoEnergetico, int peso, double precio)
        {
            if(consumoEnergetico == 'A')
            {
                precio = precio + 100;
            } else if(consumoEnergetico == 'B')
            {
                precio = precio + 80;
            }
            else if (consumoEnergetico == 'C')
            {
                precio = precio + 60;
            }
            else if (consumoEnergetico == 'D')
            {
                precio = precio + 50;
            }
            else if (consumoEnergetico == 'E')
            {
                precio = precio + 30;
            }
            else if (consumoEnergetico == 'F')
            {
                precio = precio + 10;
            }

            if (peso is >= 0 and <= 19)
            {
                precio = precio + 10;
            } else if(peso is >= 20 and <= 49)
            {
                precio = precio + 50;
            }
            else if (peso is >= 50 and <= 79)
            {
                precio = precio + 80;
            }
            else if (peso is >= 80)
            {
                precio = precio + 100;
            }

            

            return precio;
        }


    }

    public class Lavadora : Electrodomestico
    {
        public int carga;

       //Constructores



        //Constructor por defecto
        public Lavadora()
        {
        
        }

        //Constructor con precio y peso
        public Lavadora(double precio, int peso)
        {

        }

        public Lavadora(int Carga, int Peso, string Color, double Precio, char ConsumoEnergetico)
        {
            precio = Precio;
            color = Color;
            consumoEnergetico = ConsumoEnergetico;
            peso = Peso;
            carga = Carga;
        }

        // Metodo

        public double precioFinal(int carga, char consumoEnergetico, int peso, double precio)
        {

            if (consumoEnergetico == 'A')
            {
                precio = precio + 100;
            }
            else if (consumoEnergetico == 'B')
            {
                precio = precio + 80;
            }
            else if (consumoEnergetico == 'C')
            {
                precio = precio + 60;
            }
            else if (consumoEnergetico == 'D')
            {
                precio = precio + 50;
            }
            else if (consumoEnergetico == 'E')
            {
                precio = precio + 30;
            }
            else if (consumoEnergetico == 'F')
            {
                precio = precio + 10;
            }

            if (peso is >= 0 and <= 19)
            {
                precio = precio + 10;
            }
            else if (peso is >= 20 and <= 49)
            {
                precio = precio + 50;
            }
            else if (peso is >= 50 and <= 79)
            {
                precio = precio + 80;
            }
            else if (peso is >= 80)
            {
                precio = precio + 100;
            }

            if (carga > 30)
            {
                precio = precio + 50;
            }

            return precio;
        }

        

    }


    public class Television : Electrodomestico
    {
        public int resolucion; // en pulgadas

        //Constructores


        //Constructor default
        public Television()
        {

        }

        //Constructor con precio, peso y resolucion opcional
        public Television(double Precio, int Peso, int Resolucion = 0 )
        {
            precio = Precio;
            peso = Peso;
            resolucion = Resolucion;
        }

        // Constructor con todos los atributos heredados y resolucion
        public Television(double Precio, int Peso, string Color, char ConsumoEnergetico, int Resolucion)
        {
            precio = Precio;
            peso = Peso;
            resolucion = Resolucion;
            color = Color;
            consumoEnergetico = ConsumoEnergetico;
        }

        //Metodos
        public double precioFinal(int resolucion, char consumoEnergetico, int peso, double precio)
        {
            if (consumoEnergetico == 'A')
            {
                precio = precio + 100;
            }
            else if (consumoEnergetico == 'B')
            {
                precio = precio + 80;
            }
            else if (consumoEnergetico == 'C')
            {
                precio = precio + 60;
            }
            else if (consumoEnergetico == 'D')
            {
                precio = precio + 50;
            }
            else if (consumoEnergetico == 'E')
            {
                precio = precio + 30;
            }
            else if (consumoEnergetico == 'F')
            {
                precio = precio + 10;
            }

            if (peso is >= 0 and <= 19)
            {
                precio = precio + 10;
            }
            else if (peso is >= 20 and <= 49)
            {
                precio = precio + 50;
            }
            else if (peso is >= 50 and <= 79)
            {
                precio = precio + 80;
            }
            else if (peso is >= 80)
            {
                precio = precio + 100;
            }

            if(resolucion > 40)
            {
                precio = precio * 1.3;
            }

            return precio;
        }
    }
}
