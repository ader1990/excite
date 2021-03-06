﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;

namespace RMA.ExciteModels
{
    public class ExciteContext : DbContext
    {
        public ExciteContext()
            : base("ExciteConnection")
        {
        }
        
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Biker> Bikers { get; set; }
    }

  
    
}
