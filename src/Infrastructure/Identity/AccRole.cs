using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

#nullable disable

namespace CleanArchitecture.Infrastructure.Identity
{
    public class AccRole : IdentityRole
    {

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        public string PersianName { get; set; }
        public ICollection<AccGroupRole> GroupRoles { get; set; }

        //public ICollection<GisLayer> GisLayers { get; set; }
    }

    public class RoleConfiguration : IEntityTypeConfiguration<AccRole>
    {
        public void Configure(EntityTypeBuilder<AccRole> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
