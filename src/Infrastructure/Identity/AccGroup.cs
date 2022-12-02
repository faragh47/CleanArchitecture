using System.Collections.Generic;
using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace CleanArchitecture.Infrastructure.Identity
{
   public class AccGroup : BaseEntity<int>
   {
      public string Title { get; set; }
      public string LatinTitle { get; set; }
      public string Description { get; set; }

      public ICollection<AccGroupUser> GroupUsers { get; set; }
      public ICollection<AccGroupRole> GroupRoles { get; set; }
   }

   public class AccGroupConfiguration : IEntityTypeConfiguration<AccGroup>
   {
      public void Configure(EntityTypeBuilder<AccGroup> builder)
      {
         builder.Property(p => p.Title).IsRequired();
         builder.Property(p => p.LatinTitle).IsRequired();
      }
   }
}
