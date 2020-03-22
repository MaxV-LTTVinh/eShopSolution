﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.ShipEmail).IsUnicode(false);
            builder.Property(x => x.ShipAddress).IsUnicode(false).IsRequired();
            builder.Property(x => x.ShipName).IsUnicode(false).IsRequired();
            builder.Property(x => x.ShipPhoneNumber).IsUnicode(false).IsRequired();
        }
    }
}