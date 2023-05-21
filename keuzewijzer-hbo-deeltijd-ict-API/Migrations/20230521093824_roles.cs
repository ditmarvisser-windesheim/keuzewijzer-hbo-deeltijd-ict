using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Student" },
                    { 3, "Studiebegeleider" },
                    { 4, "Moduleverantwoordelijke" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "1331449d-a245-4895-9a8f-41cea12eb761", "admin@example.com", "Arnold", "Min", "Arnold Dirk Min", "AQAAAAEAACcQAAAAEJkAIlAT2IWVGh6lFhNRS37EnRiynNsvBSotnSPRYfoZcRwy+TC1TfMDI3X3vB983w==", "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "831f6988-46e4-4ab0-9b91-158f77e3ce7d", "eugenevanroden@example.com", "Eugene", "Van Roden", "Eugene Van Roden", "AQAAAAEAACcQAAAAEJ2LMi/6Z04aVrIsuBMfTjyI95q6h7uphJyDOFeGwzobKLbsade18CKExEiCnj8G/w==", "eugenevanroden@example.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, null, "5780d19e-b7c9-4bb0-b3d7-a928096bb8ea", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAECM9aW2XiJg0Y3N6+LMj3wt2HupQX8aZRKptHeoARZ+zj8lJC15N2r1Xl0HgwYmoTA==", null, false, null, null, null, false, "sharonapouw@example.com" },
                    { "11", 0, null, "f3014cb6-f4a2-4be7-bb04-56c68c060a8f", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAEJxvMPWoCMAZ2a9KMD0Jq9VCax4dmLuk2u63WLkTCuwfKxeT78q6W33Qfw5lHj/XTQ==", null, false, null, null, null, false, "ashwienabbenhuis@example.com" },
                    { "12", 0, null, "e218a238-30c6-4c49-b5eb-4ab6a9853c90", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAECSjnXc07qPCTemW+MYQ44ypemHPuzP9EhYIdGd1IBH1cAvpa7nK78elVKk5FBWO3w==", null, false, null, null, null, false, "raulverdaasdonk@example.com" },
                    { "13", 0, null, "16e75836-3692-4db9-bc13-998d45f289b0", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEMJwkvP4sb0mzn652x8mqDBLnVIJnwIvUEC0q+O1cYPKTkitsklf97oSs2+/twWGlA==", null, false, null, null, null, false, "majellawessels@example.com" },
                    { "14", 0, null, "d5f64469-c7a0-4cc4-a431-dcb659167666", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAEDeECrKMOfyPqH4AGBXriX+9+NuLgetqNArnXTTBMjVr/dKY4JKG3pI48mMrkcrtPg==", null, false, null, null, null, false, "kwintlogtenberg@example.com" },
                    { "15", 0, null, "9ad76197-452f-417f-87b7-0f115d3440ab", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAEEIfSaPPPd+s8KvBKPlfuj3lOqCPlegWSkR0AtgXA/nt+/h3w138ILvO09Xwl1RD+A==", null, false, null, null, null, false, "mikhaillebbink@example.com" },
                    { "16", 0, null, "06ad62fa-d648-4a9d-a531-2e595df056e1", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEMlgLfKRCTPSYyoQQGHLvTWCq47ArV49d7ZTB16IoD3G/thk9DRiTfJa/i2Y6az8MQ==", null, false, null, null, null, false, "claylier@example.com" },
                    { "17", 0, null, "d532b6ee-f210-438e-afb8-0983e81fb404", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAELj7u/mEOWWTY0DFKam3tbr2GP+6JuS6mtM1D8BzkkggX0mISwz5u/iSLCsQ5/I5yQ==", null, false, null, null, null, false, "rubinavanderhout@example.com" },
                    { "18", 0, null, "fbabccac-af79-4eff-9be4-bf642d831356", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEI+Ut0Te646Xc3EUHFeHEobQzRIj6h61OxRsjwl0IJvnmuNO3qV0+TJJhuEq0mu03g==", null, false, null, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { "19", 0, null, "91382690-fe53-41d2-9773-d3240c4f488c", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAEGyO63/PqAWrV9xiySpYZHtdXSBmyjDPGa1Sn9iU3o+3nDIpi+mq4E673P/pm9xImQ==", null, false, null, null, null, false, "yannikconsten@example.com" },
                    { "20", 0, null, "5eec1574-fed7-45ca-8136-b5b699cf02eb", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEKlPdtBm6bJ++nvMvOJYZP39mltSkaGaqzkiSeO2Ws+lfhdr1m/fGaMOMOFyt4s4Og==", null, false, null, null, null, false, "niniboekhoudt@example.com" },
                    { "21", 0, null, "9909513b-ab62-4c8b-8c54-ea7657ddea75", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAECiZfXUOtPI72jhZ2y4P1sJyw39g0vAixVTbDSpCOGtj4lTfoDKeQwOgwhUeSNHQAA==", null, false, null, null, null, false, "mounssifborkent@example.com" },
                    { "22", 0, null, "7f02a5ac-38b4-4416-aff8-5ca8028859bd", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEHicEeQua88Sdf12x6ywoRGuH2+Cv9F2gBW8CFY2GbzmuHncmo+/yXcVYwz3DY3k1g==", null, false, null, null, null, false, "metjeknoef@example.com" },
                    { "23", 0, null, "7000b1fe-84df-48ee-ab3c-e741d3967ac3", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEB+aRApI3MVvMRpkE9YtQfj8NIKh7j0CRFGJgQrNxqxcQvlXACDnrvgeLBNLlGY9Gg==", null, false, null, null, null, false, "lolkjehagoort@example.com" },
                    { "24", 0, null, "e623e24e-6d9a-415c-a859-dd25306209d6", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAEGYeUq0+JhdMUY0HBdItuFsG0HceKTNiSy9On7HpQzxY0eLl4Pbba9gXQWRzAmxeLg==", null, false, null, null, null, false, "sabriadenissen@example.com" },
                    { "25", 0, null, "2c23f0d2-571d-40e8-9e98-27ae07b46d57", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAEPQXZJQEWAfceq/l257CZK6a5ajbtIMd8wbPA1D8t3nfBKW+UcyJVWlS5IyhI2NHlA==", null, false, null, null, null, false, "farukvanschip@example.com" },
                    { "26", 0, null, "5cc7a7e5-e6df-4ed1-a15b-f47d46609be7", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAEDJ6VQeAMKF4uzUCnsZcBCJ9JpUYMAkxXwKjjLdarn7jpSw53kt/QVIYNEPEAES1+w==", null, false, null, null, null, false, "zakariadraaisma@example.com" },
                    { "27", 0, null, "a5ff1ca3-e5a4-4ab5-be14-d467320ff20b", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEBVWM8q08Uh8UsVm+ewfWtbY5zyCAtM4R9YhsPPdAzqpeNNyzCXRQCISZ/mAVc6F/A==", null, false, null, null, null, false, "oguzheessels@example.com" },
                    { "28", 0, null, "069091ca-da70-4eaf-a233-02d5afa496eb", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEAkZMguUN+mudzlnmOj+ENxCTkv5sLwFABkQdZzoeT/WKht0/3SzwCi6dUOggUOI1w==", null, false, null, null, null, false, "mariaburggraaff@example.com" },
                    { "29", 0, null, "d3924f6c-e549-49c6-996f-2aa6fc1258e0", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEBVnKtxHmEdd5wsj1QA/qUXPHHl5eAsEKp3tJ2RnjyYOhlPExkx2DXDc4VDDrBNHqQ==", null, false, null, null, null, false, "katelijnvandekoppel@example.com" },
                    { "3", 0, null, "98498f63-aae9-4c4b-acd9-dfa38db9f3ae", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAEOPi9VFImimyZFnWHEp9YTKgGtEg38kaER+jGPSx8rN+M7TdTleS3R0P+rLvCmcaHw==", null, false, null, null, null, false, "theotan@example.com" },
                    { "30", 0, null, "9a30c2c6-9c06-4e8f-a2f9-b49554a08149", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEGpN66QPxuoagqa/dA2EhbiBVnKRub2q1dxNfVzpskrPAJ+tf/Mo81ELowbJGNGxvw==", null, false, null, null, null, false, "desirescheeren@example.com" },
                    { "31", 0, null, "f4b8ea17-4ed8-4b66-9439-bef0a3f11e15", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAEFvA6AtbMOFfDTL/pDlZp8aEA2/fRGzohTNavxi7sTGgeYO0BkBvK+dgPfrv2BoyHA==", null, false, null, null, null, false, "daxgabriel@example.com" },
                    { "32", 0, null, "0e608e17-dd43-419a-9f6b-8ef83bbded32", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEP2NVoVJ+wrzRlMKhc/RSI+hDIXUDydQVBE4ZxzHMrLaeiRXIZehKNrmBFyJZEgTSA==", null, false, null, null, null, false, "tommiestel@example.com" },
                    { "33", 0, null, "42f4e137-8f1e-4129-8fea-4ea434fdaceb", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAEL52MxCjSYpJxuxwbFTxN8JJlJ+EL4DLy2Ta207KhCAEERPCDfGaaQFoZJnVVKMZfQ==", null, false, null, null, null, false, "raphaelkoppe@example.com" },
                    { "34", 0, null, "e1510955-f3c3-4196-9c59-40676f271c9f", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAEKOi7UzFuxymMAz99PM3LWkv0fgPy+qBVQfP2gmtvtif04opfBZHzPb+fi9OQSZ5LA==", null, false, null, null, null, false, "demyjongen@example.com" },
                    { "35", 0, null, "c4afbe21-7578-4b4c-9177-1816f4cd6a19", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAECsTnQF1fW63wRaMFNtHh4nAlsLK9DYvyFNeYKuCn1YVH7f7h9LJRcaAsFy/wDdtyg==", null, false, null, null, null, false, "leahharreman@example.com" },
                    { "36", 0, null, "bd2d8fa3-85c5-4842-8228-42b6531c3ca9", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEHrUJz6Y+CpGvAiZZule1UAhuYeSBgAlGSIHrhlTJEp3gm1SFGBt2Fj4PZFCE7p5Tw==", null, false, null, null, null, false, "idrisskorpershoek@example.com" },
                    { "37", 0, null, "8b6ffb66-48df-4f5b-a9e8-73cf40fcd9db", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAEMertx5we6uiRD7cFlaRZuIJMNxEetsYj/Fev6E/eBxsoKNWx1f7CTfx/JC5idOZnw==", null, false, null, null, null, false, "rashiedbleumink@example.com" },
                    { "38", 0, null, "7ec9ef9c-bfb1-4427-a518-d3bae909fd47", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAEK3h4StftL3fGvc/Aa1y4DdnqIC6vzo6jszSm+kAA+beSPcuXi8vgHFiwYh8xyGS5Q==", null, false, null, null, null, false, "siay@example.com" },
                    { "39", 0, null, "8ac04022-f279-4961-810e-30510b973ae0", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAECKNDWS0BkiZF7f8ab8tNsXwjydbpIic5EJ32YY0zRsb3TAagSnkv1rshaEUNcdrYA==", null, false, null, null, null, false, "manolyalebens@example.com" },
                    { "4", 0, null, "7bb8fa11-5a86-405e-aa2e-014d914073b0", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEAhNCDiREVYr/XlpecAfyA6x6TezjtfhtQ+Jv+6BeDWli9bZ/CprAIBL16H0z1R6EA==", null, false, null, null, null, false, "cloekras@example.com" },
                    { "40", 0, null, "074bb91e-87e8-444d-a055-0803e25aedd6", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAEDlOhZo88s7nfDpptMvjpifPfEANK0D4yq6jApfQREu9dhwAGE7LqalZCyEhHd50tw==", null, false, null, null, null, false, "mateuszmachielsen@example.com" },
                    { "41", 0, null, "eeaef25e-e9d0-4662-ae1b-e4091a318923", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAEFL6j7yaTjLFCUcfP/0LEH5TLYByjjx3E7TzvHv0oseQHGx8G4JROqbGIlNWheD4Jg==", null, false, null, null, null, false, "douaavandepavert@example.com" },
                    { "42", 0, null, "cbfeecd2-ccf0-408e-b51a-b0da37d359a9", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEMchTQVhR/wWMl4ApkydP3hB936vfZX18brX1QAzviRJ2RZicQ30HxssktpHq75QGg==", null, false, null, null, null, false, "kishanhoogkamp@example.com" },
                    { "43", 0, null, "fefd45be-a167-408a-9a1c-2b008f058f0e", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAELiZG58dVGzhv2TyaKB3fJnM6vC2F25Es3kYw571/GQ1DPJLJYFe4rNfiU1u0HQn9A==", null, false, null, null, null, false, "harmjanversendaal@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "70cc50ab-8514-44c9-a206-14618230e21f", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAEMREVe+/vv58vsSYJJg05dap+F9wZanxSpFbfC4NGKvyR3NPZzj/i+hfDSBce7eLeQ==", null, false, null, null, null, false, "maurivannuland@example.com" },
                    { "6", 0, null, "3c34ad1f-611e-4db4-a05a-236a4442eeee", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAEBwBh3BX3MXgz366WNoDv34TGKW7i0FxR7rdt5lCFUyPjNYnN17SAcgkn0DghhN0LA==", null, false, null, null, null, false, "jeromeheerink@example.com" },
                    { "7", 0, null, "2c12b9f5-bdf1-40f5-8f99-2a3d1173b90b", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAEGf1+TzPaza/PrYsJ5oqNqgiVG7MzgVlAW6cUCpxXPvUpQaTGZ0k/qyR1FZi1to4eA==", null, false, null, null, null, false, "semihvanburken@example.com" },
                    { "8", 0, null, "9d6799a3-e70a-42a7-b841-02f731ea9e2d", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAECZtZWXb4a58TgUe5dtqLtHUCB7Eda1QCgPtoV0k+jGVdLRClh8XubUtQhE5mgj0OQ==", null, false, null, null, null, false, "jacomijntjemoraal@example.com" },
                    { "9", 0, null, "c91b82e7-c382-46ce-893a-d7c3041903fc", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAELyiQvIOvQd8YmtWdMKfoCbLObVl5gX2VV/Wgw5sGSANWwDCpISkLsEOAHz4pe/HTQ==", null, false, null, null, null, false, "sjuulalma@example.com" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "10" },
                    { 2, "11" },
                    { 2, "12" },
                    { 2, "13" },
                    { 2, "14" },
                    { 2, "15" },
                    { 2, "16" },
                    { 2, "17" },
                    { 2, "18" },
                    { 2, "19" },
                    { 2, "20" },
                    { 2, "21" },
                    { 2, "22" },
                    { 2, "23" },
                    { 2, "24" },
                    { 2, "25" },
                    { 2, "26" },
                    { 2, "27" },
                    { 2, "28" },
                    { 2, "29" },
                    { 2, "30" },
                    { 2, "31" },
                    { 2, "32" },
                    { 2, "33" },
                    { 2, "34" },
                    { 2, "35" },
                    { 2, "36" },
                    { 2, "37" },
                    { 2, "38" },
                    { 2, "39" },
                    { 2, "4" },
                    { 2, "40" },
                    { 2, "41" },
                    { 2, "42" },
                    { 2, "43" },
                    { 2, "5" },
                    { 2, "6" },
                    { 2, "7" },
                    { 2, "8" },
                    { 2, "9" },
                    { 3, "2" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[] { 3, "3" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[] { 4, "2" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[] { 4, "3" });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UsersId",
                table: "UserRoles",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "8f1c0471-21da-4ce7-afd9-3c45f772b670", "john@example.com", "John", "Doe", "John Doe", "AQAAAAEAACcQAAAAENextsNiz4T+5/w2dF6BwyJCo2JnqoC6bUmpu5NsyR3h+uDF8vHhwFNkADZJmN1WWg==", "john@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "9d23031c-e838-47e7-9fa8-4a908b03ae33", "jane@example.com", "Jane", "Smith", "Jane Smith", "AQAAAAEAACcQAAAAEL1jLISit2HaeEXJqIaUxTIQSJK0ZBQBmFnEp7JCDPD233OsD/GzDNSgs8Q4Uwl0dQ==", "jane@example.com" });
        }
    }
}
