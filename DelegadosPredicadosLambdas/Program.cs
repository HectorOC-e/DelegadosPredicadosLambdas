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
        //delegate void ObjetoDelegado(string msj);
        //public delegate int OperacionesMatematicas(int numero1, int numero2);
        public delegate bool ComparaPersonas(string n1, string n2);
        static void Main(string[] args)
        {
            //// ObjetoDelegado Apuntando a mensaje Bienvenida
            //ObjetoDelegado elDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

            ////Utilización del delegado para llamar al método saludo bienvenida
            //elDelegado("Hola acabo de llegar");

            //elDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

            ////Utilización del delegado para llamar al método saludo despedida
            //elDelegado("Hola ya me voy");

            //List<int> listaNumeros = new List<int>();

            //listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            ////Declaramos delegado predicado
            //Predicate<int> delegadoPred = new Predicate<int>(EsPar);
            //Predicate<int> esPrimo = new Predicate<int>(EsPrimo);

            //List<int> numPares = listaNumeros.FindAll(delegadoPred);

            //foreach (int num in numPares) Console.WriteLine(num);

            //List<int> numPrimos = listaNumeros.FindAll(esPrimo);

            //foreach (int num in numPrimos) Console.WriteLine(num);

            //List<Personas> gente = new List<Personas>();

            //Personas p1 = new Personas()
            //{
            //    Nombre = "Juan",
            //    Edad = 16
            //};
            //Personas p2 = new Personas()
            //{
            //    Nombre = "María",
            //    Edad = 7
            //};
            //Personas p3 = new Personas()
            //{
            //    Nombre = "Ana",
            //    Edad = 9
            //};

            //gente.AddRange(new Personas[] { p1, p2, p3 });

            //Predicate<Personas> predicado = new Predicate<Personas>(ExisteJuan);
            //Predicate<Personas> predicadoMayores = new Predicate<Personas>(ExisteMayoresDeEdad);

            //bool existe = gente.Exists(predicado);
            //bool hayMayores = gente.Exists(predicadoMayores);

            //if (existe) Console.WriteLine("Hay personas que se llaman Juan");
            //else Console.WriteLine("No hay nadie que se llame Juan");

            //if (hayMayores) Console.WriteLine("Hay personas mayores de edad");
            //else Console.WriteLine("No hay nadie mayor de edad");

            List<Personas> gente = new List<Personas>();

            Personas p1 = new Personas()
            {
                Nombre = "Juan",
                Edad = 16
            };
            Personas p2 = new Personas()
            {
                Nombre = "María",
                Edad = 16
            };

            ComparaPersonas comparaEdad = new ComparaPersonas((persona1,persona2) => persona1 == persona2);

            Console.WriteLine(comparaEdad(p1.Nombre,p2.Nombre));

            //Uso del delegado
            //OperacionesMatematicas operacion = new OperacionesMatematicas((num1, num2) => num1 + num2);

            //Console.WriteLine(operacion(4,2));

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //List<int> numerosPares = numeros.FindAll(i => i % 2 == 0);

            ////foreach (int numero in numerosPares) Console.WriteLine(numero);

            //numerosPares.ForEach(numero => {
            //    Console.WriteLine("El numero par es:");
            //    Console.WriteLine(numero); 
            //});



        }

        //static bool EsPar(int num)
        //{
        //    if (num % 2 == 0) return true;
        //    else return false;
        //}

        //static bool EsPrimo(int num)
        //{
        //    if (num == 1) return false;
        //    int i = 2;

        //    while (num%i != 0)
        //    {
        //        i++;
        //    }
        //    if (num == i) return true;
        //    else return false;
        //}

        //static bool ExisteJuan(Personas persona)
        //{
        //    if (persona.Nombre == "Juan") return true;
        //    else return false;
        //}

        //static bool ExisteMayoresDeEdad(Personas persona)
        //{
        //    if (persona.Edad >= 18) return true;
        //    else return false;
        //}

        public static int Cuadrado(int num) => num * num;
        public static int Suma(int num1, int num2) => num1 + num2;
    }

    //class MensajeBienvenida
    //{
    //    public static void SaludoBienvenida(string msj) => Console.WriteLine("Mensaje de bienvenida: {0}", msj);
    //}

    //class MensajeDespedida
    //{
    //    public static void SaludoDespedida(string msj) => Console.WriteLine("Mensaje de despedida: {0}", msj);
    //}

    class Personas
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
