using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PrototipoSistemaFGV.Authorization.Roles;
using PrototipoSistemaFGV.Authorization.Users;
using PrototipoSistemaFGV.MultiTenancy;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using PrototipoSistemaFGV.Authorization.BaseCalcules;

namespace PrototipoSistemaFGV.EntityFrameworkCore
{
	public class PrototipoSistemaFGVDbContext : AbpZeroDbContext<Tenant, Role, User, PrototipoSistemaFGVDbContext>
	{
		public DbSet<BaseCalculo> BaseCalculos { get; set; }

	/* Define a DbSet for each entity of the application */
	public PrototipoSistemaFGVDbContext(DbContextOptions<PrototipoSistemaFGVDbContext> options)
				: base(options)
		{

		}
	}
}
