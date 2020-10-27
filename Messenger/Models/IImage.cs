using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public interface IImage
    {
        MessengerUser Save(MessengerUser user);
        MessengerUser GetSavedUser();
    }
}
