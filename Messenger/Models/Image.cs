using Messenger.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class Image : IImage
    {
        private readonly MessengerContext _context;
        public Image(MessengerContext context)
        {
            _context = context;
        }
        public MessengerUser GetSavedUser()
        {
            return _context.User.SingleOrDefault();
        }

        public MessengerUser Save(MessengerUser user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;
        }
    }
}
