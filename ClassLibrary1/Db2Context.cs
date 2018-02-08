using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Db2Context: DbContext
    {
        public Db2Context(DbContextOptions<Db2Context> options)
         : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=va-5810-ws\\sqlexpress;Database=Testdb;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
    }
}
