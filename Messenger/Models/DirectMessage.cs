
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class DirectMessage
    {
        public int id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }

        public string UserID { get; set; }
        public string Sender { get; set; }
        public virtual MessengerUser Reciever { get; set; }
        public DirectMessage()
        {
            When = DateTime.Now;
        }
    }
}
