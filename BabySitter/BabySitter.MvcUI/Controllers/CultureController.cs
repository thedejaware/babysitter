using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace BabySitter.MvcUI.Controllers
{
    public class CultureController : Controller
    {
        // GET: Culture

        public ActionResult Action()
        {
            return View();
        }

        public ActionResult SetCulture(string paramCulture)
        {
            if (!string.IsNullOrEmpty(paramCulture))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(paramCulture);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(paramCulture);

                //Thread.CurrentThread.CurrentCulture = new CultureInfo(paramCulture);
                //Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = paramCulture;
            Response.Cookies.Add(cookie);

            return Redirect(Request.UrlReferrer.AbsoluteUri);

        }

    }
}