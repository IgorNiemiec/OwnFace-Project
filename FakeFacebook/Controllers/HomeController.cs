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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore.Infrastructure;

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


       // GET: Home
        
        public IActionResult Index()
        {
            return View();

        }

        //POST Index
        [HttpPost]
       public ActionResult Index(LoginAccount login)
        {

            var Model = _context.Account.Any(x => x.Email == login.Email && x.Password == login.Password);

            
                if (Model)
                {
                
                return NoContent();
                }
                else
                {

                ViewBag.valid = "Podałeś nieprawdziwy Email";
                ViewBag.validPass = "Podałeś nieprawidłowe hasło";
           
                return View();
             
                }
          
        
            


        }










       
    }
}
