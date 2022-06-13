using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace la_mia_pizzeria_static.Data
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options) : base(options) { }
        public DbSet<Pizza>? Pizzas { get; set; }
        
    }
}
