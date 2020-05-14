namespace template
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<document> document { get; set; }
        public virtual DbSet<tag> tag { get; set; }
        public virtual DbSet<tag_text> tag_text { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<document>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<document>()
                .HasMany(e => e.tag_text)
                .WithMany(e => e.document)
                .Map(m => m.ToTable("connections", "mydb").MapLeftKey("Document_ID").MapRightKey("Tag_Text_ID"));

            modelBuilder.Entity<tag>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tag>()
                .HasMany(e => e.tag_text)
                .WithRequired(e => e.tag)
                .HasForeignKey(e => e.Tag_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tag_text>()
                .Property(e => e.Text)
                .IsUnicode(false);
        }
    }
}
