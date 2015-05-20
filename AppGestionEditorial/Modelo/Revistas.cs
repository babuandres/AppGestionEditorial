using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Revistas : Documentos
    {
        #region "Atributos"
        private int volumen;        
        #endregion

        #region "Propiedades"
        public int Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }
        #endregion

        #region "Constructores"

        public Revistas():base()
        {
            this.volumen = 1;
        }

        public Revistas (string nombre, string codigo, string autor, string editorial, string fechaDePublicacion, int volumen):
            base(nombre, codigo, autor, editorial, fechaDePublicacion)
        {
            this.volumen = volumen;
        }
        #endregion

        #region "Metodos Sobre Escritos"

        public override string ToString()
        {
            return base.ToString() +
                "\n Volumenes: " + this.volumen;
        }

        public override bool Equals(object obj)
        {
            Revistas doc = (Revistas)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.volumen == doc.volumen))
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