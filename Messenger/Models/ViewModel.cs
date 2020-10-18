﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class ViewModel
    {
        public IEnumerable<Message> Messages { get; set; }
        public IEnumerable<MessengerUser> User { get; set; }
    }
}
