using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SuiviVaccinCovidCodeFirst
{
    public class VaccinContext : DbContext
    {
        public DbSet<Vaccin> Vaccins { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=deptinfo420;Database=VaccinBDBilly;Trusted_Connection=True;");
    }
}
