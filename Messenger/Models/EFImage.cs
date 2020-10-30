using Messenger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class EFImage : IImage
    {
        private readonly MessengerContext _context;
        


        public EFImage(MessengerContext context)
        {
            _context = context;
            
        }
        //public IQueryable<MessengerUser> User => _context.User;

        public Image GetImage(string id)
        {
            Image img = new Image();
            img = _context.Image.FirstOrDefault(i => i.UserID == id);
            if (img == null) return img;
            string imageBase64Data = Convert.ToBase64String(img.ImageData);
            img.ImageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            return img;
        }

        public void SaveImage(Image image)
        {
            Image dbEntry = _context.Image
                .FirstOrDefault(p => p.Id == image.Id);
            if (dbEntry != null)
            {
                dbEntry.UserID = image.UserID;
                dbEntry.ImageData = image.ImageData;
                dbEntry.ImageTitle = image.ImageTitle;

            }
            else
            {
                _context.Image.Add(image);
            }

            _context.SaveChanges();
        }
    }
}
