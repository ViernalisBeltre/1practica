using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class OracionController : Controller
    {
        
        public ActionResult ContarVocales(string frase)
        {
            if (string.IsNullOrEmpty(frase))
            {
                ViewBag.Resultado = "Mis Vocales.";
            }
            else
            {
                int cantidad = frase
                                .ToLower()
                                .Count(c => "aeiou".Contains(c)); 
                ViewBag.Resultado = $"La frase \"{frase}\" tiene {cantidad} vocales.";
            }

            return View();
        }
    }
}