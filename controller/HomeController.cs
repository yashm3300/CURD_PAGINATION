using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace pagination.controller
{
    public class HomeController : HomeController

    {
        Database_Access_Layer.db dbop = new Database_Access_Layer.db();
        public IActionResult Index()
        {
            return View(dbop.GetCategory(1  ));

        }
        [httpPost]

        public IActionResult Index(int currentPageIndex)
        {
            return View(dbop.GetCategory(currentPageIndex));

        }
        public IActionResult About()
        {
            ViewData["Message"] = "your Appliation Description Page"
            return View();

        }


    }
}