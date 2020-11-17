using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieMVC.Controllers;

namespace MovieMVC.Web.Controllers
{
    public class EmployeesController : MovieMVCControllerBase
    {
        public EmployeesController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}