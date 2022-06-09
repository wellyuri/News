namespace Shop.DataBase
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDB : DbContext
    {
        public ShopDB()
            : base("name=ShopDB")
        {
        }

        public virtual DbSet<GENRE> GENRE { get; set; }
        public virtual DbSet<LOGIN> LOGIN { get; set; }
        public virtual DbSet<MASTER_USER> MASTER_USER { get; set; }
        public virtual DbSet<COMMENT> COMMENT { get; set; }
        public virtual DbSet<MASTER_CATEGORY> MASTER_CATEGORY { get; set; }
        public virtual DbSet<MASTER_PRODUCT> MASTER_PRODUCT { get; set; }
        public virtual DbSet<USER> USER { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GENRE>()
                .Property(e => e.GENRE_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_USER>()
                .Property(e => e.REGISTER_USER_ID)
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.GENRE_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.CATEGORY_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.PRODUCT_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<COMMENT>()
                .Property(e => e.COMMENT_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_CATEGORY>()
                .Property(e => e.GENRE_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_CATEGORY>()
                .Property(e => e.CATEGORY_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_PRODUCT>()
                .Property(e => e.GENRE_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_PRODUCT>()
                .Property(e => e.CATEGORY_ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MASTER_PRODUCT>()
                .Property(e => e.PRODUCT_ID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
