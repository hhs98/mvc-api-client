using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcClient.Models;

namespace MvcClient.Controllers;

public class ProductsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
  public IActionResult Create()
  {
    return View();
  }

  public IActionResult Edit(int id)
  {
    ViewData["id"] = id;
    return View();
  }

  public IActionResult Delete(int id)
  {
    return View();
  }
}
