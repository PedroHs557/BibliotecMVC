using BibliotecMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace BibliotecMVC.Controllers;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        ModelState.AddModelError("", "Autenticação ainda não implementada");
        
        return View(model); 
            
        

    }
}
