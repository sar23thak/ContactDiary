using BlazorServerAppDemo.Components.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerAppDemo.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

    }
}
