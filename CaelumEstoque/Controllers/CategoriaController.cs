﻿using System.Collections.Generic;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias= dao.Lista();
            ViewBag.Categorias = categorias;
            return View();
        }

        public ActionResult Adiciona()
        {
            return View();
        }

        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {

            return View(); 
        }
    }
}