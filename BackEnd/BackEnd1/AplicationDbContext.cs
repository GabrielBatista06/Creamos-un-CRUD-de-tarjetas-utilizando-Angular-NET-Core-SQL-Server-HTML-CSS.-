﻿using BackEnd1.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd1
{
    public class AplicationDbContext: DbContext 
    {

       public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
    }
}
