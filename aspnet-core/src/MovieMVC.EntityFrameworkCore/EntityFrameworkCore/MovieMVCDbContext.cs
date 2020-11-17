using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MovieMVC.Authorization.Roles;
using MovieMVC.Authorization.Users;
using MovieMVC.MultiTenancy;
using MovieMVC.Models;

namespace MovieMVC.EntityFrameworkCore
{
    public class MovieMVCDbContext : AbpZeroDbContext<Tenant, Role, User, MovieMVCDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Employee> Employees { get; set; }
        public MovieMVCDbContext(DbContextOptions<MovieMVCDbContext> options)
            : base(options)
        {
        }
    }
}
