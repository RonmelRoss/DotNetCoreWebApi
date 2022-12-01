using Microsoft.EntityFrameworkCore;
using DotNetCoreWebApi.DAL.Data.Models;

namespace NetCore.Modules.DAL.Data;

public class NetCoreModulesContext : DbContext
{
    public NetCoreModulesContext(DbContextOptions<NetCoreModulesContext> options) : base(options)
    {

    }

    public DbSet<User>? Users { get; set; }
}
