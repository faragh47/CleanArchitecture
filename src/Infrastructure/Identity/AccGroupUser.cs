
using CleanArchitecture.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Identity
{
    public class AccGroupUser : BaseEntity<int>
    {
        public string UserId { get; set; }
        public int GroupId { get; set; }
        //public bool IsActive { get; set; }

        [Required]
        public ApplicationUser User { get; set; }
        public AccGroup Group { get; set; }
    }

    public class AccGroupUserConfiguration : IEntityTypeConfiguration<AccGroupUser>
    {
        public void Configure(EntityTypeBuilder<AccGroupUser> builder)
        {
            builder.Property(p => p.UserId).IsRequired();
            builder.Property(p => p.GroupId).IsRequired();
            //builder.Property(p => p.IsActive).IsRequired();
            builder.HasIndex(x => new { x.GroupId, x.UserId }).IsUnique();
            //builder.HasOne(p => p.User).WithMany(c => c.GroupUsers).HasForeignKey(c => c.FUsersId);
            builder.HasOne(p => p.Group).WithMany(c => c.GroupUsers).HasForeignKey(c => c.GroupId);
        }
    }
}
