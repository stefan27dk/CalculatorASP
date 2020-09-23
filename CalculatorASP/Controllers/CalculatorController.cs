using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorASP.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel c, string calculate)  // "Calculate is in the button name - name="calculate"
        {
            // Add
            if (calculate == "add")
            {
                c.result = c.input1 + c.input2;
            }

            // Minus
           else if (calculate == "min")
            {
                c.result = c.input1 - c.input2;
            }


            // Subtract
            else if (calculate == "sub")
            {
                c.result = c.input1 * c.input2;
            }


            // Divide
            else
            {
                c.result = c.input1 / c.input2;
            }

            return View(c);
        }

    }
}
