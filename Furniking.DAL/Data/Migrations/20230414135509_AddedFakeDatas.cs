using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFakeDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "User", "USER" },
                    { 2, null, "Moderator", "MODERATOR" },
                    { 3, null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "f54406c2-41dc-4dfd-bdea-db6073d66bea", "user@gmail.com", false, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAED+iC9L8e9iGFkhx4oAxNEGAuBS3PVgssvAmS+sYY31GztzwSrvBWzQ82SZHtEFPMA==", null, false, null, false, "user@gmail.com" },
                    { 2, 0, "e8006678-9197-4997-8962-6dba99d1b685", "moderator@gmail.com", false, false, null, "MODERATOR@GMAIL.COM", "MODERATOR@GMAIL.COM", "AQAAAAIAAYagAAAAEEy6tSAcBir/YQqTrjMkkuxZ6emj4NYnUUfkdQXPCq/Hj4CoYrj8tBtj0y0g0hBn7A==", null, false, null, false, "moderator@gmail.com" },
                    { 3, 0, "e8c7b865-ca2d-4553-81ac-9c05f61cb41a", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEHWMAJV6uY58j39+VygdlYtVbhoa7xVO4A/LyJ3P6sy6nkPe393o3N2D4r1YCR1yrA==", null, false, null, false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tools" },
                    { 2, "Kids" },
                    { 3, "Shoes" },
                    { 4, "Tools & Movies" },
                    { 5, "Toys" },
                    { 6, "Grocery, Toys & Sports" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Furnitures",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Ab voluptas illum facilis voluptatem ullam soluta sit. Id consequatur assumenda voluptatem culpa ea. Eligendi eveniet quia sed aperiam nihil voluptatem aliquam temporibus. Ut et iure.", "Ergonomic Soft Car", 841.980151623315970m },
                    { 2, 2, "Omnis eius ducimus. Asperiores impedit est autem quia sit consequatur est tempora ut. Sit corrupti nemo est suscipit sint. Ad magnam rerum et et nulla neque.", "Unbranded Cotton Bike", 279.741756547623250m },
                    { 3, 6, "Similique sit minima sunt. Autem ea veniam facilis et amet aliquam. Ut in ut. Autem fuga qui rerum vero iure molestiae eum rerum.", "Tasty Steel Car", 426.994886512878850m },
                    { 4, 4, "Ipsa aut qui suscipit voluptatum ut expedita et. Non cum minus. Quibusdam deserunt et voluptatum labore veritatis delectus molestiae voluptatem.", "Awesome Plastic Hat", 94.6081843558810210m },
                    { 5, 5, "Aperiam tenetur doloremque. Est est hic qui. Pariatur et repudiandae. Et numquam occaecati dolores aspernatur. Voluptatibus sapiente fuga et iste voluptatem ut et rerum dolor.", "Unbranded Wooden Computer", 955.112962107483730m },
                    { 6, 2, "Eos quos architecto accusamus adipisci harum. Doloribus nobis neque adipisci aut iste. Harum aspernatur illo.", "Practical Cotton Sausages", 43.8007295829899080m },
                    { 7, 1, "Maiores delectus iure necessitatibus animi. Quo ratione sint voluptatem inventore porro aliquid maxime rerum. Rerum reiciendis rem excepturi aut alias ut deleniti.", "Awesome Rubber Towels", 527.63788635323050m },
                    { 8, 2, "Voluptatem illum esse enim porro quae porro placeat. Illum repudiandae nostrum voluptas et et maiores. Omnis explicabo odit dolorem minus. Voluptatum quas hic. Asperiores recusandae molestias soluta.", "Small Concrete Chips", 208.3066207035760m },
                    { 9, 3, "Qui necessitatibus at velit fugiat fuga ut quae consequuntur. Omnis labore eius impedit tenetur. Minus dolor eius. Cumque illo reprehenderit qui sed illum sint.", "Practical Cotton Keyboard", 842.26919647560040m },
                    { 10, 3, "Non velit dolore aut consequatur et repellat officiis voluptatum. Error optio quo soluta culpa qui expedita eos. Cumque eius id aperiam facilis. Vitae temporibus aut.", "Tasty Fresh Computer", 419.832838915772140m },
                    { 11, 1, "Sit molestias pariatur ea maxime omnis. Est ratione voluptas inventore aut at et. Delectus in soluta eos quia nesciunt adipisci. Est nesciunt cum a nulla quibusdam. Voluptas nesciunt reiciendis laborum.", "Refined Wooden Pizza", 286.358920472577250m },
                    { 12, 6, "Non sit distinctio incidunt assumenda quae ducimus repellat sapiente animi. Vel et odit dolores aspernatur similique asperiores et placeat voluptatem. Neque laborum perferendis. Totam vel tempora ab eligendi eligendi a.", "Gorgeous Plastic Fish", 20.2007518068948580m },
                    { 13, 6, "Illum et eos sapiente. Dolor qui libero exercitationem voluptas at modi aut non harum. Non quibusdam similique rerum eum eveniet. Sed reprehenderit laudantium sint ipsam.", "Tasty Rubber Salad", 804.916695075078070m },
                    { 14, 3, "Nemo dignissimos quia. Ad fugit sed est laborum. Amet delectus suscipit eos dolorem at ullam. Aut amet quae tempora cumque laboriosam suscipit.", "Handmade Plastic Chicken", 975.965440516640740m },
                    { 15, 5, "Modi pariatur alias. Impedit nesciunt doloremque autem aut. At optio velit voluptas esse voluptates modi esse quia molestiae. Sed in dolorem maxime qui tempore quia ut aut a.", "Rustic Granite Tuna", 762.89931215176150m },
                    { 16, 3, "Sapiente autem occaecati voluptas placeat eaque. Quis id voluptatem. Officia qui harum modi ad sed non consequuntur. Non deleniti sint nobis. Sit voluptatem delectus adipisci dicta voluptatem iusto quia aliquam. Quisquam iure nulla occaecati nostrum.", "Tasty Concrete Pizza", 530.815256551840690m },
                    { 17, 2, "Hic autem dolores autem expedita. Dolor error ea exercitationem eligendi omnis. Possimus incidunt natus voluptatem sit maiores ipsam sunt.", "Unbranded Metal Chips", 552.34276929836740m },
                    { 18, 2, "Sit ducimus et. Eum sapiente nihil in sed. Modi est dolore. Sed impedit necessitatibus. Fuga omnis doloribus provident qui ea laborum et sed hic. Quae praesentium molestiae.", "Intelligent Cotton Computer", 771.283651770562690m },
                    { 19, 1, "Molestiae suscipit laborum rerum optio atque voluptas qui. Quia recusandae maxime aperiam sunt voluptas voluptas eius ratione qui. Cupiditate et quasi iste accusamus ipsam. Alias et est non modi. Numquam et itaque praesentium nisi autem recusandae optio.", "Intelligent Plastic Hat", 762.835535610543550m },
                    { 20, 3, "Consequatur qui est et atque minima laboriosam deserunt facilis. Tenetur quo adipisci tempore ut voluptatem harum vero sapiente itaque. Ea voluptates et sit natus ut. Rerum vitae repudiandae. Non assumenda quam nulla provident blanditiis autem assumenda. Magni nulla praesentium sunt quis molestiae similique perspiciatis eos labore.", "Unbranded Wooden Table", 551.023591152846340m },
                    { 21, 6, "Vero et modi aliquid. Sit qui dolore non eius excepturi omnis quam. Consequuntur id maiores ab iure consectetur et error. Sed nesciunt eum sit tempora et laboriosam consequatur sint. Dolorum quisquam voluptatibus ipsa eos doloremque expedita quo consequatur illum. Rem fuga incidunt possimus iusto voluptatem quis.", "Fantastic Soft Bacon", 231.554631034003960m },
                    { 22, 5, "Voluptas odio a cumque explicabo nihil. Exercitationem corrupti officiis voluptate qui magni libero temporibus. Esse et quam sapiente ut vel repudiandae. Veritatis alias tempora ullam porro possimus et ut itaque. Et officiis unde quo vel aliquam voluptatem omnis et. Sunt veniam non aut sunt nostrum et.", "Unbranded Metal Chair", 156.945839281580350m },
                    { 23, 5, "Nesciunt aut corporis quibusdam beatae sit veritatis animi totam corrupti. Dicta iste porro maxime. Optio sequi totam. Unde et in inventore voluptatem aperiam. Assumenda dolor rerum assumenda sunt sint suscipit. Rem repudiandae eaque quaerat error voluptatum ut unde.", "Awesome Plastic Chips", 594.734779646381980m },
                    { 24, 3, "Dolorem ex numquam quas. Quos neque labore dolorem. Aut alias quaerat eaque animi quo fuga eius ut repudiandae.", "Intelligent Plastic Sausages", 202.544716774159090m },
                    { 25, 1, "Magnam non pariatur quod voluptas rerum. Eum harum aut non et quibusdam voluptatem similique. Ut accusamus ab voluptas omnis et quasi delectus quod exercitationem. Dignissimos consequatur pariatur quo dolore tenetur modi. Non cumque rem ea iure possimus esse. Nostrum dolore expedita rerum praesentium quia consequatur et deleniti.", "Rustic Steel Ball", 22.1144640307966990m },
                    { 26, 5, "Ab sit sunt minus quod. Ipsa nihil ratione. Ad asperiores ut nemo. Velit assumenda et numquam et voluptatibus rem et. Repellendus pariatur et totam. Veniam deserunt repudiandae rem neque minus occaecati corrupti ut.", "Refined Granite Chicken", 435.500216429238280m },
                    { 27, 6, "Pariatur eum magnam reprehenderit. Voluptas qui est illo eum. Aut et dolores eum. Incidunt et quibusdam ut. Qui error exercitationem et.", "Rustic Granite Pizza", 120.748882778932420m },
                    { 28, 6, "Veritatis illo voluptate. Voluptas dolorem nihil provident et consectetur hic qui. Enim dicta et inventore nemo omnis. Rerum et et facere error dolore. Sunt voluptate quia ea voluptatem id. Nobis est ut repudiandae et sed et.", "Intelligent Cotton Chair", 166.94993805634990m },
                    { 29, 1, "Repellat deleniti sed suscipit asperiores deserunt ipsam itaque tempora. Ut quo quia. Molestias architecto et aut autem nostrum architecto et.", "Practical Concrete Car", 412.131309110776630m },
                    { 30, 4, "Rerum quam tenetur quibusdam blanditiis et consectetur ratione. Voluptate dolor explicabo similique a quia sed hic quas. Explicabo rerum voluptatum. Quisquam voluptas qui magni sunt illo sed minima. Exercitationem nostrum eos quas dolores aut autem nulla ut explicabo.", "Ergonomic Soft Pizza", 487.206234467338420m },
                    { 31, 6, "Sit consequuntur amet illum provident expedita nisi numquam assumenda nisi. Vel voluptatem quod quo. Libero nesciunt odio. Quia facilis est quis minus repudiandae.", "Practical Frozen Pizza", 187.070546413854280m },
                    { 32, 2, "Quis porro eos sunt est. Enim ipsam et cumque et odit. Soluta voluptas sit beatae natus sequi asperiores repudiandae a.", "Refined Metal Fish", 672.744758778072190m },
                    { 33, 6, "Hic assumenda sed at odio vel sapiente non ipsa. Et vero iusto qui aut nesciunt occaecati fugit quia. Quo qui alias. Molestiae voluptatem aut dicta. Et vero reiciendis accusantium atque et eligendi. Dolores voluptate ut et repellendus eius dolore quia non voluptas.", "Intelligent Plastic Towels", 394.252947989070490m },
                    { 34, 5, "Nostrum reprehenderit est aut voluptas praesentium quas facere. Et numquam dolorum id et. Delectus qui omnis. Eos a quo voluptas quam ex corrupti error. Voluptatem est omnis iste voluptatibus at repellendus ut omnis voluptatem.", "Fantastic Plastic Chips", 138.723375096937720m },
                    { 35, 6, "Rerum id voluptas est ut ut et. A sapiente aut. Quis dolor assumenda quia necessitatibus eos nisi sunt. Optio fugit deleniti et.", "Intelligent Rubber Tuna", 518.972609083394170m },
                    { 36, 3, "Error quibusdam eius consequatur optio. Repellendus dolor facilis. Molestias omnis facere.", "Gorgeous Wooden Hat", 982.389437783992360m },
                    { 37, 5, "Quibusdam quidem sunt dolorum asperiores labore ducimus ut debitis amet. Iusto quod nam et corrupti. Aliquam ea libero et est reprehenderit rem sapiente id corporis. Molestiae aliquid tenetur.", "Tasty Plastic Towels", 366.388310126541880m },
                    { 38, 5, "Veniam architecto dolore quidem sit soluta cupiditate. Fuga minima omnis est. Corrupti dolorem alias voluptas amet optio. Voluptatem commodi impedit autem. Reiciendis exercitationem accusantium aut architecto quia tempore. Beatae necessitatibus distinctio dignissimos soluta tenetur quas.", "Fantastic Rubber Mouse", 379.129664809096840m },
                    { 39, 6, "Quia et cumque ea minus modi. Repellat non consequatur. Esse reprehenderit consequatur accusantium neque velit. Est eos autem quo aut tenetur beatae.", "Small Fresh Bike", 125.060475323443870m },
                    { 40, 3, "Non culpa aut est dolor rerum et. Nobis repudiandae suscipit illo impedit. Quisquam voluptate qui quia autem autem enim pariatur debitis deserunt.", "Practical Wooden Computer", 185.669052234109390m },
                    { 41, 4, "Blanditiis ipsam perspiciatis eveniet modi impedit facilis et fugiat officia. Fugit eos facilis doloribus ut suscipit sed ullam tempora. Sed vitae et accusantium praesentium cum aliquam consequatur reiciendis. Est quisquam aut in. Autem ut quaerat voluptate quod quisquam rerum aut ut voluptatibus.", "Tasty Frozen Fish", 100.6104922362324190m },
                    { 42, 2, "In vel quia soluta sequi. Porro id et labore saepe sapiente est. Et adipisci exercitationem quae porro eius temporibus magnam. Unde soluta aperiam ab omnis magnam error enim quia. Quasi dignissimos nisi necessitatibus tenetur harum. Aut voluptas aliquid aut numquam voluptas.", "Intelligent Steel Towels", 582.53742730719370m },
                    { 43, 2, "Consequatur maxime qui facere debitis ex sunt et impedit. Adipisci ea rerum reprehenderit ut. Tempora cupiditate quia sunt sint facilis. A dolore in necessitatibus non eveniet eos aliquid.", "Refined Plastic Chips", 417.034737420943060m },
                    { 44, 5, "Quos magnam sunt. Aliquid vero rerum quaerat sit earum a non voluptatem. Sed ea corrupti beatae facere quasi sint et iure.", "Practical Cotton Soap", 659.83248812370790m },
                    { 45, 4, "Harum iste qui perspiciatis. Illum dolore quia. Facilis natus omnis voluptatem corporis minima. Voluptatem temporibus quia aperiam est nam. Ut itaque nemo ut voluptatum enim praesentium.", "Incredible Steel Table", 507.895623169034860m },
                    { 46, 4, "Occaecati reprehenderit est. Dolor quia dolor aliquam provident odit. Vel eos necessitatibus doloremque doloremque labore doloribus corporis ea autem. Ratione dolor sit quo. Qui dolor magnam ratione.", "Sleek Steel Computer", 530.673669560844910m },
                    { 47, 6, "Esse doloremque cumque enim illum maiores animi. At aperiam similique ea provident labore dicta ipsam provident. Dolorem odit ratione qui quia iusto numquam aliquid maxime fugit. Atque ut esse ut earum officiis quidem placeat repudiandae.", "Licensed Soft Fish", 756.285266428003720m },
                    { 48, 2, "Omnis voluptate et iusto sed saepe similique corporis magni. Totam expedita facilis nulla quae atque numquam. Sunt et doloribus odit ut optio earum voluptas qui. Id nihil in. Nisi nisi animi rerum non et consectetur et quaerat. Est voluptatem velit aspernatur rerum.", "Sleek Rubber Cheese", 492.602169388753810m },
                    { 49, 6, "Eius sit architecto. Odio dolores nihil quia ab. Ex qui aperiam soluta iusto. Cumque dicta quo atque non ut.", "Awesome Cotton Cheese", 687.402001860649120m },
                    { 50, 1, "Ab non temporibus sit nihil dolore sed. Recusandae aliquam ullam vel architecto maxime soluta quo ut officia. Iure quam nihil facere ipsam. Quod incidunt corporis reiciendis qui exercitationem suscipit at hic. Ea quo est quis necessitatibus quo aut cum.", "Handmade Rubber Bacon", 756.776492639713360m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "DateTime", "Evaluation", "FurnitureId", "UserId" },
                values: new object[,]
                {
                    { 1, "Veniam omnis sit ut dolorum aut voluptas. Consequatur officia rem sit odit quis veritatis officia incidunt. Ut labore enim inventore voluptatem id occaecati quo. Itaque praesentium aut quibusdam vel sed dolorum expedita numquam aut.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(6914), 11, 27, 2 },
                    { 2, "Quia quas eius provident. Sint magni dolor. Aut rerum debitis.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(7832), 9, 10, 2 },
                    { 3, "Quia iste quia optio ea ipsum qui nisi nihil. Nisi veritatis expedita assumenda explicabo. Ut soluta quis qui debitis odit cumque expedita quibusdam reiciendis. Omnis deserunt autem ducimus. Corporis voluptas blanditiis autem quo dolores corrupti. Repellat optio aliquid dolor voluptate sunt omnis non sed repudiandae.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8032), 10, 18, 2 },
                    { 4, "Quam accusamus voluptas reprehenderit ut ab natus quasi odio sit. Et quibusdam in consequatur culpa qui. Voluptates est ut rerum consequuntur ex. Non quo recusandae ut nihil cupiditate nemo excepturi. Ratione cupiditate pariatur facilis odit quaerat.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8182), 6, 36, 1 },
                    { 5, "Exercitationem laborum deserunt non inventore sint error porro corrupti fugit. Sit sint ipsa. Perspiciatis consequuntur consequuntur quidem sed nam voluptatem blanditiis sint a. Esse commodi exercitationem nam omnis. Earum et ullam.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8322), 8, 6, 2 },
                    { 6, "Fugit odit qui non esse cum praesentium optio quia possimus. Aut laboriosam doloribus et in magnam. Aut beatae voluptas. Totam dicta accusantium rerum et consequatur voluptatem. Labore illum doloremque.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8465), 8, 27, 3 },
                    { 7, "Error sint quia ullam consequatur repellendus ipsum. Dolorum dolores eum. Sunt laborum quo id accusantium.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8573), 10, 10, 2 },
                    { 8, "Sed est quaerat id dolores delectus ipsum qui id praesentium. Ab in optio fugit molestiae suscipit deleniti iusto minima. Rerum molestiae omnis magni. Iusto magnam et. Voluptates odit hic in.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8695), 5, 9, 1 },
                    { 9, "Ipsa explicabo unde est distinctio consequuntur voluptas. Culpa quisquam id quasi nihil omnis voluptatem. A velit est voluptatem quia voluptatem. Natus qui exercitationem mollitia fugiat fuga atque est fugit aut.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8812), 10, 18, 3 },
                    { 10, "Et eos ut consequuntur. Quasi molestias velit. Vitae omnis id excepturi.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8871), 10, 16, 3 },
                    { 11, "Officia tempora vel. Porro sunt in. Dolor voluptatem doloremque sed et dolorem. Quia laudantium consequatur voluptatem deserunt fugiat. Nihil et culpa architecto praesentium totam enim qui omnis beatae.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(8990), 3, 8, 2 },
                    { 12, "Eos magnam aut rerum dicta. Esse magnam quod veritatis deserunt numquam at rerum dolorem provident. Aut omnis reprehenderit molestiae et dignissimos architecto ut vel. Ut id natus eos molestiae nemo sed rerum eaque maiores. Hic occaecati dolore enim perspiciatis aut.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9136), 5, 32, 2 },
                    { 13, "Soluta consequuntur esse alias culpa ut ipsam. Qui eligendi maiores. Ex tenetur voluptatibus porro similique dolorem et. Autem ut iure. Neque sed harum voluptatem voluptas qui repellendus officia.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9245), 8, 44, 3 },
                    { 14, "Recusandae pariatur cupiditate cum voluptatum autem. Quis sequi quas quae incidunt ipsum quidem eos dolore odio. In ad cumque ut sint voluptatem corrupti. Ab sint in quis vero. Vel illum non facere quasi deleniti. Veniam reprehenderit ea velit quae corrupti.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9398), 6, 8, 2 },
                    { 15, "Iste eaque id quisquam non distinctio. Aliquid architecto asperiores ut enim qui consequatur eos. Facere rem omnis eaque. Sunt possimus quo. Reiciendis cumque tempore repudiandae natus ea ut.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9514), 3, 19, 1 },
                    { 16, "Aspernatur modi ut corrupti et quae minima. Sed deleniti placeat qui. Dicta aliquid rerum et repudiandae alias aspernatur quam ea beatae. Dolorum voluptas est delectus quae quasi ea quis. Maiores sint est consequuntur sit optio enim incidunt. Impedit neque nihil omnis.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9672), 3, 8, 3 },
                    { 17, "Iste numquam non molestias sit dolor maxime aperiam libero. Voluptatem cupiditate exercitationem et perferendis dolores quia aperiam. Facilis officiis veritatis maxime magni eos voluptates fugiat alias. Veniam dolorem rerum qui. Vel esse quos.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9800), 10, 9, 2 },
                    { 18, "Dolorem autem incidunt quia. Porro voluptas odio nemo aut at aut dolor. Et sunt officiis. Et debitis nihil iure dolores esse aut ex.", new DateTime(2023, 4, 14, 13, 55, 8, 881, DateTimeKind.Utc).AddTicks(9898), 6, 5, 3 },
                    { 19, "Minima consectetur asperiores eveniet mollitia ad. Rerum quia expedita quaerat ipsa beatae ut ut non aut. Delectus et non a enim et. Minus quasi vero ut voluptas voluptates accusamus ad recusandae omnis.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(11), 9, 36, 1 },
                    { 20, "Nesciunt aut repudiandae maiores. Voluptas minus nulla deserunt voluptatem quos iusto voluptates sint. Dolorem aut explicabo sed qui. Voluptas incidunt magni est quis beatae tempore eum sed. Velit omnis quia tempora ipsum omnis ipsum.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(139), 6, 3, 1 },
                    { 21, "Non temporibus mollitia aspernatur in. Deleniti occaecati dolor in et dolorem nesciunt. Et aut a minus.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(218), 2, 33, 1 },
                    { 22, "Vel temporibus aut mollitia ipsa. Quia et iusto odio ad. Praesentium voluptate sequi rerum. Aut dignissimos dolores error id repudiandae in rem ab blanditiis. A ratione voluptas excepturi adipisci.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(337), 5, 47, 2 },
                    { 23, "Labore laboriosam suscipit nihil. Aut quasi eos esse porro. Sed at eius sunt tempora impedit consequatur quia mollitia et. Nostrum quidem quia voluptatum. Ipsa atque cumque cumque facere molestias magnam.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(456), 2, 50, 1 },
                    { 24, "Sit sequi magni est et quae accusamus. In exercitationem quia minima molestiae quo eos. Explicabo aliquid velit.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(528), 2, 21, 1 },
                    { 25, "Alias iste dolor ut. Et dolor nostrum iste aspernatur amet ut minus et nesciunt. Dolorem et beatae repudiandae. Neque ipsam hic ut.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(626), 2, 50, 1 },
                    { 26, "Eum nemo accusantium atque rerum expedita voluptatibus vitae veritatis occaecati. Eveniet consectetur id porro officia atque eos. Voluptate harum porro fuga totam velit corrupti iste molestiae et. Quos placeat omnis debitis excepturi aut quo eos. Vel officiis corporis deserunt et. Tenetur quibusdam fugiat in libero enim modi assumenda quas.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(789), 7, 43, 3 },
                    { 27, "Iusto dicta harum qui quis labore et non reiciendis ullam. Ullam est eveniet ipsum et laudantium vero voluptatem. Corrupti debitis commodi. Molestiae voluptatem totam voluptatibus repellat facere.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(898), 5, 47, 2 },
                    { 28, "Officia ut rerum sunt dolorem ut. Enim libero magni sit voluptas ex cumque nulla expedita non. Distinctio voluptate est. Est tempora similique aut et odit.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(998), 5, 28, 2 },
                    { 29, "Aut delectus voluptate quae ea. Itaque quaerat quia ipsa suscipit. Sapiente qui eos vel dolorum quia quia doloribus ipsam dicta. Iure rerum velit aut molestiae. Sint et voluptatem.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1107), 5, 5, 3 },
                    { 30, "Sunt sed laboriosam minus quasi. Atque dicta omnis omnis et eveniet rerum in eius quos. Rerum dolorem officia. Fuga facere porro modi eos dolore odio.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1262), 6, 12, 2 },
                    { 31, "Nobis eos cupiditate praesentium laborum perspiciatis nostrum sint. Nesciunt est et sed vitae mollitia qui nulla dolor est. Libero animi est itaque corporis est impedit ratione et fuga. Quia quia commodi sed iusto est ipsum. Alias occaecati facilis non qui voluptatum et illum aliquid.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1424), 3, 42, 3 },
                    { 32, "Ea error officiis est dolorem repellendus hic officiis. Quos voluptatem consequatur aperiam consequatur possimus. Et eius quia repellendus aut et mollitia et. Soluta velit repudiandae expedita suscipit qui.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1535), 3, 1, 3 },
                    { 33, "Ad accusamus nobis nesciunt quidem aut rerum. Iste et unde esse voluptates optio blanditiis. Ex saepe maxime consequuntur architecto. Harum accusantium dolore eos assumenda.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1632), 3, 48, 2 },
                    { 34, "Id dignissimos doloribus. Vel aut voluptatem. Est et nulla. Esse quod velit nobis placeat odio unde laboriosam voluptas. Facilis ad vel quis in aliquid et labore.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1736), 7, 13, 1 },
                    { 35, "Commodi aliquam necessitatibus fugiat facilis accusantium distinctio accusantium occaecati. Libero qui aspernatur ex illo aperiam doloribus. Ut nihil quia et qui ducimus. Excepturi dolorum suscipit minima quam.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1841), 3, 13, 3 },
                    { 36, "Ut repellat tempora velit a suscipit rem debitis. Reiciendis voluptatem explicabo odio est quia. Modi nulla qui.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(1911), 1, 44, 2 },
                    { 37, "Distinctio sunt et facere labore. Odit qui fugit et necessitatibus qui atque quisquam itaque rerum. Voluptatum aspernatur id deserunt itaque quaerat. Et totam mollitia consequuntur accusamus sit. Omnis deserunt temporibus et aliquam ut.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2036), 7, 7, 1 },
                    { 38, "Earum officiis libero. Numquam voluptas sunt voluptatem. Totam vitae quae.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2089), 9, 43, 3 },
                    { 39, "Explicabo numquam quos sint dolorum. Autem voluptates eveniet voluptatum placeat. Aut odit provident enim soluta. Iure sunt voluptatem necessitatibus a pariatur sunt repellat sed. Ut quidem esse fugit doloribus repudiandae consequatur possimus.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2209), 11, 1, 1 },
                    { 40, "Nobis sequi omnis asperiores modi. Quae nisi voluptatem dolores quia voluptates. Nam vero eum. Omnis dolores corrupti vero aspernatur qui et quia.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2296), 2, 19, 3 },
                    { 41, "Adipisci tempora quaerat voluptas id impedit ducimus sit. Ad sapiente atque omnis eveniet. Facere possimus magnam adipisci perferendis.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2374), 10, 23, 1 },
                    { 42, "Molestiae non nisi corporis consectetur et rem quasi. Voluptas omnis sequi tempora. Officia harum architecto non accusantium sint fugiat ut eligendi. Delectus laborum ut velit quos corporis sed consequatur commodi aut. Eum et ducimus voluptas magni ea eaque voluptas sunt non. Accusantium occaecati facilis sunt eum nam delectus.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2541), 5, 48, 2 },
                    { 43, "Hic omnis debitis suscipit quisquam nihil dolores autem. Recusandae cupiditate omnis. Adipisci cum sequi veniam quidem minima perferendis maxime labore dignissimos. Aut earum quia. Rerum accusamus et veritatis corrupti atque excepturi perferendis. Vel quod rerum quidem eaque et ducimus ut eligendi.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2692), 5, 16, 2 },
                    { 44, "Rerum culpa modi eveniet ipsum. Aut sed et inventore ea officiis ut quam hic ullam. Facere itaque qui at ex omnis laborum suscipit expedita quasi. Accusamus ipsam alias corrupti at eum.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2803), 4, 12, 1 },
                    { 45, "Non est dolor necessitatibus consequatur nihil perspiciatis. Facere velit harum qui maxime autem distinctio laudantium. Est blanditiis sunt perspiciatis provident. Officiis quo quis itaque officia. Aut ad error excepturi eius iste. Quod ab dolorem quidem ipsam.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(2941), 10, 4, 2 },
                    { 46, "Recusandae quo nisi dolorem sint. Non nihil voluptatem consectetur sed et. Ut veritatis et sit nihil saepe occaecati qui quos quae. Quia harum debitis. Deserunt repellendus a quaerat dolor.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3058), 11, 36, 1 },
                    { 47, "Quo et quod. Quam dolorem aliquid facere delectus ut magnam expedita quos. Deleniti aliquid consequatur et unde repellendus enim a. Tempora accusamus dolore ducimus. Unde sit dolorum quae dolorem qui magnam voluptatem.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3175), 9, 22, 1 },
                    { 48, "Accusantium ratione doloremque cumque. Similique amet aut distinctio veritatis itaque fuga magnam. Non similique non. Adipisci non at vitae voluptatibus magni culpa voluptas incidunt sequi. Ex qui qui architecto ducimus qui omnis nihil. Est occaecati accusamus at corporis beatae quae architecto.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3326), 11, 20, 1 },
                    { 49, "Eum possimus maxime laboriosam accusamus ut voluptatibus consectetur pariatur sunt. Beatae qui aliquid et est maxime labore ex. Dolores doloremque pariatur nemo rem doloremque ipsum sint. Cumque non ut qui officia aspernatur ipsam cum omnis accusantium. Rerum magni accusantium voluptas qui.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3477), 5, 24, 3 },
                    { 50, "Deleniti nulla perferendis odio qui aut qui ut. Rerum natus voluptatibus commodi est sed quasi beatae quasi. Impedit corporis ullam reiciendis. Qui quo beatae et qui optio voluptate dolor. Voluptate consequatur quos.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3600), 11, 2, 2 },
                    { 51, "Fuga ut atque accusamus. Natus facere esse iure et nostrum et ducimus sunt. Officia nam aut quia ullam. Harum voluptatem nostrum.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3685), 4, 15, 1 },
                    { 52, "Perspiciatis repellat asperiores deleniti iste quasi. Et repellendus minima quia quia inventore qui voluptatem quibusdam rerum. Modi ut architecto repudiandae debitis dolor.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3774), 9, 23, 1 },
                    { 53, "Commodi quis ipsum alias voluptas modi. Voluptas rerum facilis odit praesentium. Voluptas nam et. Labore velit neque autem. Et nesciunt doloremque. Sapiente quas quam quia voluptate.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3880), 2, 16, 1 },
                    { 54, "Ullam eveniet eveniet doloremque. Assumenda perspiciatis adipisci sed voluptatem at sit. Quia provident consequatur reprehenderit quo dolor rerum non voluptatem. Quae voluptatem est qui.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(3978), 11, 46, 3 },
                    { 55, "Nobis id deserunt dolorem consequuntur sint ducimus. Sint et recusandae quaerat quod adipisci iste officiis praesentium. Qui molestiae sed et illo. Et et enim ex quam doloribus. Non sit dolorum ipsum quia.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4096), 3, 11, 3 },
                    { 56, "Cupiditate occaecati accusamus aliquam praesentium non aut dolor in reprehenderit. Autem incidunt voluptatibus enim praesentium laboriosam inventore. Adipisci distinctio qui quo voluptas dolores architecto a delectus cupiditate. Voluptatem atque beatae officiis quae non assumenda.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4225), 9, 12, 1 },
                    { 57, "Omnis similique laborum voluptas suscipit. Numquam asperiores voluptas nesciunt labore quod quas. Quod est voluptatem. Qui itaque pariatur distinctio suscipit. Impedit iste nihil odit velit. Reiciendis natus aliquid fuga ut sequi velit fugiat aut.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4414), 9, 15, 2 },
                    { 58, "Eum aperiam dolorem vel voluptas maiores voluptatem laboriosam aut. Qui maxime a ut aut ut corrupti est exercitationem. Non quos velit omnis aliquam quo et saepe debitis porro. Deleniti quo a dolorum iure laudantium. Expedita consequuntur voluptas perspiciatis ea enim soluta alias temporibus perferendis.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4574), 6, 12, 2 },
                    { 59, "Autem illo dolorem quae hic consequatur delectus est placeat saepe. Adipisci distinctio enim iusto cum non. Tenetur magni eligendi ut sed sed reprehenderit molestiae officia. Facere officiis et omnis vero.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4682), 8, 47, 1 },
                    { 60, "Provident inventore eligendi sed et quibusdam officiis veritatis. Modi molestiae voluptatum molestiae. Culpa doloribus ipsam culpa blanditiis recusandae. Beatae cum voluptatem assumenda. Saepe quaerat corrupti est accusamus atque consequatur qui. Aut neque quis magni non nihil ducimus totam molestiae.", new DateTime(2023, 4, 14, 13, 55, 8, 882, DateTimeKind.Utc).AddTicks(4827), 9, 39, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
