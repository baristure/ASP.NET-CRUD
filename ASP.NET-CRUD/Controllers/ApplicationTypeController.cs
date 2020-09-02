﻿using ASP.NET_CRUD.Data;
using ASP.NET_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.NET_CRUD.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View(objList);
        }


        // GET - CREATE
        public IActionResult Create()
        {

            return View();
        }


        // POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType obj)
        {
            _db.ApplicationType.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
