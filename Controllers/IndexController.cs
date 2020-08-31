using PIDDS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIDDS.Controllers
{
    public class IndexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            List<IndexModel> newList = new List<IndexModel>();

            //Create first element.
            IndexModel newIndexModel = new IndexModel
            {
                ID = 1,
                Description = "First Item",
                Comments = "This is first instance of the model"
            };

            //Create second element.
            IndexModel newindexModel2 = new IndexModel
            {
                ID = 2,
                Description = "Second Item",
                Comments = "This is the second instance of the model"
            };

            newList.Add(newIndexModel);
            newList.Add(newindexModel2);


            return View();
        }
    }
}