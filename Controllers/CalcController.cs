using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers;

public class CalcController : Controller
{
    public ActionResult Index()
    {
        return View(new Calc());
    }

    [HttpPost]
    public ActionResult Index(Calc c,string calculate)
    {
        if(calculate == "add")
        {
            c.tot = c.no1 + c.no2;
        } else if(calculate == "min")
        {
            c.tot = c.no1 - c.no2;
        } else if(calculate == "sub")
        {
            c.tot = c.no1 * c.no2;
        } else if(calculate == "div")
        {
            c.tot = c.no1 / c.no2;
        }

        return View(c);
    }
}