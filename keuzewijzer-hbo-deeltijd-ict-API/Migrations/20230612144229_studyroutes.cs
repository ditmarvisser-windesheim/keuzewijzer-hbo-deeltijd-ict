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
                value: "de803e5a-305f-4085-af8d-c105c004d606");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "8180e354-86eb-4395-8cfc-98017ee53aa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "f9dad75a-2562-45eb-954e-f2f1a6485fa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "549dcba6-0cfa-48da-91fb-67c9c54a62ad");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "724cedd0-7714-4dfe-b5a3-0800437d187e", "AQAAAAEAACcQAAAAEKS0YsoB9O1rZ8C8TDZxcJbOw/TL7LJqH5miltYAQojrrJknvJIr4kD0SHZBzYXmYQ==", "af62ba20-3c90-4fe7-9e3d-ef919969e6ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95853f14-74f4-4e9e-afde-9390d228b20d", "AQAAAAEAACcQAAAAEMMoy0qWHl+9qnmd40aoOsTFzej4xv8gTdO/VdUFzIrniCDMh0ozS7MKFG3wnFhbLA==", "037c6fc3-5ef9-42ab-9a4c-0ea047ebdfbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f14e040-24b4-4f03-82f8-ed459bad57db", "AQAAAAEAACcQAAAAEFilVMyBK9irHoeKpQXaRuRhpweRWN73pF2GpAHcKJC7KI0b2lvOEl2uSaf57AZoAg==", "4c488a52-5acb-4a31-918e-9737e0001890" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63222b38-8a9f-468a-8861-e78a10a76bc3", "AQAAAAEAACcQAAAAEGNgR90Qu01L773NIghFQLdJSkoXunnW+LG35AAW+vp2oaUTr9nOIIvBqB54Tw68UQ==", "b5062e6a-90ba-4fae-a383-2c383804985f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63665e4b-2b0d-4ef8-a4dd-f031b53d7695", "AQAAAAEAACcQAAAAEMEW9KFzV3rfeqBCmbdGLdWkZEkO7eC7XYkOwo0NI2ZcJmGu+V2lYZZAob15ftsfdQ==", "24fee9e7-8af3-4976-b49b-82abb3af51de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5362f944-2c60-4447-bed1-c24e640713d0", "AQAAAAEAACcQAAAAEPdop4IivZ6eWA98Sm4xdjaGH9UApg9OWTdMRWJdi8yT+Ax4JAemZoLqtDTXEiv85A==", "961ce991-d329-4192-9fb8-913ac9d417ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9356e5f-f0dd-47c1-833a-f5f9bc990de7", "AQAAAAEAACcQAAAAEKJwS8+SJrrT2bC5dmioGi05WIxZO3rVmLbLckVRVwCxQ16n23NpQs7P8F0bv9uVqQ==", "8c5be569-e4d7-466b-890f-3ca0f87c978a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa7ebba3-1b00-4966-afb6-5f0cbd07041e", "AQAAAAEAACcQAAAAEORklJcIUtzHEg+4i7vXHQLA8goyFswJosMOYCvjWg3hFj+ETua0OrX6bc7xYCXz6A==", "3bd85c8e-d361-4c2b-9757-cf04f0fbfa90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5c41fc8-b734-4fb4-97d4-11b0076566d3", "AQAAAAEAACcQAAAAEE448col288G5gv6iJeYAPDDfEbyP6j15/2nJdDDXrNXReOoHNCZ3CpxtW1x9dDoGQ==", "d14d87fd-7e6d-4eed-bcd6-27cacc8c9623" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f3be09e-28c0-4792-976a-d40ed1e29505", "AQAAAAEAACcQAAAAEHLlvIExrV/istjgEycyOLeHSgvTFgUmlyKWbHiGDtiWnw6u7Vz9Em3aIxIQ76z39w==", "6d3f1113-89a3-4192-a5d1-c63a2ddb0194" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41b91ec-73a4-4ee1-8636-8e02f5ed1f50", "AQAAAAEAACcQAAAAEMcpSUqc1/u5jTBikVpjDd4jBD1tS22qx5ldzaa1emnUQoVGb2LMrOQMgZ+yuglxxw==", "97334975-3967-4460-b9da-0e1ba1164305" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bec7d7a6-17ab-48f6-a44e-0dd2f48b2c41", "AQAAAAEAACcQAAAAEKdsUy35c4GgCNoAPEGkyzarl8K9kXRNUK42D/nm/CNc9WJ478tHiq1ftruMvQ+Vvw==", "cd074a37-0c33-42a7-b5ac-859cd938a01f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17719d71-c0fc-463d-a2e3-ee02a84f6654", "AQAAAAEAACcQAAAAEPS7VibFdF6ttOFlboSTSSgxuSHgc5E320rX2cMs9l5F7FP04KxNwNwK+Qr8qDhM3g==", "2a3cd59a-b41a-4dba-a6be-762c7e83ef2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "befb623e-a3b6-4dc3-aac8-091f5fc78264", "AQAAAAEAACcQAAAAEPeXaUhXVCE/1r3wvLbd2cmbb9Q5GevMJkqEwx/gzQUpzSVY6prDyOP2HiJ7ekJ9Mw==", "0b5985d6-abe7-423e-99b4-5e7d858f2f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b38108c5-3b75-4321-89b1-749ca699e409", "AQAAAAEAACcQAAAAEC7BEGrDNzz0dayzyL3I03ehaYSIPkf8xtC9BQs4MtPXNZgIThTRZTeXKBF5BvhbrA==", "89180c15-e713-478a-a6e2-d410b3434810" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa44756b-f7ce-453e-9812-aff082020470", "AQAAAAEAACcQAAAAEKjVCB0RYawTtxwgWPWgrEqoxa5zW44KKSUJt0tm/vyRGX0hILofYx1IxVD30GtPGw==", "31fcb488-47fa-4591-b24b-184ca515f245" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "882386a5-0477-41b9-aa98-7dae279788d0", "AQAAAAEAACcQAAAAED+5YhRbDkQdCf2DexYIow0feI8NKuc3EEeiAKgDtc3NoJ1TgKh8IhxPt87QG+kCTg==", "59ff1947-1478-48d5-9868-1249ac4e3f9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8254fa7-761e-4d73-8b13-86eae9762954", "AQAAAAEAACcQAAAAENjN5gj/PxtWniDsBeuQSU+D7V86EzDXmCQP+GWF9pzYEma92jl1XaYSKnzUrrxSCQ==", "b1b3fe7b-d07c-4967-82da-d08b87083d33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a15b26d-d7d1-401e-8159-4315aeaf84ff", "AQAAAAEAACcQAAAAECbd1+RNbpSHxjlT9gDy5eLAFEzQCvvXUhTNkbOPCBLM7ktyPZWkQfuPPxnfOHf6pQ==", "a7f1e2cd-7b45-4ed2-8a4b-9af91c47ee0f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d5ade06-31d8-4b84-9f6c-0912a79e368f", "AQAAAAEAACcQAAAAENFDCI8vPGOETrMMYsp5cBVW9ZfGmaAACyvzrXlXENt2W3/niwws2KGKdQvxOK4dUA==", "7635d746-14a0-4286-af61-31a70ab92c0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "097a1d4a-fb68-48b2-8297-90d7458be52e", "AQAAAAEAACcQAAAAEIjiAUMQWMLhcJLxc72d/18WC//9vm99uf1i/Nhs6R8bzuIZ+Tl9U/SaZ8StNNrOMA==", "15c561a9-b6de-4cd1-a048-4ac84e3eb4d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67c7f8be-605d-4b02-b9de-21861067a0d8", "AQAAAAEAACcQAAAAEBuG49Y620LPhLyn4nfyYMsnf4vG1jFLEmiCndt2tin9uTdjol2TiSN1vXW8UbT5lA==", "a6a7aaf4-cb30-46ab-941c-9881f4aa7257" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2994f92-42d0-481d-98df-7474d6ed3006", "AQAAAAEAACcQAAAAEEXnPGvdMOAP2nNqyE+he7Uqk2gkNXd0T9pSpCsoMzDpqR47MsVfgdq20ObkaY2Xww==", "19410f74-c27d-46dd-bd81-2ad3e5972fe8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b09f161f-784e-4202-9067-6068107ff4ff", "AQAAAAEAACcQAAAAEJ7FuMDz4QlET53rEv5LJRJYVXHUc/SwV6DDbs5dxl4+qu6Je24yhdMPof+8YX0lfQ==", "c252ff4c-79f8-4f07-9e1c-240ad3cf09cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "130be79f-481f-4b5f-8c1a-de2f322d7c90", "AQAAAAEAACcQAAAAEAUtq+//7+4dAG/qCkL9j60FevMDfPd5oRcVJObBNy3BhuH+X5HUy0AjgrSvkM2v8Q==", "4b0207cc-9e1e-4582-bd36-767cc71b7b4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c4a5e7-566e-49cb-a170-e8c57b2aead6", "AQAAAAEAACcQAAAAEEegZcrmHEC2rbrSfNa6f4fNDVKttRlc5ix7PmHFSbb2j8H++pQBK59XeqQRlmdR/A==", "0ee53bd6-7ee6-4c04-b88b-0360fbb1355d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e034d17-a0a6-467d-a81d-15a1bf6d8cb2", "AQAAAAEAACcQAAAAEAg0GwLdID5Gl+89J8aE/1jpIRPTx5BrPERAaJ0RVJ0vo9thlah8DUxet4v/7PLFtw==", "6e475f91-2586-47b6-841e-e860aa58bf83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccbcc0c0-63fb-4aeb-8a2e-4de919c046ba", "AQAAAAEAACcQAAAAEMNYsAy7jvmwFHsn20pJA2vOcc7OZQHI5BI+pIifLHqmlU7PTUSqEQ/Pssy0YTYPEw==", "0bd0cefc-bb89-4f09-ac65-b58cb07fda69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f140e5ab-6840-4d54-bec6-bae0888f2ae0", "AQAAAAEAACcQAAAAEONZ/glsb3oWnyjiKwDGt6SdsGX6Sk6elf+flq/5LBKDzmgBdo3GIZV4KIUuag4zrg==", "41136fb0-2c7e-45a1-b00d-9e93d4a29ba1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd912c76-34b0-4524-9384-2aa476e02906", "AQAAAAEAACcQAAAAEF0kUPvXykhZc5xfD51uJF7IfF651Q/HuGOBxnvWrL7Z/HJStBADFOA4Sq37lu+5PQ==", "414fad6e-292a-47b8-8d87-5596f8851793" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1fc4d51-270f-4fa4-b8e4-ae816b38785d", "AQAAAAEAACcQAAAAEM0bbI4eAxzfBy2SOhUJ9b/EKvABrhuDB0oBYMsScG1ULrELkkx/lLp2zUNUwIzoJQ==", "859ba544-09cd-40ac-929e-8ae1b9b8d161" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20493c73-6d0a-4dd9-8a58-283a460104db", "AQAAAAEAACcQAAAAELfl429B32SIsGxj+oItN2tw9moybDWS86RwjB9NBI0WUHSDKcf+vQuDj4O41JhAhA==", "95b05b9a-76c2-4a00-b57d-c72533302000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c985b31c-eeab-436c-9cc4-a2f6ebb87bda", "AQAAAAEAACcQAAAAEGL4717789f0XD/Hvt5Orfg0HTRNhMewUVElJZktSR0m1PF3biebPM7qtxYPQ9gKrg==", "43944c9a-35e3-438d-ac0f-37047bebcb23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49760209-6ac8-44b6-b22c-e70c49862051", "AQAAAAEAACcQAAAAEPzOUKG77i9k/ymWPF5cNvOKmbJ8silM3ghPSGi9RxBbojCdQj4gh+9gi5EbDNZUjg==", "f0328fbc-b02a-49af-8d75-3c9dd773d52f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "694e66d3-5384-4705-a5df-da06d7b4cf36", "AQAAAAEAACcQAAAAEIXZ7XOZ+mw2+Ja7ut2AQgzF8PmQqntbMsXQeX/1doY7F2QaDiTDBHIDoihpah/DiQ==", "f59a6404-7244-4f62-9608-a90440a08d32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d79ab8f7-badc-49b3-988e-0d4ec48501a8", "AQAAAAEAACcQAAAAEJshtXF91lMSSFHNkIBKz1Vzmx8wiiU+1sZSGB11n7Pd9GRTEupAnio37/Acn0NJcg==", "31a3d5d2-997c-4016-a57f-cbcdb41a9caa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "172ec3ce-6d6b-410a-87cd-388d2656b885", "AQAAAAEAACcQAAAAEBLRAh852r6yWP5TWiJyCUX8Q+VkRpX4ll/4N6jtFEk0AHLWcZrJopheIZ4CLdAeHA==", "3004d348-dbe5-4317-b1ba-d9a4dd4c53ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "935cd1ef-fe8a-4517-8402-c0f4a40e15d0", "AQAAAAEAACcQAAAAEKiVkxONAqfDup7wqLeE57qlPFUM6gXAUMygNJAMMRYCbhGADpfLYSKJG/ze2PFqDg==", "4676080c-cd94-46f2-9d81-bd4a9ad8584e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "616c6806-b011-438f-b6c1-6680474611fd", "AQAAAAEAACcQAAAAECMsMLf9k2MtSU39Ce6ancUC6tZQdpENN3Jd/6PvqpTY3tUCArwEB1SAZDrQK5Gn4w==", "daeb888e-6dbf-4ba4-a354-afc903d0d678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c9daba8-5228-40b1-a632-91e9c7cc3734", "AQAAAAEAACcQAAAAEDPPvF5iNbfR3doC36GosOXKQtyYV653PcVyTJGYVWYwg27psOU7YKFkHl5ZUXoj6A==", "fcd5c3dc-af5e-42ec-a3ef-747419298874" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6818bad9-218a-41f2-9eaa-65f7531010b9", "AQAAAAEAACcQAAAAEDmMzVJyw5X6iQu/Esj/TZYtCYpRFa1/8CoGprnmwbIILMm8Ki4L97bMDAMbJUY5MA==", "ac4d0ff9-1110-46d4-8c2f-a53b6096f10e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc9224e-dbc1-4d93-b49b-cbad3665a9bb", "AQAAAAEAACcQAAAAEHPJM0I3roi16MRRigzt68Kdl0J9Me95DNR4oKZ6NHUnEJXUsXqGFZVk8OJW63Hekg==", "08bb269f-4215-497a-b13f-36e07414987f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2ee02ec-1d2c-4a13-aadc-e2b88bee5a9c", "AQAAAAEAACcQAAAAEGj0lODmvckviV5ta5ZXNJV7dgLIEhDIaLyeZAQkl1/XaVJoGGsUVPbehqblpfl6UQ==", "9be353c6-c284-478c-830d-5a91d29d52e1" });

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
                    { 4, null, null, null, null, true, "4" },
                    { 5, null, null, null, null, true, "5" },
                    { 6, null, null, null, null, false, "6" },
                    { 7, null, null, null, null, false, "7" },
                    { 8, null, null, null, null, false, "8" },
                    { 9, null, null, null, null, true, "9" },
                    { 10, null, null, null, null, false, "10" },
                    { 11, null, null, null, null, true, "11" },
                    { 12, false, true, null, true, true, "12" },
                    { 13, null, null, null, null, false, "13" },
                    { 14, null, false, null, false, true, "14" },
                    { 15, null, null, null, null, false, "15" },
                    { 16, null, null, null, null, false, "16" },
                    { 17, null, false, null, false, true, "17" },
                    { 18, null, null, null, null, false, "18" },
                    { 19, null, null, null, null, false, "19" },
                    { 20, null, null, null, null, false, "20" },
                    { 21, null, false, null, false, true, "21" },
                    { 22, null, null, null, null, true, "22" },
                    { 23, null, null, null, null, false, "23" },
                    { 24, false, true, null, true, true, "24" },
                    { 25, null, null, null, null, false, "25" },
                    { 26, null, null, null, null, false, "26" },
                    { 27, null, null, null, null, false, "27" },
                    { 28, null, null, null, null, false, "28" },
                    { 29, null, null, null, null, false, "29" },
                    { 30, null, null, null, null, false, "30" },
                    { 31, null, null, null, null, false, "31" },
                    { 32, null, null, null, null, false, "32" },
                    { 33, null, false, null, false, true, "33" },
                    { 34, null, null, null, null, false, "34" },
                    { 35, null, null, null, null, true, "35" }
                });

            migrationBuilder.InsertData(
                table: "StudyRoutes",
                columns: new[] { "Id", "Approved_eb", "Approved_sb", "Note", "Send_eb", "Send_sb", "UserId" },
                values: new object[,]
                {
                    { 36, null, null, null, null, false, "36" },
                    { 37, null, null, null, null, true, "37" },
                    { 38, null, null, null, null, false, "38" },
                    { 39, null, null, null, null, false, "39" },
                    { 40, false, true, null, true, true, "40" },
                    { 41, null, null, null, null, true, "41" },
                    { 42, null, false, null, false, true, "42" },
                    { 43, null, null, null, null, true, "43" }
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
