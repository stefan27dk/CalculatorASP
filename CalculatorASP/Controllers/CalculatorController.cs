using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorASP.Models;
using CalculatorASP.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorASP.Controllers
{
    public class CalculatorController : Controller
    {
        ICalculatorService calculatorService; // Declare Interface 

        // Constructor
        public CalculatorController(ICalculatorService calculatorService) // Den tager Interface
        {
            this.calculatorService = calculatorService;
        }

        
        // Index
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }



        [HttpPost]
        public ActionResult Index(CalculatorModel c, string op)  // "Calculate is in the button name - name="op"
        {              
           c.result = calculatorService.Calculate(c.input1,c.input2, op);
                        
            return View(c);
        }

    }
}
