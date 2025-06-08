﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myCleanArchitecture.Infrastructure.Identity;

namespace myCleanArchitecture.Infrastructure.Configurations
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.User)
                .WithMany(x=>x.RefreshTokens)
                .HasForeignKey(x=>x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
