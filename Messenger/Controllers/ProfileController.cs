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
using PagedList;


namespace Messenger.Controllers
{
    public class ProfileController : Controller
    {
        private readonly MessengerContext _context;
        public readonly UserManager<MessengerUser> _userManager;


        public ProfileController(MessengerContext context, UserManager<MessengerUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> UserProfile(string userid)
        {
            ViewModel viewModel = new ViewModel();
            viewModel.User = await _context.User.ToListAsync();
            ViewBag.UserID = userid;
            return View(viewModel);
        }
        public ActionResult Search(string sortOrder, string currentFilter, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.EmailSortParm = String.IsNullOrEmpty(sortOrder) ? "email" : "";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;
            var user = from s in _context.Users
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                user = user.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString)|| s.Email.Contains(searchString));
            }
            switch (sortOrder)
            {

                case "name_desc":
                    user = user.OrderByDescending(s => s.FirstName);
                    break;
                case "email":
                    user = user.OrderByDescending(s => s.Email);
                    break;
                default:
                    user = user.OrderBy(s => s.FirstName);
                    break;
            }
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(user.ToPagedList(pageNumber, pageSize));
        }
    }
}
