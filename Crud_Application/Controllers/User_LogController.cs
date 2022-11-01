using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Core.Objects;
using Crud_Application.Models;

namespace Crud_Application.Controllers
{
    public class User_LogController : Controller
    {
        // GET: User_Log
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login_page()
        {
            
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult login_click(Loginclass ob)
        {
            if (ModelState.IsValid)
            {
                WebappEntities dbobj = new WebappEntities();
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(ob.uname, ob.pwd, op);
                int outputvalue = Convert.ToInt32(op.Value);
                if (outputvalue == 1)
                {
                    Session["uname"] = ob.uname;
                    // return RedirectToAction("login_page", ob);
                    return RedirectToAction("Dash_load", "Dash", ob);
                    

                }
                else
                {
                    ob.msg = "Invalid Username and Password";
                    return RedirectToAction("login_page", ob);
                }
            }
            return RedirectToAction("login_page", ob);
        }
    }
}