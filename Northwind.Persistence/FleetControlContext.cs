using System;
using FleetControl.Application.Interfaces;
using FleetControl.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FleetControl.Persistence
{
    public partial class FleetControlContext : DbContext, IFleetControlContext
    {
        public FleetControlContext()
        {
        }

        public FleetControlContext(DbContextOptions<FleetControlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<AuditDataType> AuditDataType { get; set; }
        public virtual DbSet<AuditDetail> AuditDetail { get; set; }
        public virtual DbSet<AuditEvent> AuditEvent { get; set; }
        public virtual DbSet<AuditHistory> AuditHistory { get; set; }
        public virtual DbSet<AuditHistoryDetail> AuditHistoryDetail { get; set; }
        public virtual DbSet<BusinessAssociate> BusinessAssociate { get; set; }
        public virtual DbSet<BusinessHours> BusinessHours { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CardAddress> CardAddress { get; set; }
        public virtual DbSet<CardCategory> CardCategory { get; set; }
        public virtual DbSet<CardClass> CardClass { get; set; }
        public virtual DbSet<CardImport> CardImport { get; set; }
        public virtual DbSet<CardNumberRegistry> CardNumberRegistry { get; set; }
        public virtual DbSet<CardPinRegistry> CardPinRegistry { get; set; }
        public virtual DbSet<ContractTaxLocation> ContractTaxLocation { get; set; }
        public virtual DbSet<CustomerClass> CustClass { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerAssignment> CustomerAssignment { get; set; }
        public virtual DbSet<CustomerCardCategory> CustomerCardCategory { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<CustomerGroupDetail> CustomerGroupDetail { get; set; }
        public virtual DbSet<CustomerMerchantLocation> CustomerMerchantLocation { get; set; }
        public virtual DbSet<CustomerPricingLocationGroup> CustomerPricingLocationGroup { get; set; }
        public virtual DbSet<CustomerPricingLocationWorkEntry> CustomerPricingLocationWorkEntry { get; set; }
        public virtual DbSet<CustomerStateLocation> CustomerStateLocation { get; set; }
        public virtual DbSet<CustomerZipCodeLocation> CustomerZipCodeLocation { get; set; }
        public virtual DbSet<DAMCard> Damcard { get; set; }
        public virtual DbSet<DAMCardConfirmation> DamcardConfirmation { get; set; }
        public virtual DbSet<DAMCustomer> Damcustomer { get; set; }
        public virtual DbSet<DAMDriver> Damdriver { get; set; }
        public virtual DbSet<DAMUploadDetail> DamuploadDetail { get; set; }
        public virtual DbSet<DAMVehicle> Damvehicle { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<DriverAssignment> DriverAssignment { get; set; }
        public virtual DbSet<DriverImport> DriverImport { get; set; }
        public virtual DbSet<DriverPinRegistry> DriverPinRegistry { get; set; }
        public virtual DbSet<DuplicateTransaction> DuplicateTransactions { get; set; }
        public virtual DbSet<ExternalDatabase> ExternalDatabase { get; set; }
        public virtual DbSet<ExternalDatabaseDetail> ExternalDatabaseDetail { get; set; }
        public virtual DbSet<FleetRec> FleetRec { get; set; }
        public virtual DbSet<FuelManagementGroup> FuelManagementGroup { get; set; }
        public virtual DbSet<FuelMasterTransactionLog> FuelMasterTransactionLog { get; set; }
        public virtual DbSet<ImportedTransaction> ImportedTransactions { get; set; }
        public virtual DbSet<InterfaceDatasource> InterfaceDatasource { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<LocationPricingLocationGroup> LocationPricingLocationGroup { get; set; }
        public virtual DbSet<MasterGroup> MasterGroups { get; set; }
        public virtual DbSet<NBCSProduct> Nbcsproducts { get; set; }
        public virtual DbSet<NumberRegistry> NumberRegistry { get; set; }
        public virtual DbSet<NYCHALabels> Nychalabels { get; set; }
        public virtual DbSet<OrgLevelDefinition> OrgLevelDefinition { get; set; }
        public virtual DbSet<OrgLevelName> OrgLevelName { get; set; }
        public virtual DbSet<ParticipantCode> ParticipantCode { get; set; }
        public virtual DbSet<PricingLocationGroup> PricingLocationGroup { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<PumpPrice> PumpPrices { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual DbSet<RetailAdder> RetailAdder { get; set; }
        public virtual DbSet<SampleTable> SampleTable { get; set; }
        public virtual DbSet<SendTransactionsErrorLog> SendTransactionsErrorLog { get; set; }
        public virtual DbSet<SiteCustomer> SiteCustomers { get; set; }
        public virtual DbSet<SiteProduct> SiteProduct { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SmallGallonTransaction> SmallGallonTransactions { get; set; }
        public virtual DbSet<SolarcProduct> SolArcProduct { get; set; }
        public virtual DbSet<SolarcLocale> SolarcLocale { get; set; }
        public virtual DbSet<Source> Source { get; set; }
        public virtual DbSet<SpecialCustomer> SpecialCustomer { get; set; }
        public virtual DbSet<SPR_CreateFleetRecExceptions> SprCreateFleetRecExceptions { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<SyncCard> SyncCard { get; set; }
        public virtual DbSet<SyncVehicle> SyncVehicle { get; set; }
        public virtual DbSet<TaxArea> TaxAreas { get; set; }
        public virtual DbSet<TaxLocation> TaxLocation { get; set; }
        public virtual DbSet<TempTransaction> TempTransaction { get; set; }
        public virtual DbSet<TransactionError> TransactionError { get; set; }
        public virtual DbSet<TransactionErrorDetail> TransactionErrorDetail { get; set; }
        public virtual DbSet<TransactionException> TransactionException { get; set; }
        public virtual DbSet<TransactionExceptionDetail> TransactionExceptionDetail { get; set; }
        public virtual DbSet<TransactionFlag> TransactionFlag { get; set; }
        public virtual DbSet<TransactionImportLog> TransactionImportLog { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleImport> VehicleImport { get; set; }
        public virtual DbSet<VehicleType> VehicleType { get; set; }
        public virtual DbSet<VoidTransaction> VoidTransactions { get; set; }
        public virtual DbSet<VoyagerErrorCodes> VoyagerErrorCodes { get; set; }
        public virtual DbSet<VoyagerSyncCard> VoyagerSyncCard { get; set; }
        public virtual DbSet<VoyagerSyncDriver> VoyagerSyncDriver { get; set; }
        public virtual DbSet<VoyagerSyncVehicle> VoyagerSyncVehicle { get; set; }
        public virtual DbSet<WinC6TransactionLog> WinC6transactionLog { get; set; }
        public virtual DbSet<YTD_Product_Totals> YtdProductTotals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            //modelBuilder.Entity<Audit>(entity =>
            //{
            //    entity.HasIndex(e => e.AuditEventId)
            //        .HasName("IX_AuditEventId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.AuditEvent)
            //    //    .WithMany(p => p.Audit)
            //    //    .HasForeignKey(d => d.AuditEventId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.Audit_dbo.AuditEvent_AuditEventId");
            //});

            //modelBuilder.Entity<AuditDataType>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.KeyCaption).HasMaxLength(100);

            //    entity.Property(e => e.KeyDataType).HasMaxLength(100);

            //    entity.Property(e => e.KeyTable).HasMaxLength(100);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ValueCaption)
            //        .IsRequired()
            //        .HasMaxLength(100);

            //    entity.Property(e => e.ValueDataType)
            //        .IsRequired()
            //        .HasMaxLength(100);
            //});

            //modelBuilder.Entity<AuditDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.AuditDataTypeId)
            //        .HasName("IX_AuditDataTypeId");

            //    entity.HasIndex(e => e.AuditId)
            //        .HasName("IX_AuditId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.AuditDataType)
            //        .WithMany(p => p.AuditDetail)
            //        .HasForeignKey(d => d.AuditDataTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.AuditDetail_dbo.AuditDataType_AuditDataTypeId");

            //    entity.HasOne(d => d.Audit)
            //        .WithMany(p => p.AuditDetail)
            //        .HasForeignKey(d => d.AuditId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.AuditDetail_dbo.Audit_AuditId");
            //});

            //modelBuilder.Entity<AuditEvent>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<AuditHistory>(entity =>
            //{
            //    entity.HasIndex(e => e.AuditEventId)
            //        .HasName("IX_AuditEventId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.AuditEvent)
            //        .WithMany(p => p.AuditHistory)
            //        .HasForeignKey(d => d.AuditEventId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.AuditHistory_dbo.AuditEvent_AuditEventId");
            //});

            //modelBuilder.Entity<AuditHistoryDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.AuditDataTypeId)
            //        .HasName("IX_AuditDataTypeId");

            //    entity.HasIndex(e => e.AuditHistoryId)
            //        .HasName("IX_AuditHistoryId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.AuditDataType)
            //        .WithMany(p => p.AuditHistoryDetail)
            //        .HasForeignKey(d => d.AuditDataTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.AuditHistoryDetail_dbo.AuditDataType_AuditDataTypeId");

            //    entity.HasOne(d => d.AuditHistory)
            //        .WithMany(p => p.AuditHistoryDetail)
            //        .HasForeignKey(d => d.AuditHistoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.AuditHistoryDetail_dbo.AuditHistory_AuditHistoryId");
            //});

            //modelBuilder.Entity<BusinessAssociate>(entity =>
            //{
            //    entity.Property(e => e.Baid).HasColumnName("BAID");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.IsFleetControlBaid).HasColumnName("IsFleetControlBAID");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<BusinessHours>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Card>(entity =>
            //{
            //    entity.HasIndex(e => e.ClassId)
            //        .HasName("IX_ClassId");

            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.HasIndex(e => e.VehicleId)
            //        .HasName("IX_VehicleId");

            //    entity.Property(e => e.CardExpirationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DamcardStatusIndicator).HasColumnName("DAMCardStatusIndicator");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.EmbossedCardNumber).HasMaxLength(15);

            //    entity.Property(e => e.ExternalDeleteDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirCardNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Class)
            //        .WithMany(p => p.Card)
            //        .HasForeignKey(d => d.ClassId)
            //        .HasConstraintName("FK_dbo.Card_dbo.CardClass_ClassId");

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.Card)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.Card_dbo.Customer_CustomerId");

            //    entity.HasOne(d => d.Driver)
            //        .WithMany(p => p.Card)
            //        .HasForeignKey(d => d.DriverId)
            //        .HasConstraintName("FK_dbo.Card_dbo.Driver_DriverId");

            //    entity.HasOne(d => d.Vehicle)
            //        .WithMany(p => p.Card)
            //        .HasForeignKey(d => d.VehicleId)
            //        .HasConstraintName("FK_dbo.Card_dbo.Vehicle_VehicleId");
            //});

            //modelBuilder.Entity<CardAddress>(entity =>
            //{
            //    entity.Property(e => e.AddressLine1).HasMaxLength(75);

            //    entity.Property(e => e.AddressLine2).HasMaxLength(75);

            //    entity.Property(e => e.City).HasMaxLength(25);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.NickName).HasMaxLength(50);

            //    entity.Property(e => e.PhoneNumber).HasMaxLength(10);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.State).HasMaxLength(2);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ZipCode).HasMaxLength(9);
            //});

            //modelBuilder.Entity<CardCategory>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CardClass>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(20);

            //    entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CardImport>(entity =>
            //{
            //    entity.HasIndex(e => e.ClassId)
            //        .HasName("IX_ClassId");

            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.HasIndex(e => e.VehicleId)
            //        .HasName("IX_VehicleId");

            //    entity.HasIndex(e => e.VehicleImportId)
            //        .HasName("IX_VehicleImportId");

            //    entity.Property(e => e.CardExpirationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CardNo).HasMaxLength(10);

            //    entity.Property(e => e.CardType).HasMaxLength(25);

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DamcardStatusIndicator).HasColumnName("DAMCardStatusIndicator");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.EmbossedCardNumber).HasMaxLength(15);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirCardNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Class)
            //        .WithMany(p => p.CardImport)
            //        .HasForeignKey(d => d.ClassId)
            //        .HasConstraintName("FK_dbo.CardImport_dbo.CardClass_ClassId");

            //    entity.HasOne(d => d.Driver)
            //        .WithMany(p => p.CardImport)
            //        .HasForeignKey(d => d.DriverId)
            //        .HasConstraintName("FK_dbo.CardImport_dbo.Driver_DriverId");

            //    entity.HasOne(d => d.Vehicle)
            //        .WithMany(p => p.CardImport)
            //        .HasForeignKey(d => d.VehicleId)
            //        .HasConstraintName("FK_dbo.CardImport_dbo.Vehicle_VehicleId");

            //    entity.HasOne(d => d.VehicleImport)
            //        .WithMany(p => p.CardImport)
            //        .HasForeignKey(d => d.VehicleImportId)
            //        .HasConstraintName("FK_dbo.CardImport_dbo.VehicleImport_VehicleImportId");
            //});

            //modelBuilder.Entity<CardNumberRegistry>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CardPinRegistry>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<ContractTaxLocation>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.FromDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.ToDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CustomerClass>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(30);

            //    entity.Property(e => e.CustomerClassExternalId).HasMaxLength(10);

            //    entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            //    entity.Property(e => e.MaxFuel).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxRange).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MinRange).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Customer>(entity =>
            //{
            //    entity.HasIndex(e => e.BusinessHoursId)
            //        .HasName("IX_BusinessHoursId");

            //    entity.HasIndex(e => e.CardAddressId)
            //        .HasName("IX_CardAddressId");

            //    entity.Property(e => e.Address1)
            //        .IsRequired()
            //        .HasMaxLength(35);

            //    entity.Property(e => e.Address2).HasMaxLength(35);

            //    entity.Property(e => e.BAID).HasColumnName("BAID");

            //    entity.Property(e => e.BillingCode).HasMaxLength(1);

            //    entity.Property(e => e.BillingFrequency).HasMaxLength(1);

            //    entity.Property(e => e.City).HasMaxLength(15);

            //    entity.Property(e => e.Contact).HasMaxLength(25);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustomerName).HasMaxLength(50);

            //    entity.Property(e => e.EmbossedCustomerName).HasMaxLength(25);

            //    entity.Property(e => e.ExternalFMSNumber)
            //        .HasColumnName("ExternalFMSNumber")
            //        .HasMaxLength(25);

            //    entity.Property(e => e.FMRGroup)
            //        .HasColumnName("FMRGroup")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.InvoiceSeparation).HasMaxLength(1);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LiftingNumber).HasMaxLength(25);

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.NYCAccount)
            //        .HasColumnName("NYCAccount")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.PinGeneration).HasMaxLength(1);

            //    entity.Property(e => e.PORequired).HasColumnName("PORequired");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesPerson).HasMaxLength(25);

            //    entity.Property(e => e.SpecialCustomerCode).HasMaxLength(1);

            //    entity.Property(e => e.UsState).HasMaxLength(2);

            //    entity.Property(e => e.Telephone)
            //        .IsRequired()
            //        .HasMaxLength(10);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.WetHosing).HasMaxLength(1);

            //    entity.Property(e => e.ZipCode)
            //        .IsRequired()
            //        .HasMaxLength(9);

            //    //entity.HasOne(d => d.BusinessHours)
            //    //    .WithMany(p => p.Customer)
            //    //    .HasForeignKey(d => d.BusinessHoursId)
            //    //    .HasConstraintName("FK_dbo.Customer_dbo.BusinessHours_BusinessHoursId");

            //    //entity.HasOne(d => d.CardAddress)
            //    //    .WithMany(p => p.Customer)
            //    //    .HasForeignKey(d => d.CardAddressId)
            //    //    .HasConstraintName("FK_dbo.Customer_dbo.CardAddress_CardAddressId");
            //});

            //modelBuilder.Entity<CustomerAssignment>(entity =>
            //{
            //    entity.Property(e => e.BAID).HasColumnName("BAID");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CustomerCardCategory>(entity =>
            //{
            //    entity.HasIndex(e => e.CardCategoryId)
            //        .HasName("IX_CardCategoryId");

            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.CardCategory)
            //    //    .WithMany(p => p.CustomerCardCategory)
            //    //    .HasForeignKey(d => d.CardCategoryId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerCardCategory_dbo.CardCategory_CardCategoryId");

            //    //entity.HasOne(d => d.Customer)
            //    //    .WithMany(p => p.CustomerCardCategory)
            //    //    .HasForeignKey(d => d.CustomerId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerCardCategory_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<CustomerGroup>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CustomerGroupDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerGroupId)
            //        .HasName("IX_CustomerGroupId");

            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.CustomerGroup)
            //    //    .WithMany(p => p.CustomerGroupDetail)
            //    //    .HasForeignKey(d => d.CustomerGroupId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerGroupDetail_dbo.CustomerGroup_CustomerGroupId");

            //    //entity.HasOne(d => d.Customer)
            //    //    .WithMany(p => p.CustomerGroupDetail)
            //    //    .HasForeignKey(d => d.CustomerId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerGroupDetail_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<CustomerMerchantLocation>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.Customer)
            //    //    .WithMany(p => p.CustomerMerchantLocation)
            //    //    .HasForeignKey(d => d.CustomerId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerMerchantLocation_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<CustomerPricingLocationGroup>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.FromDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.ToDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CustomerPricingLocationWorkEntry>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<CustomerStateLocation>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.HasIndex(e => e.StateId)
            //        .HasName("IX_StateId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.Customer)
            //    //    .WithMany(p => p.CustomerStateLocation)
            //    //    .HasForeignKey(d => d.CustomerId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerStateLocation_dbo.Customer_CustomerId");

            //    //entity.HasOne(d => d.State)
            //    //    .WithMany(p => p.CustomerStateLocation)
            //    //    .HasForeignKey(d => d.StateId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerStateLocation_dbo.State_StateId");
            //});

            //modelBuilder.Entity<CustomerZipCodeLocation>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    //entity.HasOne(d => d.Customer)
            //    //    .WithMany(p => p.CustomerZipCodeLocation)
            //    //    .HasForeignKey(d => d.CustomerId)
            //    //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    //    .HasConstraintName("FK_dbo.CustomerZipCodeLocation_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<Damcard>(entity =>
            //{
            //    entity.ToTable("DAMCard");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Damaction).HasColumnName("DAMAction");

            //    entity.Property(e => e.DamcardStatusIndicator).HasColumnName("DAMCardStatusIndicator");

            //    entity.Property(e => e.Damstatus).HasColumnName("DAMStatus");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<DamcardConfirmation>(entity =>
            //{
            //    entity.ToTable("DAMCardConfirmation");

            //    entity.Property(e => e.Baid).HasColumnName("BAID");

            //    entity.Property(e => e.CardExpirationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.ErrorCode1).HasMaxLength(5);

            //    entity.Property(e => e.ErrorCode2).HasMaxLength(5);

            //    entity.Property(e => e.ErrorCode3).HasMaxLength(5);

            //    entity.Property(e => e.ErrorCode4).HasMaxLength(5);

            //    entity.Property(e => e.ErrorCode5).HasMaxLength(5);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Damcustomer>(entity =>
            //{
            //    entity.ToTable("DAMCustomer");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Damaction).HasColumnName("DAMAction");

            //    entity.Property(e => e.Damstatus).HasColumnName("DAMStatus");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Damdriver>(entity =>
            //{
            //    entity.ToTable("DAMDriver");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Damaction).HasColumnName("DAMAction");

            //    entity.Property(e => e.Damstatus).HasColumnName("DAMStatus");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<DamuploadDetail>(entity =>
            //{
            //    entity.ToTable("DAMUploadDetail");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UploadDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Damvehicle>(entity =>
            //{
            //    entity.ToTable("DAMVehicle");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Damaction).HasColumnName("DAMAction");

            //    entity.Property(e => e.Damstatus).HasColumnName("DAMStatus");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Driver>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExternalDeleteDate).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalDriverId).HasMaxLength(20);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.Menu).HasColumnName("MENU");

            //    entity.Property(e => e.MiddleInitial).HasMaxLength(1);

            //    entity.Property(e => e.NameFirst).HasMaxLength(20);

            //    entity.Property(e => e.NameLast).HasMaxLength(20);

            //    entity.Property(e => e.Pin)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirEmployeeNumber).HasMaxLength(10);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.Driver)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.Driver_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<DriverAssignment>(entity =>
            //{
            //    entity.Property(e => e.AccountNumber).HasMaxLength(50);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DriverId).HasMaxLength(20);

            //    entity.Property(e => e.FirstName).HasMaxLength(50);

            //    entity.Property(e => e.LastName).HasMaxLength(50);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<DriverImport>(entity =>
            //{
            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.Menu).HasColumnName("MENU");

            //    entity.Property(e => e.MiddleInitial).HasMaxLength(1);

            //    entity.Property(e => e.NameFirst).HasMaxLength(20);

            //    entity.Property(e => e.NameLast).HasMaxLength(20);

            //    entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirEmployeeNumber).HasMaxLength(10);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<DriverPinRegistry>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Dtproperties>(entity =>
            //{
            //    entity.ToTable("DTProperties");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Ivalue)
            //        .HasColumnName("IValue")
            //        .HasColumnType("image");

            //    entity.Property(e => e.Property).HasMaxLength(64);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Uvalue)
            //        .HasColumnName("UValue")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Value).HasMaxLength(255);
            //});

            //modelBuilder.Entity<DuplicateTransactions>(entity =>
            //{
            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExceptionFlags).HasMaxLength(3);

            //    entity.Property(e => e.FederalExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MerchantInvoiceNumber).HasMaxLength(8);

            //    entity.Property(e => e.MicrofileRefNumber).HasMaxLength(15);

            //    entity.Property(e => e.Pbtamount)
            //        .HasColumnName("PBTAmount")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtrate).HasColumnName("PBTRate");

            //    entity.Property(e => e.PerUnitCogs).HasColumnName("PerUnitCOGS");

            //    entity.Property(e => e.PostDate).HasColumnType("datetime");

            //    entity.Property(e => e.Prod).HasMaxLength(4);

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxPerGallonAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Source).HasMaxLength(2);

            //    entity.Property(e => e.SraextrnlDcmntNmbr)
            //        .HasColumnName("SRAExtrnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StateExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranTime).HasMaxLength(4);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.VoyagerPostDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<ExternalDatabase>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DatabaseName).HasMaxLength(50);

            //    entity.Property(e => e.Path).HasMaxLength(1000);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<ExternalDatabaseDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.ExternalDatabaseId)
            //        .HasName("IX_ExternalDatabaseId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.ExternalDatabase)
            //        .WithMany(p => p.ExternalDatabaseDetail)
            //        .HasForeignKey(d => d.ExternalDatabaseId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.ExternalDatabaseDetail_dbo.ExternalDatabase_ExternalDatabaseId");
            //});

            //modelBuilder.Entity<FleetRec>(entity =>
            //{
            //    entity.Property(e => e.AuthorizationNumber).HasMaxLength(50);

            //    entity.Property(e => e.BillingWeek).HasMaxLength(10);

            //    entity.Property(e => e.CardNumber).HasMaxLength(20);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Customer).HasMaxLength(10);

            //    entity.Property(e => e.CustomerName).HasMaxLength(50);

            //    entity.Property(e => e.CustomerPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.DeviceName).HasMaxLength(50);

            //    entity.Property(e => e.DeviceNo).HasMaxLength(10);

            //    entity.Property(e => e.Division).HasMaxLength(10);

            //    entity.Property(e => e.DivisionName).HasMaxLength(50);

            //    entity.Property(e => e.IssueLicensee).HasMaxLength(10);

            //    entity.Property(e => e.IssueLicenseeName).HasMaxLength(50);

            //    entity.Property(e => e.Merchant).HasMaxLength(10);

            //    entity.Property(e => e.MerchantName).HasMaxLength(50);

            //    entity.Property(e => e.NetworkPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Product).HasMaxLength(50);

            //    entity.Property(e => e.ProductDescription).HasMaxLength(50);

            //    entity.Property(e => e.ProductType).HasMaxLength(50);

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ReceiveLicensee).HasMaxLength(10);

            //    entity.Property(e => e.ReceiveLicenseeName).HasMaxLength(50);

            //    entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranNo).HasMaxLength(50);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<FuelManagementGroup>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(30);

            //    entity.Property(e => e.Fmrgroup)
            //        .HasColumnName("FMRGroup")
            //        .HasMaxLength(3);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<FuelMasterTransactionLog>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TranTime).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<ImportedTransactions>(entity =>
            //{
            //    entity.HasIndex(e => e.LocationId)
            //        .HasName("IX_LocationId");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExceptionFlags).HasMaxLength(3);

            //    entity.Property(e => e.FederalExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.FileDate).HasColumnType("datetime");

            //    entity.Property(e => e.MerchantInvoiceNumber).HasMaxLength(8);

            //    entity.Property(e => e.MicrofileRefNumber).HasMaxLength(15);

            //    entity.Property(e => e.Pbtamount)
            //        .HasColumnName("PBTAmount")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtrate).HasColumnName("PBTRate");

            //    entity.Property(e => e.PerUnitCogs).HasColumnName("PerUnitCOGS");

            //    entity.Property(e => e.PostDate).HasColumnType("datetime");

            //    entity.Property(e => e.ProcessDate).HasColumnType("datetime");

            //    entity.Property(e => e.Prod).HasMaxLength(4);

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxPerGallonAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Source).HasMaxLength(2);

            //    entity.Property(e => e.SraextrnlDcmntNmbr)
            //        .HasColumnName("SRAExtrnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StateExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.StatementDate).HasColumnType("datetime");

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranNo).HasMaxLength(15);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.VoyagerPostDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Location)
            //        .WithMany(p => p.ImportedTransactions)
            //        .HasForeignKey(d => d.LocationId)
            //        .HasConstraintName("FK_dbo.ImportedTransactions_dbo.Location_LocationId");
            //});

            //modelBuilder.Entity<InterfaceDatasource>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Levels>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<List>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(30);

            //    entity.Property(e => e.List1)
            //        .HasColumnName("List")
            //        .HasMaxLength(5);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Location>(entity =>
            //{
            //    entity.Property(e => e.Address).HasMaxLength(25);

            //    entity.Property(e => e.BillingCycle).HasMaxLength(1);

            //    entity.Property(e => e.BrandedStation).HasMaxLength(15);

            //    entity.Property(e => e.City).HasMaxLength(17);

            //    entity.Property(e => e.Closed).HasMaxLength(1);

            //    entity.Property(e => e.ConsignmentEffectiveDate).HasMaxLength(8);

            //    entity.Property(e => e.Contact).HasMaxLength(25);

            //    entity.Property(e => e.CostPlusPubCode).HasMaxLength(3);

            //    entity.Property(e => e.County).HasMaxLength(50);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DeviceNo).HasMaxLength(13);

            //    entity.Property(e => e.Direc1).HasMaxLength(40);

            //    entity.Property(e => e.Direc2).HasMaxLength(40);

            //    entity.Property(e => e.EomtaxExempt)
            //        .HasColumnName("EOMTaxExempt")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.ExceptionReportAltPhone).HasMaxLength(10);

            //    entity.Property(e => e.Fuels).HasMaxLength(50);

            //    entity.Property(e => e.Hour1).HasMaxLength(9);

            //    entity.Property(e => e.Hour2).HasMaxLength(9);

            //    entity.Property(e => e.Igasca)
            //        .HasColumnName("IGASCA")
            //        .HasMaxLength(6);

            //    entity.Property(e => e.IgascashipTo)
            //        .HasColumnName("IGASCAShipTo")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.Jdelocation)
            //        .HasColumnName("JDELocation")
            //        .HasMaxLength(4);

            //    entity.Property(e => e.MailAddress).HasMaxLength(40);

            //    entity.Property(e => e.MailAttn).HasMaxLength(20);

            //    entity.Property(e => e.MailCity).HasMaxLength(20);

            //    entity.Property(e => e.MailName).HasMaxLength(40);

            //    entity.Property(e => e.MailState).HasMaxLength(2);

            //    entity.Property(e => e.MailZip).HasMaxLength(10);

            //    entity.Property(e => e.Name).HasMaxLength(25);

            //    entity.Property(e => e.NyccontractSite)
            //        .HasColumnName("NYCContractSite")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.OffOnSiteType)
            //        .HasColumnName("Off_OnSiteType")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.ParticipantCd).HasColumnName("ParticipantCD");

            //    entity.Property(e => e.Phone).HasMaxLength(12);

            //    entity.Property(e => e.Private).HasMaxLength(1);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SiteName).HasMaxLength(25);

            //    entity.Property(e => e.State).HasMaxLength(2);

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.Truck).HasMaxLength(1);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ViewOnTaxListing).HasMaxLength(1);

            //    entity.Property(e => e.Zip).HasMaxLength(5);

            //    entity.Property(e => e.Zip4).HasMaxLength(4);

            //    entity.Property(e => e._01minus).HasColumnName("01Minus");

            //    entity.Property(e => e._02minus).HasColumnName("02Minus");

            //    entity.Property(e => e._03minus).HasColumnName("03Minus");

            //    entity.Property(e => e._31minus).HasColumnName("31Minus");
            //});

            //modelBuilder.Entity<LocationPricingLocationGroup>(entity =>
            //{
            //    entity.HasIndex(e => e.LocationId)
            //        .HasName("IX_LocationId");

            //    entity.HasIndex(e => e.PricingLocationGroupId)
            //        .HasName("IX_PricingLocationGroupId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.FromDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.ToDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Location)
            //        .WithMany(p => p.LocationPricingLocationGroup)
            //        .HasForeignKey(d => d.LocationId)
            //        .HasConstraintName("FK_dbo.LocationPricingLocationGroup_dbo.Location_LocationId");

            //    entity.HasOne(d => d.PricingLocationGroup)
            //        .WithMany(p => p.LocationPricingLocationGroup)
            //        .HasForeignKey(d => d.PricingLocationGroupId)
            //        .HasConstraintName("FK_dbo.LocationPricingLocationGroup_dbo.PricingLocationGroup_PricingLocationGroupId");
            //});

            //modelBuilder.Entity<MasterGroups>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.MasterGroupCode).HasMaxLength(3);

            //    entity.Property(e => e.MasterGroupDesc).HasMaxLength(30);

            //    entity.Property(e => e.MasterGroupSumCode).HasMaxLength(3);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Nbcsproducts>(entity =>
            //{
            //    entity.ToTable("NBCSProducts");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.FleetCorProduct).HasMaxLength(10);

            //    entity.Property(e => e.ProductDescription).HasMaxLength(16);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.Units).HasMaxLength(10);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<NumberRegistry>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Nychalabels>(entity =>
            //{
            //    entity.ToTable("NYCHALabels");

            //    entity.Property(e => e.Address).HasMaxLength(30);

            //    entity.Property(e => e.AttnTo).HasMaxLength(30);

            //    entity.Property(e => e.City).HasMaxLength(24);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustomerNumber).HasMaxLength(5);

            //    entity.Property(e => e.Description).HasMaxLength(40);

            //    entity.Property(e => e.GroupNumber).HasMaxLength(5);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.State).HasMaxLength(2);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ZipCode).HasMaxLength(10);
            //});

            //modelBuilder.Entity<OrgLevelDefinition>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DisplayName).HasMaxLength(25);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<OrgLevelName>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<ParticipantCode>(entity =>
            //{
            //    entity.Property(e => e.BrandName).HasMaxLength(50);

            //    entity.Property(e => e.Code).HasMaxLength(5);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<PersistentObject>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<PricingLocationGroup>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.PricingLocationGroupName).HasMaxLength(50);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Product>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ProdAbbrev).HasMaxLength(4);

            //    entity.Property(e => e.ProdCode).HasMaxLength(2);

            //    entity.Property(e => e.ProdDesc).HasMaxLength(30);

            //    entity.Property(e => e.ProdSumDesc).HasMaxLength(2);

            //    entity.Property(e => e.ProdType).HasMaxLength(2);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.WinC6productName)
            //        .HasColumnName("WinC6ProductName")
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<ProductLocationXref>(entity =>
            //{
            //    entity.HasIndex(e => e.LocationId)
            //        .HasName("IX_LocationId");

            //    entity.HasIndex(e => e.ProductId)
            //        .HasName("IX_ProductId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.FromDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.ToDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Location)
            //        .WithMany(p => p.ProductLocationXref)
            //        .HasForeignKey(d => d.LocationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.ProductLocationXref_dbo.Location_LocationId");

            //    entity.HasOne(d => d.Product)
            //        .WithMany(p => p.ProductLocationXref)
            //        .HasForeignKey(d => d.ProductId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.ProductLocationXref_dbo.Product_ProductId");
            //});

            //modelBuilder.Entity<PumpPrices>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.Site).HasMaxLength(6);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<PurchaseOrder>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            //    entity.Property(e => e.EndDate).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Repltest>(entity =>
            //{
            //    entity.HasKey(e => e.C1)
            //        .HasName("PK__repltest__3213663B47FBA9D6");

            //    entity.ToTable("repltest");

            //    entity.Property(e => e.C1).HasColumnName("c1");

            //    entity.Property(e => e.C2)
            //        .HasColumnName("c2")
            //        .HasColumnType("datetime");
            //});

            //modelBuilder.Entity<RetailAdder>(entity =>
            //{
            //    entity.Property(e => e.AdderAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.EndDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.StartDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SampleTable>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SendTransactionsErrorLog>(entity =>
            //{
            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.Property(e => e.AmtGal).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CostPerMile).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.CustomerSalesAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExceptionFlags).HasMaxLength(3);

            //    entity.Property(e => e.FedEx).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.FederalExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.FullPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MerchantInvoiceNumber).HasMaxLength(8);

            //    entity.Property(e => e.MicrofileRefNumber).HasMaxLength(15);

            //    entity.Property(e => e.MilesPerGallon).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.OtherTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtamount)
            //        .HasColumnName("PBTAmount")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtrate)
            //        .HasColumnName("PBTRate")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PerUnitCogs)
            //        .HasColumnName("PerUnitCOGS")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PostDate).HasColumnType("datetime");

            //    entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Prod).HasMaxLength(4);

            //    entity.Property(e => e.ProductBasePrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.PumpPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxPerGallonAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPerGallonRate).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentRate).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SolarcProductPrice).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Source).HasMaxLength(2);

            //    entity.Property(e => e.SraextrnlDcmntNmbr)
            //        .HasColumnName("SRAExtrnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StaEx).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.StaSales).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.StateExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.StationReimbursementActual).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.StationReimbursementAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranTime).HasMaxLength(4);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UnpaidTaxes).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.VoyagerPostDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SiteCustomers>(entity =>
            //{
            //    entity.Property(e => e.CardPrefix).HasMaxLength(1);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DeviceNo).HasMaxLength(7);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SiteProduct>(entity =>
            //{
            //    entity.HasIndex(e => e.LocationId)
            //        .HasName("IX_LocationId");

            //    entity.HasIndex(e => e.ProductId)
            //        .HasName("IX_ProductId");

            //    entity.HasIndex(e => e.SiteId)
            //        .HasName("IX_SiteId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Location)
            //        .WithMany(p => p.SiteProduct)
            //        .HasForeignKey(d => d.LocationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.SiteProduct_dbo.Location_LocationId");

            //    entity.HasOne(d => d.Product)
            //        .WithMany(p => p.SiteProduct)
            //        .HasForeignKey(d => d.ProductId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.SiteProduct_dbo.Product_ProductId");

            //    entity.HasOne(d => d.Site)
            //        .WithMany(p => p.SiteProduct)
            //        .HasForeignKey(d => d.SiteId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.SiteProduct_dbo.Sites_SiteId");
            //});

            //modelBuilder.Entity<Sites>(entity =>
            //{
            //    entity.Property(e => e.Address).HasMaxLength(50);

            //    entity.Property(e => e.City).HasMaxLength(50);

            //    entity.Property(e => e.Cos).HasColumnName("COS");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.IcuInit)
            //        .HasColumnName("ICU_Init")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.InitString).HasMaxLength(50);

            //    entity.Property(e => e.LastConnection).HasColumnType("datetime");

            //    entity.Property(e => e.ModemNumber).HasMaxLength(30);

            //    entity.Property(e => e.Parity).HasMaxLength(1);

            //    entity.Property(e => e.Phone).HasMaxLength(15);

            //    entity.Property(e => e.ReceiptLine1).HasMaxLength(17);

            //    entity.Property(e => e.ReceiptLine2).HasMaxLength(17);

            //    entity.Property(e => e.ReceiptLine3).HasMaxLength(17);

            //    entity.Property(e => e.ReceiptLine4).HasMaxLength(17);

            //    entity.Property(e => e.RomDesc)
            //        .HasColumnName("ROM_Desc")
            //        .HasMaxLength(40);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SiteName).HasMaxLength(50);

            //    entity.Property(e => e.State).HasMaxLength(2);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Zip).HasMaxLength(15);
            //});

            //modelBuilder.Entity<SmallGallonTransactions>(entity =>
            //{
            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExceptionFlags).HasMaxLength(3);

            //    entity.Property(e => e.FederalExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MerchantInvoiceNumber).HasMaxLength(8);

            //    entity.Property(e => e.MicrofileRefNumber).HasMaxLength(15);

            //    entity.Property(e => e.Pbtamount)
            //        .HasColumnName("PBTAmount")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtrate).HasColumnName("PBTRate");

            //    entity.Property(e => e.PerUnitCogs).HasColumnName("PerUnitCOGS");

            //    entity.Property(e => e.PostDate).HasColumnType("datetime");

            //    entity.Property(e => e.Prod).HasMaxLength(4);

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxPerGallonAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Source).HasMaxLength(2);

            //    entity.Property(e => e.SraextrnlDcmntNmbr)
            //        .HasColumnName("SRAExtrnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StateExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranTime).HasMaxLength(4);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.VoyagerPostDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Driver)
            //        .WithMany(p => p.SmallGallonTransactions)
            //        .HasForeignKey(d => d.DriverId)
            //        .HasConstraintName("FK_dbo.SmallGallonTransactions_dbo.Driver_DriverId");
            //});

            //modelBuilder.Entity<SolArcProduct>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ProductAbbreviation).HasMaxLength(3);

            //    entity.Property(e => e.ProductName).HasMaxLength(50);

            //    entity.Property(e => e.ProductStatus).HasMaxLength(1);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SolarcLocale>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.LocaleAbbreviation).HasMaxLength(20);

            //    entity.Property(e => e.LocaleStatus).HasMaxLength(1);

            //    entity.Property(e => e.OfficeBaid).HasColumnName("OfficeBAID");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Source>(entity =>
            //{
            //    entity.Property(e => e.Code).HasMaxLength(5);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(50);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SpecialCustomer>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SpecialCustomerCode).HasMaxLength(1);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SprCreateFleetRecExceptions>(entity =>
            //{
            //    entity.ToTable("SPR_CreateFleetRecExceptions");

            //    entity.Property(e => e.BillingWeek).HasMaxLength(6);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ErrorDesc).HasMaxLength(200);

            //    entity.Property(e => e.FleetTranNo).HasMaxLength(10);

            //    entity.Property(e => e.GasCardValue).HasMaxLength(20);

            //    entity.Property(e => e.ImportValue).HasMaxLength(20);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<State>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.State1)
            //        .HasColumnName("State")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<SyncCard>(entity =>
            //{
            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.HasIndex(e => e.VehicleId)
            //        .HasName("IX_VehicleId");

            //    entity.Property(e => e.CardExpirationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Driver)
            //        .WithMany(p => p.SyncCard)
            //        .HasForeignKey(d => d.DriverId)
            //        .HasConstraintName("FK_dbo.SyncCard_dbo.Driver_DriverId");

            //    entity.HasOne(d => d.Vehicle)
            //        .WithMany(p => p.SyncCard)
            //        .HasForeignKey(d => d.VehicleId)
            //        .HasConstraintName("FK_dbo.SyncCard_dbo.Vehicle_VehicleId");
            //});

            //modelBuilder.Entity<SyncVehicle>(entity =>
            //{
            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalPin).HasMaxLength(10);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MeterType).HasMaxLength(12);

            //    entity.Property(e => e.MileageUnitsOfMeasure).HasMaxLength(10);

            //    entity.Property(e => e.ProductType1).HasMaxLength(25);

            //    entity.Property(e => e.ProductType2).HasMaxLength(25);

            //    entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirVehicleNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UsedOnRoad).HasMaxLength(1);

            //    entity.Property(e => e.VehDesc).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLicenseTag).HasMaxLength(10);

            //    entity.Property(e => e.VehicleLicenseTagState).HasMaxLength(2);

            //    entity.Property(e => e.VehicleType).HasMaxLength(2);

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.Vin)
            //        .HasColumnName("VIN")
            //        .HasMaxLength(17);
            //});

            //modelBuilder.Entity<TaxAreas>(entity =>
            //{
            //    entity.Property(e => e.County).HasMaxLength(30);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Mctd)
            //        .HasColumnName("MCTD")
            //        .HasMaxLength(1);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxRegion).HasMaxLength(1);

            //    entity.Property(e => e.State).HasMaxLength(2);

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxAreaDesc).HasMaxLength(30);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TaxLocation>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TempTransaction>(entity =>
            //{
            //    entity.Property(e => e.CostPerMile).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.CostPerUnit).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.ExemptFederalTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptLocalSalesTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptMiscTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptPrimaryMotorFuelTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptSecondaryMotorFuelTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptStateSalesTax).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ExemptTaxes).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.FileDate).HasColumnType("datetime");

            //    entity.Property(e => e.MilesPerGallon).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ProductAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.ProductUnits).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.StatementDate).HasColumnType("datetime");

            //    entity.Property(e => e.TotalProductAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TotalProductUnits).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TransactionError>(entity =>
            //{
            //    entity.Property(e => e.Code).HasMaxLength(50);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(100);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TransactionErrorDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.ImportedTransactionId)
            //        .HasName("IX_ImportedTransactionId");

            //    entity.HasIndex(e => e.TransactionErrorId)
            //        .HasName("IX_TransactionErrorId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.ImportedTransaction)
            //        .WithMany(p => p.TransactionErrorDetail)
            //        .HasForeignKey(d => d.ImportedTransactionId)
            //        .HasConstraintName("FK_dbo.TransactionErrorDetail_dbo.ImportedTransactions_ImportedTransactionId");

            //    entity.HasOne(d => d.TransactionError)
            //        .WithMany(p => p.TransactionErrorDetail)
            //        .HasForeignKey(d => d.TransactionErrorId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.TransactionErrorDetail_dbo.TransactionError_TransactionErrorId");
            //});

            //modelBuilder.Entity<TransactionException>(entity =>
            //{
            //    entity.Property(e => e.Code).HasMaxLength(50);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Description).HasMaxLength(100);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TransactionExceptionDetail>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.HasIndex(e => e.TransactionExceptionId)
            //        .HasName("IX_TransactionExceptionId");

            //    entity.HasIndex(e => e.TransactionId)
            //        .HasName("IX_TransactionId");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.TransactionExceptionDetail)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.TransactionExceptionDetail_dbo.Customer_CustomerId");

            //    entity.HasOne(d => d.TransactionException)
            //        .WithMany(p => p.TransactionExceptionDetail)
            //        .HasForeignKey(d => d.TransactionExceptionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.TransactionExceptionDetail_dbo.TransactionException_TransactionExceptionId");

            //    entity.HasOne(d => d.Transaction)
            //        .WithMany(p => p.TransactionExceptionDetail)
            //        .HasForeignKey(d => d.TransactionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.TransactionExceptionDetail_dbo.Transactions_TransactionId");
            //});

            //modelBuilder.Entity<TransactionFlag>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<TransactionImportLog>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.StatementDate).HasColumnType("datetime");

            //    entity.Property(e => e.TotalProductAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TotalProductUnits).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<Transactions>(entity =>
            //{
            //    entity.HasIndex(e => e.CardId)
            //        .HasName("IX_CardId");

            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.HasIndex(e => e.DriverId)
            //        .HasName("IX_DriverId");

            //    entity.HasIndex(e => e.LocationId)
            //        .HasName("IX_LocationId");

            //    entity.HasIndex(e => e.VehicleId)
            //        .HasName("IX_VehicleId");

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.ExceptionFlags).HasMaxLength(3);

            //    entity.Property(e => e.FederalExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MerchantInvoiceNumber).HasMaxLength(8);

            //    entity.Property(e => e.MicrofileRefNumber).HasMaxLength(15);

            //    entity.Property(e => e.Pbtamount)
            //        .HasColumnName("PBTAmount")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Pbtrate).HasColumnName("PBTRate");

            //    entity.Property(e => e.PerUnitCogs).HasColumnName("PerUnitCOGS");

            //    entity.Property(e => e.PostDate).HasColumnType("datetime");

            //    entity.Property(e => e.Prod).HasMaxLength(4);

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.PurchaseOrderNumber).HasMaxLength(30);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SalesTaxPerGallonAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.SalesTaxPercentAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Source).HasMaxLength(2);

            //    entity.Property(e => e.SraextrnlDcmntNmbr)
            //        .HasColumnName("SRAExtrnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StateExciseTaxAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TaxArea).HasMaxLength(2);

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranNo).HasMaxLength(15);

            //    entity.Property(e => e.TranTime).HasMaxLength(4);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.VoyagerPostDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.Transactions)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.Transactions_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<Vehicle>(entity =>
            //{
            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("IX_CustomerId");

            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalDeleteDate).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalPin).HasMaxLength(10);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LegacyProductCode1).HasMaxLength(5);

            //    entity.Property(e => e.LegacyProductCode2).HasMaxLength(5);

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MeterType).HasMaxLength(12);

            //    entity.Property(e => e.MileageUnitsOfMeasure).HasMaxLength(10);

            //    entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirVehicleNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UsedOnRoad).HasMaxLength(1);

            //    entity.Property(e => e.VehDesc)
            //        .IsRequired()
            //        .HasMaxLength(25);

            //    entity.Property(e => e.VehicleLicenseTag).HasMaxLength(10);

            //    entity.Property(e => e.VehicleLicenseTagState).HasMaxLength(2);

            //    entity.Property(e => e.VehicleType).HasMaxLength(2);

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.Vin)
            //        .HasColumnName("VIN")
            //        .HasMaxLength(17);

            //    entity.HasOne(d => d.Customer)
            //        .WithMany(p => p.Vehicle)
            //        .HasForeignKey(d => d.CustomerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_dbo.Vehicle_dbo.Customer_CustomerId");
            //});

            //modelBuilder.Entity<VehicleImport>(entity =>
            //{
            //    entity.Property(e => e.CardNo).HasMaxLength(10);

            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(10);

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalPin).HasMaxLength(10);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LegacyProductCode1).HasMaxLength(5);

            //    entity.Property(e => e.LegacyProductCode2).HasMaxLength(5);

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MeterType).HasMaxLength(12);

            //    entity.Property(e => e.MileageUnitsOfMeasure).HasMaxLength(10);

            //    entity.Property(e => e.OriginCreateDate).HasColumnType("datetime");

            //    entity.Property(e => e.OriginModifyDate).HasColumnType("datetime");

            //    entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirVehicleNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UsedOnRoad).HasMaxLength(1);

            //    entity.Property(e => e.VehDesc).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLicenseTag).HasMaxLength(10);

            //    entity.Property(e => e.VehicleLicenseTagState).HasMaxLength(2);

            //    entity.Property(e => e.VehicleType).HasMaxLength(2);

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.Vin)
            //        .HasColumnName("VIN")
            //        .HasMaxLength(17);
            //});

            //modelBuilder.Entity<VehicleType>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehicleType1)
            //        .HasColumnName("VehicleType")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.VehicleTypeDesc).HasMaxLength(30);
            //});

            //modelBuilder.Entity<VoidTransactions>(entity =>
            //{
            //    entity.Property(e => e.CardNo).HasMaxLength(19);

            //    entity.Property(e => e.CardNoShort).HasMaxLength(6);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CreationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustNo).HasMaxLength(5);

            //    entity.Property(e => e.DateProcessed).HasColumnType("datetime");

            //    entity.Property(e => e.DeviceNo).HasMaxLength(7);

            //    entity.Property(e => e.EmplNo).HasMaxLength(5);

            //    entity.Property(e => e.ErrorCond).HasMaxLength(2);

            //    entity.Property(e => e.FleetNetTranNo).HasMaxLength(10);

            //    entity.Property(e => e.FleetNetWeek).HasMaxLength(6);

            //    entity.Property(e => e.FranNo).HasMaxLength(10);

            //    entity.Property(e => e.Item).HasMaxLength(2);

            //    entity.Property(e => e.Odometer).HasMaxLength(6);

            //    entity.Property(e => e.OrgnlSraextnlDcmntNmbr)
            //        .HasColumnName("OrgnlSRAExtnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.Prod).HasMaxLength(2);

            //    entity.Property(e => e.Pump).HasMaxLength(2);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.SiteFran).HasMaxLength(5);

            //    entity.Property(e => e.SraextnlDcmntNmbr)
            //        .HasColumnName("SRAExtnlDcmntNmbr")
            //        .HasMaxLength(80);

            //    entity.Property(e => e.StationReimbursementAmount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.TaxFlag).HasMaxLength(1);

            //    entity.Property(e => e.TranDate).HasColumnType("datetime");

            //    entity.Property(e => e.TranNo).HasMaxLength(4);

            //    entity.Property(e => e.TranTime).HasMaxLength(4);

            //    entity.Property(e => e.TranType4).HasMaxLength(4);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.VehcNo).HasMaxLength(5);
            //});

            //modelBuilder.Entity<VoyagerErrorCodes>(entity =>
            //{
            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<VoyagerSyncCard>(entity =>
            //{
            //    entity.Property(e => e.CardExpirationDate).HasColumnType("datetime");

            //    entity.Property(e => e.CardLevel2Name).HasMaxLength(25);

            //    entity.Property(e => e.CardLevel3Name).HasMaxLength(25);

            //    entity.Property(e => e.CardLevel4Name).HasMaxLength(25);

            //    entity.Property(e => e.CardLevel5Name).HasMaxLength(25);

            //    entity.Property(e => e.CardLevel6Name).HasMaxLength(25);

            //    entity.Property(e => e.CardLevel7Name).HasMaxLength(25);

            //    entity.Property(e => e.CardUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.CardUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.CardUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.CardUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DamcardStatusIndicator).HasColumnName("DAMCardStatusIndicator");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.EmbossedCardNumber).HasMaxLength(15);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.PurchaseFromTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseFromTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand1).HasColumnType("datetime");

            //    entity.Property(e => e.PurchaseToTimeBand2).HasColumnType("datetime");

            //    entity.Property(e => e.Qty)
            //        .HasColumnName("QTY")
            //        .HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<VoyagerSyncDriver>(entity =>
            //{
            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.DriverLevel2Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverLevel3Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverLevel4Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverLevel5Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverLevel6Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverLevel7Name).HasMaxLength(25);

            //    entity.Property(e => e.DriverUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.DriverUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.DriverUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.DriverUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.Menu).HasColumnName("MENU");

            //    entity.Property(e => e.MiddleInitial).HasMaxLength(1);

            //    entity.Property(e => e.NameFirst).HasMaxLength(20);

            //    entity.Property(e => e.NameLast).HasMaxLength(20);

            //    entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirEmployeeNumber).HasMaxLength(10);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<VoyagerSyncVehicle>(entity =>
            //{
            //    entity.Property(e => e.Class).HasMaxLength(10);

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Date1stPur).HasColumnType("datetime");

            //    entity.Property(e => e.ExternalPin).HasMaxLength(10);

            //    entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastGallons).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUseDate).HasColumnType("datetime");

            //    entity.Property(e => e.LegacyProductCode1).HasMaxLength(5);

            //    entity.Property(e => e.LegacyProductCode2).HasMaxLength(5);

            //    entity.Property(e => e.LockCode).HasMaxLength(1);

            //    entity.Property(e => e.LockDate).HasColumnType("datetime");

            //    entity.Property(e => e.MaxGalCycl).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalDay).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxGalTrn).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MaxMotorOil).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.MeterType).HasMaxLength(12);

            //    entity.Property(e => e.MileageUnitsOfMeasure).HasMaxLength(10);

            //    entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TheirVehicleNumber).HasMaxLength(20);

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.UsedOnRoad).HasMaxLength(1);

            //    entity.Property(e => e.VehDesc).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel2Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel3Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel4Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel5Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel6Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLevel7Name).HasMaxLength(25);

            //    entity.Property(e => e.VehicleLicenseTag).HasMaxLength(10);

            //    entity.Property(e => e.VehicleLicenseTagState).HasMaxLength(2);

            //    entity.Property(e => e.VehicleType).HasMaxLength(2);

            //    entity.Property(e => e.VehicleUserCode1).HasMaxLength(13);

            //    entity.Property(e => e.VehicleUserCode2).HasMaxLength(10);

            //    entity.Property(e => e.VehicleUserCode3).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode4).HasMaxLength(8);

            //    entity.Property(e => e.VehicleUserCode5).HasMaxLength(8);

            //    entity.Property(e => e.Vin)
            //        .HasColumnName("VIN")
            //        .HasMaxLength(17);
            //});

            //modelBuilder.Entity<WinC6importClasses>(entity =>
            //{
            //    entity.ToTable("WinC6ImportClasses");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<WinC6importEmployees>(entity =>
            //{
            //    entity.ToTable("WinC6ImportEmployees");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<WinC6importVehicles>(entity =>
            //{
            //    entity.ToTable("WinC6ImportVehicles");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Issued).HasColumnType("datetime");

            //    entity.Property(e => e.LastDate).HasColumnType("datetime");

            //    entity.Property(e => e.LastOdometer).HasColumnType("datetime");

            //    entity.Property(e => e.LastUpdated).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<WinC6productXref>(entity =>
            //{
            //    entity.ToTable("WinC6ProductXref");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.WinC6productCode).HasColumnName("WinC6ProductCode");
            //});

            //modelBuilder.Entity<WinC6transactionLog>(entity =>
            //{
            //    entity.ToTable("WinC6TransactionLog");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            //});

            //modelBuilder.Entity<YtdProductTotals>(entity =>
            //{
            //    entity.ToTable("YTD_Product_Totals");

            //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.CustomerNumber).HasMaxLength(5);

            //    entity.Property(e => e.Month)
            //        .HasColumnName("_Month")
            //        .HasMaxLength(2);

            //    entity.Property(e => e.Product).HasMaxLength(2);

            //    entity.Property(e => e.RowVersion)
            //        .IsRequired()
            //        .IsRowVersion();

            //    entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            //    entity.Property(e => e.Year)
            //        .HasColumnName("_Year")
            //        .HasMaxLength(4);
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}