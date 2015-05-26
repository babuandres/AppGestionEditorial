using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Formato
    {
        #region "Atributos"
        public int codigo;
        public string nombre;
        public bool leer;
        public bool guardar;
        public bool imprimir;
        public bool editar;
        public bool escuchar;
        public bool visualizar;
     
        #endregion

    #region "Propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Leer
        {
            get { return leer; }
            set { leer = value; }
        }

         public bool Guardar
        {
            get { return guardar; }
            set { guardar = value; }
        }

        public bool Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }

        public bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }

        public bool Escuchar
        {
            get { return escuchar; }
            set { escuchar = value; }
        }

         public bool Visualizar
        {
            get { return visualizar; }
            set { visualizar = value; }
        }

       
        #endregion

    #region "Constructores"
        public Formato()
        {
  
            this.codigo = 000000;
            this.nombre = "nombre";
            this.leer = true;
            this.guardar = true;
            this.imprimir = true;
            this.editar = true;
            this.escuchar = true;
            this.visualizar = true;
            
           
        }

        public Formato(int codigo, string nombre, bool leer, bool guardar, bool imprimir, bool editar, bool escuchar, bool visualizar)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.leer = leer;
            this.guardar = guardar;
            this.imprimir = imprimir;
            this.editar = editar;
            this.escuchar = escuchar;
            this.visualizar = visualizar;
            
        }
        #endregion

    #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n______________________" +
                     "\n Codigo De La Factura  " + this.codigo +
                     "\n Nombre  " + this.nombre +
                     "\n Leer: " + this.leer +
                     "\n Guardar: " + this.guardar +
                     "\n Imprimir: " + this.imprimir +
                     "\n Editar: " + this.editar +
                     "\n Escuchar: " + this.escuchar +
                     "\n Visualizar: " + this.visualizar;
                     
        }

        public override bool Equals(object obj)
        {
            Formato f = (Formato)obj;
            bool result = false;

            if ((this.codigo == f.codigo) &&
                (this.nombre == f.nombre) &&
                (this.leer == f.leer) &&
                (this.guardar == f.guardar) &&
                (this.imprimir == f.imprimir) &&
                (this.editar == f.editar)&&
                (this.escuchar == f.escuchar) &&
                (this.visualizar == f.visualizar))

                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}