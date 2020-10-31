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
using System.IO;

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
            ViewModel viewModel = new ViewModel();
            viewModel.Posts = await _context.Posts.ToListAsync();
            viewModel.User = await _context.User.ToListAsync();
            viewModel.Comment = await _context.Comment.ToListAsync();
            return View(viewModel);
        }
        public async Task<IActionResult> Profile()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            ViewModel viewModel = new ViewModel();
            viewModel.User = await _context.User.ToListAsync();
            viewModel.Image = await _context.Image.ToListAsync();
            return View(viewModel);
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

        public async Task<IActionResult> Addlike(int postid)
        {

            if (ModelState.IsValid)
            {
                Posts post = _context.Posts.FirstOrDefault(p => p.id == postid);
                post.likes++;
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return Error();
        }
        public async Task<IActionResult> AddComment(Comment comment, int postid, string text)
        {
            if (ModelState.IsValid)
            {
                comment.UserName = User.Identity.Name;
                var sender = await _userManager.GetUserAsync(User);
                comment.UserID = sender.Id;
                comment.postid = postid;
                comment.Text = text;
                await _context.Comment.AddAsync(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");


            }
            return Error();
        }

        public async Task<IActionResult> AddQuote(MessengerUser user, string text)
        {
            if (ModelState.IsValid)
            {
                user = _context.User.First(u => u.UserName == User.Identity.Name);
                user.Quote = text;
                await _context.SaveChangesAsync();
                return RedirectToAction("Profile");


            }
            return Error();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult UploadImage(string id)
        {
            return View(new MessengerUser { Id = id });
        }
        [HttpPost]
        public IActionResult UploadImage(MessengerUser user, string userid)
        {
            user = _context.User.FirstOrDefault(o => o.Id == userid);
            if (user.Id != null)
            {
                foreach (var file in Request.Form.Files)
                {
                    var img = new Image { UserID = user.Id, ImageTitle = file.FileName };

                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        img.ImageData = ms.ToArray();
                        ms.Close();
                        ms.Dispose();
                    }

                    _context.SaveImage(img);
                }

                TempData["message"] = "Image(s) stored in  database!";
            }
            else
            {
                TempData["message"] = "Cannot add images to a non existent product!";
            }

            return RedirectToAction("Index");
        }
    } 
}
