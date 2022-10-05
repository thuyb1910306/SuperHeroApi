using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SuperHeroAPI.Data.EntityTypeConfiguration
{
	public class SuperHeroEntityTypeConfiguration : IEntityTypeConfiguration<SuperHero>
	{
		public void Configure(EntityTypeBuilder<SuperHero> builder)
		{
			builder
				.ToTable("SuperHero");

			builder
				.Property(x => x.Id)
				.IsRequired();

			builder
				.Property(x => x.Name)
				.IsRequired();

			builder
				.Property(x => x.FirstName)
				.IsRequired();

			builder
				.Property(x => x.LastName)
				.IsRequired();

			builder
				.Property(x => x.Place)
				.IsRequired();

			builder
				.HasKey(x => x.Id)
				.HasName("PK_SuperHero");
		}
	}
}
