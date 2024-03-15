using CoreMVCCodeFirst_1.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMVCCodeFirst_1.Models.Configuration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder); //orginal görevi

            builder.ToTable("Kategoriler");
            builder.Property(x => x.CategoryName).HasColumnName("KategoriIsmi");
            builder.Property(x => x.Description).HasColumnName("Aciklama");
        }
    }
}
