using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Times.Data;
using System;
using System.Linq;

namespace Times.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new TimesContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<TimesContext>>()))
                {
                    if(context.Time.Any())
                    {
                        return;
                    }
                    context.Time.AddRange(
                        

                    );
                    context.SaveChanges();
                }
        }
    }
}
