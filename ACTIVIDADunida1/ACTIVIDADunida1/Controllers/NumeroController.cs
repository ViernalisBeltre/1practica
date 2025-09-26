using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
  
        public ActionResult Signo(string numero)
        {
            if (string.IsNullOrWhiteSpace(numero))
            {
                ViewBag.Resultado = "Introduce un número (puedes usar el formulario o escribir en la URL ?numero=5).";
            }
            else if (!int.TryParse(numero.Trim(), out int n))
            {
                ViewBag.Resultado = "Valor no válido. Por favor ingresa un número entero (ejemplo: 5, -3, 0).";
            }
            else
            {
                string mensaje = n > 0 ? "Positivo" : (n < 0 ? "Negativo" : "Cero");
                ViewBag.Resultado = $"El número {n} es {mensaje}.";
            }

            return View();
        }
    }
}
