using Microsoft.EntityFrameworkCore;
using Times.Models;

namespace Times.Data
{
    public class TimesContext : DbContext
    {
        public TimesContext(DbContextOptions<TimesContext> options) : base(options)
        {

        }

        public DbSet<Time> Time {get; set;}

        
    }
}