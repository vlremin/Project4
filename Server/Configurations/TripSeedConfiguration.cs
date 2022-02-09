using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project4.Shared.Domain;

namespace Project4.Server.Configurations
{
    public class TripSeedConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasData(
                    new Trip
                    {
                        ID = 1,
                        Details = "To and from Australia"
                    },
                    new Trip
                    {
                        ID = 2,
                        Details = "To and from United Kingdom"
                    }
                    );

        }
    }
}