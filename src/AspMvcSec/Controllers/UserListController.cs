﻿using System;
using System.Web.Mvc;
using AspMvcSec.DataAccess;
using AspMvcSec.Models;

namespace AspMvcSec.Controllers
{
  //// CORS
  //[EnableCors("*","","")]
  [Authorize]
  public class UserListController : Controller
  {
    private IUserRepository _repository;

    public UserListController() : this(new UserRepository())
    {
      
    }
    public UserListController(IUserRepository repository)
    {
      _repository = repository;
    }

    // GET: UserList
    public ActionResult Index()
    {
      return View(_repository.GetAll());
    }

    [HttpGet]
    [ActionName("Create")]
    public ActionResult CreateGet(User user)
    {
      return View(user);
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
      _repository.Delete(id);
      return RedirectToAction("Index");
    }

    // POST: UserList/Create
    [HttpPost]
    public ActionResult Create(User user)
    {
      try
      {
        _repository.Add(user);

        return RedirectToAction("Index");
      }
      catch(Exception ex)
      {
        return View();
      }
    }
  }
}
