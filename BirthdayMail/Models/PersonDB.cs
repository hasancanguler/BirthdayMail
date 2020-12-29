using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayMail.Models
{
    public class PersonDB : DbContext
    {
        public PersonDB() : base("name=PersonDBConnectionString") 
        {

        }

        public DbSet<Person> Person { get; set; }
    }
}
