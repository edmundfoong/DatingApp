using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    //ctor - constructor
    
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions <DataContext> options):base (options){}

        //To tell entityframework about entity
        //"Values" - will be table name when sql created
        //"Value - which the entity
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}