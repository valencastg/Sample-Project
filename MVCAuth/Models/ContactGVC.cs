using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAuth.Models
{
    public class ContactGVC
    {
        // we want to meke name required field
        public int ID {get;set;}
        [Required]
        public string Name { get; set; }
        [Required]
        public string  Phone { get; set; }
        public string  Email { get; set; }
        public DateTime  Birthday { get; set; }
    }

    public class ContactGVCDcContext : DbContext
    {
        public DbSet<ContactGVC> ContactGVC { get; set; }
    }
}