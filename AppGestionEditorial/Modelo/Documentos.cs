using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Documentos
    {
        #region "Atributos"
        private string nombre;        
        private string codigo;        
        private string autor;        
        private string editorial;        
        private string fechaDePublicacion;        
        #endregion

        #region "Propiedades"
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string FechaDePublicacion
        {
            get { return fechaDePublicacion; }
            set { fechaDePublicacion = value; }
        }
        #endregion

        #region "Constructores"

        public Documentos()
        {
            this.nombre = "NombreLibro";
            this.codigo = "XXXXXX";
            this.autor = "Nombre Autor";
            this.editorial = "Nombre Editorial";
            this.fechaDePublicacion = "dd/mm/aaaa";
        }

        public Documentos(string nombre, string codigo, string autor, string editorial, string fechaDePublicacion)
        {
            this.nombre = nombre;
            this.codigo = codigo;
            this.autor = autor;
            this.editorial = editorial;
            this.fechaDePublicacion = fechaDePublicacion;
        }

        #endregion
    }
}