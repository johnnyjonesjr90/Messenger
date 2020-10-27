using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Messenger.Models
{
    public class Comment
    {
        public int id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public string UserID { get; set; }
        public int postid { get; set; }
        public virtual MessengerUser Author { get; set; }
        public int likes { get; set; }

        public Comment()
        {
            When = DateTime.Now;
        }
    }
}
