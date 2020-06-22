using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FakeFacebook.Models;
using FakeFacebook.Dtos;

using FakeFacebook.Context;
using Microsoft.VisualBasic;
using AutoMapper;

namespace FakeFacebook.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        AccountContext _context;


        public HomeController(ILogger<HomeController> logger, AccountContext context)
        {
            _logger = logger;
            _context = context;
          


        }


        //GET Index
        public IActionResult Index()
        {
            return View();

        }

        //GET Index/Login
        [HttpGet]
       public IActionResult Login(string Email , string Password)
        {

            var Model = _context.Account.FirstOrDefault(x => x.Email == Email && x.Password == Password);


            if (Model != null)
            {
                return NotFound();
            }
            else
            {
                return NotFound();
            }
           


        }










       
    }
}
