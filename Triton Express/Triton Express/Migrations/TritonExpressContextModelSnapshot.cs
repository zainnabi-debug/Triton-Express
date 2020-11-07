﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TritonExpress.Models;

namespace TritonExpress.Migrations
{
    [DbContext(typeof(TritonExpressContext))]
    partial class TritonExpressContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TritonExpress.Models.Vehicle", b =>
                {
                    b.Property<int>("Vehicle_Registration_Number")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Branch")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Vehicle_Make")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Vehicle_Model")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Vehicle_Number_Plate")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Vehicle_Registration_Number");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("TritonExpress.Models.Waybill", b =>
                {
                    b.Property<int>("WaybillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Vehicle_Number_Plate");

                    b.Property<int>("Vehicle_Registration_Number");

                    b.Property<string>("Waybil_Total_Parcels_Allocated")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Waybill_Total_weight")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("WaybillId");

                    b.HasIndex("Vehicle_Registration_Number");

                    b.ToTable("Waybill");
                });

            modelBuilder.Entity("TritonExpress.Models.Waybill", b =>
                {
                    b.HasOne("TritonExpress.Models.Vehicle", "Vehicle")
                        .WithMany("Waybill")
                        .HasForeignKey("Vehicle_Registration_Number")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}