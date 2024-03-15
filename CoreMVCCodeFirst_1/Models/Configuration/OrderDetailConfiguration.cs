﻿using CoreMVCCodeFirst_1.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst_1.Models.Configuration
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }
    }
}
