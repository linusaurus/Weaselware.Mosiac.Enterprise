﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using DataLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Data;

public partial class MosaicContext : DbContext
{
    private readonly string _connectionString;
    public MosaicContext(string connectionString)
    {
        _connectionString = connectionString;
    }
    public MosaicContext(DbContextOptions<MosaicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asset> Asset { get; set; }

    public virtual DbSet<Attachment> Attachment { get; set; }

    public virtual DbSet<BOM> BOM { get; set; }

    public virtual DbSet<BOMListItem> BOMListItem { get; set; }

    public virtual DbSet<Claim> Claim { get; set; }

    public virtual DbSet<ClaimDocument> ClaimDocument { get; set; }

    public virtual DbSet<ClaimItem> ClaimItem { get; set; }

    public virtual DbSet<Delivery> Delivery { get; set; }

    public virtual DbSet<DeliveryReceipt> DeliveryReceipt { get; set; }

    public virtual DbSet<Destination> Destination { get; set; }

    public virtual DbSet<Document> Document { get; set; }

    public virtual DbSet<Employee> Employee { get; set; }

    public virtual DbSet<Inventory> Inventory { get; set; }

    public virtual DbSet<Job> Job { get; set; }

    public virtual DbSet<JobSite> JobSite { get; set; }

    public virtual DbSet<Location> Location { get; set; }

    public virtual DbSet<Manu> Manu { get; set; }

    public virtual DbSet<NFRC> NFRC { get; set; }

    public virtual DbSet<OpCode> OpCode { get; set; }

    public virtual DbSet<OrderFee> OrderFee { get; set; }

    public virtual DbSet<OrderReceiptItems> OrderReceiptItems { get; set; }

    public virtual DbSet<OrderReciept> OrderReciept { get; set; }

    public virtual DbSet<OrderState> OrderState { get; set; }

    public virtual DbSet<Part> Part { get; set; }

    public virtual DbSet<PartCategory> PartCategory { get; set; }

    public virtual DbSet<PartTypes> PartTypes { get; set; }

    public virtual DbSet<PickList> PickList { get; set; }

    public virtual DbSet<PickListItem> PickListItem { get; set; }

    public virtual DbSet<Product> Product { get; set; }

    public virtual DbSet<PurchaseLineItem> PurchaseLineItem { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }

    public virtual DbSet<Resource> Resource { get; set; }

    public virtual DbSet<ResourceVersion> ResourceVersion { get; set; }

    public virtual DbSet<ShipBy> ShipBy { get; set; }

    public virtual DbSet<SubAssembly> SubAssembly { get; set; }

    public virtual DbSet<Supplier> Supplier { get; set; }

    public virtual DbSet<TransActionType> TransActionType { get; set; }

    public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }

    public virtual DbSet<WorkCenter> WorkCenter { get; set; }

    public virtual DbSet<WorkOrder> WorkOrder { get; set; }

    public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asset>(entity =>
        {
            entity.Property(e => e.AddedBy).HasMaxLength(60);
            entity.Property(e => e.AssetDescription).HasMaxLength(512);
            entity.Property(e => e.AssetName).HasMaxLength(120);
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ManuPartNum)
                .HasMaxLength(120)
                .IsFixedLength();
            entity.Property(e => e.ModifiedBy).HasMaxLength(60);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PurchaseDate).HasColumnType("date");
            entity.Property(e => e.SerialNumber).HasMaxLength(75);
            entity.Property(e => e.Tag).HasMaxLength(50);
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasIndex(e => e.RowID, "UQ__Attachme__FFEE74505D190063").IsUnique();

