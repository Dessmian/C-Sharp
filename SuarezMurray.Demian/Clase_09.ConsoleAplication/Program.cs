using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_09.Entidades;

namespace Clase_09.ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int paginasTotales;
            List<Capitulo> listaCaps = new List<Capitulo>();
            Capitulo c1 = "Primer Capitulo";
            Capitulo c2 = "Segundo Capitulo";
            Capitulo c3 = "Tercer Capitulo";
            listaCaps.Add(c1);
            listaCaps.Add(c2);
            listaCaps.Add(c3);
            Libro l1 = new Libro("titulo", "autor", listaCaps);
            paginasTotales = l1.CantidadDePaginas;


            Console.WriteLine("{0}, {1}, {2}", c1.Numero.ToString(), c1.Titulo, c1.Paginas.ToString());
            Console.WriteLine("{0}, {1}, {2}", c2.Numero.ToString(), c2.Titulo, c2.Paginas.ToString());
            Console.WriteLine("{0}, {1}, {2}", c3.Numero.ToString(), c3.Titulo, c3.Paginas.ToString());
            Console.WriteLine("Cantida de paginas {0}", l1.CantidadDePaginas);


            Capitulo c4 = "Cuarto Capitulo";
            l1[5] = c4;
            paginasTotales += c4.Paginas;
            Console.WriteLine("\n\nPaginas en libro: {0}", l1.CantidadDePaginas);
            Console.WriteLine("Paginas creadas: {0}", paginasTotales);


            Capitulo c5 = "Quinto Capitulo";
            paginasTotales += c5.Paginas;
            l1[10] = c5;
            Console.WriteLine("\n\nPaginas en libro: {0}", l1.CantidadDePaginas);
            Console.WriteLine("Paginas creadas: {0}", paginasTotales);


            Console.ReadKey();*/

            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");
            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";
            miLibro[-1] = "Genero un índice erroneo";
            miLibro[5] = "Genero otro índice erroneo";

            Console.WriteLine("Libro:");
            Console.WriteLine("Titulo: {0}", miLibro.Titulo);
            Console.WriteLine("Autor: {0}", miLibro.Autor);
            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantidadDePaginas);

            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)
            {
                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);
            }

            Console.ReadLine();
        }
    }
}


/*
 * Libro 
 * 
 * (-)titulo : string
 * (-)autor : string
 * (-)capitulos : List<Capitulo>
 * 
 * Propiedades (Solo Lectura)
 *      Titulo : string
 *      Autor : string
 *      CantidadDePaginas : int
 */