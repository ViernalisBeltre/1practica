using Microsoft.AspNetCore.Mvc;

namespace ACTIVIDADunida1.Controllers
{
    public class 
        PresentacionController1 : Controller
    {
        public IActionResult Saludo()
   

        {
           
            ViewBag.Mensaje= "Hola!! me llamo Viernalis,Mi Matricula es SD-2022-0400";

            return View();
        }
    }
}
  