using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public interface IImage
    {
        //IQueryable<MessengerUser> User { get; }
        Image GetImage(string id);
        void SaveImage(Image image);
    }
}
