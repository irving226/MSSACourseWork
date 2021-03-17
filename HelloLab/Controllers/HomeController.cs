﻿using HelloLab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloLab.Controllers
{
    public class HomeController : Controller
    {
      public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
           string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView", viewModel);

        }

    }
  

}


