﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YQTrack.Core.Backend.Admin.Data;

namespace YQTrack.Core.Backend.Admin.Data.Migrations
{
    [DbContext(typeof(AdminDbContext))]
    [Migration("20190311100938_EditLoginLogUserAgentFieldLength")]
    partial class EditLoginLogUserAgentFieldLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.LoginLog", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FAccount")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("FIp")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<DateTime>("FLoginTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("FManagerId");

                    b.Property<string>("FNickName")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("FPlatform")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("FUserAgent")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.HasKey("FId");

                    b.HasIndex("FAccount", "FNickName", "FPlatform", "FUserAgent", "FIp");

                    b.ToTable("TLoginLog");
                });

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.Manager", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FAccount")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("FAvatar")
                        .HasMaxLength(128);

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("FIsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("FIsLock")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<DateTime>("FLastLoginTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("FNickName")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("FPassword")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("FRemark")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("FUpdatedBy");

                    b.Property<DateTime?>("FUpdatedTime");

                    b.HasKey("FId");

                    b.HasIndex("FAccount")
                        .IsUnique();

                    b.ToTable("TManager");
                });

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.ManagerRole", b =>
                {
                    b.Property<int>("FManagerId");

                    b.Property<int>("FRoleId");

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("FManagerId", "FRoleId");

                    b.ToTable("TManagerRole");
                });

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.Permission", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FActionName")
                        .HasMaxLength(32);

                    b.Property<string>("FAreaName")
                        .HasMaxLength(16);

                    b.Property<string>("FControllerName")
                        .HasMaxLength(32);

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("FFullName")
                        .HasMaxLength(64);

                    b.Property<string>("FIcon")
                        .HasMaxLength(64);

                    b.Property<bool>("FIsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<int>("FMenuType");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("FParentId");

                    b.Property<string>("FRemark")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<int>("FSort");

                    b.Property<string>("FTopMenuKey")
                        .HasMaxLength(32);

                    b.Property<int?>("FUpdatedBy");

                    b.Property<DateTime?>("FUpdatedTime");

                    b.Property<string>("FUrl")
                        .HasMaxLength(128);

                    b.HasKey("FId");

                    b.HasIndex("FFullName");

                    b.HasIndex("FName")
                        .IsUnique();

                    b.HasIndex("FUrl");

                    b.ToTable("TPermission");
                });

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.Role", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("FIsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("FIsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("FRemark")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<int?>("FUpdatedBy");

                    b.Property<DateTime?>("FUpdatedTime");

                    b.HasKey("FId");

                    b.HasIndex("FName")
                        .IsUnique();

                    b.ToTable("TRole");
                });

            modelBuilder.Entity("YQTrack.Core.Backend.Admin.Data.Entity.RolePermission", b =>
                {
                    b.Property<int>("FRoleId");

                    b.Property<int>("FPermissionId");

                    b.Property<int>("FCreatedBy");

                    b.Property<DateTime>("FCreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("FRoleId", "FPermissionId");

                    b.ToTable("TRolePermission");
                });
#pragma warning restore 612, 618
        }
    }
}
