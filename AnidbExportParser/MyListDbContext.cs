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
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace AnidbExportParser
{
    public class MyListDbContext : DbContext
    {
        public DbSet<Anime> Anime { get; set; }
        public DbSet<AnimeCategory> AnimeCategory { get; set; }
        public DbSet<Award> Award { get; set; }
        public DbSet<AwardType> AwardType { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<EpisodeTitle> EpisodeTitle { get; set; }
        public DbSet<Model.File> File { get; set; }
        public DbSet<AnimeGroup> AnimeGroup { get; set; }
        public DbSet<Title> Title { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }

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

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Anime>()
                .ToTable("anime")
                .HasKey(c => c.AnimeID);

            builder.Entity<AnimeCategory>()
                .ToTable("anime_category")
                .HasKey(c => c.EntityId);
            builder.Entity<AnimeCategory>()
                .HasIndex(c => new { c.AnimeID, c.CategoryID });

            builder.Entity<Award>()
                .ToTable("award")
                .HasKey(c => new { c.AnimeID, c.AwardID });

            builder.Entity<AwardType>()
                .ToTable("award_type")
                .HasKey(c => new { c.AnimeID, c.AwardTypeID });

            builder.Entity<Category>()
                .ToTable("category")
                .HasKey(c => c.CategoryID);

            builder.Entity<Company>()
                .ToTable("company")
                .HasKey(c => c.EntityId);

            builder.Entity<Episode>()
                .ToTable("episode")
                .HasKey(c => c.EpID);

            builder.Entity<EpisodeTitle>()
                .ToTable("episode_title")
                .HasKey(c => new { c.AnimeID, c.EpID, c.LanguageID });

            builder.Entity<Model.File>()
                .ToTable("file")
                .HasKey(c => new { c.FID, c.EpID });

            builder.Entity<AnimeGroup>()
                .ToTable("aniime_group")
                .HasKey(c => new { c.AnimeID, c.GID });

            builder.Entity<Title>()
                .ToTable("title")
                .HasKey(c => c.EntityId);

            builder.Entity<UserInfo>()
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
