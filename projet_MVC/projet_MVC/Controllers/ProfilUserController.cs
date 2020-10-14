using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetCoreData.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projet_MVC.Controllers
{
    public class ProfilUserController : Controller
    {
        private readonly DefaultContext _context = null;

        public ProfilUserController(DefaultContext context)
        {
            this._context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            this.ViewBag.Titre = "Liste des utilisateus";
            List<Utilisateur> utilisateursListe = new List<Utilisateur>();

            var query = from utilisateur in _context.Utilisateur
                        select utilisateur;
            return View(query.ToList());
            
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Utilisateur utilisateur)
        {
            this._context.Utilisateur.Add(utilisateur);
            this._context.SaveChanges();
            return RedirectToAction(nameof(All));
        }


        public IActionResult Edit(int id)
        {
            Utilisateur utilisateur = null;

            utilisateur = this._context.Utilisateur.First(item => item.id == id);
            return View(utilisateur);
        }

        [HttpPost]
        public IActionResult Edit(Utilisateur utilisateur)
        {
            this._context.Utilisateur.Update(utilisateur);
            this._context.SaveChanges();

            return View(utilisateur);
        }

    }
}
