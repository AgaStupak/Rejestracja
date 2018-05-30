using RejestracjaBillenniumPraktyki.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RejestracjaBillenniumPraktyki.DAL
{
    public class RegistrationContext :DbContext
    {
        public RegistrationContext()
            : base("MyConnectionString")
        {

        }
        public DbSet<Registration> Registrations { get; set; }
        
    }
}