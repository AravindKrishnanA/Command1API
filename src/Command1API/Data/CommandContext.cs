using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Command1API.Models;

namespace Command1API.Data
{
    public class CommandContext : DbContext
    {
        public CommandContext(DbContextOptions<CommandContext> options): base(options)
        {

        }

        public DbSet<Command> CommandItems { get; set; }
    }
}
