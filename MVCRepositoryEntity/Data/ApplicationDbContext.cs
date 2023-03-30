﻿using MVCRepositoryEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCRepositoryEntity.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() : base("ApplicationDbContext") { }
        public DbSet<Student> Students { get; set; }
    }
}