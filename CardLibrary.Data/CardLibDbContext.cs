using CardLibrary.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardLibrary.Data
{
   public class CardLibDbContext : IdentityDbContext
    {
        public CardLibDbContext()        {               
        }
        public CardLibDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<User> UserLists { get; set; }
        public virtual DbSet<UserRole> UserRoleLists { get; set; }

        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<UserCard> CustomerCards { get; set; }
        public virtual DbSet<CardGroup> CardGroups { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
    }
}
