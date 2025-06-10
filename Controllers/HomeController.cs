using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP5.Models;

namespace TP5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;     

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult introduccion(){
        return View("presentacionJuego");
    }

    public IActionResult Index()
    {
        Juego juego = new Juego();
        HttpContext.Session.SetString("juego",Objeto.ObjectToString(juego));

        return View();
    }

   public IActionResult empezarJuego(){
    return View("Sala1");
   }

    public IActionResult pasarDeSala(string clave){
     Juego juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("juego"));
        if(juego.pasarDeSala(clave)==true){  
            ViewBag.Victoria="Ha pasado de sala";
        }
        
        return View("Index");
    }

    
}
