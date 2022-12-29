using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredicadosLambdas
{
    internal class Program
    {
        // Definición del objeto delegado
        delegate void ObjetoDelegado(string msj);
        static void Main(string[] args)
        {
            // ObjetoDelegado Apuntando a mensaje Bienvenida
            ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            //Utilización del delegado para llamar al método saludo bienvenida
            elDelegado("Hola acabo de llegar");

            elDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            //Utilización del delegado para llamar al método saludo despedida
            elDelegado("Hola ya me voy");

        }

    }

    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj) => Console.WriteLine("Mensaje de bienvenida: {0}", msj);
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj) => Console.WriteLine("Mensaje de despedida: {0}", msj);
    }
}
