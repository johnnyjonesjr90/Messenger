using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public interface IMessage
    {
        IQueryable<MessengerUser> User { get; }
    }
}
