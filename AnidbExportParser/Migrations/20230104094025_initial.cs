using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnidbExportParser.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "anime",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    NameKanji = table.Column<string>(type: "TEXT", nullable: true),
                    NameEnglish = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<string>(type: "TEXT", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: true),
                    AnimeDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Update = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Rating = table.Column<decimal>(type: "TEXT", nullable: true),
                    Votes = table.Column<int>(type: "INTEGER", nullable: false),
                    TempRating = table.Column<decimal>(type: "TEXT", nullable: true),
                    TempVotes = table.Column<int>(type: "INTEGER", nullable: false),
                    ReviewRating = table.Column<decimal>(type: "TEXT", nullable: true),
                    Reviews = table.Column<int>(type: "INTEGER", nullable: false),
                    MyVote = table.Column<int>(type: "INTEGER", nullable: true),
                    MyVoteDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MyTempVote = table.Column<string>(type: "TEXT", nullable: true),
                    MyTempVoteDate = table.Column<string>(type: "TEXT", nullable: true),
                    TypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeName = table.Column<string>(type: "TEXT", nullable: false),
                    NFOID = table.Column<int>(type: "INTEGER", nullable: false),
                    NFOID2 = table.Column<string>(type: "TEXT", nullable: true),
                    NFOURL = table.Column<string>(type: "TEXT", nullable: true),
                    NFOURLName = table.Column<string>(type: "TEXT", nullable: true),
                    ANNID = table.Column<int>(type: "INTEGER", nullable: false),
                    ANNURL = table.Column<string>(type: "TEXT", nullable: true),
                    AllCinemaID = table.Column<int>(type: "INTEGER", nullable: false),
                    AllCinemaURL = table.Column<string>(type: "TEXT", nullable: true),
                    AnimePlanetURL = table.Column<string>(type: "TEXT", nullable: true),
                    Eps = table.Column<int>(type: "INTEGER", nullable: false),
                    EpsSpecial = table.Column<int>(type: "INTEGER", nullable: false),
                    EpsTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    MyEps = table.Column<int>(type: "INTEGER", nullable: false),
                    MyEpsSpecial = table.Column<int>(type: "INTEGER", nullable: false),
                    MyEpsTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    WatchedEps = table.Column<int>(type: "INTEGER", nullable: false),
                    WatchedSpecial = table.Column<int>(type: "INTEGER", nullable: false),
                    WatchedTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    UnWatchedEps = table.Column<int>(type: "INTEGER", nullable: false),
                    UnWatchedSpecial = table.Column<int>(type: "INTEGER", nullable: false),
                    UnWatchedTotal = table.Column<int>(type: "INTEGER", nullable: false),
                    ByteCount = table.Column<string>(type: "TEXT", nullable: true),
                    MyWishlistType = table.Column<string>(type: "TEXT", nullable: true),
                    MyWishlistTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    MyWishlistPriority = table.Column<string>(type: "TEXT", nullable: true),
                    MyWishlistPriorityName = table.Column<string>(type: "TEXT", nullable: true),
                    MyWishlistComment = table.Column<string>(type: "TEXT", nullable: true),
                    Hentai = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anime", x => x.AnimeID);
                });

            migrationBuilder.CreateTable(
                name: "anime_category",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryParentID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryHentai = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryWeight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anime_category", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "anime_group",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    GID = table.Column<int>(type: "INTEGER", nullable: false),
                    AGID = table.Column<int>(type: "INTEGER", nullable: false),
                    GName = table.Column<string>(type: "TEXT", nullable: false),
                    GShortName = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    EpRange = table.Column<string>(type: "TEXT", nullable: false),
                    LastEp = table.Column<int>(type: "INTEGER", nullable: false),
                    EpCount = table.Column<int>(type: "INTEGER", nullable: false),
                    SpecialCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Update = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Rating = table.Column<decimal>(type: "TEXT", nullable: true),
                    Votes = table.Column<int>(type: "INTEGER", nullable: false),
                    MyVote = table.Column<decimal>(type: "TEXT", nullable: true),
                    MyVoteDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Comments = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anime_group", x => new { x.AnimeID, x.GID });
                });

            migrationBuilder.CreateTable(
                name: "award",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    AwardID = table.Column<int>(type: "INTEGER", nullable: false),
                    AwardName = table.Column<string>(type: "TEXT", nullable: false),
                    AwardType = table.Column<int>(type: "INTEGER", nullable: false),
                    AwardURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_award", x => new { x.AnimeID, x.AwardID });
                });

            migrationBuilder.CreateTable(
                name: "award_type",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    AwardTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    AwardTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    AwardTypeImage = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_award_type", x => new { x.AnimeID, x.AwardTypeID });
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryParentID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryHentai = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "file_episode",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FID = table.Column<int>(type: "INTEGER", nullable: false),
                    EpID = table.Column<int>(type: "INTEGER", nullable: false),
                    StartPercent = table.Column<int>(type: "INTEGER", nullable: false),
                    EndPercent = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_episode", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "file_file",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FID1 = table.Column<int>(type: "INTEGER", nullable: false),
                    FID2 = table.Column<int>(type: "INTEGER", nullable: false),
                    RelationType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_file", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "tag",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    TagID = table.Column<int>(type: "INTEGER", nullable: false),
                    TagName = table.Column<string>(type: "TEXT", nullable: false),
                    TagDate = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tag", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "user_info",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    ExportDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MyAnimeCount = table.Column<int>(type: "INTEGER", nullable: false),
                    MyEpisodeCount = table.Column<int>(type: "INTEGER", nullable: false),
                    MyFileCount = table.Column<int>(type: "INTEGER", nullable: false),
                    MyByteCount = table.Column<string>(type: "TEXT", nullable: false),
                    MyAnimesAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    MyEpisodesAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    MyFilesAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    MyGroupsAdded = table.Column<int>(type: "INTEGER", nullable: false),
                    MyLameFiles = table.Column<string>(type: "TEXT", nullable: false),
                    MyLameFilesPercent = table.Column<string>(type: "TEXT", nullable: false),
                    MyIndependencePercent = table.Column<int>(type: "INTEGER", nullable: false),
                    MyLeechPercent = table.Column<int>(type: "INTEGER", nullable: false),
                    MyReviews = table.Column<int>(type: "INTEGER", nullable: false),
                    MyVotes = table.Column<int>(type: "INTEGER", nullable: false),
                    MyTotalViewedPercent = table.Column<int>(type: "INTEGER", nullable: false),
                    MyTotalOwnedPercent = table.Column<int>(type: "INTEGER", nullable: false),
                    MyOwnViewedPercent = table.Column<int>(type: "INTEGER", nullable: false),
                    MyViewedEpisodeCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AniDBURL = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_info", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyID = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyShortName = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyOtherName = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyURL = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyPicURL = table.Column<string>(type: "TEXT", nullable: true),
                    CompanyApTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    CompanyApTypeName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_company_anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "anime",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "episode",
                columns: table => new
                {
                    EpID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    EpNo = table.Column<string>(type: "TEXT", nullable: false),
                    EpName = table.Column<string>(type: "TEXT", nullable: false),
                    EpNameRomaji = table.Column<string>(type: "TEXT", nullable: true),
                    EpNameKanji = table.Column<string>(type: "TEXT", nullable: true),
                    EpLength = table.Column<int>(type: "INTEGER", nullable: false),
                    EpAired = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EpDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EpUpdate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EpOther = table.Column<string>(type: "TEXT", nullable: true),
                    EpState = table.Column<int>(type: "INTEGER", nullable: true),
                    EpStateSpecial = table.Column<int>(type: "INTEGER", nullable: true),
                    EpStateRecap = table.Column<int>(type: "INTEGER", nullable: true),
                    EpStateOp = table.Column<int>(type: "INTEGER", nullable: true),
                    EpStateEnd = table.Column<int>(type: "INTEGER", nullable: true),
                    EpRating = table.Column<decimal>(type: "TEXT", nullable: true),
                    EpVotes = table.Column<int>(type: "INTEGER", nullable: true),
                    EpMyVote = table.Column<decimal>(type: "TEXT", nullable: true),
                    EpMyVoteDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MyEpWatched = table.Column<int>(type: "INTEGER", nullable: true),
                    MyEpState = table.Column<int>(type: "INTEGER", nullable: true),
                    MyEpStateString = table.Column<string>(type: "TEXT", nullable: true),
                    MyEpStateIcon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_episode", x => x.EpID);
                    table.ForeignKey(
                        name: "FK_episode_anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "anime",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "title",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    TitleTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    TitleTypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_title", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_title_anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "anime",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "episode_title",
                columns: table => new
                {
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    EpID = table.Column<int>(type: "INTEGER", nullable: false),
                    LanguageID = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    LanguageName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_episode_title", x => new { x.AnimeID, x.EpID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_episode_title_episode_EpID",
                        column: x => x.EpID,
                        principalTable: "episode",
                        principalColumn: "EpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "file",
                columns: table => new
                {
                    EpID = table.Column<int>(type: "INTEGER", nullable: false),
                    FID = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimeID = table.Column<int>(type: "INTEGER", nullable: false),
                    Size = table.Column<long>(type: "INTEGER", nullable: false),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    Generic = table.Column<int>(type: "INTEGER", nullable: false),
                    CRC = table.Column<string>(type: "TEXT", nullable: true),
                    MD5 = table.Column<string>(type: "TEXT", nullable: true),
                    SHA1 = table.Column<string>(type: "TEXT", nullable: true),
                    TTH = table.Column<string>(type: "TEXT", nullable: true),
                    Ed2kName = table.Column<string>(type: "TEXT", nullable: true),
                    Ed2kHash = table.Column<string>(type: "TEXT", nullable: true),
                    Ed2kLink = table.Column<string>(type: "TEXT", nullable: true),
                    GID = table.Column<int>(type: "INTEGER", nullable: false),
                    GName = table.Column<string>(type: "TEXT", nullable: true),
                    GShortName = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    QualityID = table.Column<int>(type: "INTEGER", nullable: false),
                    QualityName = table.Column<string>(type: "TEXT", nullable: false),
                    ResName = table.Column<string>(type: "TEXT", nullable: false),
                    VCount = table.Column<int>(type: "INTEGER", nullable: false),
                    VAspectRatio = table.Column<int>(type: "INTEGER", nullable: false),
                    VAspectRatioName = table.Column<string>(type: "TEXT", nullable: false),
                    VFPS = table.Column<int>(type: "INTEGER", nullable: false),
                    VFlags = table.Column<int>(type: "INTEGER", nullable: false),
                    VBitRate = table.Column<int>(type: "INTEGER", nullable: false),
                    VCodecID = table.Column<int>(type: "INTEGER", nullable: false),
                    VCodecName = table.Column<string>(type: "TEXT", nullable: true),
                    ACount = table.Column<int>(type: "INTEGER", nullable: false),
                    ABitRate = table.Column<int>(type: "INTEGER", nullable: false),
                    ACodecID = table.Column<int>(type: "INTEGER", nullable: false),
                    ACodecName = table.Column<string>(type: "TEXT", nullable: true),
                    AChanType = table.Column<int>(type: "INTEGER", nullable: false),
                    AChanTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    ALangID = table.Column<int>(type: "INTEGER", nullable: false),
                    ALangName = table.Column<string>(type: "TEXT", nullable: true),
                    AType = table.Column<int>(type: "INTEGER", nullable: false),
                    ATypeName = table.Column<string>(type: "TEXT", nullable: true),
                    ABitRate2 = table.Column<int>(type: "INTEGER", nullable: false),
                    ACodecID2 = table.Column<int>(type: "INTEGER", nullable: false),
                    ACodecName2 = table.Column<string>(type: "TEXT", nullable: true),
                    AChanType2 = table.Column<int>(type: "INTEGER", nullable: false),
                    AChanTypeName2 = table.Column<string>(type: "TEXT", nullable: true),
                    ALangID2 = table.Column<int>(type: "INTEGER", nullable: false),
                    ALangName2 = table.Column<string>(type: "TEXT", nullable: true),
                    AType2 = table.Column<int>(type: "INTEGER", nullable: false),
                    ATypeName2 = table.Column<string>(type: "TEXT", nullable: true),
                    SubCount = table.Column<int>(type: "INTEGER", nullable: false),
                    SubID = table.Column<int>(type: "INTEGER", nullable: false),
                    SubName = table.Column<string>(type: "TEXT", nullable: true),
                    SubFlags = table.Column<int>(type: "INTEGER", nullable: false),
                    SubType = table.Column<int>(type: "INTEGER", nullable: false),
                    SubTypeName = table.Column<string>(type: "TEXT", nullable: true),
                    SubID2 = table.Column<int>(type: "INTEGER", nullable: false),
                    SubName2 = table.Column<string>(type: "TEXT", nullable: true),
                    SubFlags2 = table.Column<int>(type: "INTEGER", nullable: false),
                    SubType2 = table.Column<int>(type: "INTEGER", nullable: false),
                    SubTypeName2 = table.Column<string>(type: "TEXT", nullable: true),
                    TypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeName = table.Column<string>(type: "TEXT", nullable: false),
                    Other = table.Column<string>(type: "TEXT", nullable: true),
                    HasComment = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Update = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Storage = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    ListDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ViewDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: false),
                    StateCRCOK = table.Column<int>(type: "INTEGER", nullable: false),
                    StateCRCFailed = table.Column<int>(type: "INTEGER", nullable: false),
                    StateCRCUnverified = table.Column<int>(type: "INTEGER", nullable: false),
                    VersionName = table.Column<string>(type: "TEXT", nullable: false),
                    MyWatched = table.Column<int>(type: "INTEGER", nullable: false),
                    MyState = table.Column<int>(type: "INTEGER", nullable: false),
                    MyStateString = table.Column<string>(type: "TEXT", nullable: false),
                    MyStateIcon = table.Column<string>(type: "TEXT", nullable: false),
                    MyFileState = table.Column<int>(type: "INTEGER", nullable: false),
                    MyFileStateString = table.Column<string>(type: "TEXT", nullable: true),
                    MyFileStateIcon = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file", x => new { x.FID, x.EpID });
                    table.ForeignKey(
                        name: "FK_file_anime_AnimeID",
                        column: x => x.AnimeID,
                        principalTable: "anime",
                        principalColumn: "AnimeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_file_episode_EpID",
                        column: x => x.EpID,
                        principalTable: "episode",
                        principalColumn: "EpID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_anime_category_AnimeID_CategoryID",
                table: "anime_category",
                columns: new[] { "AnimeID", "CategoryID" });

            migrationBuilder.CreateIndex(
                name: "IX_company_AnimeID",
                table: "company",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_episode_AnimeID",
                table: "episode",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_episode_title_EpID",
                table: "episode_title",
                column: "EpID");

            migrationBuilder.CreateIndex(
                name: "IX_file_AnimeID",
                table: "file",
                column: "AnimeID");

            migrationBuilder.CreateIndex(
                name: "IX_file_EpID",
                table: "file",
                column: "EpID");

            migrationBuilder.CreateIndex(
                name: "IX_file_episode_FID_EpID",
                table: "file_episode",
                columns: new[] { "FID", "EpID" });

            migrationBuilder.CreateIndex(
                name: "IX_file_file_FID1_FID2",
                table: "file_file",
                columns: new[] { "FID1", "FID2" });

            migrationBuilder.CreateIndex(
                name: "IX_tag_TagID_AnimeID",
                table: "tag",
                columns: new[] { "TagID", "AnimeID" });

            migrationBuilder.CreateIndex(
                name: "IX_title_AnimeID",
                table: "title",
                column: "AnimeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anime_category");

            migrationBuilder.DropTable(
                name: "anime_group");

            migrationBuilder.DropTable(
                name: "award");

            migrationBuilder.DropTable(
                name: "award_type");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "company");

            migrationBuilder.DropTable(
                name: "episode_title");

            migrationBuilder.DropTable(
                name: "file");

            migrationBuilder.DropTable(
                name: "file_episode");

            migrationBuilder.DropTable(
                name: "file_file");

            migrationBuilder.DropTable(
                name: "tag");

            migrationBuilder.DropTable(
                name: "title");

            migrationBuilder.DropTable(
                name: "user_info");

            migrationBuilder.DropTable(
                name: "episode");

            migrationBuilder.DropTable(
                name: "anime");
        }
    }
}
