using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyTextBooksMain.Models
{
    public class MyDbContex : DbContext

    {
        public MyDbContex() : base("Books")
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}