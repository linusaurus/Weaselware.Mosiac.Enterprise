using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataLayer.Entity;

#nullable disable

namespace DataLayer.Data
{
    public partial class BadgerContext : DbContext
    {
        public BadgerContext()
        {
        }

        public BadgerContext(DbContextOptions<BadgerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assembly> Assemblies { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<ClaimDocument> ClaimDocuments { get; set; }
        public virtual DbSet<ClaimItem> ClaimItems { get; set; }
        public virtual DbSet<CostHistory> CostHistories { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentPart> DocumentParts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Finish> Finishes { get; set; }
        public virtual DbSet<Global> Globals { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Manu> Manus { get; set; }
        public virtual DbSet<NFRC> NFRCs { get; set; }
        public virtual DbSet<OrderFee> OrderFees { get; set; }
        public virtual DbSet<OrderReceiptItem> OrderReceiptItems { get; set; }
        public virtual DbSet<OrderReciept> OrderReciepts { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<PartCategory> PartCategories { get; set; }
        public virtual DbSet<PartType> PartTypes { get; set; }
        public virtual DbSet<ProductionGroup> ProductionGroups { get; set; }
        public virtual DbSet<PurchaseLineItem> PurchaseLineItems { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<ResourceVersion> ResourceVersions { get; set; }
        public virtual DbSet<SDAPCD> SDAPCDs { get; set; }
        public virtual DbSet<ShipBy> ShipBies { get; set; }
        public virtual DbSet<StockBill> StockBills { get; set; }
        public virtual DbSet<StockBillItem> StockBillItems { get; set; }
        public virtual DbSet<SubAssembly> SubAssemblies { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TransActionType> TransActionTypes { get; set; }
        public virtual DbSet<UnitOfMeasure> UnitOfMeasures { get; set; }
        public virtual DbSet<UnitOfPurchase> UnitOfPurchases { get; set; }
        public virtual DbSet<WorkCenter> WorkCenters { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=192.168.10.34;database=Badger;uid=sa;pwd=Kx09a32x");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Assembly>(entity =>
            {
                entity.HasKey(e => e.ProductID);

                entity.ToTable("Assembly");

                entity.Property(e => e.ArchRef).HasMaxLength(120);

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.AssemblyName).HasMaxLength(120);

                entity.Property(e => e.CalculatedCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LaborHours).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Note)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Perimeter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ProductionDate).HasColumnType("date");

                entity.Property(e => e.ProductionID).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ProductionGroup)
                    .WithMany(p => p.Assemblies)
                    .HasForeignKey(d => d.ProductionGroupID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Article_Project");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("Asset");

                entity.Property(e => e.AddedBy).HasMaxLength(60);

                entity.Property(e => e.AssetDescription).HasMaxLength(512);

                entity.Property(e => e.AssetName).HasMaxLength(120);

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ManuPartNum)
                    .HasMaxLength(120)
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedBy).HasMaxLength(60);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Tag).HasMaxLength(50);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment");

                entity.Property(e => e.AttachmentDescription)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Creator).HasMaxLength(30);

                entity.Property(e => e.Ext)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.FileSize).HasMaxLength(50);

                entity.Property(e => e.src)
                    .HasMaxLength(140)
                    .IsUnicode(false);

                entity.HasOne(d => d.OrderNumNavigation)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.OrderNum)
                    .HasConstraintName("FK_Attachment_PurchaseOrder");
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.ToTable("Claim");

                entity.Property(e => e.ClaimDate).HasColumnType("date");

