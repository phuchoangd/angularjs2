﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Shop.DomainModel.Entities;
using System;

namespace Shop.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("Avatar");

                    b.Property<string>("City");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("CountryId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long?>("FacebookId");

                    b.Property<string>("FirstName");

                    b.Property<string>("GoogleId");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MidName");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PictureUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("State");

                    b.Property<string>("TwitterId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<string>("Description")
                        .HasMaxLength(256);

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<string>("Picture")
                        .HasMaxLength(2147483647);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<int>("Gender");

                    b.Property<string>("IdentityId");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<string>("Locale")
                        .HasMaxLength(28);

                    b.Property<string>("Location")
                        .HasMaxLength(28);

                    b.Property<int>("ModifiedOn");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("City")
                        .HasMaxLength(28);

                    b.Property<string>("Country");

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<string>("Extension")
                        .HasMaxLength(8);

                    b.Property<string>("FirstName")
                        .HasMaxLength(64);

                    b.Property<DateTime>("HireDate");

                    b.Property<string>("HomePhone")
                        .HasMaxLength(16);

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<string>("LastName")
                        .HasMaxLength(64);

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Notes")
                        .HasMaxLength(1024);

                    b.Property<string>("Photo")
                        .HasMaxLength(2147483647);

                    b.Property<string>("PhotoPath")
                        .HasMaxLength(256);

                    b.Property<string>("PostCode")
                        .HasMaxLength(8);

                    b.Property<string>("Region")
                        .HasMaxLength(28);

                    b.Property<string>("ReportsTo")
                        .HasMaxLength(64);

                    b.Property<decimal>("Salary");

                    b.Property<string>("Title")
                        .HasMaxLength(128);

                    b.Property<string>("TitleOfCourtesy")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<string>("City")
                        .HasMaxLength(28);

                    b.Property<int>("CountryId");

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<int>("CustomerId");

                    b.Property<int>("Freight");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("Region")
                        .HasMaxLength(28);

                    b.Property<DateTime>("RequiredDate");

                    b.Property<string>("ShipName")
                        .HasMaxLength(64);

                    b.Property<int>("ShipVia");

                    b.Property<DateTime>("ShippedDate");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<double>("Discount");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<bool>("Discontinued");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Name")
                        .HasMaxLength(64);

                    b.Property<string>("QuantityPerUnit")
                        .HasMaxLength(28);

                    b.Property<int>("ReorderLevel");

                    b.Property<int>("SupplierId");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.Property<int>("UnitsOnOrder");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Shipper", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .HasMaxLength(64);

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.HasKey("Id");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(256);

                    b.Property<string>("City")
                        .HasMaxLength(28);

                    b.Property<string>("CompanyName")
                        .HasMaxLength(64);

                    b.Property<string>("ContactName")
                        .HasMaxLength(64);

                    b.Property<string>("ContactTitle")
                        .HasMaxLength(256);

                    b.Property<int>("Country");

                    b.Property<int>("CreatedById");

                    b.Property<int>("CreatedOn");

                    b.Property<string>("Fax")
                        .HasMaxLength(16);

                    b.Property<string>("HomePage")
                        .HasMaxLength(64);

                    b.Property<bool?>("IsDeleted");

                    b.Property<int>("LastModified");

                    b.Property<int>("ModifiedOn");

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.Property<string>("Region")
                        .HasMaxLength(28);

                    b.Property<string>("ZipCode")
                        .HasMaxLength(8);

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.DomainModel.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.AppUser", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Customer", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId");
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Order", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.DomainModel.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.OrderDetail", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.DomainModel.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.DomainModel.Entities.Product", b =>
                {
                    b.HasOne("Shop.DomainModel.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.DomainModel.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
