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
        public DbSet<AnimeGroup> AnimeGroup { get; set; }
        public DbSet<Award> Award { get; set; }
        public DbSet<AwardType> AwardType { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Episode> Episode { get; set; }
        public DbSet<EpisodeTitle> EpisodeTitle { get; set; }
        public DbSet<Model.File> File { get; set; }
        public DbSet<FileEpisode> FileEpisode { get; set; }
        public DbSet<FileFile> FileFile { get; set; }
        public DbSet<Tag> Tag { get; set; }
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

            builder.Entity<Episode>()
                .HasOne(a => a.Anime)
                .WithMany(e => e.Episodes)
                .HasForeignKey(e => e.AnimeID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<EpisodeTitle>()
                .ToTable("episode_title")
                .HasKey(c => new { c.AnimeID, c.EpID, c.LanguageID });

            builder.Entity<Model.File>()
                .ToTable("file")
                .HasKey(c => new { c.FID, c.EpID });

            builder.Entity<Model.File>()
                .HasOne(a => a.Anime)
                .WithMany(e => e.Files)
                .HasForeignKey(e => e.AnimeID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Model.File>()
                .HasOne(a => a.Episode)
                .WithMany(e => e.Files)
                .HasForeignKey(e => e.EpID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<FileEpisode>()
                .ToTable("file_episode")
                .HasKey(c => c.EntityId);

            builder.Entity<FileEpisode>()
                .HasIndex(c => new { c.FID, c.EpID });

            builder.Entity<FileFile>()
                .ToTable("filefile")
                .HasKey(c => c.EntityId);

            builder.Entity<FileFile>()
                .HasIndex(c => new { c.FID1, c.FID2 });

            builder.Entity<AnimeGroup>()
                .ToTable("anime_group")
                .HasKey(c => new { c.AnimeID, c.GID });

            builder.Entity<Tag>()
                .ToTable("tag")
                .HasKey(c => c.EntityId);
            builder.Entity<Tag>()
                .HasIndex(c => new { c.TagID, c.AnimeID });

            builder.Entity<Title>()
                .ToTable("title")
                .HasKey(c => c.EntityId);

            builder.Entity<UserInfo>()
                .ToTable("user_info")
                .HasKey(c => c.UserID);
        }
    }

}
