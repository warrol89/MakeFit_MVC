using MakeFitMVC.Business;
using MakeFitMVC.Business.Interface;
using MakeFitMVCWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakeFitMVCWeb.Controllers
{
    public class HomeController : Controller
    {
        public ILogin _loginService;

        public HomeController(Login loginService)
        {
            _loginService = loginService;

        }
        [HandleError]
        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel Model)
        {
            _loginService.CheckLoginDetails();
            return View();
        }
    }
}