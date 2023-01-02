using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using AnidbExportParser.Model;
using Microsoft.EntityFrameworkCore;


namespace AnidbExportParser
{
    public class MyListDbContext : DbContext
    {
        public DbSet<Title> Title { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<user_info> user_info { get; set; }
        //public DbSet<Datasource> Datasource { get; set; }
        //public DbSet<Summary> Summary { get; set; }
        //public DbSet<Tag> Tag { get; set; }
        //public DbSet<TagCategory> TagCategory { get; set; }
        //public DbSet<TagFilter> TagFilter { get; set; }
        //public DbSet<Timeline> Timeline { get; set; }
        //public DbSet<TimelineType> TimelineType { get; set; }

        public MyListDbContext() : base() { }

        public MyListDbContext(MyListDbContextFactory controller)
            : this(controller.ContextOptions) { }

        public MyListDbContext(DbContextOptions options)
            : base(options) { }

        public MyListDbContext(DbContextOptions<MyListDbContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<title>().Property(m => m.UserId)
            //         .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            builder.Entity<Company>()
                .ToTable("company")
                .HasKey(c => c.EntityId);

            //builder.Entity<Company>()
            //    .ToTable("company")
            //    .HasIndex(c => new
            //    {
            //        c.AnimeID,
            //        c.CompanyID,
            //        c.CompanyTypeID
            //    });

            builder.Entity<Title>()
                .ToTable("title")
                .HasKey(c => c.EntityId);



            //builder.Entity<Title>()
            //    .ToTable("title")
            //    .HasKey(c => new {
            //        c.AnimeID,
            //        c.LanguageID,
            //        c.TitleTypeID
            //    });

            builder.Entity<user_info>()
                .ToTable("user_info")
                .HasKey(c => c.UserID);


            

            //builder.Entity<title>()
            //    .HasIndex(c => c.AnimeID)
            //    .IsUnique();

            //builder.Entity<company>()
            //    .HasIndex(c => c.AnimeID)
            //    .IsUnique();

            //builder.Entity<company>()
            //    .HasIndex(c => c.CompanyID)
            //    .IsUnique();

            //builder.Entity<Datasource>()
            //    .HasIndex(d => d.DBLocation)
            //    .IsUnique();

            //builder.Entity<Datasource>()
            //    .HasIndex(d => d.Name)
            //    .IsUnique();

            //builder.Entity<Summary>()
            //    .HasIndex(s => new { s.TimelineId, s.TagId, s.StartDate })
            //    .IsUnique();

            //builder.Entity<Tag>()
            //    .HasIndex(t => t.Name)
            //    .IsUnique();

            //builder.Entity<TagCategory>()
            //    .HasIndex(tc => new { tc.TagId, tc.CategoryId })
            //    .IsUnique();

            //builder.Entity<TagCategory>()
            //    .HasOne(tc => tc.Tag)
            //    .WithMany(t => t.TagCategories)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<TagCategory>()
            //    .HasOne(tc => tc.Category)
            //    .WithMany(t => t.TagCategories)
            //    .OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<TagFilter>()
            //    .HasIndex(tf => new { tf.TagId, tf.GroupName, tf.DisplayName, tf.TimelineTypeId })
            //    .IsUnique();

            //builder.Entity<TagFilter>()
            //    .HasIndex(tf => new { tf.Active });

            //builder.Entity<Timeline>()
            //    .HasIndex(tl => new { tl.ManicTimelineId, tl.TimelineTypeId, tl.DataSourceId })
            //    .IsUnique();

            //builder.Entity<TimelineType>()
            //    .HasIndex(tt => tt.TypeName)
            //    .IsUnique();
        }
    }

}
