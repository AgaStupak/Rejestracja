using RejestracjaBillenniumPraktyki.Models;
using System.Data.Entity;


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