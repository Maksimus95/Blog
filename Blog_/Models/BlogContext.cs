﻿using Blog_.Models.DataBase;
using System.Data.Entity;


namespace Blog_.Models
{
    public class BlogContext: DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new BlogContextInitializer());
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}