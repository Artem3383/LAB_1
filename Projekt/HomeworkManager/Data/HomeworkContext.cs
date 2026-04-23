using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeworkManager.Models;

namespace HomeworkManager.Data
{
    public class HomeworkContext : DbContext
    {
        public HomeworkContext (DbContextOptions<HomeworkContext> options)
            : base(options)
        {
        }

        public DbSet<HomeworkManager.Models.Homework> Homework { get; set; } = default!;
    }
}
