﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace prjAjax.Models;

public partial class DemoContext : DbContext
{
    public DemoContext()
    {
    }

    public DemoContext(DbContextOptions<DemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Address { get; set; }

    public virtual DbSet<Members> Members { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Demo;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.city).HasMaxLength(10);
            entity.Property(e => e.road).HasMaxLength(200);
            entity.Property(e => e.site_id).HasMaxLength(50);
        });

        modelBuilder.Entity<Members>(entity =>
        {
            entity.HasKey(e => e.MemberId);

            entity.Property(e => e.MemberId);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FileName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}