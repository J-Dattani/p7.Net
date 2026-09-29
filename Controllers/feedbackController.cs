using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace p7.Models
{
    public class feedbackController : Controller
    {
        // GET: feedback
        [HttpGet]
        public ActionResult feedback1()
        {
            return View("feedback");
        }

        [HttpPost]
        public ActionResult feedback(feedback feedback)
        {
            if(ModelState.IsValid)
            {
                return View("thankyou", feedback);
            }
            return View(feedback);
        }
    }
}