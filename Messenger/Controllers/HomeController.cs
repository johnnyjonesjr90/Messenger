using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Messenger.Models;
using Messenger.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace Messenger.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MessengerContext _context;
        public readonly UserManager<MessengerUser> _userManager;
        

        public HomeController(MessengerContext context, UserManager<MessengerUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            var posts = await _context.Posts.ToListAsync();
            return View(posts);
        }
            public async Task<IActionResult> ChatHome()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            ViewModel viewModel = new ViewModel();
            viewModel.User = await _context.User.ToListAsync();
            viewModel.Messages = await _context.Messages.ToListAsync();
            //var messages = await _context.Messages.ToListAsync();
            //var user = await _context.User.ToListAsync();
            return View(viewModel);
        }
        public async Task<IActionResult> Create(Message message)
        {
            if (ModelState.IsValid)
            {
                message.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                message.UserID = sender.Id;
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                return RedirectToAction("ChatHome");
                

            }
            return Error();
        }
        public async Task<IActionResult> Create2(Posts post)
        {
            if (ModelState.IsValid)
            {
                post.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                post.UserID = sender.Id;
                await _context.Posts.AddAsync(post);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");


            }
            return Error();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