            entity.Property(e => e.AttachmentDescription)
                .HasMaxLength(520)
                .IsUnicode(false);
            entity.Property(e => e.BLOBData).HasDefaultValueSql("(0x)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Creator).HasMaxLength(30);
            entity.Property(e => e.FileSize).HasMaxLength(50);
            entity.Property(e => e.RowID).HasDefaultValueSql("(newid())");
            entity.Property(e => e.src)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.Attachment)
                .HasForeignKey(d => d.PurchaseOrderID)
                .HasConstraintName("FK_Attachment_PurchaseOrder");
        });

        modelBuilder.Entity<BOM>(entity =>
        {
            entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyArea).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyDepth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyHieght).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.AssemblyWidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FunctionalName).HasMaxLength(255);
            entity.Property(e => e.JobName).HasMaxLength(255);
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Markup).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PartClass).HasMaxLength(255);
            entity.Property(e => e.PartIdentifier).HasMaxLength(255);
            entity.Property(e => e.PartLabel).HasMaxLength(255);
            entity.Property(e => e.PartType).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SourceDescription).HasMaxLength(255);
            entity.Property(e => e.SourceName).HasMaxLength(255);
            entity.Property(e => e.SubAssemblyArea).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyDepth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyHieght).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyID).HasMaxLength(255);
            entity.Property(e => e.SubAssemblyWidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Thick).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Waste).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<BOMListItem>(entity =>
        {
            entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyArea).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyDepth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyHieght).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.AssemblyName).HasMaxLength(255);
            entity.Property(e => e.AssemblyWidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.FunctionalName).HasMaxLength(255);
            entity.Property(e => e.JobName).HasMaxLength(255);
            entity.Property(e => e.LaborAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Length).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Markup).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PartClass).HasMaxLength(255);
            entity.Property(e => e.PartIdentifier).HasMaxLength(255);
            entity.Property(e => e.PartLabel).HasMaxLength(255);
            entity.Property(e => e.PartType).HasMaxLength(255);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SourceDescription).HasMaxLength(255);
            entity.Property(e => e.SourceName).HasMaxLength(255);
            entity.Property(e => e.SubAssemblyArea).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyDepth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyHieght).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SubAssemblyID).HasMaxLength(255);
            entity.Property(e => e.SubAssemblyWidth).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Thick).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Waste).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity.Property(e => e.ClaimDate).HasColumnType("date");
            entity.Property(e => e.SupplierOrder)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimDocument>(entity =>
        {
            entity.Property(e => e.DocumentDesciption)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.DocumentExtension)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.ClaimItem).WithMany(p => p.ClaimDocument)
                .HasForeignKey(d => d.ClaimItemID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClaimDocument_ClaimItem");
        });

        modelBuilder.Entity<ClaimItem>(entity =>
        {
            entity.Property(e => e.Bcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DefectDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.DeliveryID).HasName("PK_Delivery_1");

            entity.Property(e => e.TimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Job).WithMany(p => p.Delivery)
                .HasForeignKey(d => d.JobID)
                .HasConstraintName("FK_Delivery_Job");

            entity.HasOne(d => d.PickList).WithMany(p => p.Delivery)
                .HasForeignKey(d => d.PickListID)
                .HasConstraintName("FK_Delivery_PickList");
        });

        modelBuilder.Entity<DeliveryReceipt>(entity =>
        {
            entity.HasKey(e => e.DeliveryReceiptID).HasName("PK__Delivery__FBFDCF82F36BA245");

            entity.HasIndex(e => e.FileGuid, "UQ__Delivery__6DB18C95A99DD0DD").IsUnique();

            entity.Property(e => e.ReferenceName)
                .HasMaxLength(60)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Attn)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DestinationName)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocID).HasName("PK_DocumentDescriptor");

            entity.Property(e => e.Creator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DocumentPath)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.DocumentView)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Modifier)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.employeeID).HasName("PK_emps");

            entity.Property(e => e.EmployeeEmail)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Login)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Show).HasDefaultValueSql("((1))");
            entity.Property(e => e.firstname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.lastname)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.middlename)
                .HasMaxLength(50)
                .HasDefaultValueSql("('')");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.StockTransactionID).HasName("PK_InventoryItems");

            entity.Property(e => e.DateStamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date");
            entity.Property(e => e.Description).HasMaxLength(512);
            entity.Property(e => e.InventoryAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Location).HasMaxLength(120);
            entity.Property(e => e.Note).HasMaxLength(240);
            entity.Property(e => e.QntyOrdered)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.QntyReceived).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TransactionReference)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Emp).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.EmpID)
                .HasConstraintName("FK_Inventory_Employee");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.LocationID)
                .HasConstraintName("FK_Inventory_Location");

            entity.HasOne(d => d.TransActionTypeNavigation).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.TransActionType)
                .HasConstraintName("FK_Inventory_TransActionType");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.Inventory)
                .HasForeignKey(d => d.UnitOfMeasureID)
                .HasConstraintName("FK_Inventory_UnitOfMeasure");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.jobID).HasName("PK_jobMain");

            entity.Property(e => e.ParentID).HasDefaultValueSql("((0))");
            entity.Property(e => e.company_id).HasDefaultValueSql("((0))");
            entity.Property(e => e.jobdesc)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.jobname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.jobnumber).HasDefaultValueSql("((0))");
            entity.Property(e => e.leftNode).HasDefaultValueSql("((0))");
            entity.Property(e => e.project_id).HasDefaultValueSql("((0))");
            entity.Property(e => e.rightnode).HasDefaultValueSql("((0))");
            entity.Property(e => e.start_ts).HasColumnType("datetime");
            entity.Property(e => e.structurelevel).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<JobSite>(entity =>
        {
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.State).HasMaxLength(50);
            entity.Property(e => e.StreetAddress).HasMaxLength(50);
            entity.Property(e => e.Zip).HasMaxLength(50);
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.Photo).HasDefaultValueSql("(0x)");
            entity.Property(e => e.Row)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Manu>(entity =>
        {
            entity.Property(e => e.ManuCategoryID).HasDefaultValueSql("((0))");
            entity.Property(e => e.Manufacturer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(16)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength();
            entity.Property(e => e.WebAddress)
                .HasMaxLength(120)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength();
        });

        modelBuilder.Entity<NFRC>(entity =>
        {
            entity.HasKey(e => e.CPD_ID);

            entity.Property(e => e.CPD).HasMaxLength(255);
            entity.Property(e => e.FrameMaterial)
                .HasMaxLength(65)
                .IsFixedLength();
            entity.Property(e => e.FrameSashType).HasMaxLength(255);
            entity.Property(e => e.GapFill).HasMaxLength(255);
            entity.Property(e => e.GlassName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grid).HasMaxLength(255);
            entity.Property(e => e.IGU)
                .HasMaxLength(75)
                .IsFixedLength();
            entity.Property(e => e.LowE).HasMaxLength(255);
            entity.Property(e => e.ManufacturerProductCode).HasMaxLength(255);
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(240)
                .IsUnicode(false);
            entity.Property(e => e.Spacer).HasMaxLength(255);
            entity.Property(e => e.SystemName)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.Tint).HasMaxLength(255);
            entity.Property(e => e.UnitType)
                .HasMaxLength(70)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OpCode>(entity =>
        {
            entity.Property(e => e.OperationName).HasMaxLength(50);
        });

        modelBuilder.Entity<OrderFee>(entity =>
        {
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Extension).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FeeName).HasMaxLength(200);
            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.OrderFee)
                .HasForeignKey(d => d.PurchaseOrderID)
                .HasConstraintName("FK_OrderFee_PurchaseOrder");
        });

        modelBuilder.Entity<OrderReceiptItems>(entity =>
        {
            entity.HasKey(e => e.OrderReceiptLineID);

            entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Description).HasMaxLength(1250);

            entity.Property(e => e.Extended).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.InventoryAmount).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.Note).HasMaxLength(240);

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.QuantityOrdered).HasColumnType("decimal(18, 4)");

            entity.Property(e => e.QuantityReceived).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.OrderReceipt)
                .WithMany(p => p.OrderReceiptItems)
                .HasForeignKey(d => d.OrderReceiptID)
                .HasConstraintName("FK_OrderReceiptItems_OrderReciept");

            entity.HasOne(d => d.UnitOfMeasure)
                .WithMany(p => p.OrderReceiptItems)
                .HasForeignKey(d => d.UnitOfMeasureID)
                .HasConstraintName("FK_OrderReceiptItems_UnitOfMeasure");
        });

        modelBuilder.Entity<OrderReciept>(entity =>
        {
            entity.HasKey(e => e.OrderReceiptID)
                     .HasName("PK_Reciept");

            entity.Property(e => e.ReceiptDate).HasColumnType("date");

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.OrderReciept)
                .HasForeignKey(d => d.EmployeeID)
                .HasConstraintName("FK_OrderReciept_Employee");

            entity.HasOne(d => d.PurchaseOrder)
                .WithMany(p => p.OrderReciept)
                .HasForeignKey(d => d.PurchaseOrderID)
                .HasConstraintName("FK_OrderReciept_PurchaseOrder");


        });

        modelBuilder.Entity<OrderState>(entity =>
        {
            entity.Property(e => e.OrderStateID).ValueGeneratedNever();
            entity.Property(e => e.OrderStateName).HasMaxLength(20);
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.Property(e => e.AddedBy).HasMaxLength(60);
            entity.Property(e => e.Amount_Required).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CARBtrack).HasDefaultValueSql("((0))");
            entity.Property(e => e.Cost)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DateAdded).HasColumnType("datetime");
            entity.Property(e => e.ItemDescription)
                .HasMaxLength(512)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.ItemName)
                .HasMaxLength(120)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Location)
                .HasMaxLength(10)
                .HasDefaultValueSql("(' ')")
                .IsFixedLength();
            entity.Property(e => e.LocationID).HasDefaultValueSql("((5))");
            entity.Property(e => e.ManuPartNum)
                .HasMaxLength(120)
                .IsFixedLength();
            entity.Property(e => e.MarkUp)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(60);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes)
                .HasMaxLength(512)
                .IsUnicode(false);
            entity.Property(e => e.ObsoluteFlag).HasDefaultValueSql("((0))");
            entity.Property(e => e.PartNum)
                .HasMaxLength(160)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.PartTypeID).HasDefaultValueSql("((10))");
            entity.Property(e => e.SKU)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.UnitOfMeasureID).HasDefaultValueSql("((1))");
            entity.Property(e => e.UseSupplierNameFlag).HasDefaultValueSql("((1))");
            entity.Property(e => e.Waste)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.LocationNavigation).WithMany(p => p.Part)
                .HasForeignKey(d => d.LocationID)
                .HasConstraintName("FK_Part_Location");

            entity.HasOne(d => d.Manu).WithMany(p => p.Part)
                .HasForeignKey(d => d.ManuID)
                .HasConstraintName("FK_Part_Manu");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.Part)
                .HasForeignKey(d => d.UnitOfMeasureID)
                .HasConstraintName("FK_Part_UnitOfMeasure");

            entity.HasMany(d => d.Doc).WithMany(p => p.Part)
                .UsingEntity<Dictionary<string, object>>(
                    "DocumentParts",
                    r => r.HasOne<Document>().WithMany()
                        .HasForeignKey("DocID")
                        .HasConstraintName("FK_DocumentParts_Document1"),
                    l => l.HasOne<Part>().WithMany()
                        .HasForeignKey("PartID")
                        .HasConstraintName("FK_DocumentParts_Part"),
                    j =>
                    {
                        j.HasKey("PartID", "DocID");
                    });
        });

        modelBuilder.Entity<PartCategory>(entity =>
        {
            entity.Property(e => e.PartCategoryName).HasMaxLength(70);
        });

        modelBuilder.Entity<PartTypes>(entity =>
        {
            entity.HasKey(e => e.PartTypeID);

            entity.Property(e => e.PartTypeName)
                .HasMaxLength(75)
                .IsFixedLength();

            entity.HasOne(d => d.PartCategory).WithMany(p => p.PartTypes)
                .HasForeignKey(d => d.PartCategoryID)
                .HasConstraintName("FK_PartTypes_PartCategory");
        });

        modelBuilder.Entity<PickList>(entity =>
        {
            entity.HasKey(e => e.PickListID).HasName("PK_Delivery");

            entity.Property(e => e.DateStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Destination).WithMany(p => p.PickList)
                .HasForeignKey(d => d.DestinationID)
                .HasConstraintName("FK_PickList_Destination");

            entity.HasOne(d => d.Employee).WithMany(p => p.PickList)
                .HasForeignKey(d => d.EmployeeID)
                .HasConstraintName("FK_PickList_Employee");

            entity.HasOne(d => d.Job).WithMany(p => p.PickList)
                .HasForeignKey(d => d.JobID)
                .HasConstraintName("FK_PickList_Job");
        });

        modelBuilder.Entity<PickListItem>(entity =>
        {
            entity.HasKey(e => e.PickListItemID).HasName("PK_DeliveryItem");

            entity.Property(e => e.Description).HasMaxLength(1220);
            entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.PickList).WithMany(p => p.PickListItem)
                .HasForeignKey(d => d.PickListID)
                .HasConstraintName("FK_PickListItem_PickList");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ArchDescription).HasMaxLength(200);
            entity.Property(e => e.D).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DeliveredDate).HasColumnType("date");
            entity.Property(e => e.H).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ProductionDate).HasColumnType("date");
            entity.Property(e => e.RoomName).HasMaxLength(50);
            entity.Property(e => e.UnitName).HasMaxLength(50);
            entity.Property(e => e.W).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Job).WithMany(p => p.Product)
                .HasForeignKey(d => d.JobID)
                .HasConstraintName("FK_Product_Job");
        });

        modelBuilder.Entity<PurchaseLineItem>(entity =>
        {
            entity.HasKey(e => e.LineID);

            entity.Property(e => e.AmountReceived)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BCode).HasMaxLength(50);
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.ExpectedDate).HasColumnType("date");
            entity.Property(e => e.Extended)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Qnty)
                .HasDefaultValueSql("((1.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecievedDate).HasColumnType("date");
            entity.Property(e => e.Thick)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UnitCost)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("((0.00))")
                .HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.PurchaseLineItem)
                .HasForeignKey(d => d.PurchaseOrderID)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_PurchaseLineItem_PurchaseOrder");

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.PurchaseLineItem)
                .HasForeignKey(d => d.UnitOfMeasureID)
                .HasConstraintName("FK_PurchaseLineItem_UnitOfMeasure");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderID).HasName("PK_Order");

            entity.Property(e => e.AddedBy)
                .HasMaxLength(60)
                .IsFixedLength();
            entity.Property(e => e.DateAdded).HasColumnType("date");
            entity.Property(e => e.ExpectedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsBackOrder).HasDefaultValueSql("((0))");
            entity.Property(e => e.Memo)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.ModifiedBy)
                .HasMaxLength(60)
                .IsFixedLength();
            entity.Property(e => e.ModifiedDate).HasColumnType("date");
            entity.Property(e => e.OrderDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OrderFormat).HasMaxLength(50);
            entity.Property(e => e.OrderState).HasDefaultValueSql("((1))");
            entity.Property(e => e.OrderTotal)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("money");
            entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");
            entity.Property(e => e.RecievedDate).HasColumnType("datetime");
            entity.Property(e => e.SalesRep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.ShipID).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShippingCost)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("money");
            entity.Property(e => e.SubTotal)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("money");
            entity.Property(e => e.SuppressTax).HasDefaultValueSql("((0))");
            entity.Property(e => e.Tax)
                .HasDefaultValueSql("((0.0))")
                .HasColumnType("money");
            entity.Property(e => e.TrackingLabelNum)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.Employee).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.EmployeeID)
                .HasConstraintName("FK_PurchaseOrder_Employee");

            entity.HasOne(d => d.Job).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.JobID)
                .HasConstraintName("FK_PurchaseOrder_Job");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrder)
                .HasForeignKey(d => d.SupplierID)
                .HasConstraintName("FK_PurchaseOrder_Supplier");
        });

        modelBuilder.Entity<Resource>(entity =>
        {
            entity.HasIndex(e => e.RowID, "UQ__Resource__FFEE7450F82258EA").IsUnique();

            entity.Property(e => e.Createdby).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("date");
            entity.Property(e => e.FileSize).HasMaxLength(50);
            entity.Property(e => e.Lastmod).HasColumnType("date");
            entity.Property(e => e.ResourceDescription).HasMaxLength(240);
            entity.Property(e => e.ResourceFile).HasDefaultValueSql("(0x)");
            entity.Property(e => e.RowID).HasDefaultValueSql("(newid())");
            entity.Property(e => e.filesource).HasMaxLength(90);

            entity.HasOne(d => d.Part).WithMany(p => p.Resource)
                .HasForeignKey(d => d.PartID)
                .HasConstraintName("FK_Resource_Part");
        });

        modelBuilder.Entity<ResourceVersion>(entity =>
        {
            entity.Property(e => e.ModDate).HasColumnType("date");
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.Src).HasMaxLength(90);
            entity.Property(e => e.VersionComment).HasMaxLength(50);
        });

        modelBuilder.Entity<ShipBy>(entity =>
        {
            entity.HasKey(e => e.ShipID);

            entity.Property(e => e.ShipByName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubAssembly>(entity =>
        {
            entity.Property(e => e.D).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.H).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MakeFile).HasMaxLength(240);
            entity.Property(e => e.SubAssemblyName).HasMaxLength(50);
            entity.Property(e => e.W).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Product).WithMany(p => p.SubAssembly)
                .HasForeignKey(d => d.ProductID)
                .HasConstraintName("FK_SubAssembly_Product");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierID).HasName("PK_Suppliers");

            entity.HasIndex(e => e.SupplierName, "IX_Suppliers").HasFillFactor(90);

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<TransActionType>(entity =>
        {
            entity.HasKey(e => e.TransactionsTypeID);

            entity.Property(e => e.TransactionTypeName).HasMaxLength(35);
        });

        modelBuilder.Entity<UnitOfMeasure>(entity =>
        {
            entity.Property(e => e.UnitName).HasMaxLength(50);
        });

        modelBuilder.Entity<WorkCenter>(entity =>
        {
            entity.Property(e => e.Availabilty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WorkCenterName)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.Property(e => e.WorkOrderID).ValueGeneratedOnAdd();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.WorkOrderDate).HasColumnType("date");

            entity.HasOne(d => d.WorkOrderNavigation).WithOne(p => p.WorkOrder)
                .HasForeignKey<WorkOrder>(d => d.WorkOrderID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkOrder_WorkOrderRouting");
        });

        modelBuilder.Entity<WorkOrderRouting>(entity =>
        {
            entity.HasKey(e => e.WorkOrderID);

            entity.Property(e => e.ActualCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ActualEndDate).HasColumnType("datetime");
            entity.Property(e => e.ActualStartDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PlannedCost).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");
            entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}