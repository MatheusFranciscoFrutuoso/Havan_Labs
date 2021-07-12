﻿using Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class UsuarioController : Controller
    {
        List<Usuario> listaUsuarios = new List<Usuario>();

        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List()
        {
            return View(listaUsuarios);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Usuario model)
        {
            listaUsuarios.Add(model);
            return RedirectToAction("List");
        }
    }
}