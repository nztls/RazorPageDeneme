using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPageDeneme.Models;

public partial class FitnessContext : DbContext
{
    public FitnessContext()
    {
    }

    public FitnessContext(DbContextOptions<FitnessContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = WebApplication.CreateBuilder();
        var connectionString = builder.Configuration.GetConnectionString ("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
}
