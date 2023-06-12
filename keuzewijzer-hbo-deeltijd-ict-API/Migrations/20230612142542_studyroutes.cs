using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keuzewijzer_hbo_deeltijd_ict_API.Migrations
{
    public partial class studyroutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "StudyRoutes");

            migrationBuilder.AlterColumn<bool>(
                name: "Send_eb",
                table: "StudyRoutes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "StudyRoutes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Approved_sb",
                table: "StudyRoutes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Approved_eb",
                table: "StudyRoutes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6c6e3152-fcfb-4f08-9128-121415e7c88a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3c974eec-80d2-4623-a4d4-4a2fac1e523d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "16b25789-9330-4b89-a854-b0aface3ce3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "69813f82-54ad-496a-8620-5bef5725a742");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e553ad-b443-4fbe-bf03-519d933278e0", "AQAAAAEAACcQAAAAEA1UG5gbk9Nfz2wTSWEbeg3XZK4ZQYYTIdy2lWiiPFv/73g8IR4ydN/1/WuMvLGcqg==", "5094c8b9-220c-4735-9c4f-7f2ec7585534" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "773c34b2-5888-4da0-8efb-fabefcefb2e4", "AQAAAAEAACcQAAAAEHr9arpfErahlqxssIi7f/niGLv9SKD3kcs453yitZlaoKm5XLC8DJC8bqZ1WP5jBQ==", "2c79329b-25e6-43bb-b381-daa544e0955e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1da5283-30d8-4cc3-9bc5-ca1a3429503e", "AQAAAAEAACcQAAAAEO8ridKEyL2BKRsSlwZ4ioM6SDTF0v6w1k6vGJ1rqOBB7nLfbcPL/7i4ABS11auJTg==", "64b1903a-f349-48b3-9c14-14418a76bd43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c8e8f3e-9eff-4b5e-b6cf-2e57ebb029b1", "AQAAAAEAACcQAAAAEBG3+Q78dr49lRiUE+q0IzaxgQctyvN+gCEd6AZsEi+qdNNPrAxxENa+gMK+kg2wiw==", "b08cc16c-18f9-4e1f-a205-043b8eea28dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b78f024-a03d-4587-bd39-752baefaa41c", "AQAAAAEAACcQAAAAEKvMHGTKobzzBlA+/ghQC8BXd548kE5tH2NBufycJKmt//a1mTY98buyI1f/2Rz1Vg==", "4b8c79ed-f43d-4ee6-9c42-26bfc10114c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4a22673-d849-4905-aae6-1fc2fdcb0440", "AQAAAAEAACcQAAAAEClGlNwga7BrWWvGtF8fRH3dzCst+0+PMz+jyLrGSyDvaXtQvl+JsvyFfPox3HRfTA==", "4980689c-3be1-4706-9613-e69f3882fe70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ae64f52-4e08-4486-a390-2b60541c13ee", "AQAAAAEAACcQAAAAEGECkGKq2FTBYpZ4x/L48YwfIWuPcl/gmK5S+8FmWrk7zY3NmT9qnQPj+PebBbIp+w==", "9c441b1f-bcf1-4d39-81f8-fa8f5540bf3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41be16af-3c5d-46bf-870c-ffe31116f9f3", "AQAAAAEAACcQAAAAEFuvD8DB1fREj8QsqFWtticGgVkGBXdaqwlxVA0zcJx2SQ5N4ImijvhbrJ0SQVnTxA==", "b976f85a-13a2-41a1-9161-c7e811db0293" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86070592-6675-49ff-b1cc-45df9f853f3d", "AQAAAAEAACcQAAAAEGbl+2xEEec0a5wBEKRv3t0xj8eEx7R9i0xIavxpXqZau/Z5GDjGjabwypC7mpF+RA==", "041b7d4d-156d-488c-8c4b-e38daec50435" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9645272e-083b-481e-9419-13b53b6e16a2", "AQAAAAEAACcQAAAAEDIf8xy9gl/PwbV7A8wPjIRfwaovfX8uvQKOLbDt3CSPePAfaODMNF+ImWF3WE+IPA==", "d78cd03d-1bf8-4131-9a55-dfd3a1575f2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "714583e5-256b-4a23-bee1-1d83fbc9c646", "AQAAAAEAACcQAAAAEBiaU5qfkRkNg6sK3v8/0DTxWLBH5RJ+GhmRIM1ht/KCw8hcVXeWbHr/k2bWiu4r1g==", "f9f73232-783c-4961-bdbb-24d29b242394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36310d0-dd86-4369-afcd-3180ba91ae63", "AQAAAAEAACcQAAAAEIZXcf64AoV1a6Mhtc4qyhN1ngeLNu+KnwNODDKSWgocBsHMyY7SON0hQP5lUgdFgQ==", "08acbaf3-4e39-4fe9-94ad-325119a3ef70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d9ad141-63c1-45b8-ad47-1d9b1eed21aa", "AQAAAAEAACcQAAAAEBtI/yJfkr1XPNC4r2P2K7N8JmhnIdoVaP3fXgeAhJhIH1SBZiiPT5DuKa8AF2iGlg==", "a9d4dfca-d198-4a13-94c3-aa7485b36cf4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "094f4e72-5ea9-4f16-9cec-a7afb94c0748", "AQAAAAEAACcQAAAAEABdMDgQsV/3upjORAS8rx8N4B6iCqgd+2cFMVNJ1EDN4rDhxFTWp9lY8Vob7ZdmoQ==", "e6d38636-6a2e-4db6-9fac-137e9cf99a95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fff34f7e-48cb-4b6c-b7d8-ea4b3f47a866", "AQAAAAEAACcQAAAAEF1vi2prf4uriPlPSxGFJxYFL2lOoIHqtAnP026D6poM4dkTF422mqz3PKO4K/dk+Q==", "c15fded7-d2f6-465b-a18a-b502a812a348" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c01c0a4-3566-4a8b-b2ad-144f6ee90c9d", "AQAAAAEAACcQAAAAEHUwij2uuvZ6l51ID2HkkCGbhPD7OdTCQQgPR6W5dxK4QhHyezWy66K/l2wi2W9KTw==", "b1e07bde-f08e-41fe-b6c6-b55f4df9ca2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59e5f7d8-920a-4788-925c-9e8531e0b004", "AQAAAAEAACcQAAAAEG/GUX0EtDzy0z9bpmPLuvAwP58iLd29I5JQ6E+LTaXbOG8hYOEFZ5rjd2vUBijOSQ==", "38d6f60c-c45d-4ea7-b26a-56454e11deba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8396b6a4-6cfd-4549-af20-fdb462cb704e", "AQAAAAEAACcQAAAAEChCkcJp5UVlkBxjS28u2X+hOjp900WhucDAGbsJ392NcM4SABZQLk7HRNyw49u3Vg==", "d2edc8b4-4b39-481b-b1a0-77ec814d0013" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "826b1be8-9f6a-48f9-85eb-5328fad2a0ad", "AQAAAAEAACcQAAAAEEcJIpfraDNcjP8stCzQV5PhnQgnXpCb7Wh/w8ZATq7aRZpLzlQRWsmxgUv1Q53RTg==", "0d866eef-3e62-4951-b056-b9382a95ff9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "182d00e5-50f9-4ffd-b923-477662225ee8", "AQAAAAEAACcQAAAAEL+UazYVFrZ2hALtgfFV2MKH8kKvR+3l4trglO5bsZpEYSbCgfKOWfnurJ3g+DJ2/Q==", "63021d81-85fd-4c97-9851-34ee47902505" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c358fa03-6b87-4899-a02d-52c7cef12a57", "AQAAAAEAACcQAAAAEPW5z4m8RF6tNa/aQglECXUWWuArbJeHi+SqKihma8DVy5s5inhthNUow3cx6e+0jw==", "5aae99a3-7049-4365-bcad-13773b5b5c73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0cd0ca-25f5-41a7-a04d-0aaaaf273112", "AQAAAAEAACcQAAAAEPbkCiUpv/jNcaRFHf6/ddeaR9efu+UTp791D980BoG28PTBSd2FZp+5o+7Og09UCg==", "2e9ab9f3-49da-4e0f-9911-ab9007b7fec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55d6541e-a0c1-48e1-b5bb-eea26f098cd2", "AQAAAAEAACcQAAAAEN1UdFD0iFy4eBbuvIwaYgjZsZkQ+hs4sGecarbSN8d7r1Qq5WXywHSG3LJymBfEAg==", "7f14ac54-4f69-4bf0-a37b-a2206b95e9d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ce98c3e-1905-4330-a79d-3556a8ed5362", "AQAAAAEAACcQAAAAENwcUSgdELYhU2ZlVE+z+rZRuZdyw3N0F1rUbxmJ2PvLPnEfAuSVnVsonZEKk8p1jQ==", "fc52844f-46a7-40d5-8d86-bb479d8eae03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e3b0a46-b32c-4fd3-bb6b-ccbc642287e9", "AQAAAAEAACcQAAAAEDH0lRJF6qyB6EbD3KO7TBnBPGq3hEDNRidUtgIjlsMQFue7vz1IkoTLaYsU2ERYyA==", "787f8e60-4057-4a01-a665-21e1c873cb12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47640b9b-64b2-4e2e-a151-1922d4d641ae", "AQAAAAEAACcQAAAAEOTcz1xwtoBk6aoxc8PrVn3m/hiAyvHJkMapk7YSZjeC4/w2Dauwuw9Aitq8kD5cAQ==", "92caae5d-1f8d-4524-b6c5-db60187e3c1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c468835d-7f73-4512-9213-27b8ebe6086e", "AQAAAAEAACcQAAAAEIv82N0upP9pSNRNlwxb90vVMosqznEGPyj+wDjvh4bC7sIMup9CUQ0jjqBa1+Cvig==", "7fb66f54-879d-4ec2-84b1-b6fdb61292bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba8c9fc1-93e9-433d-96de-0a7566ea4ae0", "AQAAAAEAACcQAAAAEIEnq7bL9CPYTpzRUYp5DYViH/hoYsjb/1hSfFgL30tTcnbFpz2dfvLjhCsoyY0VjQ==", "b0979bf9-00e7-497e-9838-0e5be2f5e50a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0244b2ca-a8b2-43e3-86ab-7b749b3c5580", "AQAAAAEAACcQAAAAEGZC/6XDyf0sQDIg0rqUFK2SmjkyHA1bpUHxKvaqIyeQgYdP7hjXdXHGsg/8fGH3Yg==", "b4340dea-f1e2-4df0-9e07-dd9b23ef48a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b0ec82e-1a92-4782-9542-1f84e47ed128", "AQAAAAEAACcQAAAAENId99X9QnUWWc24Nafk/F4SorQI6JxYMDZTGg6Y35U7wrYmxaPJuReIqMhgp1ikNA==", "ce18cd27-4ef0-4c3d-89a7-4be55abb3a15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a07d73e4-5929-4d95-b7ee-86303082cfe5", "AQAAAAEAACcQAAAAEARsPQEidnxB6dGQHMtRaPXBNqdY3f4t6GY5oj2iO9ltMBXy67qDJOmG8pL5+TNLaw==", "b727ca70-bfe3-4102-810d-17f3950d6b04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7fb1088-f413-42aa-950e-b9ce25d09b88", "AQAAAAEAACcQAAAAELeOLZhrXMCQx/z8N+nean7cG67xtMvtBmY5IX7UpW6Vh1VARKfPHc9nrCOCzhrCMw==", "24535acc-0cef-4da0-97c1-b7a1593babdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00aff851-009b-4860-8459-2343e9f64960", "AQAAAAEAACcQAAAAEEV0W+L6dg1Yzx9vwuUKKXakUedrI0s23P6C0uq/hhX57ySpNCoRlvSL+NYvItjnvA==", "096c35ef-c36d-4f03-85de-8db1603c6c41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78c36b09-e094-45d3-b074-88e6ec72740f", "AQAAAAEAACcQAAAAEOXS3Yoid2gDriWvXeTitRIKnFiyxN+B4NCRxC4YI6OVUklXGyTbcK89mOaebELRuw==", "5ef3c489-8f05-4bdf-8a65-c3656258b6ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eafdc32-7e57-4109-9e93-59be7824fc70", "AQAAAAEAACcQAAAAEIZ+byzozkivyeeTC9xs4EdzmwB2fAY6P2z/06yy5g18f33pYZxiOzJx6LnlItHswg==", "fb7df269-7735-407e-89f8-deca1677ab6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc71262f-6e38-43a5-9896-9a9e45338e0b", "AQAAAAEAACcQAAAAEFYrq2Ufp7MuMK931NjNcURK6dkeVZBJx9n+8DWWp+j9xTXEPnDv6GJ7cL+CelmQRA==", "4902c18e-4fb5-4dd6-968b-eae968366fca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "923f75ff-4983-4581-ae96-f35edf8d356e", "AQAAAAEAACcQAAAAEDFX4ztVzR232GzavtTZh4EuraGhdstdxOncVSFA3ojnBb/9wgPUBf8c6r+/1jnd4A==", "9bb477d5-f82b-42d7-8304-2cf1fd3ebd14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dba5f5d2-04ef-47be-9e6a-4e46162ce5df", "AQAAAAEAACcQAAAAEMYV9NJdKNwjp9x51V9pfpBi7yd21Hjm2zotZq784hleqbaK+boChEjvm2tK7CfVzg==", "e8a92d4b-2451-469e-8b1b-6b0617a3e826" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f8d0955-3f1e-444b-9bf3-d30ace64a62d", "AQAAAAEAACcQAAAAEJ83+V5AZZRn8cyx1RRy9Z/MiM6uEqhShGGj3pCwcDOsQOERKTBSZo8PegaXL0HdsQ==", "46e33449-c58e-44d3-b596-15552e04f47c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04ba2c65-e3bd-414a-892f-a66a1abd8007", "AQAAAAEAACcQAAAAEDc+RrilSDYGrkP6+WvL5OFdYtMBmjyviLkv4QWk4cLj6rt1EVjexcGQzDxBDmnAqw==", "772e6f45-b841-4a0a-95d7-0ad7399b2174" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "555ee89c-f05e-4a9f-a9ef-5e5c612e0f8b", "AQAAAAEAACcQAAAAEKehEoPy5wOE9iGO1CDs6h8mIrAlFe/7aYEJTxntrQOeGSkNL0ySxJkmlqPYM0v8MQ==", "2f31d8c0-46f5-49a4-82e0-46be3af7a2d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7e11875-8e70-44d1-97f9-c5b7f83781b7", "AQAAAAEAACcQAAAAEHLnZMWm6IJfwvrDags/8DKrJHrcBw8AoLBs+WYilKE9lV8mfkVKJ0zpQcBh16sLvQ==", "de9a78bd-b62c-454a-83b9-199a3b5ec0c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90535313-aa81-4764-a88a-7c20e04f4b0b", "AQAAAAEAACcQAAAAEKFmUISLg5/2WR5f0zdPV2AFa56LGrQVnQ1wjFmDdC3vv6O+Oo8aZfwijaErpjtTzg==", "380561fe-d840-4719-b7ce-0df817d7ba61" });

            migrationBuilder.InsertData(
                table: "SemesterItems",
                columns: new[] { "Id", "Description", "Name", "Semester", "YearJson" },
                values: new object[,]
                {
                    { 5, "Description for Semester Item 5", "Semester Item 5", 2, "[2]" },
                    { 6, "Description for Semester Item 6", "Semester Item 6", 2, "[2]" },
                    { 7, "Description for Semester Item 7", "Semester Item 7", 2, "[2]" },
                    { 8, "Description for Semester Item 8", "Semester Item 8", 2, "[2]" },
                    { 999, "Reparatiesemester", "Reparatiesemester", 1, "[1,2]" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[,]
                {
                    { 4, null, null, null, null, false, "4" },
                    { 5, null, null, null, null, false, "5" },
                    { 6, null, false, null, false, true, "6" },
                    { 7, null, false, null, false, true, "7" },
                    { 8, null, false, null, false, true, "8" },
                    { 9, true, true, null, true, true, "9" },
                    { 10, null, null, null, null, false, "10" },
                    { 11, null, false, null, false, true, "11" },
                    { 12, null, null, null, null, false, "12" },
                    { 13, null, false, null, false, true, "13" },
                    { 14, null, null, null, null, false, "14" },
                    { 15, false, true, null, true, true, "15" },
                    { 16, null, null, null, null, false, "16" },
                    { 17, null, null, null, null, false, "17" },
                    { 18, null, null, null, null, false, "18" },
                    { 19, null, null, null, null, false, "19" },
                    { 20, null, null, null, null, false, "20" },
                    { 21, null, null, null, null, false, "21" },
                    { 22, null, null, null, null, false, "22" },
                    { 23, null, null, null, null, false, "23" },
                    { 24, null, null, null, null, false, "24" },
                    { 25, null, false, null, false, true, "25" },
                    { 26, null, null, null, null, false, "26" },
                    { 27, true, true, null, true, true, "27" },
                    { 28, null, false, null, false, true, "28" },
                    { 29, null, null, null, null, false, "29" },
                    { 30, null, null, null, null, false, "30" },
                    { 31, null, null, null, null, false, "31" },
                    { 32, null, null, null, null, false, "32" },
                    { 33, null, null, null, null, false, "33" },
                    { 34, null, null, null, null, false, "34" },
                    { 35, null, null, null, null, false, "35" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[,]
                {
                    { 36, null, null, null, null, false, "36" },
                    { 37, null, false, null, false, true, "37" },
                    { 38, null, false, null, false, true, "38" },
                    { 39, null, null, null, null, false, "39" },
                    { 40, null, null, null, null, false, "40" },
                    { 41, true, true, null, true, true, "41" },
                    { 42, null, false, null, false, true, "42" },
                    { 43, null, null, null, null, false, "43" }
                });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 2, 4, 1 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 2, 5, 4, 1 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 1, 4, 2 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Semester", "StudyRouteId", "Year" },
                values: new object[] { 2, 4, 2 });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 5, 1, 1, 5, 1 },
                    { 6, 2, 5, 5, 1 },
                    { 7, 1, 6, 6, 1 },
                    { 8, 2, 8, 6, 1 },
                    { 9, 1, 4, 6, 2 },
                    { 10, 2, 2, 6, 2 },
                    { 11, 1, 8, 7, 1 },
                    { 12, 2, 1, 7, 1 },
                    { 13, 1, 5, 8, 1 },
                    { 14, 2, 6, 8, 1 },
                    { 15, 1, 4, 9, 1 },
                    { 16, 2, 5, 9, 1 },
                    { 17, 1, 6, 9, 2 },
                    { 18, 2, 8, 9, 2 },
                    { 19, 1, 3, 10, 1 },
                    { 20, 2, 7, 10, 1 },
                    { 21, 1, 5, 10, 2 },
                    { 22, 2, 6, 10, 2 },
                    { 23, 1, 8, 10, 3 },
                    { 24, 2, 4, 10, 3 },
                    { 25, 1, 3, 11, 1 },
                    { 26, 2, 8, 11, 1 },
                    { 27, 1, 5, 11, 2 },
                    { 28, 1, 7, 12, 1 },
                    { 29, 2, 1, 12, 1 },
                    { 30, 1, 3, 12, 2 },
                    { 31, 2, 2, 12, 2 },
                    { 32, 1, 5, 12, 3 },
                    { 33, 1, 2, 13, 1 },
                    { 34, 2, 7, 13, 1 },
                    { 35, 1, 5, 13, 2 },
                    { 36, 2, 8, 13, 2 },
                    { 37, 1, 3, 13, 3 },
                    { 38, 2, 6, 13, 3 },
                    { 39, 1, 6, 14, 1 },
                    { 40, 2, 3, 14, 1 },
                    { 41, 1, 6, 15, 1 },
                    { 42, 2, 8, 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 43, 1, 1, 15, 2 },
                    { 44, 2, 4, 15, 2 },
                    { 45, 1, 2, 15, 3 },
                    { 46, 2, 3, 15, 3 },
                    { 47, 1, 7, 15, 4 },
                    { 48, 1, 6, 16, 1 },
                    { 49, 2, 5, 16, 1 },
                    { 50, 1, 7, 16, 2 },
                    { 51, 2, 3, 16, 2 },
                    { 52, 1, 1, 17, 1 },
                    { 53, 2, 8, 17, 1 },
                    { 54, 1, 5, 18, 1 },
                    { 55, 2, 8, 18, 1 },
                    { 56, 1, 2, 18, 2 },
                    { 57, 1, 5, 19, 1 },
                    { 58, 2, 3, 19, 1 },
                    { 59, 1, 7, 19, 2 },
                    { 60, 2, 2, 19, 2 },
                    { 61, 1, 4, 19, 3 },
                    { 62, 2, 6, 19, 3 },
                    { 63, 1, 8, 20, 1 },
                    { 64, 2, 5, 20, 1 },
                    { 65, 1, 2, 20, 2 },
                    { 66, 2, 3, 20, 2 },
                    { 67, 1, 6, 20, 3 },
                    { 68, 2, 4, 20, 3 },
                    { 69, 1, 4, 21, 1 },
                    { 70, 2, 6, 21, 1 },
                    { 71, 1, 1, 21, 2 },
                    { 72, 1, 6, 22, 1 },
                    { 73, 2, 4, 22, 1 },
                    { 74, 1, 7, 22, 2 },
                    { 75, 2, 3, 22, 2 },
                    { 76, 1, 5, 22, 3 },
                    { 77, 1, 3, 23, 1 },
                    { 78, 2, 4, 23, 1 },
                    { 79, 1, 1, 23, 2 },
                    { 80, 1, 8, 24, 1 },
                    { 81, 2, 2, 24, 1 },
                    { 82, 1, 6, 25, 1 },
                    { 83, 2, 5, 25, 1 },
                    { 84, 1, 7, 26, 1 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 85, 2, 8, 26, 1 },
                    { 86, 1, 4, 26, 2 },
                    { 87, 2, 1, 26, 2 },
                    { 88, 1, 5, 26, 3 },
                    { 89, 1, 1, 27, 1 },
                    { 90, 2, 8, 27, 1 },
                    { 91, 1, 7, 28, 1 },
                    { 92, 2, 6, 28, 1 },
                    { 93, 1, 5, 28, 2 },
                    { 94, 1, 1, 29, 1 },
                    { 95, 2, 2, 29, 1 },
                    { 96, 1, 3, 29, 2 },
                    { 97, 2, 8, 29, 2 },
                    { 98, 1, 6, 29, 3 },
                    { 99, 2, 7, 29, 3 },
                    { 100, 1, 6, 30, 1 },
                    { 101, 2, 3, 30, 1 },
                    { 102, 1, 4, 30, 2 },
                    { 103, 2, 1, 30, 2 },
                    { 104, 1, 2, 30, 3 },
                    { 105, 2, 7, 30, 3 },
                    { 106, 1, 5, 30, 4 },
                    { 107, 1, 6, 31, 1 },
                    { 108, 2, 1, 31, 1 },
                    { 109, 1, 4, 31, 2 },
                    { 110, 2, 2, 31, 2 },
                    { 111, 1, 8, 32, 1 },
                    { 112, 2, 4, 32, 1 },
                    { 113, 1, 1, 32, 2 },
                    { 114, 2, 2, 32, 2 },
                    { 115, 1, 5, 32, 3 },
                    { 116, 2, 3, 32, 3 },
                    { 117, 1, 7, 32, 4 },
                    { 118, 1, 3, 33, 1 },
                    { 119, 2, 6, 33, 1 },
                    { 120, 1, 4, 33, 2 },
                    { 121, 2, 5, 33, 2 },
                    { 122, 1, 5, 34, 1 },
                    { 123, 2, 7, 34, 1 },
                    { 124, 1, 1, 34, 2 },
                    { 125, 2, 4, 34, 2 },
                    { 126, 1, 6, 34, 3 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[,]
                {
                    { 127, 2, 2, 34, 3 },
                    { 128, 1, 8, 34, 4 },
                    { 129, 1, 6, 35, 1 },
                    { 130, 2, 4, 35, 1 },
                    { 131, 1, 5, 35, 2 },
                    { 132, 1, 4, 36, 1 },
                    { 133, 2, 1, 36, 1 },
                    { 134, 1, 8, 37, 1 },
                    { 135, 2, 5, 37, 1 },
                    { 136, 1, 1, 37, 2 },
                    { 137, 2, 3, 37, 2 },
                    { 138, 1, 2, 37, 3 },
                    { 139, 2, 7, 37, 3 },
                    { 140, 1, 4, 37, 4 },
                    { 141, 1, 1, 38, 1 },
                    { 142, 2, 4, 38, 1 },
                    { 143, 1, 5, 38, 2 },
                    { 144, 1, 6, 39, 1 },
                    { 145, 2, 5, 39, 1 },
                    { 146, 1, 2, 39, 2 },
                    { 147, 2, 3, 39, 2 },
                    { 148, 1, 8, 39, 3 },
                    { 149, 2, 7, 39, 3 },
                    { 150, 1, 1, 39, 4 },
                    { 151, 1, 7, 40, 1 },
                    { 152, 2, 3, 40, 1 },
                    { 153, 1, 2, 40, 2 },
                    { 154, 1, 4, 41, 1 },
                    { 155, 2, 3, 41, 1 },
                    { 156, 1, 1, 41, 2 },
                    { 157, 2, 6, 41, 2 },
                    { 158, 1, 2, 41, 3 },
                    { 159, 2, 7, 41, 3 },
                    { 160, 1, 8, 42, 1 },
                    { 161, 2, 1, 42, 1 },
                    { 162, 1, 2, 42, 2 },
                    { 163, 2, 5, 42, 2 },
                    { 164, 1, 3, 42, 3 },
                    { 165, 1, 2, 43, 1 },
                    { 166, 2, 6, 43, 1 },
                    { 167, 1, 7, 43, 2 },
                    { 168, 2, 3, 43, 2 }
                });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 169, 1, 1, 43, 3 });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 170, 2, 5, 43, 3 });

            migrationBuilder.InsertData(
                table: "StudyRouteItems",
                columns: new[] { "Id", "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 171, 1, 4, 43, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SemesterItems",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SemesterItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SemesterItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SemesterItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SemesterItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "StudyRoutes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.AlterColumn<bool>(
                name: "Send_eb",
                table: "StudyRoutes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Note",
                table: "StudyRoutes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Approved_sb",
                table: "StudyRoutes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Approved_eb",
                table: "StudyRoutes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "StudyRoutes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59854608-15d7-4596-a1e5-e221a3064ca5", "AQAAAAEAACcQAAAAEMg/jYMYZPsiK5l7GIpZtzpc8ptHgQnB1giFVwkMCE/PPq7jMMeDiFZMVcPQrmZOHw==", "2dc449a5-4eae-4d76-aec2-855f9c77e3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b84b040-f668-4ace-af15-a9249bdbfc7f", "AQAAAAEAACcQAAAAEHxGpoRdRLFGBBpghDcXLasfLFUmTnOip4lMaCWmmwFFMLaD7qFQFnMvsDgzdno24g==", "7787a0c7-1b30-4a60-b3d1-6341e60c28ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ced67c7-706a-4bb0-bfe0-4933727648cd", "AQAAAAEAACcQAAAAECd9koB6HCXye3Jxuz58zEVaTIr15h62UCibo2ekpoiLpF/xd+HuAtv/TKv7FshQDA==", "27c91780-7457-4843-a237-88218b911c2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e404aa7-60df-4fc1-b877-205d8ca33109", "AQAAAAEAACcQAAAAEJhHjuaH0o/8aXSKgNJ7vL/cRd6rHzTKjQAyPqJi++D3QufIpXW/mVE1k7bmLafMyw==", "c46c241e-62bb-4516-9602-583eddf15896" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c6ee1a-ea00-450c-8020-316a7f4be5e8", "AQAAAAEAACcQAAAAEIq4ruBBm4wff1MHmgIHcre/zT3VSj+X2DHYWWtkciR/1q1Whb0nHUcKTR+O4sgrsg==", "a3ef1747-2d84-404a-96cf-1b5f81d1b5dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09c0e1f0-fe55-4c96-8f2b-97f608bc6e66", "AQAAAAEAACcQAAAAEJDR6qRaahtz0v9bIyv1UzQQq6aDRl5JZBUjBlCE8vRXHNv/mDNyUG/DIQh/JZOxmg==", "764cad79-0da3-4366-af6a-4446f6145692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75d92c65-cea9-41fa-a779-27bf84f9eba1", "AQAAAAEAACcQAAAAEFEaBBpIz1mOnTrvG2zAULOsW1h6IyL8H66IovGVzrAfNMST+BJNTz0iL0uAL72XcQ==", "3e6a7de9-c017-4ddc-bd1f-b9ca2eda5db4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b62175df-d3a6-4605-8d71-5dac44a20aaa", "AQAAAAEAACcQAAAAEGZOBLLxptiwCV98+i8LZqvoYya7jPZrNLMTKeLlZDYVAKHYwEdyD4WBFpK0whilJg==", "203a5f0e-a895-49fe-ae91-5e142705d2cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e67a55-8858-4086-ba27-4100dee79b6c", "AQAAAAEAACcQAAAAEFxy2MOO6NEn1KCrgPuSuu1RH8Av+3YDVEaVsUa9iiFM2ZfZ1bQ67D28kDIZ+WGWfg==", "44ca0d1c-8c74-4e24-bf9d-5ee3c6343bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb92d808-6aa2-4843-97fc-01fcab67c73c", "AQAAAAEAACcQAAAAEA1RuSPHCpuIe2twIW8hoBNKKneitczsv5R2XkYV4eB4asHiVunHUPnJB3ySsbDeTQ==", "91dd5f35-79d0-4e0f-9d62-1545e96abba3" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab082219-9ecb-4509-97bc-7c6aa24e6661", "AQAAAAEAACcQAAAAEP0J2UfIFIYJr5CLrKdCxkcUCqAuEV30jtPuTLC7YPsRJw+ylSgPE6kNEFUdoRkv4w==", "2ff55fc2-d773-4e92-9de3-7a48e177eb26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccd90cd0-e4d4-47c0-9a1d-fe54bd1b1ea8", "AQAAAAEAACcQAAAAEGP0K10XHouaBC5hOoLmn02X6asNID8owj+z0jyydJELiRPLFXq2t4fmvh9DCfDyyA==", "cf101b6b-e30e-40f9-b450-4a5d390b2c78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0dd9c3c-0ea2-420d-8d04-224c9aba0ae8", "AQAAAAEAACcQAAAAECUuRar2ZtIUG49qCBGvL/k7wfBsg1smNgkpjNXPU2UR4ADgK+7bob4fY0hmnOJqXA==", "217061dc-6f60-405a-9b78-b448ab69e667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca9017a8-a69d-47c0-bcec-8eae3524d24e", "AQAAAAEAACcQAAAAEJvdGnVaRoFYrFthfY/MGi465lPWuOWC6at6kZKpo1LcjJ97BfPj+YpvvLiKqjhH+g==", "2946b339-a2ab-43d4-bcd5-27d8c5378a20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fcaaaa9-ea64-44cf-9518-9e80f784513f", "AQAAAAEAACcQAAAAECPVXwgBBOkoDsZx36NfzXDTGeIrftb+NNX9q3Ks2N/ykbl99kHHATech1BYZIfeyg==", "109d80c0-8553-463e-91df-81715424e693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541f3834-7255-465b-8f5a-ba7fc1023a30", "AQAAAAEAACcQAAAAELBjl5Y1eiuP6GcriZZrshLyYnRZgIiKWZqJQGpMsvms4ba00NWfnkIkkR7kBWHDow==", "c9dc4055-a329-4f87-900b-a7a1783cb5cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64da7893-7e19-48f4-a315-636533918e00", "AQAAAAEAACcQAAAAEP1q9xui/Eopxrf7loVphzBusgzRETh9XJaxEJRQxac1zq6BW3b3M89gkbsjb/FSHg==", "08159233-5f42-454e-b1d2-002da6ad294c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c12daef-3e01-4bb6-a220-907130c5366e", "AQAAAAEAACcQAAAAENijXjxKyXgJsc90kHQGpATClRiZeZi2fvq0VVgOCIjbvdasjJdIY7vxC32obx/aCw==", "7a0eb7dc-0ba4-45f2-ae30-c00d473b8243" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2465fb79-cfa1-4c4e-a17b-5d88d23211f4", "AQAAAAEAACcQAAAAEALAfsSBv5s4zIysBoVgGYX5RLECEqEwcMLLjYuPGNuzlJrTH4pMwe/ZdyV3da9EmA==", "66d9989a-122a-49cc-9ec2-0a057becb6e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cb7a2b6-4d6d-4214-8c20-d2d3c10e97aa", "AQAAAAEAACcQAAAAECqr3OAM6EGBTIZJderxUP6VLPU8Tt+WRMMITkccFNDGnlV+7fvf34MOfZhJNo2LsQ==", "12fcef0b-b52b-4bb5-b27c-a14320d504a4" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "170697ef-313e-4fbb-b783-8ce0661d8388", "AQAAAAEAACcQAAAAEDVsvGLa4bhdtK8wCI9S41eC8TPOQr8XywgOUyI7Nr4g8jOQPBFIQ/RVEJL5l3HTgA==", "b7ddbbe8-6c24-478d-ab78-4a6e78603273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a38f524-aad3-4f04-9b9d-dc5f86ff5f71", "AQAAAAEAACcQAAAAEFcNln4PRYwMgZnJ3JO7DkMNyZTsMBWo9+IucLMombwPsenFoy5b5PEXSEsqlXfF4w==", "fcc23d04-c339-4497-b39a-318aaff02fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e670b005-54f2-4fc2-9f1c-5e1b32852860", "AQAAAAEAACcQAAAAEETTzLlMXpGkZt6eqM86XST0GT/o0BhkarbV7OGUycUMoBopOApJWjqjmAQd6VlYcw==", "b44d2fc1-0ae3-4905-bfb1-1818b7dd48a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3766a7b3-f093-48cc-a010-b67ac31249e5", "AQAAAAEAACcQAAAAEMqR3tKoXDqPJQhnfxww8VVb/v5UmF4WU2fP7DgRrkxL/Bhu7NKPUbk3afI7fYJXlQ==", "6ad036ac-d60e-4079-9a97-25a43cf1ff62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35fb4b1-50c3-4433-b8c4-7561e8d3c133", "AQAAAAEAACcQAAAAECPYXcH/2HzdEqf1JRa63ddZqYpG9J9vRhP6NgjSFVM7sssBC6TCqoUSE7HwPH3feA==", "9bc7029e-e98d-4035-bb19-870f74e7df26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68677fd7-cdb0-41e0-8382-72fa31392083", "AQAAAAEAACcQAAAAEFkiTls8LstKlR7jmrRJDKVpKZQ3RRzAft+utfDn/cGqmWm9pdowAcFckYU5J/ehbQ==", "2a480e96-01a8-4aac-8d8e-25654c5b2b6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24672270-efe2-45c4-a8a8-e3d9354e4ce5", "AQAAAAEAACcQAAAAEONakbrqrEckcTUv3+mHSxgvmZCcvsQSj0DvKnUzD4RkdDhPiC0Rt97NOT/96ymP1Q==", "e8ea7e9b-084d-4ddb-8f35-ce5b839220b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec357fa4-7e11-4e42-b86e-e0ec4311b239", "AQAAAAEAACcQAAAAEG+nv4ivipFBKCVjxw4/8xojDKmZOp/J+nC1klzpz6Yr43geaaJcZnNJL35ze7x1oA==", "9d8b74e6-1c46-4c5f-bc36-50c421767d0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9efb69f-8cf4-4d47-9c9b-10dbb5626325", "AQAAAAEAACcQAAAAENkwZTL/a8mH/E7HncuEwe8zImd5/gBphZtyGVXZWAKfVlJ1wsKuIUHhzoLol9hi3A==", "ccc6a722-5de7-49f8-9ba4-fb685bec167f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7017f9ff-e5b4-4988-9f49-1a0a4c77f7f5", "AQAAAAEAACcQAAAAENeRHzUoyFGz1LoKnEqO7auCDZsq14iRket63+VaZii+1/axulLUBIErlLNMiDLRIA==", "7e3f56f8-0140-4e69-959c-048d0cddac95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b57e8bb-6ce6-454b-8ea8-f5799cfb8c90", "AQAAAAEAACcQAAAAELpWuq4duuVFwEYJojomKABpWDHZNNhM8hIuTlto/Q5A4Yu5k6PbG9RKRc7OCV2/Vg==", "871bcd48-6d97-4679-8b03-9d417cbd1991" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd12d42-5b22-493b-8a3e-53732c508d73", "AQAAAAEAACcQAAAAEMls5IUZu0qh8qHzTVr8NvhQifagdfNy4DnZ8+bYTizVPu2+jPwYs93pp+CSh8ap/w==", "701b6224-ea22-4bba-8d17-29cc710c0d44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99bbeb1a-2b04-4238-9d72-f3f561303732", "AQAAAAEAACcQAAAAEN9O7MjbQZ5AFh1daiI7/bzphXj9x9wOIvt1PavhjLhPJYuEEOeByl0c8nVerAhPCQ==", "f9fd87c8-5597-48d9-bcff-7871d6bf13ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b92456-40e8-4d30-8c0c-97c0b6fc99b3", "AQAAAAEAACcQAAAAEKRZFBtt6BWnOFiFQCp6t/+vdeo4ueO0IwyiSS+7LA4eztD1ysxUnBXx4qVGcjfniQ==", "3d3963f3-d38f-465a-9344-c5009c3a42d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46208564-8bf5-4596-8d09-9cd4572558a3", "AQAAAAEAACcQAAAAEHiu9SPWHTeSYC2j+EQoWqkZeNlgmRldFajzCeLIEq59EHB7MmNW3UYawpiy21lSYw==", "08f5ae92-2760-4533-a901-effe959c6f96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b6c274-469a-40f3-bdb0-fa10bd1a5d9d", "AQAAAAEAACcQAAAAEPV8/qAf3vu/dOJByK3wZxmUH0vGeDVj1pG+ysHQ45SA5vxSwoiNvgHIUZJiAfOxUQ==", "35fc1d2e-c758-442e-a579-62fd701221a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "683d3bd4-5aad-4035-bed6-070cc409ba38", "AQAAAAEAACcQAAAAEIZgWdRFWhY6IIkHZxV6KNgOSpA7OQ1hMlWjDjU4lgGHzQHoQSEguWyV5yJYEylcrg==", "e355f232-41fc-45c1-9651-03d96f9f8141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3800e097-18a2-44c0-85c4-3f9ace04a242", "AQAAAAEAACcQAAAAEOodB3lLNzZQOd63S5+L9w/+T1jl9v8TkLn9V44p6LBS7PnLe7bf7Ub5Ke/J/UpTsg==", "a40b1ee0-2b43-4da8-a952-fee6ec50ac42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e35bd108-d169-4dff-8878-049a0496772a", "AQAAAAEAACcQAAAAEGg/5YT8tSLhOXSqSe9AwHfdsRbqm1bZjHihlYBiw5tMSP2VCM7nYMnmImM6Jh7J6w==", "a839d3d4-969a-49c3-89a7-fbb87736bf9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a66f8d4-69b5-4cc7-9e25-2f596258e863", "AQAAAAEAACcQAAAAELCVqSU9WBwXGWVQsa51+O5OmBISX1flDG04LJFjYeUddPJUI6dBtErBCpH4zz3nkQ==", "3b54209b-b673-40d0-b314-41ad36465303" });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Name", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[] { 1, true, true, "Computer Science", "This is a note", true, true, "1" });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 1, 1, 2023 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Semester", "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 1, 2, 1, 2023 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SemesterItemId", "StudyRouteId", "Year" },
                values: new object[] { 3, 1, 2023 });

            migrationBuilder.UpdateData(
                table: "StudyRouteItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Semester", "StudyRouteId", "Year" },
                values: new object[] { 1, 1, 2023 });
        }
    }
}
