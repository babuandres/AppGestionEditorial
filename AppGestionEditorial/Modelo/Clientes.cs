using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelo
{
    public class Clientes
    {
        #region "Atributos"
        public int id;
        public string nombres;
        public string apellidos;
        public string direccion;
        public int telefono;
        public string email;

        #endregion

        #region "Propiedades"
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        #endregion

        #region "Constructores"
        public Clientes()
        {

            this.id = 000000;
            this.nombres = "nombre";
            this.apellidos = "apellidos";
            this.direccion = "direccion";
            this.telefono = 300604854;
            this.email = "email@hotmail.com";

        }

        public Clientes(int id, string nombres, string apellidos, string direccion, int telefono, string email)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return"\n______________________" +
                     "\n Id: " + this.id +
                     "\n Nombres: " + this.nombres +
                     "\n Apellidos: " + this.apellidos +
                     "\n Direccion: " + this.direccion +
                     "\n Telefono: " + this.telefono +
                     "\n Email: " + this.email;

        }

        public override bool Equals(object obj)
        {
            Clientes c = (Clientes)obj;
            bool result = false;

            if ((this.id == c.id) &&
                (this.nombres == c.nombres) &&
                (this.apellidos == c.apellidos) &&
                (this.direccion == c.direccion) &&
                (this.telefono == c.telefono) &&
                (this.email == c.email))

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