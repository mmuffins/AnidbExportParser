﻿// <auto-generated />
using System;
using AnidbExportParser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnidbExportParser.Migrations
{
    [DbContext(typeof(MyListDbContext))]
    [Migration("20230104094025_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("AnidbExportParser.Model.Anime", b =>
                {
                    b.Property<int>("AnimeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ANNID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ANNURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("AllCinemaID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AllCinemaURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("AnimeDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("AnimePlanetURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("ByteCount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Eps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpsSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpsTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hentai")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyEps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyEpsSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyEpsTotal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyTempVote")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyTempVoteDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MyVote")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("MyVoteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyWishlistComment")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyWishlistPriority")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyWishlistPriorityName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyWishlistType")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyWishlistTypeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("NFOID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NFOID2")
                        .HasColumnType("TEXT");

                    b.Property<string>("NFOURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("NFOURLName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NameEnglish")
                        .HasColumnType("TEXT");

                    b.Property<string>("NameKanji")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ReviewRating")
                        .HasColumnType("TEXT");

                    b.Property<int>("Reviews")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TempRating")
                        .HasColumnType("TEXT");

                    b.Property<int>("TempVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("URL")
                        .HasColumnType("TEXT");

                    b.Property<int>("UnWatchedEps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnWatchedSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UnWatchedTotal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Update")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WatchedEps")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WatchedSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WatchedTotal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeID");

                    b.ToTable("anime", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.AnimeCategory", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryHentai")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryParentID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryWeight")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntityId");

                    b.HasIndex("AnimeID", "CategoryID");

                    b.ToTable("anime_category", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.AnimeGroup", b =>
                {
                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AGID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Comments")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EpRange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GShortName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LastEp")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("MyVote")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("MyVoteDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<int>("SpecialCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("TEXT");

                    b.Property<int>("Votes")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimeID", "GID");

                    b.ToTable("anime_group", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Award", b =>
                {
                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwardID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AwardName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AwardType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AwardURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeID", "AwardID");

                    b.ToTable("award", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.AwardType", b =>
                {
                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AwardTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AwardTypeImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AwardTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeID", "AwardTypeID");

                    b.ToTable("award_type", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryHentai")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryParentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryID");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Company", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyApTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyApTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CompanyID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyOtherName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyPicURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyShortName")
                        .HasColumnType("TEXT");

                    b.Property<int>("CompanyTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyTypeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyURL")
                        .HasColumnType("TEXT");

                    b.HasKey("EntityId");

                    b.HasIndex("AnimeID");

                    b.ToTable("company", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Episode", b =>
                {
                    b.Property<int>("EpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EpAired")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EpDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("EpLength")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("EpMyVote")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("EpMyVoteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("EpName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EpNameKanji")
                        .HasColumnType("TEXT");

                    b.Property<string>("EpNameRomaji")
                        .HasColumnType("TEXT");

                    b.Property<string>("EpNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EpOther")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("EpRating")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EpState")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EpStateEnd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EpStateOp")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EpStateRecap")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EpStateSpecial")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("EpUpdate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EpVotes")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MyEpState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyEpStateIcon")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyEpStateString")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MyEpWatched")
                        .HasColumnType("INTEGER");

                    b.HasKey("EpID");

                    b.HasIndex("AnimeID");

                    b.ToTable("episode", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.EpisodeTitle", b =>
                {
                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimeID", "EpID", "LanguageID");

                    b.HasIndex("EpID");

                    b.ToTable("episode_title", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.File", b =>
                {
                    b.Property<int>("FID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ABitRate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ABitRate2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AChanType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AChanType2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AChanTypeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("AChanTypeName2")
                        .HasColumnType("TEXT");

                    b.Property<int>("ACodecID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ACodecID2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ACodecName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ACodecName2")
                        .HasColumnType("TEXT");

                    b.Property<int>("ACount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ALangID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ALangID2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ALangName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ALangName2")
                        .HasColumnType("TEXT");

                    b.Property<int>("AType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AType2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ATypeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ATypeName2")
                        .HasColumnType("TEXT");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CRC")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ed2kHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ed2kLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ed2kName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GShortName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Generic")
                        .HasColumnType("INTEGER");

                    b.Property<int>("HasComment")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ListDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MD5")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyFileState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyFileStateIcon")
                        .HasColumnType("TEXT");

                    b.Property<string>("MyFileStateString")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyState")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyStateIcon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MyStateString")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MyWatched")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Other")
                        .HasColumnType("TEXT");

                    b.Property<int>("QualityID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("QualityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SHA1")
                        .HasColumnType("TEXT");

                    b.Property<long>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateCRCFailed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateCRCOK")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StateCRCUnverified")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Storage")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubFlags")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubFlags2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubID2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubName2")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubType2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubTypeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubTypeName2")
                        .HasColumnType("TEXT");

                    b.Property<string>("TTH")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("TEXT");

                    b.Property<int>("VAspectRatio")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VAspectRatioName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VBitRate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VCodecID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VCodecName")
                        .HasColumnType("TEXT");

                    b.Property<int>("VCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VFPS")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VFlags")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VersionName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ViewDate")
                        .HasColumnType("TEXT");

                    b.HasKey("FID", "EpID");

                    b.HasIndex("AnimeID");

                    b.HasIndex("EpID");

                    b.ToTable("file", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.FileEpisode", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EndPercent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EpID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartPercent")
                        .HasColumnType("INTEGER");

                    b.HasKey("EntityId");

                    b.HasIndex("FID", "EpID");

                    b.ToTable("file_episode", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.FileFile", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FID1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FID2")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RelationType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EntityId");

                    b.HasIndex("FID1", "FID2");

                    b.ToTable("file_file", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Tag", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TagDate")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EntityId");

                    b.HasIndex("TagID", "AnimeID");

                    b.ToTable("tag", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Title", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimeID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LanguageID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TitleTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TitleTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EntityId");

                    b.HasIndex("AnimeID");

                    b.ToTable("title", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.UserInfo", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AniDBURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExportDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("MyAnimeCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyAnimesAdded")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyByteCount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MyEpisodeCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyEpisodesAdded")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyFileCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyFilesAdded")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyGroupsAdded")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyIndependencePercent")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MyLameFiles")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MyLameFilesPercent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MyLeechPercent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyOwnViewedPercent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyReviews")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyTotalOwnedPercent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyTotalViewedPercent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyViewedEpisodeCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MyVotes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("user_info", (string)null);
                });

            modelBuilder.Entity("AnidbExportParser.Model.Company", b =>
                {
                    b.HasOne("AnidbExportParser.Model.Anime", "Anime")
                        .WithMany("Companies")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("AnidbExportParser.Model.Episode", b =>
                {
                    b.HasOne("AnidbExportParser.Model.Anime", "Anime")
                        .WithMany("Episodes")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("AnidbExportParser.Model.EpisodeTitle", b =>
                {
                    b.HasOne("AnidbExportParser.Model.Episode", "Episode")
                        .WithMany("Titles")
                        .HasForeignKey("EpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("AnidbExportParser.Model.File", b =>
                {
                    b.HasOne("AnidbExportParser.Model.Anime", "Anime")
                        .WithMany("Files")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnidbExportParser.Model.Episode", "Episode")
                        .WithMany("Files")
                        .HasForeignKey("EpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("AnidbExportParser.Model.Title", b =>
                {
                    b.HasOne("AnidbExportParser.Model.Anime", "Anime")
                        .WithMany("Titles")
                        .HasForeignKey("AnimeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Anime");
                });

            modelBuilder.Entity("AnidbExportParser.Model.Anime", b =>
                {
                    b.Navigation("Companies");

                    b.Navigation("Episodes");

                    b.Navigation("Files");

                    b.Navigation("Titles");
                });

            modelBuilder.Entity("AnidbExportParser.Model.Episode", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("Titles");
                });
#pragma warning restore 612, 618
        }
    }
}
