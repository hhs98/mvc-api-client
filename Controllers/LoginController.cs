using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcClient.Models;

namespace MvcClient.Controllers;

public class LoginController : Controller
{
  public IActionResult Index()
    {
        return View();
    }
}
