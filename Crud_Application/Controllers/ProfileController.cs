using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Crud_Application.Models;

namespace Crud_Application.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Profileload()
        {
            WebappEntities dbobj = new WebappEntities();
            var getdata = dbobj.sp_profile(Session["uname"].ToString()).FirstOrDefault();
            return View(new profilecls
            {
                Name = getdata.Name,
                Emai = getdata.Emai,
                Mobileno=getdata.Mobileno,
                Country=getdata.Country,
                Image=getdata.Image,


            });
        }
        
        public ActionResult profile_update(profilecls obj)
        {
            if (ModelState.IsValid && false)
            {
                WebappEntities dbobj = new WebappEntities();
                dbobj.sp_profile_update(Session["uname"].ToString(), obj.Name, obj.Emai, obj.Mobileno, obj.Country, obj.Image);
                obj.msg = "Successfully Updated";
                return View("Profileload", obj);

            }
            return View("Profileload", obj);
        }


    //    public ActionResult Profile_delete(profilecls obj1)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            WebappEntities dbobj1 = new WebappEntities();
    //            dbobj1.sp_delete();
    //            obj1.msg = "Successfully Updated";
    //            return View("Profileload", obj1);

    //        }
    //        return View("Profileload", obj1);
    //    }
    //}

    public ActionResult Profile_signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("login_page", "User_Log");
        }
    }
}