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
    }
}