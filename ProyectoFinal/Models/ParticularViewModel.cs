using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class ParticularViewModel:ClientePadreModel
    {

        public ParticularViewModel(int Id, string Nacionalidad, string Provincia, string Direccion, string Telefono, string DNI, string Apellido, string Nombre):base(Id, Nacionalidad, Provincia, Direccion, Telefono, DNI, Apellido, Nombre)
        {

        }
    }
}