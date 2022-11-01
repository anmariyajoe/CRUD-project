using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud_Application.Models;

namespace Crud_Application.Controllers
{
    public class DashController : Controller
    {
        // GET: Dash
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dash_load()
        {
           
            WebappEntities dbobj = new WebappEntities();
            var getdata = dbobj.sp_dashboard();
            
             return View(dbobj.User_Reg.ToList());


        }
    }
}