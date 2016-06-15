using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMVC;
namespace EntityFWUsingRepo.Controllers
{
    public class DB1Controller : Controller
    {
        // GET: DB1
        public ActionResult Index()
        {
            Repo obj = new Repo();
            return View(obj.GetJobs());
        }

    }
}