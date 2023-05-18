using TP_LW4.Models;
using Microsoft.AspNetCore.Mvc;


namespace TP_LW4.Conrollers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model, string action)
        {
            if (action == "clear")
            {
                model.Num1 = 0;
                model.Num2 = 0;
                model.Operation = "Add";
                ViewBag.Result = null;
            }
            else
            {
                double result = 0;

                switch (model.Operation)
                {
                    case "Add":
                        result = model.Num1 + model.Num2;
                        break;
                    case "Subtract":
                        result = model.Num1 - model.Num2;
                        break;
                    case "Multiply":
                        result = model.Num1 * model.Num2;
                        break;
                    case "Divide":
                        result = model.Num1 / model.Num2;
                        break;
                }

                ViewBag.Result = result;
            }

            return View(model);
        }
    }

}