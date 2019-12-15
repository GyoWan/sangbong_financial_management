namespace sangbong_financial_management.SFM.Common.Database.EFModel
{
    using sangbong_financial_management.SFM.Common.Database.Entity;
    using System.Data.Entity;

    public partial class SFMDatabaseModel : DbContext
    {
        public SFMDatabaseModel()
            : base("name=SFMDataBaseModel")
        {
        }

        public virtual DbSet<SFM_POSITION> SFM_POSITION { get; set; }
        public virtual DbSet<SFM_USER_INFO> SFM_USER_INFO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SFM_POSITION>()
                .HasOptional(e => e.SFM_POSITION1)
                .WithRequired(e => e.SFM_POSITION2);
        }
    }
}
