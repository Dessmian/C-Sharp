using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_09.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        public Libro(string tit, string aut, List<Capitulo> caps):this(tit,aut)
        {            
            this.capitulos = caps;
        }
        public Libro(string tit, string aut)
        {
            this.titulo = tit;
            this.autor = aut;
            this.capitulos = new List<Capitulo>();
        }
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }
        public int CantidadDeCapitulos
        {
            get
            {
                return this.capitulos.Count;
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
        }
        public int CantidadDePaginas
        {
            get
            {
                int pags = 0;
                foreach(Capitulo cap in this.capitulos)
                {
                    pags += cap.Paginas;
                }
                return pags;
            }
        }        
        public Capitulo this [int i]
        {
            get
            {
                if (i>=0 && i<=this.capitulos.Count)
                {
                    return this.capitulos.ElementAt(i);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i>=0)
                {
                    if (i == this.capitulos.Count)
                    {
                        this.capitulos.Add(value);
                    }
                    else if (i < this.capitulos.Count) 
                    {
                        this.capitulos[i] = value;
                    }
                }               
            }
        }
    }
}
