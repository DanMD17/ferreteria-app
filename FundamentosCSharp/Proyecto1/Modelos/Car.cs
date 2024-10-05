using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto1.Modelos
{
    public class Car
    {
        /*
         * Atributos del carrito pe
         */
        string color;
        int cilindraje;
        int modelo;

        /*
         * Metodo que retorna el msj
         */

        public string stop()
        {
            string msj = "El carro esta detenido";
            return msj;
        }
    }
}