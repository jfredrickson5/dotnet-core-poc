﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreHelloWorld.Models;

namespace CoreHelloWorld
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) {}

        public DbSet<Widget> Widgets { get; set; }
    }
}
