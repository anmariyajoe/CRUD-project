using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud_Application.Models;

namespace Crud_Application.Controllers
{
    public class User_RegController : Controller
    {
        // GET: User_Reg
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult reg_pageload()
        {
            return View();

        }

        public ActionResult reg_click(userinsert ob, HttpPostedFileBase file)
        {

            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    String filename = Path.GetFileName(file.FileName);
                    String p = Path.Combine(Server.MapPath("/Image"), filename);
                    file.SaveAs(p);
                    var pa = Path.Combine("~//Image", filename);
                    ob.Image = pa;
                }
               WebappEntities dbobj = new WebappEntities();
                dbobj.sp_insert(ob.Name, ob.Email, ob.Mobileno, ob.Country, ob.Image, ob.Username, ob.Password);
                ob.msg = "Successfully Inserted";
                ModelState.Clear();
                return View("reg_pageload", ob);
            }
            return View("reg_pageload", ob);
        }
    }
}