using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messenger.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Messenger.Data
{
    public class MessengerContext : IdentityDbContext<MessengerUser>
    {
        public MessengerContext(DbContextOptions<MessengerContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Message>()
                .HasOne<MessengerUser>(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserID);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public Image GetImage(string id)
        {
            Image img = new Image();
            img = Image.FirstOrDefault(i => i.UserID == id);
            if (img == null) return img;
            string imageBase64Data = Convert.ToBase64String(img.ImageData);
            img.ImageDataUrl = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            return img;
        }

        public void SaveImage(Image image)
        {
            Image dbEntry = Image
                .FirstOrDefault(p => p.Id == image.Id);
            if (dbEntry != null)
            {
                dbEntry.UserID = image.UserID;
                dbEntry.ImageData = image.ImageData;
                dbEntry.ImageTitle = image.ImageTitle;

            }
            else
            {
                Image.Add(image);
            }

            SaveChanges();
        }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessengerUser> User { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Image> Image { get; set; }
    }
}
