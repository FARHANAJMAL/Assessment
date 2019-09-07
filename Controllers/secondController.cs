using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Controllers
{
    public class secondController : Controller
    {
        private ASMTContext ORM = null;
        private ASMTContext _ORM;

        public secondController(ASMTContext _ORM)
        {
            ORM = _ORM;
        }




        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(Post p)
        {
            ORM.Post.Add(p);

            ORM.SaveChanges();
            return View();
        }

    }
}