using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Cientificos : Documentos
    {
        #region "Atributos"
        private string tema;        
        #endregion

        #region "Propiedades"
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        #endregion

        #region "Constructores"
        public Cientificos(): base ()
        {
            this.tema = "Tema del Texto Cientifico: ";
        }

        public Cientificos (string nombre, string codigo, string autor, string editorial, string fechaDePublicacion, string tema):
            base(nombre, codigo, autor, editorial, fechaDePublicacion)
        {
            this.tema = tema;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n Tema: " + this.tema;
        }

        public override bool Equals(object obj)
        {
            Cientificos doc = (Cientificos)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.tema == doc.tema))
                result = true;
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}