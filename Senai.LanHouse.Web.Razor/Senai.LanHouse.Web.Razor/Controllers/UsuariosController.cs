using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.LanHouse.Web.Razor.Contextos;
using Senai.LanHouse.Web.Razor.Dominios;

namespace Senai.LanHouse.Web.Razor.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly LanHouseContext _context;

        public UsuariosController(LanHouseContext context)
        {
            _context = context;
        }


        // GET: Login/Create
        public IActionResult Create()
        {
            HttpContext.Session.Clear();
            return View();
        }

        //verificar se ele existe

        // POST: Usuarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Senha")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                Usuarios retorno = _context.Usuarios.FirstOrDefault(x => x.Email.ToLower() == usuarios.Email.ToLower() && x.Senha == usuarios.Senha);
                
                if(retorno == null)
                {
                    ViewBag.Mensagem = "Email ou senha inválidos, tente novamente.";
                    return View(usuarios);
                }

                //projeto rápido é melhor usar sessão para autenticar
                HttpContext.Session.SetString("email", usuarios.Email);
                return RedirectToAction("Index", "RegistrosDefeitos");

                //return RedirectToAction(nameof(Index));
            }
            return View(usuarios);
        }
    }
}
