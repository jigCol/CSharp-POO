using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
        //Agregale los siguientes atributos:
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).

        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;
        private int nConfirmacion;


        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }


        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca { get { return marca; } }
        public string NumeroTelefonico { get; set; }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        public int NConfirmacion
        {
            set
            {
                if(value == 1 || value == 2)
                {
                    nConfirmacion = value;
                }
                else
                {
                    nConfirmacion = 2;
                }
            }
        }


        

        public void ConfirmacionLlamada()
        {
            if (nConfirmacion == 1)
            {
                Console.WriteLine("Seleccione el contacto:\n1-Ana\n2-Juan\n3-Pepito\n");
            }
            else
            {
                Console.WriteLine("No se realizara la llamada a ningun contacto.");
            }   

        }
   

        public string Llamar()
        {
            return "Realizando llamada...";
        }
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto + "...";
        }
    }
}
