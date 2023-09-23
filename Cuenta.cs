using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Cuenta
    {
        public string titular;
        public float cantidad;



        //Constructor
        public Cuenta(string titularParam, int cantidadParam)
        {
            titular = titularParam;
            cantidad = cantidadParam;
        }

        // Metodos
        public string Titular { get => titular; set => titular = value; }
        public float Cantidad { get => cantidad; set => cantidad = value; }

        public void Deposito(float cantidadIngresada)
        {
            if(cantidadIngresada > 0)
            {
                cantidad = cantidad + cantidadIngresada;
            }
            else
            {
                return;
            }
        }

        public void Retiro( float cantidadIngresada)
        {
            if(cantidadIngresada > 0)
            {
                if (cantidadIngresada <= cantidad)
                {
                    cantidad = cantidad - cantidadIngresada;
                }
                else
                {
                    cantidad = 0;
                }
            }
            else
            {
                return;
            }
        }
    }

   
}
