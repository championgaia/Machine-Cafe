using Interface.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Interface.Controllers
{
    public class HomeController : Controller
    {
        // Page Accueil
        public ActionResult Accueil()
        {
            return View();
        }
        // Get all Drink, choose a drink
        public ActionResult Index()
        {
            ListBoissonViewModel boissons = new ListBoissonViewModel(0);
            return View(boissons);
        }
        // Choose quantiy of sugar
        public ActionResult CreatSelectionSucre(int idBoisson)
        {
            ChoixBoissonSucreViewModel choixBoissonSucre = new ChoixBoissonSucreViewModel(idBoisson);
            return View(choixBoissonSucre);
        }
        // Choose to use personal mug
        public ActionResult CreatSelectionSucreMug(int idBoisson, int idSucre)
        {
            ChoixBoissonSucreMugViewModel choixBoissonSucreMug = new ChoixBoissonSucreMugViewModel(idBoisson, idSucre);
            return View(choixBoissonSucreMug);
        }
        // Create selection
        public ActionResult CreatSelection(int idBoisson, int idSucre, bool mugPerso)
        {
            ChoixBoissonSucreMugViewModel choixBoissonSucreMug = new ChoixBoissonSucreMugViewModel(idBoisson, idSucre)
            {
                MugPerso = mugPerso
            };
            choixBoissonSucreMug.CreateSelectionViewModel(choixBoissonSucreMug);
            Thread.Sleep(3000);
            return RedirectToAction("Service");
        }
        //Waiting Page
        public ActionResult Service()
        {
            return View();
        }
    }
}