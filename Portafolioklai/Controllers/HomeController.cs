using Microsoft.AspNetCore.Mvc;
using Portafolioklai.Models;

namespace Portafolioklai.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var modelo = new PortafolioViewModel
            {
                Nombre = "Klaimer Navarro",
                TituloProfesional = "Desarrollador de Software y Móviles",
                FotoPerfil = "/imagenes/perfil.jpeg", // Guarda tu foto en wwwroot/images/perfil.jpg
                Biografia = "Estudiante de ingeniería de software apasionado por la creación de aplicaciones móviles y soluciones modernas.",
                Email = "klaimernavarro3@gmail.com",
                GitHub = "https://github.com/?locale=es-419",
                LinkedIn = "#",
                Proyectos = new List<ProyectoModel>
                {
                    new ProyectoModel
                    {
                        Titulo = "Mini Ferretería Don Toño",
                        Descripcion = "UI administrativa móvil desarrollada en Flutter para la gestión de inventarios y procesos internos.",
                        Tecnologias = "Flutter, Dart",
                        ImagenUrl = "/imagenes/mini.jpeg", // Coloca la imagen en wwwroot/images/
                        EnlaceRepo = "https://github.com/Josuejm420/FerreteriaApp.git"
                    },
                    new ProyectoModel
                    {
                        Titulo = "Feriando",
                        Descripcion = "Aplicación móvil diseñada para la gestión y exploración de ferias y eventos locales.",
                        Tecnologias = "Flutter, Dart",
                        ImagenUrl = "/imagenes/feriando.jpeg", // Coloca la imagen en wwwroot/images/
                        EnlaceRepo = "https://github.com/Ronald12-wp/Feriando-Frontend_Hackathon.git"
                    }
                }
            };

            return View(modelo);
        }
    }
}