using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Verificador_de_CPF.Models;

namespace Verificador_de_CPF.Controllers;


public class HomeController : Controller
{
    
    /* metodo index*/
    public IActionResult Index()
    {
        return View();
    }

    /* metodo privadcidade*/
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    /*metodo erro*/

    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
