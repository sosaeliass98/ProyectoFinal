using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class ClientePadreModel
    {
        public ClientePadreModel(int Id, string nacionalidad, string provincia, string direccion, string telefono, string dNI, string apellido, string nombre)
        {
            
            Nacionalidad = nacionalidad;
            Provincia = provincia;
            Direccion = direccion;
            Telefono = telefono;
            DNI = dNI;
            Apellido = apellido;
            Nombre = nombre;
        }

        public int Id { get; set; }
        public string Nacionalidad { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string DNI { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        


    }



}