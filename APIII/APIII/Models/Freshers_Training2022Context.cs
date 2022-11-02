using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace APIII.Models
{
    public partial class Freshers_Training2022Context : DbContext
    {
        public Freshers_Training2022Context()
        {
        }

        public Freshers_Training2022Context(DbContextOptions<Freshers_Training2022Context> options)
            : base(options)
        {
        }

        public virtual DbSet<RrIkpBusinessUnit> RrIkpBusinessUnit { get; set; }
        public virtual DbSet<RrIkpDivision> RrIkpDivision { get; set; }
        public virtual DbSet<RrIkpInterestLevel> RrIkpInterestLevel { get; set; }
        public virtual DbSet<RrIkpMarket> RrIkpMarket { get; set; }
        public virtual DbSet<RrIkpProjectType> RrIkpProjectType { get; set; }
        public virtual DbSet<RrIkpRegion> RrIkpRegion { get; set; }
        public virtual DbSet<RrIkpSalesJobOppType> RrIkpSalesJobOppType { get; set; }
        public virtual DbSet<RrIkpSalesOppPhase> RrIkpSalesOppPhase { get; set; }
        public virtual DbSet<RrIkpSalesOppPricing> RrIkpSalesOppPricing { get; set; }
        public virtual DbSet<RrIkpSalesOppStatus> RrIkpSalesOppStatus { get; set; }
        public virtual DbSet<RrIkpSalesOppStatusReason> RrIkpSalesOppStatusReason { get; set; }
        public virtual DbSet<RrIkpSalesOpportunity> RrIkpSalesOpportunity { get; set; }
        public virtual DbSet<RrIkpScopeOfWork> RrIkpScopeOfWork { get; set; }
        public virtual DbSet<RrSalesOpp> RrSalesOpp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=192.168.1.230;user=trainee2022;password=trainee@2022;database=Freshers_Training2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RrIkpBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.Buname)
                    .HasName("PK__RR_ikp_B__52D1CFF3DF499067");

                entity.ToTable("RR_ikp_Business_Unit");

                entity.Property(e => e.Buname)
                    .HasColumnName("buname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrIkpDivision>(entity =>
            {
                entity.HasKey(e => e.SalesOpportunityDivname)
                    .HasName("PK__RR_ikp_D__1161FFA503E75754");

                entity.ToTable("RR_ikp_Division");

                entity.Property(e => e.SalesOpportunityDivname)
                    .HasColumnName("sales_opportunity_DIVName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DivId)
                    .HasColumnName("div_id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrIkpInterestLevel>(entity =>
            {
                entity.HasKey(e => e.Intlevel)
                    .HasName("PK__RR_ikp_I__750E09CEE5A2D666");

                entity.ToTable("RR_ikp_Interest_Level");

                entity.Property(e => e.Intlevel)
                    .HasColumnName("intlevel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrIkpMarket>(entity =>
            {
                entity.HasKey(e => e.SoMarketId)
                    .HasName("PK__RR_ikp_M__B5A489D24895D7B0");

                entity.ToTable("RR_ikp_Market");

                entity.Property(e => e.SoMarketId).HasColumnName("so_market_id");

                entity.Property(e => e.SoRegionId).HasColumnName("so_region_id");

                entity.HasOne(d => d.SoRegion)
                    .WithMany(p => p.RrIkpMarket)
                    .HasForeignKey(d => d.SoRegionId)
                    .HasConstraintName("FK__RR_ikp_Ma__so_re__6715F92A");
            });

            modelBuilder.Entity<RrIkpProjectType>(entity =>
            {
                entity.HasKey(e => e.PrjtType)
                    .HasName("PK__RR_ikp_P__391F6E27251E76BE");

                entity.ToTable("RR_ikp_Project_Type");

                entity.Property(e => e.PrjtType)
                    .HasColumnName("prjt_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesOpportunityDivname)
                    .HasColumnName("sales_opportunity_DIVName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.SalesOpportunityDivnameNavigation)
                    .WithMany(p => p.RrIkpProjectType)
                    .HasForeignKey(d => d.SalesOpportunityDivname)
                    .HasConstraintName("FK__RR_ikp_Pr__sales__46A92998");
            });

            modelBuilder.Entity<RrIkpRegion>(entity =>
            {
                entity.HasKey(e => e.SoRegionId)
                    .HasName("PK__RR_ikp_R__271F565FF41B8C3C");

                entity.ToTable("RR_ikp_Region");

                entity.Property(e => e.SoRegionId).HasColumnName("so_region_id");

                entity.Property(e => e.Area)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RrIkpSalesJobOppType>(entity =>
            {
                entity.HasKey(e => e.JobType)
                    .HasName("PK__RR_ikp_S__85D2665A7496C38A");

                entity.ToTable("RR_ikp_Sales_Job_Opp_Type");

                entity.Property(e => e.JobType)
                    .HasColumnName("job_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SalesOpportunityDivname)
                    .HasColumnName("sales_opportunity_DIVName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.SalesOpportunityDivnameNavigation)
                    .WithMany(p => p.RrIkpSalesJobOppType)
                    .HasForeignKey(d => d.SalesOpportunityDivname)
                    .HasConstraintName("FK__RR_ikp_Sa__sales__4E4A4B60");
            });

            modelBuilder.Entity<RrIkpSalesOppPhase>(entity =>
            {
                entity.HasKey(e => e.Phase)
                    .HasName("PK__RR_ikp_S__C60A98C4BEA5DABD");

                entity.ToTable("RR_ikp_Sales_Opp_Phase");

                entity.HasIndex(e => e.PhsPrc)
                    .HasName("UQ__RR_ikp_S__FEEABB55D45C587A")
                    .IsUnique();

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PhsPrc)
                    .IsRequired()
                    .HasColumnName("phs_prc");
            });

            modelBuilder.Entity<RrIkpSalesOppPricing>(entity =>
            {
                entity.HasKey(e => e.PriDollarAmt)
                    .HasName("PK__RR_ikp_S__15396838E02C1B31");

                entity.ToTable("RR_ikp_Sales_Opp_Pricing");

                entity.Property(e => e.PriDollarAmt)
                    .HasColumnName("pri_dollar_amt")
                    .HasColumnType("money");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.JobType)
                    .HasColumnName("job_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrjtType)
                    .HasColumnName("prjt_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobTypeNavigation)
                    .WithMany(p => p.RrIkpSalesOppPricing)
                    .HasForeignKey(d => d.JobType)
                    .HasConstraintName("FK__RR_ikp_Sa__job_t__615D1FD4");

                entity.HasOne(d => d.PrjtTypeNavigation)
                    .WithMany(p => p.RrIkpSalesOppPricing)
                    .HasForeignKey(d => d.PrjtType)
                    .HasConstraintName("FK__RR_ikp_Sa__prjt___6068FB9B");
            });

            modelBuilder.Entity<RrIkpSalesOppStatus>(entity =>
            {
                entity.HasKey(e => e.SosStatus)
                    .HasName("PK__RR_ikp_S__7E5C6C6E150EC2DC");

                entity.ToTable("RR_ikp_Sales_Opp_Status");

                entity.Property(e => e.SosStatus)
                    .HasColumnName("sos_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrIkpSalesOppStatusReason>(entity =>
            {
                entity.HasKey(e => e.SosReason)
                    .HasName("PK__RR_ikp_S__02D5D3D0257E5487");

                entity.ToTable("RR_ikp_Sales_Opp_Status_Reason");

                entity.Property(e => e.SosReason)
                    .HasColumnName("sos_reason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SosStatus)
                    .HasColumnName("sos_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.SosStatusNavigation)
                    .WithMany(p => p.RrIkpSalesOppStatusReason)
                    .HasForeignKey(d => d.SosStatus)
                    .HasConstraintName("FK__RR_ikp_Sa__sos_s__2824A278");
            });

            modelBuilder.Entity<RrIkpSalesOpportunity>(entity =>
            {
                entity.HasKey(e => e.SoNumSites)
                    .HasName("PK__RR_ikp_S__57CEE0A1F10AF38E");

                entity.ToTable("RR_ikp_Sales_Opportunity");

                entity.Property(e => e.SoNumSites)
                    .HasColumnName("so_num_sites")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrIkpScopeOfWork>(entity =>
            {
                entity.HasKey(e => e.SowName)
                    .HasName("PK__RR_ikp_S__EB7F74AAE8E135FC");

                entity.ToTable("RR_ikp_Scope_of_Work");

                entity.Property(e => e.SowName)
                    .HasColumnName("sow_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RrSalesOpp>(entity =>
            {
                entity.HasKey(e => e.SaleId)
                    .HasName("PK__RR_Sales__E1EB00B20F11D604");

                entity.ToTable("RR_Sales_Opp");

                entity.Property(e => e.SaleId)
                    .HasColumnName("sale_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Buname)
                    .HasColumnName("buname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Intlevel)
                    .HasColumnName("intlevel")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .HasColumnName("job_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasColumnName("phase")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhsPrc).HasColumnName("phs_prc");

                entity.Property(e => e.PriDollarAmt)
                    .HasColumnName("pri_dollar_amt")
                    .HasColumnType("money");

                entity.Property(e => e.PrjtType)
                    .HasColumnName("prjt_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunityActiveSalesEmployee)
                    .HasColumnName("sales_opportunity_active_sales_employee")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunityBusname)
                    .HasColumnName("sales_opportunity_BUSName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunityDivname)
                    .HasColumnName("sales_opportunity_DIVName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunitySalesEmployee)
                    .HasColumnName("sales_opportunity_sales_employee")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunitySloEstWorkDate)
                    .HasColumnName("sales_opportunity_slo_est_work_date")
                    .HasColumnType("date");

                entity.Property(e => e.SalesOpportunitySoClosingDate)
                    .HasColumnName("sales_opportunity_so_closing_date")
                    .HasColumnType("date");

                entity.Property(e => e.SalesOpportunitySoEndDate)
                    .HasColumnName("sales_opportunity_so_end_date")
                    .HasColumnType("date");

                entity.Property(e => e.SalesOpportunitySoPhaseStartDate)
                    .HasColumnName("sales_opportunity_so_phase_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.SalesOpportunitySoStartDate)
                    .HasColumnName("sales_opportunity_so_start_date")
                    .HasColumnType("date");

                entity.Property(e => e.SalesOpportunitySoname)
                    .HasColumnName("sales_opportunity_SOName")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOpportunityWeightedAmount)
                    .HasColumnName("sales_opportunity_weighted_amount")
                    .HasColumnType("money");

                entity.Property(e => e.SalesOpprotunityManager)
                    .HasColumnName("sales_opprotunity_manager")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SoMarketId).HasColumnName("so_market_id");

                entity.Property(e => e.SoNumSites).HasColumnName("so_num_sites");

                entity.Property(e => e.SoRegionId).HasColumnName("so_region_id");

                entity.Property(e => e.SosReason)
                    .HasColumnName("sos_reason")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SosStatus)
                    .HasColumnName("sos_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SowName)
                    .HasColumnName("sow_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UspGetSalesOpportunityData)
                    .HasColumnName("usp_get_sales_opportunity_data")
                    .HasColumnType("money");

                entity.HasOne(d => d.BunameNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.Buname)
                    .HasConstraintName("FK__RR_Sales___bunam__69F265D5");

                entity.HasOne(d => d.IntlevelNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.Intlevel)
                    .HasConstraintName("FK__RR_Sales___intle__746FF448");

                entity.HasOne(d => d.JobTypeNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.JobType)
                    .HasConstraintName("FK__RR_Sales___job_t__6EB71AF2");

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.RrSalesOppPhaseNavigation)
                    .HasForeignKey(d => d.Phase)
                    .HasConstraintName("FK__RR_Sales___phase__7287ABD6");

                entity.HasOne(d => d.PhsPrcNavigation)
                    .WithMany(p => p.RrSalesOppPhsPrcNavigation)
                    .HasPrincipalKey(p => p.PhsPrc)
                    .HasForeignKey(d => d.PhsPrc)
                    .HasConstraintName("FK__RR_Sales___phs_p__737BD00F");

                entity.HasOne(d => d.PriDollarAmtNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.PriDollarAmt)
                    .HasConstraintName("FK__RR_Sales___pri_d__709F6364");

                entity.HasOne(d => d.PrjtTypeNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.PrjtType)
                    .HasConstraintName("FK__RR_Sales___prjt___6DC2F6B9");

                entity.HasOne(d => d.SalesOpportunityDivnameNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SalesOpportunityDivname)
                    .HasConstraintName("FK__RR_Sales___sales__6BDAAE47");

                entity.HasOne(d => d.SoMarket)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SoMarketId)
                    .HasConstraintName("FK__RR_Sales___so_ma__6CCED280");

                entity.HasOne(d => d.SoNumSitesNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SoNumSites)
                    .HasConstraintName("FK__RR_Sales___so_nu__7193879D");

                entity.HasOne(d => d.SoRegion)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SoRegionId)
                    .HasConstraintName("FK__RR_Sales___so_re__6AE68A0E");

                entity.HasOne(d => d.SosReasonNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SosReason)
                    .HasConstraintName("FK__RR_Sales___sos_r__76583CBA");

                entity.HasOne(d => d.SosStatusNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SosStatus)
                    .HasConstraintName("FK__RR_Sales___sos_s__75641881");

                entity.HasOne(d => d.SowNameNavigation)
                    .WithMany(p => p.RrSalesOpp)
                    .HasForeignKey(d => d.SowName)
                    .HasConstraintName("FK__RR_Sales___sow_n__6FAB3F2B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
