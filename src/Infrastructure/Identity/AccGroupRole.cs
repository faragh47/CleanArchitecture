using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CleanArchitecture.Infrastructure.Identity
{
    public class AccGroupRole : BaseEntity<int>
    {
        public string RoleId { get; set; }
        public int GroupId { get; set; }
        public AccRole Role { get; set; }
        public AccGroup Group { get; set; }
    }

    public class AccGroupRoleConfiguration : IEntityTypeConfiguration<AccGroupRole>
    {
        public void Configure(EntityTypeBuilder<AccGroupRole> builder)
        {
            builder.Property(p => p.RoleId).IsRequired();
            builder.Property(p => p.GroupId).IsRequired();
            builder.HasIndex(x => new { x.RoleId, x.GroupId }).IsUnique();
            builder.HasOne(p => p.Role).WithMany(c => c.GroupRoles).HasForeignKey(c => c.RoleId);
            builder.HasOne(p => p.Group).WithMany(c => c.GroupRoles).HasForeignKey(c => c.GroupId);
        }
    }
}
