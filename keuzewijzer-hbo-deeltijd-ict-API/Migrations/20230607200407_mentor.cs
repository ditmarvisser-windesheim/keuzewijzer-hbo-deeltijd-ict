using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class mentor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MentorId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1f36400c-e9c7-452e-affb-53fd65dfb5df");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3e35e3f5-e4b4-4061-aa83-6b2cf857eaa4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0322a93d-f0c0-4f47-97e4-740e842fdab7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "80498bda-896c-46cb-a587-558ed35c9c50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "428b7416-67ef-4ee6-b39e-073a5a0e4457", "AQAAAAEAACcQAAAAEBpE/1Cf3yVzD4/fJWzYt/l+ONP95Zu4fqIQG3KM6WEnh7U3bd4t0biprlVl8k/Rgw==", "8c39698b-333a-4c75-a842-199b06b3cc92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59854608-15d7-4596-a1e5-e221a3064ca5", "2", "AQAAAAEAACcQAAAAEMg/jYMYZPsiK5l7GIpZtzpc8ptHgQnB1giFVwkMCE/PPq7jMMeDiFZMVcPQrmZOHw==", "2dc449a5-4eae-4d76-aec2-855f9c77e3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b84b040-f668-4ace-af15-a9249bdbfc7f", "2", "AQAAAAEAACcQAAAAEHxGpoRdRLFGBBpghDcXLasfLFUmTnOip4lMaCWmmwFFMLaD7qFQFnMvsDgzdno24g==", "7787a0c7-1b30-4a60-b3d1-6341e60c28ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ced67c7-706a-4bb0-bfe0-4933727648cd", "2", "AQAAAAEAACcQAAAAECd9koB6HCXye3Jxuz58zEVaTIr15h62UCibo2ekpoiLpF/xd+HuAtv/TKv7FshQDA==", "27c91780-7457-4843-a237-88218b911c2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e404aa7-60df-4fc1-b877-205d8ca33109", "2", "AQAAAAEAACcQAAAAEJhHjuaH0o/8aXSKgNJ7vL/cRd6rHzTKjQAyPqJi++D3QufIpXW/mVE1k7bmLafMyw==", "c46c241e-62bb-4516-9602-583eddf15896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c6ee1a-ea00-450c-8020-316a7f4be5e8", "2", "AQAAAAEAACcQAAAAEIq4ruBBm4wff1MHmgIHcre/zT3VSj+X2DHYWWtkciR/1q1Whb0nHUcKTR+O4sgrsg==", "a3ef1747-2d84-404a-96cf-1b5f81d1b5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c0e1f0-fe55-4c96-8f2b-97f608bc6e66", "2", "AQAAAAEAACcQAAAAEJDR6qRaahtz0v9bIyv1UzQQq6aDRl5JZBUjBlCE8vRXHNv/mDNyUG/DIQh/JZOxmg==", "764cad79-0da3-4366-af6a-4446f6145692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75d92c65-cea9-41fa-a779-27bf84f9eba1", "2", "AQAAAAEAACcQAAAAEFEaBBpIz1mOnTrvG2zAULOsW1h6IyL8H66IovGVzrAfNMST+BJNTz0iL0uAL72XcQ==", "3e6a7de9-c017-4ddc-bd1f-b9ca2eda5db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b62175df-d3a6-4605-8d71-5dac44a20aaa", "2", "AQAAAAEAACcQAAAAEGZOBLLxptiwCV98+i8LZqvoYya7jPZrNLMTKeLlZDYVAKHYwEdyD4WBFpK0whilJg==", "203a5f0e-a895-49fe-ae91-5e142705d2cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e67a55-8858-4086-ba27-4100dee79b6c", "2", "AQAAAAEAACcQAAAAEFxy2MOO6NEn1KCrgPuSuu1RH8Av+3YDVEaVsUa9iiFM2ZfZ1bQ67D28kDIZ+WGWfg==", "44ca0d1c-8c74-4e24-bf9d-5ee3c6343bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb92d808-6aa2-4843-97fc-01fcab67c73c", "2", "AQAAAAEAACcQAAAAEA1RuSPHCpuIe2twIW8hoBNKKneitczsv5R2XkYV4eB4asHiVunHUPnJB3ySsbDeTQ==", "91dd5f35-79d0-4e0f-9d62-1545e96abba3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "172a6fb9-e332-4eec-aca1-ea76f3bbdcbd", "AQAAAAEAACcQAAAAELQvZsq7VvPz+FOZdQiJzUIzQEocpnLcudOuwOJkwAJSz7H2mgXBfNVNgouQh8cHYQ==", "cad1de36-f66d-46d6-8728-43395af7b523" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab082219-9ecb-4509-97bc-7c6aa24e6661", "2", "AQAAAAEAACcQAAAAEP0J2UfIFIYJr5CLrKdCxkcUCqAuEV30jtPuTLC7YPsRJw+ylSgPE6kNEFUdoRkv4w==", "2ff55fc2-d773-4e92-9de3-7a48e177eb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccd90cd0-e4d4-47c0-9a1d-fe54bd1b1ea8", "2", "AQAAAAEAACcQAAAAEGP0K10XHouaBC5hOoLmn02X6asNID8owj+z0jyydJELiRPLFXq2t4fmvh9DCfDyyA==", "cf101b6b-e30e-40f9-b450-4a5d390b2c78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0dd9c3c-0ea2-420d-8d04-224c9aba0ae8", "2", "AQAAAAEAACcQAAAAECUuRar2ZtIUG49qCBGvL/k7wfBsg1smNgkpjNXPU2UR4ADgK+7bob4fY0hmnOJqXA==", "217061dc-6f60-405a-9b78-b448ab69e667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9017a8-a69d-47c0-bcec-8eae3524d24e", "2", "AQAAAAEAACcQAAAAEJvdGnVaRoFYrFthfY/MGi465lPWuOWC6at6kZKpo1LcjJ97BfPj+YpvvLiKqjhH+g==", "2946b339-a2ab-43d4-bcd5-27d8c5378a20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fcaaaa9-ea64-44cf-9518-9e80f784513f", "3", "AQAAAAEAACcQAAAAECPVXwgBBOkoDsZx36NfzXDTGeIrftb+NNX9q3Ks2N/ykbl99kHHATech1BYZIfeyg==", "109d80c0-8553-463e-91df-81715424e693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541f3834-7255-465b-8f5a-ba7fc1023a30", "3", "AQAAAAEAACcQAAAAELBjl5Y1eiuP6GcriZZrshLyYnRZgIiKWZqJQGpMsvms4ba00NWfnkIkkR7kBWHDow==", "c9dc4055-a329-4f87-900b-a7a1783cb5cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64da7893-7e19-48f4-a315-636533918e00", "3", "AQAAAAEAACcQAAAAEP1q9xui/Eopxrf7loVphzBusgzRETh9XJaxEJRQxac1zq6BW3b3M89gkbsjb/FSHg==", "08159233-5f42-454e-b1d2-002da6ad294c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c12daef-3e01-4bb6-a220-907130c5366e", "3", "AQAAAAEAACcQAAAAENijXjxKyXgJsc90kHQGpATClRiZeZi2fvq0VVgOCIjbvdasjJdIY7vxC32obx/aCw==", "7a0eb7dc-0ba4-45f2-ae30-c00d473b8243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2465fb79-cfa1-4c4e-a17b-5d88d23211f4", "3", "AQAAAAEAACcQAAAAEALAfsSBv5s4zIysBoVgGYX5RLECEqEwcMLLjYuPGNuzlJrTH4pMwe/ZdyV3da9EmA==", "66d9989a-122a-49cc-9ec2-0a057becb6e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb7a2b6-4d6d-4214-8c20-d2d3c10e97aa", "3", "AQAAAAEAACcQAAAAECqr3OAM6EGBTIZJderxUP6VLPU8Tt+WRMMITkccFNDGnlV+7fvf34MOfZhJNo2LsQ==", "12fcef0b-b52b-4bb5-b27c-a14320d504a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01a79118-5e75-485b-abed-0d9480f61cab", "AQAAAAEAACcQAAAAEBwx7Xq3ltCSF6UxumtapN1PiqHm/hPIjstqem91hjH61lEKObz0r3cfuPwgROnCYw==", "90009b7e-36e0-424f-a589-5856db6e9e9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "170697ef-313e-4fbb-b783-8ce0661d8388", "3", "AQAAAAEAACcQAAAAEDVsvGLa4bhdtK8wCI9S41eC8TPOQr8XywgOUyI7Nr4g8jOQPBFIQ/RVEJL5l3HTgA==", "b7ddbbe8-6c24-478d-ab78-4a6e78603273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a38f524-aad3-4f04-9b9d-dc5f86ff5f71", "3", "AQAAAAEAACcQAAAAEFcNln4PRYwMgZnJ3JO7DkMNyZTsMBWo9+IucLMombwPsenFoy5b5PEXSEsqlXfF4w==", "fcc23d04-c339-4497-b39a-318aaff02fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e670b005-54f2-4fc2-9f1c-5e1b32852860", "3", "AQAAAAEAACcQAAAAEETTzLlMXpGkZt6eqM86XST0GT/o0BhkarbV7OGUycUMoBopOApJWjqjmAQd6VlYcw==", "b44d2fc1-0ae3-4905-bfb1-1818b7dd48a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3766a7b3-f093-48cc-a010-b67ac31249e5", "3", "AQAAAAEAACcQAAAAEMqR3tKoXDqPJQhnfxww8VVb/v5UmF4WU2fP7DgRrkxL/Bhu7NKPUbk3afI7fYJXlQ==", "6ad036ac-d60e-4079-9a97-25a43cf1ff62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35fb4b1-50c3-4433-b8c4-7561e8d3c133", "3", "AQAAAAEAACcQAAAAECPYXcH/2HzdEqf1JRa63ddZqYpG9J9vRhP6NgjSFVM7sssBC6TCqoUSE7HwPH3feA==", "9bc7029e-e98d-4035-bb19-870f74e7df26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68677fd7-cdb0-41e0-8382-72fa31392083", "3", "AQAAAAEAACcQAAAAEFkiTls8LstKlR7jmrRJDKVpKZQ3RRzAft+utfDn/cGqmWm9pdowAcFckYU5J/ehbQ==", "2a480e96-01a8-4aac-8d8e-25654c5b2b6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24672270-efe2-45c4-a8a8-e3d9354e4ce5", "3", "AQAAAAEAACcQAAAAEONakbrqrEckcTUv3+mHSxgvmZCcvsQSj0DvKnUzD4RkdDhPiC0Rt97NOT/96ymP1Q==", "e8ea7e9b-084d-4ddb-8f35-ce5b839220b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec357fa4-7e11-4e42-b86e-e0ec4311b239", "3", "AQAAAAEAACcQAAAAEG+nv4ivipFBKCVjxw4/8xojDKmZOp/J+nC1klzpz6Yr43geaaJcZnNJL35ze7x1oA==", "9d8b74e6-1c46-4c5f-bc36-50c421767d0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9efb69f-8cf4-4d47-9c9b-10dbb5626325", "3", "AQAAAAEAACcQAAAAENkwZTL/a8mH/E7HncuEwe8zImd5/gBphZtyGVXZWAKfVlJ1wsKuIUHhzoLol9hi3A==", "ccc6a722-5de7-49f8-9ba4-fb685bec167f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7017f9ff-e5b4-4988-9f49-1a0a4c77f7f5", "3", "AQAAAAEAACcQAAAAENeRHzUoyFGz1LoKnEqO7auCDZsq14iRket63+VaZii+1/axulLUBIErlLNMiDLRIA==", "7e3f56f8-0140-4e69-959c-048d0cddac95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b57e8bb-6ce6-454b-8ea8-f5799cfb8c90", "2", "AQAAAAEAACcQAAAAELpWuq4duuVFwEYJojomKABpWDHZNNhM8hIuTlto/Q5A4Yu5k6PbG9RKRc7OCV2/Vg==", "871bcd48-6d97-4679-8b03-9d417cbd1991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd12d42-5b22-493b-8a3e-53732c508d73", "3", "AQAAAAEAACcQAAAAEMls5IUZu0qh8qHzTVr8NvhQifagdfNy4DnZ8+bYTizVPu2+jPwYs93pp+CSh8ap/w==", "701b6224-ea22-4bba-8d17-29cc710c0d44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99bbeb1a-2b04-4238-9d72-f3f561303732", "3", "AQAAAAEAACcQAAAAEN9O7MjbQZ5AFh1daiI7/bzphXj9x9wOIvt1PavhjLhPJYuEEOeByl0c8nVerAhPCQ==", "f9fd87c8-5597-48d9-bcff-7871d6bf13ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b92456-40e8-4d30-8c0c-97c0b6fc99b3", "3", "AQAAAAEAACcQAAAAEKRZFBtt6BWnOFiFQCp6t/+vdeo4ueO0IwyiSS+7LA4eztD1ysxUnBXx4qVGcjfniQ==", "3d3963f3-d38f-465a-9344-c5009c3a42d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46208564-8bf5-4596-8d09-9cd4572558a3", "3", "AQAAAAEAACcQAAAAEHiu9SPWHTeSYC2j+EQoWqkZeNlgmRldFajzCeLIEq59EHB7MmNW3UYawpiy21lSYw==", "08f5ae92-2760-4533-a901-effe959c6f96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b6c274-469a-40f3-bdb0-fa10bd1a5d9d", "2", "AQAAAAEAACcQAAAAEPV8/qAf3vu/dOJByK3wZxmUH0vGeDVj1pG+ysHQ45SA5vxSwoiNvgHIUZJiAfOxUQ==", "35fc1d2e-c758-442e-a579-62fd701221a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "683d3bd4-5aad-4035-bed6-070cc409ba38", "2", "AQAAAAEAACcQAAAAEIZgWdRFWhY6IIkHZxV6KNgOSpA7OQ1hMlWjDjU4lgGHzQHoQSEguWyV5yJYEylcrg==", "e355f232-41fc-45c1-9651-03d96f9f8141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3800e097-18a2-44c0-85c4-3f9ace04a242", "2", "AQAAAAEAACcQAAAAEOodB3lLNzZQOd63S5+L9w/+T1jl9v8TkLn9V44p6LBS7PnLe7bf7Ub5Ke/J/UpTsg==", "a40b1ee0-2b43-4da8-a952-fee6ec50ac42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35bd108-d169-4dff-8878-049a0496772a", "2", "AQAAAAEAACcQAAAAEGg/5YT8tSLhOXSqSe9AwHfdsRbqm1bZjHihlYBiw5tMSP2VCM7nYMnmImM6Jh7J6w==", "a839d3d4-969a-49c3-89a7-fbb87736bf9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "MentorId", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a66f8d4-69b5-4cc7-9e25-2f596258e863", "2", "AQAAAAEAACcQAAAAELCVqSU9WBwXGWVQsa51+O5OmBISX1flDG04LJFjYeUddPJUI6dBtErBCpH4zz3nkQ==", "3b54209b-b673-40d0-b314-41ad36465303" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MentorId",
                table: "AspNetUsers",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers",
                column: "MentorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetUsers_MentorId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MentorId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ac70acb1-0b5f-4df6-9436-363ebfa9936a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "07b0fb93-c5de-4b59-a408-9c5e56828ceb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "27045336-6a5f-482a-a53c-50cd62ca167a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "1b67057e-b6c3-467b-bab4-eaf5cd1411ca");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c209aa9-1021-4b87-bf7d-c4c2bb93e243", "AQAAAAEAACcQAAAAEAeyatbsi/FDMHltQ40EIeaX7PPISqS3JuZjhW4Zq46BFP4/sJmnmsEaIQdLA4LU9g==", "d5197e63-1935-452b-bc25-f72820151dd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8c6c6b7-0094-4761-a728-5bd2edcca873", "AQAAAAEAACcQAAAAEIxSWpbLhOvd+52a9RpHirzWTlz3N7aW1KZxSGrrXvVAE49pKK3tYPUdAGqTkCVuVw==", "d48edaae-65dd-4e70-ab48-8f0e39a440a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81a3b540-1fc8-4f2e-8541-a9bd5614d518", "AQAAAAEAACcQAAAAENNxhWJ5+siuZWGsLqrY5buelN4bTrrBWl5zhJoL3E+1/3Zb/mfESWTZ1daSz2KyIA==", "b538196c-b87b-4931-a665-c0f1f46d0ecb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "516803b7-2c14-4bba-bc76-e6242a017ccc", "AQAAAAEAACcQAAAAEOg+ekrOmnMKizgBy+qq+/5Hje4/rMzIBhzxfyOTHnUdX0W4mVlX4wIASvi/dLWwlA==", "c6b74a88-01ec-4109-8ff6-1891351ae779" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0d1b9f-45bd-403a-a7d7-3c8b7bcc7c4d", "AQAAAAEAACcQAAAAECYdabkZIwyMiBsukAwFlRom7mARfYGqlC52Gs6wcaXieBugLrWq9pdW+iOjbdxeXA==", "d94e955a-6264-4c9d-95cf-ccf7bb6b9ba4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c777f0fa-0c09-41fa-9bfa-b9657d3e80fc", "AQAAAAEAACcQAAAAEIdGuVRYIzf8lHQWoaJ5feW06+on1xF8zZVSEDsJoVaFlAIl4+DCRn7wLTwaDc9BSQ==", "b7b80ccb-d141-4133-a457-8ee95645fbb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b3796a8-9cfd-4945-b9c3-86f1561732cc", "AQAAAAEAACcQAAAAEBXAWlJBtN8KEJEJUYWKafKYJQXz6szUcnCCObTJy7yon+UXUZweAUUzC3wp5+Dg9w==", "6851d434-6dec-45e1-b9d6-fca1bd5f90b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64172856-347a-4e4b-8ec5-d845da743772", "AQAAAAEAACcQAAAAEPJ0fRMRjMaWd8+bKkK1IdHNodjh59g+dhCqSaclxewwp+Wm0FA4Ggof2B7qG2L56w==", "eaaf693e-24ac-4615-887d-5a87e1dc6d51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a511f357-1f06-4cd7-bbfb-222ce2d6ce30", "AQAAAAEAACcQAAAAEDfa0cCs0cjiRZ3jzp2H1zmIMUwknoXvHhCtXRRZS4vQooLDkqQwWXZlzs6Ur2dbkg==", "068a053e-ef33-4408-afa9-0d01bea1bdb6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f829c5-b263-41fb-8903-edbaab1d6460", "AQAAAAEAACcQAAAAEE5DFIvWKYBhx1CKbn9jKjM36Ngzn38Lnf9DJ07Z+Q3zOh9JvB+rlxxl0B9cM1Iqzg==", "23f7280b-a99e-46de-bbb6-f2f279abed96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd1fbc9d-0f66-4224-9f64-7fece90a5009", "AQAAAAEAACcQAAAAEN8/ovap/bR1q3LNQMl0dvw5NZXymE0g2hrZO69zaqMXP4Ubafjmd46I+oU2vkyGeA==", "1a26c76a-e75e-44b9-b6c2-42881c792367" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "179157e5-67b0-4fa6-bd81-0a80c014c634", "AQAAAAEAACcQAAAAEINIAgt1voawK/s08zww3BEG7dis5Gpopc2abG/S2UxAKZtILzAEIupCx4y+3YkdQw==", "cfc861d0-d215-44b2-87b0-0d7ed9e0991c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7fdebca-4691-4539-84bb-6416e7155578", "AQAAAAEAACcQAAAAEOEbft+nDwwTtnJVZLKfdbHjGhCDPJrOjqvvxdgfXkJJEStav1l4EHCd6vBLEB6c0w==", "2d35a13c-8bac-4146-b7ee-bab7123983df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0632bbdb-dab7-4a14-a818-56c9df8f0533", "AQAAAAEAACcQAAAAEEHttZwgs51v2thLOTETyKYaztgF2DKL1AG64WlfPPXEAqp8oalQl6QQnJuxKoSdxg==", "272e9fee-5299-44d3-a020-28d22ddc404a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab540f6-8342-46e8-bae3-8ca54a0218f5", "AQAAAAEAACcQAAAAEI9EAbPAndZcboJckW0+RkjkSajZSXVyGib+FtUoXNrOHGGrzZfy4I0x064KjROECw==", "653f5bd6-4e2f-43ff-8a3a-c74326a92b81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05221e0b-1068-4eb7-aee4-7ffd02355c7f", "AQAAAAEAACcQAAAAEO5af3Do+pKvNg7mqaFZ9uO3JMgU0YFWP8kwxY2upprI9oOH7EwLAUHvmro7iXtbIg==", "c58690f8-3f3b-467e-af9e-78ac87acb27b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "919a5256-a566-48ac-a893-43441de58a34", "AQAAAAEAACcQAAAAEJa4EX0XnNyKdcvlbxpuvr1VpBFnymNrrauo2EqB6RQLycE1Zy8RBOo9CMgPMbmxEw==", "dfc8e33c-9426-4ab3-8823-8ec6562cecb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe8b94d7-2c16-4c63-9ee3-80b6aa5a2b8b", "AQAAAAEAACcQAAAAECrz9KtkAKMAMCwUTbsxW1HJGqaWWIZGgonhJeAapZ5rin6S8Be1fH9syMANk3ot8A==", "20c524bb-564f-459b-a9c0-00b1c14eedd3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff24ce6-bd4c-4c65-a415-edc7bfba89b6", "AQAAAAEAACcQAAAAEMskMLt6n4Z4VHhEQgzrt9rG83FGuPpO7lARu8Lud0pzhxJI/3i7SvXO2Ti4Zdp+ew==", "cf11ef7c-43de-478e-9bcc-8852fb28c0f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01be97ac-2225-49b9-950c-c870350e25e4", "AQAAAAEAACcQAAAAEHTjWx1K74pZG+SMHzH6w3ydBoPDyQlkh0lLWjDFh91YIuTx+F4HVstrFqzhDRRoRQ==", "0ac71ad6-a24d-47c9-8501-da237c3076bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3293e36c-e50c-4021-b2ef-567a6c10e2ac", "AQAAAAEAACcQAAAAEE2dwpJzsJNDk47qXBgiuVNrbnDUANCAsLXwNlk9m384HQQm6/PqcThBh0hk3oU3Fg==", "6619102d-da64-4667-8262-74f596a385f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "901f41f9-1d26-4185-93f6-0281f6b3b1af", "AQAAAAEAACcQAAAAEBn8ACg3gmAwaz9FbVsElb3AgbPHAvQ1+2/3O59yC2qM4MdI+KnZCd7VwqY3vNHyZA==", "1732a8e8-adca-4f71-a512-0230c8786982" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf5839c3-4f6f-4567-a989-6e7ee718a62a", "AQAAAAEAACcQAAAAEDZC2f+703cXJqey/ViXh6e04fF2OMBoe4pQwDZgVElQBc4VXEPwkVuUKB9C6RKsIg==", "9266c34a-f29a-40d9-b607-c760d2b7c5fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3cd5dc5e-5fdf-4a1c-936b-ff301b437217", "AQAAAAEAACcQAAAAELAxI3voB2DPrU1vrkHeuKPzBAA8dgGxAgM7Dh+9tQ7VnrA4GRyuXJbBY5YjDoB8KA==", "de37a1e1-db30-4f07-ad29-0101bc61b94d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc955a06-4a36-404a-a383-aab936058d8b", "AQAAAAEAACcQAAAAEAbnFx+UWJMpnSlixI51zjACPzsnJk7/imG+Ux82duZlnGy3VJdhedKP3FFXZAU/Ag==", "cd45f264-37b6-427c-9e80-0df042405bdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cde4689-96b7-4d34-99b6-740fe92af847", "AQAAAAEAACcQAAAAEAUXkV6qg0xbp4Kbt5SHQWFoJ2KFwvQXqvqIyxhqu52fZKcKFxsPpGwN1KzRFAMKXg==", "69e1ca09-dc0e-4943-b297-a173f3fb1707" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbcc9cfd-a841-4422-8f8a-eec6c8a4bdf7", "AQAAAAEAACcQAAAAEK58UqjIYt+eDEUFAeFRD3LDXFP6vHKoQyBS4OsTLy5nM3gOItRHI19iBZ7uomn+KQ==", "fda7f5ff-a86f-463a-bd7f-3e1a7f8a9a89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7095b921-3a8d-4f2a-a2a3-6309f6569d5d", "AQAAAAEAACcQAAAAEA9Mv4djExsPwg+OeKkqt9ag1K9WoGdAd80BN48dbWbCUQ1nroXVj9F3161foCv5VQ==", "d2b77bba-574f-4d7f-9e6a-00362a5e2c05" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "718084e2-7cae-47c1-ac38-e197e3ba4bff", "AQAAAAEAACcQAAAAEDfhh9GXH3HHfeN6ZSeTCewrhI4F31c56hcVKLgUkz2BSvgeQ2wCCt+52T34gXEpfg==", "52073ace-2ec4-475b-974e-d7f64d84471e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0afaff10-eef3-44bb-8f4b-bd6b4af8a51c", "AQAAAAEAACcQAAAAEIuQy6KE6LMxgw2FtT6j8hWubJWPkFfmH5vWzmo3lbKYXe/DGmaJtVlNs6SGzaZl5Q==", "6b9ea6f4-bc3c-4f4b-ba4f-81202a6895b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b535de08-6253-4d39-b807-1e9b257fc413", "AQAAAAEAACcQAAAAEG5Wkp5EduE8eOdGxv2XDyPTMHzMsc8B3CwTPS97T5Hiz8HRyRoDI6azrqu7JMskaQ==", "4ea51e72-55b6-4ce8-943c-0fe9faf992ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac24001d-6c10-4c0f-9f95-a69c363ea504", "AQAAAAEAACcQAAAAEBtZA0Efam3RY2Fb9Uwrf9T7T7+/NLze8jDKnBSLXgpTuADcZFWRgXvb8EhHskI7yw==", "d2d7f46d-7598-4d84-8100-28b27fcd5845" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16ee691e-9a93-422c-b1e4-41a7d29ea988", "AQAAAAEAACcQAAAAEOCVOUyaqLgCaYv5S7bgDQKE56SicFD74i+/80/AP6mYtmuy0o/FGrXSLvQXqKJwBA==", "22094e5b-9b68-48b6-a9ab-4dd1f1b80020" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77db9fc9-d449-4347-a621-2aae639eb4c2", "AQAAAAEAACcQAAAAEDxjtgOXyfebRadgt+jUQB7Qua12cUXz3osSbt4WZ0bgMu034Nii7E2p33RL89wsig==", "53a2d423-c9e4-44e2-8cce-4d75b360ee6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79c1f6a1-c53d-48df-bb34-338af48c6c0e", "AQAAAAEAACcQAAAAEBNz06CO4SiIBfVm1REOYV8H1p6I190E+p/SJBbccjjB4p2hmxEV5Om3s8PU4Qr1BA==", "61d91643-f71c-40a8-b1c6-07476065228b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8620490f-2bef-4360-9b47-8cca9c26fa5d", "AQAAAAEAACcQAAAAEPtfDX5xcCz8nV7pQpK3Nc2isglYFqdbjn90Ou5Ui9OFEKloNpoE99IVRiZI3yiRfA==", "44b18537-7b2f-4633-ab4d-b23b8594ba58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "971aab6b-d5eb-4b11-aeb2-f34f4e5b4a46", "AQAAAAEAACcQAAAAEDFcmP+BOphX4wEdU6ednSwvK3ck5hfhxOsbc2Dd31WjOz+LVvVr3+tlWgZnC/+KfA==", "9b919a14-2d09-49de-917d-6bd2d1426f0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ebf3f26-667d-4b65-b21c-1ed808d536bf", "AQAAAAEAACcQAAAAEE3Doj5bwa5Wljji6BC3EwcZJtY7df+QMGC4hl2EuxBSItPBB3PiZEIaGD5FRq+IcA==", "94638b8c-ad7a-42b5-b9d7-9676dce39c96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd36100d-4394-4102-90fe-baf8aa96961d", "AQAAAAEAACcQAAAAEN0u80JPqpyvPr7Pww8n4GCRDp+GHXDvY3wS2OdKj4mxsID/DCc6zGuDsPy/nbnvvQ==", "e429ffdd-7ce3-40e1-8390-732249ab35dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da5a543e-ca03-49ad-bb4d-ffedf7f86e69", "AQAAAAEAACcQAAAAEGrfpw8IQeO3iocx444ypHCX222gpcNVjp9kwZBKc5e1qx9/5PZOukEhN+0IudIRnQ==", "0de4ed63-5f06-48c2-a3e7-9de5d4f31287" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df0b069d-1f0c-4cf3-b194-d886def51a68", "AQAAAAEAACcQAAAAEFqa5ExB7CAKA5mZrSKCzdqcksJK67/uNzseHE4nqskC91EIsicuHXJo5e7LuA50qw==", "e875988f-7ceb-41ad-b7f9-cc428348ea01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf68eda-f73a-4b15-a5e1-8f98ffd241ac", "AQAAAAEAACcQAAAAEO6LXmc6THkzoZ9eLCtDIyeXP8yRhBNylb2Scs6+vxAT54t3P1JAcqNC+XjnbtrR/g==", "378a065c-5d64-4d33-884f-7140851eb048" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0aeb413-2655-4e28-a452-cb86b8d5f688", "AQAAAAEAACcQAAAAEDLrh+x9v0u4yt0bHHLT9SBZflHirRCX4LJZuFL6NcGsUmcQ9rN+2bVJ2zP/48xC7g==", "e576c053-3dcf-4e1d-9d2a-2cc4e036e728" });
        }
    }
}
