using Messenger.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Components
{
    public class ImageRetrieverViewComponent : ViewComponent
    {
        private MessengerContext repository;
        public ImageRetrieverViewComponent(MessengerContext repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke(string id)
        {
            return View(repository.GetImage(id));
        }
    }
}
