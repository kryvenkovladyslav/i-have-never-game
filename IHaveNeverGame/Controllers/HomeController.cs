﻿using IHaveNeverGame.Models;
using IHaveNeverGame.Models.Domain;
using IHaveNeverGame.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IHaveNeverGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Question> questionRepository;
        private readonly IRepository<Player> playerRepository;
        private readonly ILogger<HomeController> logger;

        public HomeController(IRepository<Player> playerRepository, IRepository<Question> questionRepository,
            ILogger<HomeController> logger)
        {
            this.questionRepository = questionRepository;
            this.playerRepository = playerRepository;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
