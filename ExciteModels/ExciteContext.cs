using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Excite.Models
{
    public class ExciteContext : DbContext
    {
        public ExciteContext()
            : base("ExciteConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

  
    
}
