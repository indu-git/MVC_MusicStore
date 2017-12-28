using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_MusicStore.Models
{
    public class MusicStoreEntities:DbContext
    {
        public MusicStoreEntities() : base("InduDB")
        { }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}