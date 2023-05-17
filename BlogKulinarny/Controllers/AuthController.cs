﻿using BlogKulinarny.Data.Services;
using BlogKulinarny.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogKulinarny.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool isAuthenticated = _authService.Login(model.EmailOrLogin, model.Password);

                if (isAuthenticated)
                {
                    // Przekieruj do głównej strony po zalogowaniu
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Nieprawidłowe dane logowania.");
            }

            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
