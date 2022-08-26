using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreWebApp.Controllers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "returning from HomeController Index action method";
        }
    }
}
