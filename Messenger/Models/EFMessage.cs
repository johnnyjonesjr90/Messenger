using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Messenger.Data;

namespace Messenger.Models
{
    public class EFMessage : IMessage
    {
        private MessengerContext context;

        public EFMessage(MessengerContext ctx)
        {
            context = ctx;
        }
        public IQueryable<MessengerUser> User => context.Users;
    }
}
