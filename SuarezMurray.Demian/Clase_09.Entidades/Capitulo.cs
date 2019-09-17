using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }
        private Capitulo(int num, string tit, int pag)
        {
            this.numero = num;
            this.titulo = tit;
            this.paginas = pag;
        }        
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }
        public int Paginas
        {
            get
            {
                return this.paginas;
            }
        }
        public static implicit operator Capitulo (string tit)
        {
            Capitulo cap = new Capitulo(Capitulo.generadorDeNumeros.Next(1,65),
                                        tit,Capitulo.generadorDePaginas.Next(15,233));            
            return cap;
        }
        public static bool operator == (Capitulo cap1, Capitulo cap2)
        {
            bool retBool = false;
            if (cap1.Titulo == cap2.Titulo)
            {
                if (cap1.Numero == cap2.Numero)
                {
                    retBool = true;
                }
            }
            return retBool;
        }
        public static bool operator !=(Capitulo cap1, Capitulo cap2)
        {
            return !(cap1 == cap2);
        }
    }
}


/*
 *  (I)(-)Capitulo()
 *  (-)Capitulo(int,string,int)
 *  (+)implicit(string):Capitulo
 *  (+)==(Capitulo,Capitulo):bool  Si numeros y titulos son iguales -> true
 * 
 */
