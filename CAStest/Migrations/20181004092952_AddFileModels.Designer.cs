﻿// <auto-generated />
using CAStest.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace CAStest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181004092952_AddFileModels")]
    partial class AddFileModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAStest.Models.Act", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActNumber");

                    b.Property<int>("ContractId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Acts");
                });

            modelBuilder.Entity("CAStest.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DatePassword");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Fullname");

                    b.Property<int?>("IndividualId");

                    b.Property<bool>("IsBlocked");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("IndividualId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CAStest.Models.CASFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CASFiles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CASFile");
                });

            modelBuilder.Entity("CAStest.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CAStest.Models.CategoryProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("PropertyId");

                    b.HasKey("Id");

                    b.ToTable("CategoryPropertieses");
                });

            modelBuilder.Entity("CAStest.Models.ConnectionUserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PermissionGroupId");

                    b.Property<int?>("PermissionsGroupId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("PermissionsGroupId");

                    b.HasIndex("UserId1");

                    b.ToTable("GroupsUserGroups");
                });

            modelBuilder.Entity("CAStest.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactTypeId");

                    b.Property<int>("CounterpartyId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("CounterpartyId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CAStest.Models.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("CAStest.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContractNumber");

                    b.Property<DateTime>("ContractTime");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateOfOffer");

                    b.Property<bool>("IsBlocked");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("CAStest.Models.ContractCounterparty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<int>("CounterpartyId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("CounterpartyId");

                    b.ToTable("ContractCounterparties");
                });

            modelBuilder.Entity("CAStest.Models.ContractProperties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<int>("PropertyId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("PropertyId");

                    b.ToTable("ContractPropertieses");
                });

            modelBuilder.Entity("CAStest.Models.Counterparty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<bool>("IsBlocked");

                    b.HasKey("Id");

                    b.ToTable("Counterparties");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Counterparty");
                });

            modelBuilder.Entity("CAStest.Models.CounterpartyContracts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConterpartyId");

                    b.Property<int>("ContractId");

                    b.HasKey("Id");

                    b.HasIndex("ConterpartyId");

                    b.HasIndex("ContractId");

                    b.ToTable("CounterpartyContractses");
                });

            modelBuilder.Entity("CAStest.Models.Favorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("CAStest.Models.Permissions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permissionses");
                });

            modelBuilder.Entity("CAStest.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("PropertyTypeId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyTypeId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("CAStest.Models.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("CAStest.Models.Supplementary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<string>("SupplementaryNumber");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.ToTable("Supplementaries");
                });

            modelBuilder.Entity("CAStest.Models.ViewModels.PermissionsGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractId");

                    b.Property<string>("Name");

                    b.Property<int>("PermissionId");

                    b.Property<int?>("PermissionsId");

                    b.HasKey("Id");

                    b.HasIndex("ContractId");

                    b.HasIndex("PermissionsId");

                    b.ToTable("PermissionsGroups");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
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

            modelBuilder.Entity("CAStest.Models.ActFile", b =>
                {
                    b.HasBaseType("CAStest.Models.CASFile");

                    b.Property<int>("ActId");

                    b.HasIndex("ActId");

                    b.ToTable("ActFile");

                    b.HasDiscriminator().HasValue("ActFile");
                });

            modelBuilder.Entity("CAStest.Models.ContractFile", b =>
                {
                    b.HasBaseType("CAStest.Models.CASFile");

                    b.Property<int>("ContractId");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractFile");

                    b.HasDiscriminator().HasValue("ContractFile");
                });

            modelBuilder.Entity("CAStest.Models.SupplementaryFile", b =>
                {
                    b.HasBaseType("CAStest.Models.CASFile");

                    b.Property<int>("SupplementaryId");

                    b.HasIndex("SupplementaryId");

                    b.ToTable("SupplementaryFile");

                    b.HasDiscriminator().HasValue("SupplementaryFile");
                });

            modelBuilder.Entity("CAStest.Models.Company", b =>
                {
                    b.HasBaseType("CAStest.Models.Counterparty");

                    b.Property<string>("BIC");

                    b.Property<string>("CheckingAccount");

                    b.Property<int>("CompanyINN");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Country");

                    b.Property<string>("IndividualAddress");

                    b.Property<string>("LegalAddress");

                    b.Property<string>("MailAddress");

                    b.Property<string>("ShortName");

                    b.ToTable("Company");

                    b.HasDiscriminator().HasValue("Company");
                });

            modelBuilder.Entity("CAStest.Models.Individual", b =>
                {
                    b.HasBaseType("CAStest.Models.Counterparty");

                    b.Property<string>("Address");

                    b.Property<int?>("CompanyId");

                    b.Property<string>("Country")
                        .HasColumnName("Individual_Country");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Fullname");

                    b.Property<int>("Inn");

                    b.Property<string>("LegalAddress")
                        .HasColumnName("Individual_LegalAddress");

                    b.Property<string>("PassportData");

                    b.Property<string>("Position");

                    b.HasIndex("CompanyId");

                    b.ToTable("Individual");

                    b.HasDiscriminator().HasValue("Individual");
                });

            modelBuilder.Entity("CAStest.Models.Role", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");


                    b.ToTable("Role");

                    b.HasDiscriminator().HasValue("Role");
                });

            modelBuilder.Entity("CAStest.Models.IndividualEntrepreneur", b =>
                {
                    b.HasBaseType("CAStest.Models.Individual");


                    b.ToTable("IndividualEntrepreneur");

                    b.HasDiscriminator().HasValue("IndividualEntrepreneur");
                });

            modelBuilder.Entity("CAStest.Models.Act", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany("Acts")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ApplicationUser", b =>
                {
                    b.HasOne("CAStest.Models.Individual", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualId");
                });

            modelBuilder.Entity("CAStest.Models.ConnectionUserGroup", b =>
                {
                    b.HasOne("CAStest.Models.ViewModels.PermissionsGroup", "PermissionsGroup")
                        .WithMany()
                        .HasForeignKey("PermissionsGroupId");

                    b.HasOne("CAStest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("CAStest.Models.Contact", b =>
                {
                    b.HasOne("CAStest.Models.ContactType", "ContactType")
                        .WithMany()
                        .HasForeignKey("ContactTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.Counterparty")
                        .WithMany("Contacts")
                        .HasForeignKey("CounterpartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ContractCounterparty", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.Counterparty", "Counterparty")
                        .WithMany()
                        .HasForeignKey("CounterpartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ContractProperties", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany("ContractProperties")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.Property", "Property")
                        .WithMany()
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.CounterpartyContracts", b =>
                {
                    b.HasOne("CAStest.Models.Counterparty", "Counterparty")
                        .WithMany()
                        .HasForeignKey("ConterpartyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.Favorites", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CAStest.Models.Property", b =>
                {
                    b.HasOne("CAStest.Models.PropertyType", "PropertyType")
                        .WithMany()
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.Supplementary", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany("Supplementaries")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ViewModels.PermissionsGroup", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CAStest.Models.Permissions", "Permissions")
                        .WithMany()
                        .HasForeignKey("PermissionsId");
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
                    b.HasOne("CAStest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CAStest.Models.ApplicationUser")
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

                    b.HasOne("CAStest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CAStest.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ActFile", b =>
                {
                    b.HasOne("CAStest.Models.Act", "Act")
                        .WithMany()
                        .HasForeignKey("ActId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.ContractFile", b =>
                {
                    b.HasOne("CAStest.Models.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.SupplementaryFile", b =>
                {
                    b.HasOne("CAStest.Models.Supplementary", "Supplementary")
                        .WithMany()
                        .HasForeignKey("SupplementaryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CAStest.Models.Individual", b =>
                {
                    b.HasOne("CAStest.Models.Company", "Company")
                        .WithMany("Individuals")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.SetNull);
                });
#pragma warning restore 612, 618
        }
    }
}
