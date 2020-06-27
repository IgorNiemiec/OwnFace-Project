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
        private readonly IMapper _mapper;

        AccountContext _context;
        


        public HomeController(ILogger<HomeController> logger, AccountContext context , IMapper mapper)
        {
            _logger = logger;
            _context = context;
            _mapper = mapper;
          


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

                return View();
                }
                else
                {

                ViewBag.valid = "Podałeś nieprawdziwy Email";
                ViewBag.validPass = "Podałeś nieprawidłowe hasło";
           
                return View();
             
                }
          
        
            


        }

        [HttpPost]
        public ActionResult Create(CreateAccountDto create)
        {

          

          var Model = _mapper.Map<Account>(create);

           

            _context.Account.Add(Model);


            _context.SaveChanges();


            return View("Index");




        }










       
    }
}
