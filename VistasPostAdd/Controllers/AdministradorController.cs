﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VistasPostAdd.Controllers
{
    public class AdministradorController : Controller
    {
        // GET: Administrador
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Publicaciones()
        {
            return View();

        }
        public ActionResult Usuarios()
        {
            return View();
        }

        public ActionResult Configuracion()
        {
            return View();
        }

    }
}