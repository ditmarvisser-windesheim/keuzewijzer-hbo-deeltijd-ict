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
                values: new object[] { "9e2453d8-3466-41f1-b38e-1ef170559157", "admin@example.com", "Arnold", "Min", "Arnold Dirk Min", "AQAAAAEAACcQAAAAEKKeKdA0mEUKiWMORSnPeAxosxtoF30CAOIYpmaRcONH99pQHp8uj6hfWRDPU/67Cg==", "admin@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "0daa3cbd-b499-4842-8401-361735119855", "eugenevanroden@example.com", "Eugene", "Van Roden", "Eugene Van Roden", "AQAAAAEAACcQAAAAEHavCfajAhn/o4dE6rgZpo19MOuYQ2UBZ5yZIi1Ikz0t6JOpX69feiEa7ArTK8jGEw==", "eugenevanroden@example.com" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "10", 0, null, "1257afad-b1bd-43ac-93df-7dee13ea0a7c", "sharonapouw@example.com", false, "Sharona", "Pouw", false, null, "Sharona Pouw", null, null, "AQAAAAEAACcQAAAAEL+d27oZY5OW/jGhvU7ezz4PGYGSeBvTqYzucwp1N7EeRpkEKsV7t/ILEonzxhIREw==", null, false, null, null, null, false, "sharonapouw@example.com" },
                    { "11", 0, null, "4c8e2d38-e425-4a30-9b04-1f2ef138b479", "ashwienabbenhuis@example.com", false, "Ashwien", "Abbenhuis", false, null, "Ashwien Abbenhuis", null, null, "AQAAAAEAACcQAAAAEFFZsl3o8EH5Qw+kNB3Ni21u6TDSW2hVZGxB2vmqlvFuMiK8eQXcG6wLeDihObtxjA==", null, false, null, null, null, false, "ashwienabbenhuis@example.com" },
                    { "12", 0, null, "dbccb16f-ab66-470c-82d0-03067d67b793", "raulverdaasdonk@example.com", false, "Raul", "Verdaasdonk", false, null, "Raul Verdaasdonk", null, null, "AQAAAAEAACcQAAAAEE9PQHPN7NiqUUN1Jw6AwdqGIuEdy+K7rb3youXchcLhGOWEoRXLKLw6xRNfDz77lw==", null, false, null, null, null, false, "raulverdaasdonk@example.com" },
                    { "13", 0, null, "1fb282d2-4a22-4dfa-9fba-db0244c184ba", "majellawessels@example.com", false, "Majella", "Wessels", false, null, "Majella Wessels", null, null, "AQAAAAEAACcQAAAAEFktZOaQ3Rr0I+7lbHaJgcJ4pUc4vhUXWGsLsNVLdUaL2lZ8WGeHbOnNp9DKzaSiYw==", null, false, null, null, null, false, "majellawessels@example.com" },
                    { "14", 0, null, "0cfe2ad7-b52c-4f96-905d-9fa451c2cbfc", "kwintlogtenberg@example.com", false, "Kwint", "Logtenberg", false, null, "Kwint Logtenberg", null, null, "AQAAAAEAACcQAAAAEKBw+ATeFmglgwbS+HtsM1d+es2tDGwS4R7A8bNToIfklQAuLZ9hc+YaeHcAWdIitQ==", null, false, null, null, null, false, "kwintlogtenberg@example.com" },
                    { "15", 0, null, "29b4c5af-eae2-41f3-ab67-5bcdb9d4d7bf", "mikhaillebbink@example.com", false, "Mikhail", "Lebbink", false, null, "Mikhail Lebbink", null, null, "AQAAAAEAACcQAAAAEF6eJ4fn2nLgi3Bp7XDuVqu8dVSEbZSj5p55E0Y6G4MXF96WSYJatvNFvuno0HyDng==", null, false, null, null, null, false, "mikhaillebbink@example.com" },
                    { "16", 0, null, "f9fbf61c-69b2-46b7-90a9-6f7db149e73f", "claylier@example.com", false, "Clay", "Lier", false, null, "Clay Lier", null, null, "AQAAAAEAACcQAAAAEKdUnnfX571M2nrL79fcCgQIzbSdQZ7CQ0Rhf8cpqOiQZIby/kIUPjavdB4SRRImkg==", null, false, null, null, null, false, "claylier@example.com" },
                    { "17", 0, null, "43befe2d-de8a-4b5c-bf20-8e6d687abceb", "rubinavanderhout@example.com", false, "Rubina", "Van der Hout", false, null, "Rubina Van der Hout", null, null, "AQAAAAEAACcQAAAAEBj1ijvdDK4IilqteSt21jiMbFUB3I/mZkFRVXy5dhDJZnFxf88I9jaA7CziQe55ew==", null, false, null, null, null, false, "rubinavanderhout@example.com" },
                    { "18", 0, null, "7f432805-ae02-4d98-9d36-d0e3fae24f0d", "abderrazakblaauwbroek@example.com", false, "Abderrazak", "Blaauwbroek", false, null, "Abderrazak Blaauwbroek", null, null, "AQAAAAEAACcQAAAAEOFCiFSVNbKipC13wlK9VBpKjW1W3d+WV+E307250LKnhkZZLOlTkODnI4g6DxVugA==", null, false, null, null, null, false, "abderrazakblaauwbroek@example.com" },
                    { "19", 0, null, "775d7340-c4ef-4b3e-8e8a-110eefdedfc3", "yannikconsten@example.com", false, "Yannik", "Consten", false, null, "Yannik Consten", null, null, "AQAAAAEAACcQAAAAEI+3fRFZVsV8Wqhcotihqa7gZsAIkX0Etv2D8ALp1Nsx+OEvAuM1i9EtbwhHEuSJCw==", null, false, null, null, null, false, "yannikconsten@example.com" },
                    { "20", 0, null, "3e64e860-e468-43b5-8608-d3ae270b9659", "niniboekhoudt@example.com", false, "Nini", "Boekhoudt", false, null, "Nini Boekhoudt", null, null, "AQAAAAEAACcQAAAAEABMkHfAckAfXDPkHHUqSpcTVHrxQ/a9AP7HbUJMorm6lTGIold8gFpQd+mjOlR8FQ==", null, false, null, null, null, false, "niniboekhoudt@example.com" },
                    { "21", 0, null, "e6f76f72-dc4d-41d6-97a6-bdeca2645119", "mounssifborkent@example.com", false, "Mounssif", "Borkent", false, null, "Mounssif Borkent", null, null, "AQAAAAEAACcQAAAAEDw31HwghNqZl7wdCrh8x5g5guR/SkhnTNqXHqhouD7Rfkd9b2BgjkZADGDFDjZfrg==", null, false, null, null, null, false, "mounssifborkent@example.com" },
                    { "22", 0, null, "710eecef-67cf-4ed2-9ab8-990ef37f9e39", "metjeknoef@example.com", false, "Metje", "Knoef", false, null, "Metje Knoef", null, null, "AQAAAAEAACcQAAAAEI+XdPOfr64HGEDf6of9Gl7vR4MDLZiYHA0upfRHlD8hMLVAkXjQBc2RKDTxecSp3A==", null, false, null, null, null, false, "metjeknoef@example.com" },
                    { "23", 0, null, "e7738c37-2b5e-4fcb-bf97-27115ae882ff", "lolkjehagoort@example.com", false, "Lolkje", "Hagoort", false, null, "Lolkje Hagoort", null, null, "AQAAAAEAACcQAAAAEIj4AzSHMiQRUwaKZnvBZKEdYwxALCQd6ImDehO9N3mLBBb1mlmHr7MLCiL/oVZUXQ==", null, false, null, null, null, false, "lolkjehagoort@example.com" },
                    { "24", 0, null, "f85d245e-db93-4ade-bb4a-150667d4a1d4", "sabriadenissen@example.com", false, "Sabria", "Denissen", false, null, "Sabria Denissen", null, null, "AQAAAAEAACcQAAAAEKH367R3G1os/vw5UFMG46M7neLP2zEDdC35/mJ6RyPF+Ir7mn2HhzOJdRq5BERWiw==", null, false, null, null, null, false, "sabriadenissen@example.com" },
                    { "25", 0, null, "8e359c77-1d62-417d-a0fc-6b53e02e9485", "farukvanschip@example.com", false, "Faruk", "Van Schip", false, null, "Faruk Van Schip", null, null, "AQAAAAEAACcQAAAAEAZSAjpDP8W/0cD1u6u2MP3FUXxJ1LYx4FWDFpLOmSPAjRpf6ZD7DohLw8GdFmuq8A==", null, false, null, null, null, false, "farukvanschip@example.com" },
                    { "26", 0, null, "9a63e875-2a5d-48a6-bec4-b98cf8c571dc", "zakariadraaisma@example.com", false, "Zakaria", "Draaisma", false, null, "Zakaria Draaisma", null, null, "AQAAAAEAACcQAAAAELzQKyluCPcXDD9KtIrkImXmtszXq89l1VhXLTHAoktCOs1QhIh8s/n+85sBdpOnKw==", null, false, null, null, null, false, "zakariadraaisma@example.com" },
                    { "27", 0, null, "e94e85c3-b881-42aa-90b8-61168cf10065", "oguzheessels@example.com", false, "Oguz", "Heessels", false, null, "Oguz Heessels", null, null, "AQAAAAEAACcQAAAAEP7QtkFQS4Hk94smByelEHMbncP1yELuyXm9g6XasN6ni5i4ACvvtspc/2CeoaCeCA==", null, false, null, null, null, false, "oguzheessels@example.com" },
                    { "28", 0, null, "ee34b22e-c3f6-43bf-89ae-0147f2838bae", "mariaburggraaff@example.com", false, "Maria", "Burggraaff", false, null, "Maria Burggraaff", null, null, "AQAAAAEAACcQAAAAEGbcvaVOKjmqcfZdOEzIWW1ucLhzwu4DX85ZViKlObDR62OskkWhsHu8oHxZsEdx6w==", null, false, null, null, null, false, "mariaburggraaff@example.com" },
                    { "29", 0, null, "79059f28-e504-4bf0-9d3a-64bc0f1e2d49", "katelijnvandekoppel@example.com", false, "Katelijn", "Van de Koppel", false, null, "Katelijn Van de Koppel", null, null, "AQAAAAEAACcQAAAAEL2UYdV0fO3H3BsbCQ4iM/QpUB8HeLo1hcsKle2hI7nksX9NH3gib/QAuhJk1z/HVw==", null, false, null, null, null, false, "katelijnvandekoppel@example.com" },
                    { "3", 0, null, "b8c61ef8-9c2a-4162-8da0-5c00751406a1", "theotan@example.com", false, "Theo", "Tan", false, null, "Theo Tan", null, null, "AQAAAAEAACcQAAAAEAzdE90p2afy4pqSSrXO0EXKjAFeGJEBya4a8oRD/pB5qZ4nRJM7uox6EMaHw54xwg==", null, false, null, null, null, false, "theotan@example.com" },
                    { "30", 0, null, "e5b6c42d-9b83-4733-a422-460cce591e0b", "desirescheeren@example.com", false, "Désiré", "Scheeren", false, null, "Désiré Scheeren", null, null, "AQAAAAEAACcQAAAAEOo3GO/Cd0JyCXeK9MCnPPsbSbi3vZhlCzOdh4t6R05oZfbL8a0p0GkfHxuZn8CvVg==", null, false, null, null, null, false, "desirescheeren@example.com" },
                    { "31", 0, null, "0dbf6c60-30e9-4796-942e-0f1f7636c94c", "daxgabriel@example.com", false, "Dax", "Gabriel", false, null, "Dax Gabriel", null, null, "AQAAAAEAACcQAAAAEN9CjACzT0ujKcHu7TYKx2f0nWWhs+NEhMnvth0ff60U80XEzJ548mSFfFEhz8GFtA==", null, false, null, null, null, false, "daxgabriel@example.com" },
                    { "32", 0, null, "c3a9bd0e-86d9-4ada-b2da-b3b4b4e061db", "tommiestel@example.com", false, "Tommie", "Stel", false, null, "Tommie Stel", null, null, "AQAAAAEAACcQAAAAEGAHceV3uZraduwtH2EE04plLyI1Uyl3dqAikqTBIsJdtYocOle+a9zWWpBFCpXT0A==", null, false, null, null, null, false, "tommiestel@example.com" },
                    { "33", 0, null, "c17a7a6d-66e4-466f-92a0-38ebb6bd19de", "raphaelkoppe@example.com", false, "Raphaël", "Koppe", false, null, "Raphaël Koppe", null, null, "AQAAAAEAACcQAAAAEM+5E1C1Xu2sv4GZwsfzZlJ2U5VMPpBBuWOvWY2ja6+7pkLlArCID2bt2IAd+zfIig==", null, false, null, null, null, false, "raphaelkoppe@example.com" },
                    { "34", 0, null, "504d497d-40f5-42c5-bae9-1f0d51badbd5", "demyjongen@example.com", false, "Demy", "Jongen", false, null, "Demy Jongen", null, null, "AQAAAAEAACcQAAAAECxmizeZtIzBsqsQd/P/P8F4M+gaKU9Mp4mya3bCdIP1dP+Gqyj40uwv3FkD8BVaFQ==", null, false, null, null, null, false, "demyjongen@example.com" },
                    { "35", 0, null, "95019984-3134-44ba-a67c-8fdf8691c34f", "leahharreman@example.com", false, "Leah", "Harreman", false, null, "Leah Harreman", null, null, "AQAAAAEAACcQAAAAEPKCa2vaOmC+YR2bVwMPIiVfJbAiLFZaIiA2yI2K2IHDqy448dx2t4XrzDzlYCf/kg==", null, false, null, null, null, false, "leahharreman@example.com" },
                    { "36", 0, null, "1c0e378a-4613-4d42-b022-11ee65f036d1", "idrisskorpershoek@example.com", false, "Idriss", "Korpershoek", false, null, "Idriss Korpershoek", null, null, "AQAAAAEAACcQAAAAEK7hrp96VbBThDjmgIozURsNG3MuOZYrua5WyuXYoANPnalpysDypvDw55yA1wLWsQ==", null, false, null, null, null, false, "idrisskorpershoek@example.com" },
                    { "37", 0, null, "9c93a939-e1a8-4485-ab66-f594465b25c2", "rashiedbleumink@example.com", false, "Rashied", "Bleumink", false, null, "Rashied Bleumink", null, null, "AQAAAAEAACcQAAAAEEyXktpLpclT58HlaihPbnePdBHvIfHiJNiVGT/QLPplMRAF+YeFsf35zxjNCo2u2g==", null, false, null, null, null, false, "rashiedbleumink@example.com" },
                    { "38", 0, null, "8af721d9-056e-40c3-8a9e-f7ca1c8135a6", "siay@example.com", false, "Si", "Ay", false, null, "Si Ay", null, null, "AQAAAAEAACcQAAAAEPdQhn6dYLCuuGKZsrBMnXw5s6X/9r/EgqOtrLEAPCZR28cceL5hnW6LfUnPytJNEw==", null, false, null, null, null, false, "siay@example.com" },
                    { "39", 0, null, "0974564b-13ce-4be9-9ccd-c09da794710a", "manolyalebens@example.com", false, "Manolya", "Lebens", false, null, "Manolya Lebens", null, null, "AQAAAAEAACcQAAAAEIhkc5UjATDPz5yVQSpKnTKQ4x1x6M4l5ohHwLVXeegzu9f5I+AWDHg8DB2t/daHJg==", null, false, null, null, null, false, "manolyalebens@example.com" },
                    { "4", 0, null, "62fdab9b-c321-49f2-a244-0f5d462c89ba", "cloekras@example.com", false, "Cloé", "Kras", false, null, "Cloé Kras", null, null, "AQAAAAEAACcQAAAAEOhXvRkaMiaDldqZpY2On6OwM4TaWblN5hs1zlV2DWfz5W528twi7t99YIg+UE3uZg==", null, false, null, null, null, false, "cloekras@example.com" },
                    { "40", 0, null, "f7c443e9-d740-42c3-8a36-c2ec28067f0b", "mateuszmachielsen@example.com", false, "Mateusz", "Machielsen", false, null, "Mateusz Machielsen", null, null, "AQAAAAEAACcQAAAAENpaSk0edwTZ71roXppM7PRdzWNhxC+lAMm12y3tbi30OE+uzZ8wotnfc/poMUZr/A==", null, false, null, null, null, false, "mateuszmachielsen@example.com" },
                    { "41", 0, null, "7e10a5a3-4fdc-4c01-a4d9-af5d37633e6a", "douaavandepavert@example.com", false, "Douaa", "Van de Pavert", false, null, "Douaa Van de Pavert", null, null, "AQAAAAEAACcQAAAAEHw58CHVRBpUtXeHLfVzYKDW0esHcfsmaGiHJVpHHlQFyDddglrRal8A9fSQoBa6jw==", null, false, null, null, null, false, "douaavandepavert@example.com" },
                    { "42", 0, null, "84251fa0-d29a-4a67-ac9c-1f045844e5b2", "kishanhoogkamp@example.com", false, "Kishan", "Hoogkamp", false, null, "Kishan Hoogkamp", null, null, "AQAAAAEAACcQAAAAEMz7+qHD9lpDKXwNgoZy/pZ9XJRysoeUIW/KZDaMkwUXuC/Mvg7egQ0WMz2BXZHPgg==", null, false, null, null, null, false, "kishanhoogkamp@example.com" },
                    { "43", 0, null, "4e7b2bac-03b8-4188-91d9-7cb9823e38d9", "harmjanversendaal@example.com", false, "Harmjan", "Versendaal", false, null, "Harmjan Versendaal", null, null, "AQAAAAEAACcQAAAAEFVQAkORr39Vyw/eeMndyTq9fh2KoDQGjuscU8vJgYo2ToQhG0Bcf+6u/P4rF6GFCA==", null, false, null, null, null, false, "harmjanversendaal@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "CohortId1", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudyRouteId", "TimedOut", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5", 0, null, "f3cbd7f7-984a-4fb1-beef-000021c0df6b", "maurivannuland@example.com", false, "Mauri", "Van Nuland", false, null, "Mauri Van Nuland", null, null, "AQAAAAEAACcQAAAAECKL59ncPN4a+vE9lizEGffjY+vdkO7EEYM4p+yrdWfnj3Q4ZO5JLiscLbgbBaJ1sg==", null, false, null, null, null, false, "maurivannuland@example.com" },
                    { "6", 0, null, "f826a3f5-2ebb-4917-9d85-fbd4db2e45ef", "jeromeheerink@example.com", false, "Jerome", "Heerink", false, null, "Jerome Heerink", null, null, "AQAAAAEAACcQAAAAENp3Vm/CJcQAwDpBYIdxv0kP9jtHUL07vaSPkIaiV/CiObiTj9GX9ZHKmSaNv4pwhw==", null, false, null, null, null, false, "jeromeheerink@example.com" },
                    { "7", 0, null, "034a3895-02a1-4c6e-b95b-d38e52afce9c", "semihvanburken@example.com", false, "Semih", "Van Burken", false, null, "Semih Van Burken", null, null, "AQAAAAEAACcQAAAAEKlyEGP4oS9U5cII0pVpaeZz3vS+9d9Si8BGfw8+BRhXs8cAbPGOrg5Y33rUk0weGQ==", null, false, null, null, null, false, "semihvanburken@example.com" },
                    { "8", 0, null, "12616f53-c77c-4148-94f9-abe9eff10519", "jacomijntjemoraal@example.com", false, "Jacomijntje", "Moraal", false, null, "Jacomijntje Moraal", null, null, "AQAAAAEAACcQAAAAEFu78v79ps0dNn+h1kwB1B5Toji+SM7vZuzLsXq+1i7qGZZA+ZvxcV5c+PbUutweLA==", null, false, null, null, null, false, "jacomijntjemoraal@example.com" },
                    { "9", 0, null, "b0b8dc16-712f-4dc8-b69e-68b20284222d", "sjuulalma@example.com", false, "Sjuul", "Alma", false, null, "Sjuul Alma", null, null, "AQAAAAEAACcQAAAAEESOAnsp5+kBgum6tuiUVU+A8WG2OOQKswd3tDoMJ85pIWUQ0DASI7wiUmdumf5nNQ==", null, false, null, null, null, false, "sjuulalma@example.com" }
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
                values: new object[] { "8312979c-8042-418b-9e10-0ab5927ebd0d", "john@example.com", "John", "Doe", "John Doe", "AQAAAAEAACcQAAAAEBCJj2eCgrwilHibr2ag2d3FbM82tC9mUr/002fA6jMLWVHfzqazHIDHYSb7ebW4lw==", "john@example.com" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "Name", "PasswordHash", "UserName" },
                values: new object[] { "25a54afa-4f69-4033-98cb-e39cbe749b95", "jane@example.com", "Jane", "Smith", "Jane Smith", "AQAAAAEAACcQAAAAEOx74P8anDqON40Ik7Jug4v2K4qB6d1XuX1e+aQiw/q2NfEIKZ2wuaP5a97jNPnGwQ==", "jane@example.com" });
        }
    }
}
