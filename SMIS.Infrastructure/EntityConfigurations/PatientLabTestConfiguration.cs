using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMIS.Domain.Entities.Patients;
using SMIS.Domain.Enums;

namespace SMIS.Infrastructure.EntityConfigurations
{
    public class PatientLabTestConfiguration : IEntityTypeConfiguration<PatientLabTest>
    {
        public void Configure(EntityTypeBuilder<PatientLabTest> builder)
        {
            builder.HasKey(plt => plt.Id);

            // Configure the enum-to-string conversion for LabStatus
            builder.Property(e => e.Status)
                .HasConversion(new EnumToStringConverter<LabStatus>())
                .HasMaxLength(50); // Set a max length for the string column
        }
    }
}