                entity.Property(e => e.SupplierOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaimDocument>(entity =>
            {
                entity.ToTable("ClaimDocument");

                entity.Property(e => e.DocumentDesciption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentExtension)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClaimItem)
                    .WithMany(p => p.ClaimDocuments)
                    .HasForeignKey(d => d.ClaimItemID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ClaimDocument_ClaimItem");
            });

            modelBuilder.Entity<ClaimItem>(entity =>
            {
                entity.ToTable("ClaimItem");

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

            modelBuilder.Entity<CostHistory>(entity =>
            {
                entity.HasKey(e => e.CostChangeID);

                entity.ToTable("CostHistory");

                entity.Property(e => e.DateStamp).HasColumnType("date");

                entity.Property(e => e.UoP).HasMaxLength(50);

                entity.Property(e => e.UpdatedUnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedUoPCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.User).HasMaxLength(50);
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocID)
                    .HasName("PK_DocumentDescriptor");

                entity.ToTable("Document");

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

            modelBuilder.Entity<DocumentPart>(entity =>
            {
                entity.HasKey(e => new { e.PartID, e.DocID });

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.DocumentParts)
                    .HasForeignKey(d => d.DocID)
                    .HasConstraintName("FK_DocumentParts_Document1");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.DocumentParts)
                    .HasForeignKey(d => d.PartID)
                    .HasConstraintName("FK_DocumentParts_Part");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

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

            modelBuilder.Entity<Finish>(entity =>
            {
                entity.ToTable("Finish");

                entity.Property(e => e.FinishName)
                    .HasMaxLength(70)
                    .HasDefaultValueSql("(' ')");
            });

            modelBuilder.Entity<Global>(entity =>
            {
                entity.HasKey(e => e.GiD);

                entity.Property(e => e.Data)
                    .HasMaxLength(70)
                    .IsFixedLength(true);

                entity.Property(e => e.ElementName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.StockTransactionID)
                    .HasName("PK_InventoryItems");

                entity.ToTable("Inventory");

                entity.Property(e => e.DateStamp)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.Location).HasMaxLength(120);

                entity.Property(e => e.Note).HasMaxLength(240);

                entity.Property(e => e.QntyBackOrdered).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.QntyOrdered)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.QntyReceived).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.StockBill)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.StockBillID)
                    .HasConstraintName("FK_Inventory_StockBill");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

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

            modelBuilder.Entity<Manu>(entity =>
            {
                entity.ToTable("Manu");

                entity.Property(e => e.ManuCategoryID).HasDefaultValueSql("((0))");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength(true);

                entity.Property(e => e.WebAddress)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NFRC>(entity =>
            {
                entity.HasKey(e => e.CPD_ID);

                entity.ToTable("NFRC");

                entity.Property(e => e.CPD).HasMaxLength(255);

                entity.Property(e => e.FrameMaterial)
                    .HasMaxLength(65)
                    .IsFixedLength(true);

                entity.Property(e => e.FrameSashType).HasMaxLength(255);

                entity.Property(e => e.GapFill).HasMaxLength(255);

                entity.Property(e => e.GlassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grid).HasMaxLength(255);

                entity.Property(e => e.IGU)
                    .HasMaxLength(75)
                    .IsFixedLength(true);

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

            modelBuilder.Entity<OrderFee>(entity =>
            {
                entity.ToTable("OrderFee");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Extension).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FeeName).HasMaxLength(200);

                entity.Property(e => e.Qnty).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.OrderFees)
                    .HasForeignKey(d => d.PurchaseOrderID)
                    .HasConstraintName("FK_OrderFee_PurchaseOrder");
            });

            modelBuilder.Entity<OrderReceiptItem>(entity =>
            {
                entity.HasKey(e => e.OrderReceiptLineID);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Extended).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Note).HasMaxLength(240);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.QuantityOrdered).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.QuantityReceived).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.OrderReceipt)
                    .WithMany(p => p.OrderReceiptItems)
                    .HasForeignKey(d => d.OrderReceiptID)
                    .HasConstraintName("FK_OrderReceiptItems_OrderReciept");
            });

            modelBuilder.Entity<OrderReciept>(entity =>
            {
                entity.HasKey(e => e.OrderReceiptID)
                    .HasName("PK_Reciept");

                entity.ToTable("OrderReciept");

                entity.Property(e => e.ReceiptDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.OrderReciepts)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_OrderReciept_Employee");

                entity.HasOne(d => d.OrderNumNavigation)
                    .WithMany(p => p.OrderReciepts)
                    .HasForeignKey(d => d.OrderNum)
                    .HasConstraintName("FK_OrderReciept_PurchaseOrder");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.OrderStatusID).ValueGeneratedNever();

                entity.Property(e => e.OrderStatus1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderStatus");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("Part");

                entity.Property(e => e.AddedBy).HasMaxLength(60);

                entity.Property(e => e.Amount_Required).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CARBlevel).HasMaxLength(50);

                entity.Property(e => e.CARBtrack).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.DateAdded).HasColumnType("datetime");

                entity.Property(e => e.FinishID).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemDescription)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Location)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength(true);

                entity.Property(e => e.ManuID).HasDefaultValueSql("((1))");

                entity.Property(e => e.ManuPartNum)
                    .HasMaxLength(120)
                    .IsFixedLength(true);

                entity.Property(e => e.MarkUp)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(60);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ObsoluteFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartNum)
                    .HasMaxLength(160)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.PartTypeID).HasDefaultValueSql("((10))");

                entity.Property(e => e.SKU)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.SupplierDescription)
                    .HasMaxLength(240)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength(true);

                entity.Property(e => e.UOP)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.UOPCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.UnitID).HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitToPurchaseFactor)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.UseSupplierNameFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Waste)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.SupplierID)
                    .HasConstraintName("FK_Supplier_Part");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Parts)
                    .HasForeignKey(d => d.UnitID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Part_UnitOfMeasure");
            });

            modelBuilder.Entity<PartCategory>(entity =>
            {
                entity.ToTable("PartCategory");

                entity.Property(e => e.PartCategoryName).HasMaxLength(70);
            });

            modelBuilder.Entity<PartType>(entity =>
            {
                entity.Property(e => e.PartTypeName)
                    .HasMaxLength(75)
                    .IsFixedLength(true);

                entity.HasOne(d => d.PartCategory)
                    .WithMany(p => p.PartTypes)
                    .HasForeignKey(d => d.PartCategoryID)
                    .HasConstraintName("FK_PartTypes_PartCategory");
            });

            modelBuilder.Entity<ProductionGroup>(entity =>
            {
                entity.ToTable("ProductionGroup");

                entity.Property(e => e.Created)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContracted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductionGroupName)
                    .HasMaxLength(120)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PurchaseLineItem>(entity =>
            {
                entity.HasKey(e => e.LineID);

                entity.ToTable("PurchaseLineItem");

                entity.Property(e => e.AmountReceived)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.BCode).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.Extended)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Note).HasMaxLength(254);

                entity.Property(e => e.Qnty)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierPartName)
                    .HasMaxLength(120)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength(true);

                entity.Property(e => e.Thick)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UnitCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.UoPPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseLineItems)
                    .HasForeignKey(d => d.PurchaseOrderID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PurchaseLineItem_PurchaseOrder");
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.OrderNum)
                    .HasName("PK_Order");

                entity.ToTable("PurchaseOrder");

                entity.Property(e => e.AddedBy)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.ExpectedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsBackOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Memo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderFormat).HasMaxLength(50);

                entity.Property(e => e.OrderState).HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Recieved).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecievedDate).HasColumnType("datetime");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.ShipID).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.SubTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.SuppressTax).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tax)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0.0))");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.EmployeeID)
                    .HasConstraintName("FK_PurchaseOrder_Employee");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.JobID)
                    .HasConstraintName("FK_PurchaseOrder_Job");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.SupplierID)
                    .HasConstraintName("FK_PurchaseOrder_Supplier");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.ToTable("Resource");

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.FileSize).HasMaxLength(50);

                entity.Property(e => e.Lastmod).HasColumnType("date");

                entity.Property(e => e.ResourceDescription).HasMaxLength(240);

                entity.Property(e => e.filesource).HasMaxLength(90);

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.PartID)
                    .HasConstraintName("FK_Resource_Part");
            });

            modelBuilder.Entity<ResourceVersion>(entity =>
            {
                entity.ToTable("ResourceVersion");

                entity.Property(e => e.ModDate).HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Src).HasMaxLength(90);

                entity.Property(e => e.VersionComment).HasMaxLength(50);
            });

            modelBuilder.Entity<SDAPCD>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SDAPCD");

                entity.Property(e => e.BoilingPoint).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.MixRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VOC_Content).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VOC_Limit).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ShipBy>(entity =>
            {
                entity.HasKey(e => e.ShipID);

                entity.ToTable("ShipBy");

                entity.Property(e => e.ShipByName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockBill>(entity =>
            {
                entity.ToTable("StockBill");

                entity.Property(e => e.ItemTotal).HasColumnType("money");

                entity.Property(e => e.StockBillDate).HasColumnType("date");

                entity.Property(e => e.Submitted).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<StockBillItem>(entity =>
            {
                entity.HasKey(e => e.StockItemID)
                    .HasName("PK_BomItems");

                entity.ToTable("StockBillItem");

                entity.Property(e => e.Description).HasMaxLength(240);

                entity.Property(e => e.Qnty).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.StockBillDNavigation)
                    .WithMany(p => p.StockBillItems)
                    .HasForeignKey(d => d.StockBillD)
                    .HasConstraintName("FK_BomItems_BOM");
            });

            modelBuilder.Entity<SubAssembly>(entity =>
            {
                entity.ToTable("SubAssembly");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CompositeCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FrameSashType).HasMaxLength(70);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LaborHr).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MakeFile).HasMaxLength(120);

                entity.Property(e => e.Perimeter).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubAssemblyName).HasMaxLength(100);

                entity.Property(e => e.SystemName).HasMaxLength(120);

                entity.Property(e => e.UnitType).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SubAssemblies)
                    .HasForeignKey(d => d.ProductID)
                    .HasConstraintName("FK_SubAssembly_Assembly");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("Supplier");

                entity.HasIndex(e => e.SupplierName, "IX_Suppliers")
                    .HasFillFactor((byte)90);

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

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasKey(e => e.TaskCode);

                entity.ToTable("Task");

                entity.Property(e => e.TaskCode).ValueGeneratedNever();

                entity.Property(e => e.ActualTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostCalculation)
                    .HasMaxLength(60)
                    .IsFixedLength(true);

                entity.Property(e => e.EstimatedTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MarkUp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaskDescription)
                    .HasMaxLength(240)
                    .IsUnicode(false);

                entity.Property(e => e.TaskName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<TransActionType>(entity =>
            {
                entity.HasKey(e => e.TransactionsTypeID);

                entity.ToTable("TransActionType");

                entity.Property(e => e.TransactionTypeName).HasMaxLength(35);
            });

            modelBuilder.Entity<UnitOfMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitID);

                entity.ToTable("UnitOfMeasure");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitOfPurchase>(entity =>
            {
                entity.HasKey(e => e.UoPID);

                entity.ToTable("UnitOfPurchase");

                entity.Property(e => e.UOPCostUnit).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UOPName).HasMaxLength(50);

                entity.Property(e => e.UOPRatio).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.UnitOfPurchases)
                    .HasForeignKey(d => d.PartID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitOfPurchase_Part");
            });

            modelBuilder.Entity<WorkCenter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkCenter");

                entity.Property(e => e.Availabilty).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkCenterName)
                    .HasMaxLength(75)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkOrder");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WorkOrderDate).HasColumnType("date");
            });

            modelBuilder.Entity<WorkOrderRouting>(entity =>
            {
                entity.HasKey(e => e.WorkOrderID);

                entity.ToTable("WorkOrderRouting");

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
}
