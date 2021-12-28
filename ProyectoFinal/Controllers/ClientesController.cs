using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFinal.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            List<ParticularViewModel> list;
            using (EmpresaEntities db = new EmpresaEntities())
            {
                list = (from d in db.Clientes
                        select new ParticularViewModel
                        {
                            Id = d.Id,
                            Nacionalidad = d.Nacionalidad,
                            Provincia = d.Provincia,
                            Direccion = d.Direccion,
                            Telefono = d.Telefono,
                            DNI = d.DNI,
                            Nombre = d.Nombre,
                            Apellido = d.Apellido
                        });
            }

            return View();
        }
    }
}