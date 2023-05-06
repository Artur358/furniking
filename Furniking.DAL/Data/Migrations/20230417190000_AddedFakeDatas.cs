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
            migrationBuilder.RenameColumn(
                name: "date",
                table: "Orders",
                newName: "DateOfOrder");

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
                    { 1, 0, "21c53e03-fd40-4570-90c8-211429dee3b3", "user@gmail.com", false, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEHoWCBgH3ws4pJuPE0Sw0nXGaaSaUaWQ0xd8iGVtU0PpUSaU3sx1hunMzugJILO0jQ==", null, false, null, false, "user@gmail.com" },
                    { 2, 0, "ee75aeac-5629-48db-a34a-5c97a0e31e8e", "moderator@gmail.com", false, false, null, "MODERATOR@GMAIL.COM", "MODERATOR@GMAIL.COM", "AQAAAAIAAYagAAAAEJQpYDRw6wDN0DFD2TfMXlotvG2nRWUCsR08Cknx8POGd7SHqrQm4mXsgXfWG5aJ8w==", null, false, null, false, "moderator@gmail.com" },
                    { 3, 0, "f0f8c806-61be-474a-84d5-9a241eb02cfb", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDOSM01nsK/lzdlCNusop15wuaNEMqiwhVI0HEF/Pil67OgMe4eD3ouRPeulfi5IeA==", null, false, null, false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Movies" },
                    { 2, "Beauty, Jewelery & Sports" },
                    { 3, "Shoes" },
                    { 4, "Beauty" },
                    { 5, "Tools" },
                    { 6, "Books" }
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
                    { 1, 3, "Dolorem dolorem id quaerat quas incidunt iure numquam voluptatem. Quod adipisci rerum eos. Aut non ea impedit culpa. Minus placeat qui dolore nobis non sint. Magnam assumenda alias atque ducimus corrupti.", "Ergonomic Steel Cheese", 714.461616745433470m },
                    { 2, 4, "At quia at facilis et. Dolores doloremque sed quo et non. Explicabo quam laboriosam perferendis. Sit accusamus qui assumenda commodi id quo odio autem.", "Gorgeous Plastic Tuna", 650.814796421125480m },
                    { 3, 6, "Aut sunt perspiciatis animi quasi. Voluptatem blanditiis porro inventore recusandae omnis enim reprehenderit exercitationem. Aliquam laudantium et. Rerum dicta vel fugit recusandae dolor.", "Gorgeous Steel Car", 76.2118420359733480m },
                    { 4, 1, "Molestiae numquam nulla quibusdam esse placeat magnam pariatur. Illo corporis et nesciunt dolorem. Ex ut consequatur laborum blanditiis eos laborum autem omnis et. Saepe cumque ipsum beatae odio nihil earum voluptates. Quia ducimus ipsam voluptas quo. In commodi aperiam molestias enim.", "Fantastic Plastic Tuna", 777.491902325996650m },
                    { 5, 1, "Ut repellendus ipsam. Dicta consequatur maxime at unde cum. Laborum aut eos magnam. Aut et tempora neque eveniet sunt veniam dolore omnis.", "Ergonomic Granite Pizza", 261.13919084013430m },
                    { 6, 3, "Dolorem in ea quia. Possimus commodi hic. Vero illum eveniet. Quam fuga ducimus cupiditate. Minima officia laborum aut.", "Unbranded Fresh Soap", 134.002516751178670m },
                    { 7, 3, "At ut non alias. Ducimus deleniti praesentium consequuntur autem ab perspiciatis ad quasi eaque. Eum vitae nisi et tempore. Cumque laboriosam dicta et illo. Tenetur fuga delectus aspernatur provident. Labore necessitatibus rerum eveniet non ut ratione maiores.", "Sleek Steel Tuna", 405.774495506554120m },
                    { 8, 3, "Ipsum fugit voluptatibus. Sed in corrupti enim officia. Voluptas reprehenderit quia quas quas dolorem hic perferendis sunt eum.", "Intelligent Steel Pants", 159.21915804930970m },
                    { 9, 3, "Delectus nemo fugit ipsa exercitationem perferendis consectetur repellendus. Voluptatibus temporibus voluptas consequuntur facere et exercitationem. Aut in itaque atque eveniet similique minima aperiam omnis non. Dolor et aut itaque quisquam saepe occaecati delectus voluptatum officiis.", "Sleek Fresh Shirt", 41.4305067115605610m },
                    { 10, 5, "Nobis dignissimos architecto provident. Quas doloribus et. Velit quasi id fugiat consequatur provident aut. Consequatur aut officiis pariatur id. Ut et qui odit. Velit et voluptas ut est fugit ut voluptatem eos.", "Small Metal Chips", 408.106683580254220m },
                    { 11, 4, "Qui tempora rerum et et sunt omnis porro. Ut enim vitae. Voluptas aut ad qui.", "Rustic Wooden Keyboard", 147.693521630807560m },
                    { 12, 3, "Distinctio numquam libero at ipsam possimus facere quo. Ut repellendus nihil dolor et aliquid. Nesciunt quae temporibus facere aut ut odit exercitationem.", "Generic Cotton Keyboard", 525.813177430915210m },
                    { 13, 2, "Veniam numquam molestiae quia veniam. Voluptates in ex eius mollitia et libero inventore blanditiis aspernatur. Temporibus aut praesentium iure. Quaerat repudiandae qui aut quis sit. Doloremque est dolor accusamus veniam et quia magnam aperiam et.", "Handmade Frozen Hat", 722.661815305548460m },
                    { 14, 3, "Iusto labore veritatis ipsam similique adipisci natus. Accusamus et a. Vel quia sed.", "Handcrafted Cotton Hat", 584.586835356702520m },
                    { 15, 3, "Iste magnam nulla quia quisquam aliquam. Id rerum quisquam nihil. Tempore magni ut officia laudantium culpa et assumenda esse. Magnam et modi necessitatibus sit libero sequi. Explicabo temporibus eum. Nobis vel rem.", "Incredible Cotton Table", 453.62573194951990m },
                    { 16, 6, "Corporis doloremque quas ea. Voluptates eos et et sit. Sapiente repellat animi eveniet eum quasi ut qui fugiat et. Tenetur fuga ducimus qui fugit perferendis odit enim debitis veniam. Perferendis itaque adipisci iure omnis ex dolore dolore. Doloribus vel architecto quisquam.", "Incredible Fresh Keyboard", 817.925183082896230m },
                    { 17, 3, "Consequuntur laborum iure beatae debitis a eos. Nulla possimus corrupti eos est suscipit maiores nam nihil. Nostrum amet laboriosam officia in non. Unde qui quidem et.", "Awesome Metal Bike", 469.148209746530590m },
                    { 18, 4, "Unde sed molestias qui dolores qui. Rem et tempore iure iure eum. Pariatur adipisci earum neque. Ut non praesentium recusandae. Incidunt tempora omnis eum nostrum.", "Ergonomic Granite Fish", 417.512601603526870m },
                    { 19, 2, "Itaque rem eligendi necessitatibus amet molestiae molestiae. Neque laboriosam aut aperiam et enim. Consequatur non sapiente consectetur.", "Tasty Fresh Soap", 98.7827203417116160m },
                    { 20, 1, "Sit dicta et. Iste dolore explicabo voluptatem quaerat totam. Voluptatem ex quis aperiam totam dolorem. Quam occaecati voluptas sit ad et nihil accusamus qui voluptatem. Possimus aut nihil asperiores dolorem maxime. Ea qui repellendus natus itaque.", "Intelligent Rubber Ball", 359.69252862021940m },
                    { 21, 3, "Inventore porro perferendis cumque pariatur vel magnam neque vel qui. Nobis pariatur quasi. Et officia ab voluptas amet ut eligendi veritatis iusto. Vero culpa esse. Laborum ut non.", "Handcrafted Fresh Bike", 272.869536384414190m },
                    { 22, 1, "Laborum repudiandae culpa non culpa quisquam aut. Et quos excepturi beatae nulla rerum esse commodi. Et culpa mollitia doloribus quibusdam.", "Tasty Metal Fish", 839.805642808697170m },
                    { 23, 5, "Odit ipsum possimus ea voluptatum. Ad a neque deleniti quo alias ratione quo. Quos provident quas quia pariatur magni animi aperiam neque officia. Illum beatae nihil voluptas odit sint nobis.", "Intelligent Granite Bacon", 359.802114041429830m },
                    { 24, 6, "Qui ea velit ipsum. Mollitia voluptas vitae sint nam libero ut voluptatum similique. Quas eos deserunt vel. Saepe adipisci sed quo quis autem voluptatem autem tenetur animi.", "Incredible Soft Chicken", 740.821988052140050m },
                    { 25, 5, "Eos ullam asperiores quod id nesciunt. Expedita eos odio fugit quia aliquam sit neque eos. Veniam rerum et commodi quibusdam quasi. Ab consequuntur voluptatem non vel. Sit et quas aut minima exercitationem qui voluptatem nesciunt.", "Rustic Wooden Chicken", 47.5563073240017190m },
                    { 26, 6, "Cumque esse in asperiores distinctio et possimus vero. Veritatis tempora porro. Est quo eum nulla nemo aut magnam dolorum.", "Intelligent Concrete Pants", 159.875408345775310m },
                    { 27, 6, "Dicta amet error porro architecto vel molestiae ut aliquid qui. Totam odit est et. Quasi odit praesentium omnis.", "Refined Steel Gloves", 206.863160443894450m },
                    { 28, 2, "Unde excepturi quo. Suscipit quod pariatur est at et molestias rerum enim dolor. Voluptatum accusantium dolores facilis ratione aut dicta est quibusdam non. Sunt impedit magni pariatur quidem voluptatum quia voluptas aut. Rerum et quo est aliquam officiis. Porro natus totam ratione.", "Incredible Frozen Bike", 377.165895680508760m },
                    { 29, 3, "Beatae laudantium qui repudiandae voluptatem rem dolorem eos rerum. Eos aperiam occaecati. Ullam perspiciatis quo neque ullam sint necessitatibus aspernatur officiis aut. Laudantium porro sed ducimus. Perspiciatis nulla debitis enim magnam esse similique est.", "Sleek Plastic Cheese", 842.430422251313380m },
                    { 30, 6, "Non rerum neque quasi porro rerum ratione quos soluta. Voluptatibus deserunt pariatur cum natus facere delectus eligendi doloribus praesentium. Nesciunt quia id.", "Awesome Wooden Bike", 884.712643853720320m },
                    { 31, 5, "Et distinctio sed impedit sint iste magni qui aut. Aliquid adipisci qui ut dolorem quisquam. Veniam laborum deserunt. Et facere voluptas consequatur quod molestiae.", "Ergonomic Plastic Sausages", 195.175981533330370m },
                    { 32, 4, "Fugit non qui ut. Velit fugiat sapiente. Veritatis distinctio sapiente vel totam inventore quaerat et eaque voluptatem. Ex fuga voluptates minima nisi omnis consequuntur rerum asperiores.", "Awesome Fresh Towels", 483.25502701255240m },
                    { 33, 6, "Doloribus beatae labore esse omnis praesentium voluptatem est dolor voluptate. Sapiente magni deleniti totam temporibus et unde temporibus quos voluptatem. Et ut quasi necessitatibus ut quas.", "Licensed Fresh Ball", 497.765535930062830m },
                    { 34, 6, "Maiores et et aut saepe. Eius aspernatur recusandae nulla dolorem. Excepturi aut dolor unde voluptas laudantium distinctio debitis sed.", "Ergonomic Rubber Gloves", 455.704362381112120m },
                    { 35, 4, "Nemo quia consequatur est. Non deleniti doloribus suscipit ut saepe magni et aliquid eligendi. Et architecto blanditiis quos quo voluptatem. Aspernatur et veniam minus sed dolorem natus eos ea. Sit temporibus laborum deleniti sint nulla corporis. Autem non repellendus similique non architecto sit.", "Incredible Fresh Shoes", 759.673856361617110m },
                    { 36, 5, "Doloribus similique enim repellat nobis voluptatum. Neque est ea corrupti non repellendus error vitae earum iure. Voluptatem sapiente sint odit. Non quia non unde dolor ad quia nisi quis suscipit.", "Practical Soft Chair", 537.971333469251320m },
                    { 37, 2, "Qui harum iusto eum vitae alias nostrum dolorum cum. Illo similique aut nemo similique aut animi. Officiis voluptatum non dolorem rerum et veritatis fugit.", "Small Concrete Hat", 200.633238698650660m },
                    { 38, 2, "Quia autem quis. Qui ducimus sed et non aut nam quasi. Quos doloremque delectus et dignissimos laudantium facilis nobis ut. Maxime repellendus quia delectus consequatur eaque. Quidem officiis amet et iste non minima non perferendis. Possimus iste repellat veritatis eius.", "Handmade Steel Fish", 587.85921572607910m },
                    { 39, 1, "Enim eius iure nihil tenetur perspiciatis rerum. Deleniti enim aut quasi totam. Aut ad itaque aspernatur nobis quo molestiae dolorem necessitatibus. Ut ea cupiditate sed. Nisi est possimus. Ipsa id ut.", "Generic Wooden Ball", 121.539898012550590m },
                    { 40, 5, "Dignissimos tempore non mollitia molestiae nihil perferendis est veritatis. Consequuntur neque aut voluptas quaerat cupiditate deserunt. Nobis modi eos. Consequuntur illo nihil consectetur voluptates neque aut quia. Iure tempore aliquid ducimus blanditiis ut voluptas aspernatur et accusantium. Qui nesciunt necessitatibus aut et rerum vero est.", "Tasty Soft Gloves", 389.064030791196520m },
                    { 41, 4, "Debitis ipsum labore autem pariatur aut itaque. Quod quos placeat aut et omnis eum et. Velit atque beatae delectus. Perspiciatis est enim nemo. Quod incidunt placeat qui. Nam et explicabo deserunt vero nihil quia est.", "Generic Granite Chicken", 648.648024661768330m },
                    { 42, 2, "Illo iste quibusdam. Suscipit consectetur cumque culpa quo et. Occaecati perspiciatis nobis velit quam doloribus aliquid. Numquam eveniet praesentium. Veritatis deleniti voluptatem quo. Praesentium perferendis sequi earum sint aliquam.", "Rustic Cotton Fish", 154.147735058398390m },
                    { 43, 4, "Quia vel sapiente enim amet harum sunt ducimus sunt nesciunt. Cum ut sequi. Voluptatem id aut enim deleniti voluptatem quia. Voluptatum id consequatur quis sed perferendis maiores optio.", "Practical Plastic Bacon", 548.208269583158350m },
                    { 44, 3, "Exercitationem reprehenderit fuga doloribus quis at fugit ut aut. Omnis et eligendi. Quos aut cumque velit cum. Nihil dolor nisi omnis et aut.", "Gorgeous Rubber Car", 469.202228430287320m },
                    { 45, 5, "Maiores soluta et. Ad facere pariatur commodi laboriosam aperiam consectetur maiores ratione. Autem ab in unde autem. Repellendus ipsa sed quae quasi iste. Iure et dolor soluta sint.", "Ergonomic Plastic Towels", 48.3001001031603790m },
                    { 46, 5, "Ducimus eum consequuntur consequatur ratione voluptatem. Quis consequatur sunt dignissimos excepturi maxime quia. Voluptatem earum natus.", "Handmade Metal Towels", 876.887589230615260m },
                    { 47, 6, "Aliquid tempore rerum quia. Minus deleniti nihil quia non sunt distinctio. Ut saepe quas ut praesentium ullam ipsum nam. Enim non natus voluptas beatae eligendi quis nihil sapiente quis. Quia autem deleniti dolorum sapiente modi.", "Handmade Granite Shoes", 364.30728545147320m },
                    { 48, 5, "Ut deserunt voluptatibus minima blanditiis accusantium nesciunt. Dolores velit ea sit voluptas illum et. Ab esse delectus sed minima totam dolor esse rerum. Ut earum quia sunt ipsam. Reprehenderit a et.", "Ergonomic Rubber Ball", 494.905089975755680m },
                    { 49, 1, "Quo vel sed animi velit ea nihil dolor ipsa. Enim suscipit quia quibusdam. Similique reprehenderit voluptatem temporibus eius commodi.", "Ergonomic Concrete Sausages", 925.404324184825750m },
                    { 50, 5, "Architecto a neque doloremque. Totam possimus quibusdam exercitationem quis odit eum ut doloremque provident. Est inventore harum. Beatae ratione cumque aut ratione asperiores dignissimos repellendus.", "Incredible Rubber Bacon", 290.497724488609210m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "DateTime", "Evaluation", "FurnitureId", "UserId" },
                values: new object[,]
                {
                    { 1, "Est excepturi quibusdam. Dolorem id quaerat quas incidunt iure numquam voluptatem dolores. Adipisci rerum eos ea aut non ea impedit.", new DateTime(2023, 4, 5, 5, 41, 16, 627, DateTimeKind.Unspecified).AddTicks(3057), 7, 38, 3 },
                    { 2, "Nobis non sint atque. Assumenda alias atque ducimus corrupti. Qui enim veniam quidem exercitationem quis at quia. Facilis et odio dolores doloremque sed quo et non.", new DateTime(2023, 3, 19, 22, 32, 23, 548, DateTimeKind.Unspecified).AddTicks(4042), 2, 17, 2 },
                    { 3, "Sit accusamus qui assumenda commodi id quo odio autem. Et quaerat architecto quasi quis magnam aut sunt. Animi quasi assumenda voluptatem blanditiis porro inventore.", new DateTime(2023, 4, 3, 3, 36, 58, 579, DateTimeKind.Unspecified).AddTicks(2015), 11, 20, 1 },
                    { 4, "Aliquam laudantium et. Rerum dicta vel fugit recusandae dolor. Pariatur vel minima. Asperiores facilis molestiae numquam nulla quibusdam esse placeat.", new DateTime(2023, 4, 12, 7, 28, 44, 443, DateTimeKind.Unspecified).AddTicks(6330), 3, 3, 1 },
                    { 5, "Nesciunt dolorem voluptatibus ex ut consequatur laborum blanditiis eos. Autem omnis et libero saepe cumque ipsum. Odio nihil earum. Nisi quia ducimus ipsam voluptas quo commodi in commodi aperiam.", new DateTime(2023, 3, 26, 15, 23, 40, 579, DateTimeKind.Unspecified).AddTicks(8482), 6, 1, 3 },
                    { 6, "Quo enim voluptatem ut repellendus ipsam. Dicta consequatur maxime at unde cum. Laborum aut eos magnam.", new DateTime(2023, 4, 10, 23, 54, 56, 654, DateTimeKind.Unspecified).AddTicks(6325), 10, 12, 3 },
                    { 7, "Sunt veniam dolore omnis aliquam sed saepe rerum et cum. Dolorem in ea quia. Possimus commodi hic.", new DateTime(2023, 4, 12, 14, 58, 48, 838, DateTimeKind.Unspecified).AddTicks(695), 2, 45, 3 },
                    { 8, "Fuga ducimus cupiditate amet minima officia. Aut consequuntur ducimus et et expedita fugiat. At ut non alias.", new DateTime(2023, 3, 30, 22, 5, 16, 305, DateTimeKind.Unspecified).AddTicks(6103), 11, 24, 2 },
                    { 9, "Ab perspiciatis ad quasi eaque ad eum vitae nisi. Tempore consequatur cumque laboriosam dicta et illo ad. Fuga delectus aspernatur provident nihil labore necessitatibus rerum eveniet non.", new DateTime(2023, 3, 21, 12, 4, 41, 809, DateTimeKind.Unspecified).AddTicks(5559), 11, 20, 3 },
                    { 10, "Quae suscipit eaque dicta. Fugit voluptatibus enim sed. Corrupti enim officia repudiandae voluptas reprehenderit quia. Quas dolorem hic perferendis sunt eum voluptatem.", new DateTime(2023, 4, 1, 2, 40, 18, 873, DateTimeKind.Unspecified).AddTicks(6811), 5, 19, 3 },
                    { 11, "Delectus nemo fugit ipsa exercitationem perferendis consectetur repellendus. Voluptatibus temporibus voluptas consequuntur facere et exercitationem. Aut in itaque atque eveniet similique minima aperiam omnis non. Dolor et aut itaque quisquam saepe occaecati delectus voluptatum officiis.", new DateTime(2023, 3, 28, 16, 34, 9, 504, DateTimeKind.Unspecified).AddTicks(3675), 1, 36, 1 },
                    { 12, "Neque nobis dignissimos architecto provident explicabo quas doloribus et. Velit quasi id fugiat consequatur provident aut. Consequatur aut officiis pariatur id. Ut et qui odit. Velit et voluptas ut est fugit ut voluptatem eos. Est quia sed eos dolor eligendi.", new DateTime(2023, 3, 24, 1, 44, 56, 397, DateTimeKind.Unspecified).AddTicks(9572), 5, 44, 2 },
                    { 13, "Omnis porro fugit ut enim vitae non. Aut ad qui eos animi dolorum iusto dolorem perferendis. Distinctio numquam libero at ipsam possimus facere quo. Ut repellendus nihil dolor et aliquid.", new DateTime(2023, 3, 21, 23, 21, 47, 797, DateTimeKind.Unspecified).AddTicks(226), 7, 40, 1 },
                    { 14, "Ut odit exercitationem occaecati velit est voluptatibus sed natus. Veniam numquam molestiae quia veniam. Voluptates in ex eius mollitia et libero inventore blanditiis aspernatur. Temporibus aut praesentium iure. Quaerat repudiandae qui aut quis sit. Doloremque est dolor accusamus veniam et quia magnam aperiam et.", new DateTime(2023, 3, 24, 17, 32, 52, 249, DateTimeKind.Unspecified).AddTicks(918), 8, 22, 2 },
                    { 15, "Laborum iusto labore veritatis. Similique adipisci natus aspernatur accusamus. A aut vel quia sed culpa dolores quia dignissimos quam. Iure iste magnam nulla quia quisquam aliquam non id. Quisquam nihil dolor tempore magni ut officia laudantium culpa et.", new DateTime(2023, 3, 29, 20, 8, 49, 33, DateTimeKind.Unspecified).AddTicks(3475), 9, 13, 2 },
                    { 16, "Necessitatibus sit libero sequi. Explicabo temporibus eum. Nobis vel rem.", new DateTime(2023, 3, 31, 14, 57, 42, 936, DateTimeKind.Unspecified).AddTicks(3147), 5, 45, 1 },
                    { 17, "Labore corporis doloremque quas ea ipsam voluptates eos et et. Aut sapiente repellat. Eveniet eum quasi ut qui fugiat et.", new DateTime(2023, 4, 15, 13, 13, 8, 280, DateTimeKind.Unspecified).AddTicks(3841), 11, 23, 2 },
                    { 18, "Perferendis odit enim. Veniam et perferendis itaque adipisci iure omnis ex dolore dolore. Doloribus vel architecto quisquam. Officiis omnis rerum ut ut unde consequuntur laborum iure.", new DateTime(2023, 4, 13, 5, 40, 37, 780, DateTimeKind.Unspecified).AddTicks(8457), 1, 44, 3 },
                    { 19, "Possimus corrupti eos est suscipit maiores nam nihil dignissimos. Amet laboriosam officia in non. Unde qui quidem et. Totam beatae non id et in. Sed molestias qui dolores qui in rem. Tempore iure iure eum quia pariatur.", new DateTime(2023, 4, 15, 4, 54, 34, 964, DateTimeKind.Unspecified).AddTicks(2469), 3, 11, 1 },
                    { 20, "Praesentium recusandae voluptas incidunt. Omnis eum nostrum velit. Tenetur fugiat qui fugit qui itaque rem. Necessitatibus amet molestiae molestiae totam neque laboriosam aut. Et enim dolores.", new DateTime(2023, 4, 2, 10, 24, 27, 657, DateTimeKind.Unspecified).AddTicks(1007), 5, 10, 3 },
                    { 21, "Dolor officia ut eveniet. Sit dicta et. Iste dolore explicabo voluptatem quaerat totam.", new DateTime(2023, 3, 26, 20, 23, 54, 339, DateTimeKind.Unspecified).AddTicks(5620), 6, 15, 2 },
                    { 22, "Dolorem necessitatibus quam occaecati voluptas sit. Et nihil accusamus qui voluptatem. Possimus aut nihil asperiores dolorem maxime.", new DateTime(2023, 3, 29, 12, 16, 1, 892, DateTimeKind.Unspecified).AddTicks(2886), 4, 40, 3 },
                    { 23, "Aliquid perferendis nam saepe non id ut inventore porro perferendis. Pariatur vel magnam neque vel qui aut nobis. Quasi eos et officia ab voluptas amet ut eligendi. Iusto aut vero. Esse consequatur laborum ut non ut quos.", new DateTime(2023, 4, 7, 7, 0, 42, 730, DateTimeKind.Unspecified).AddTicks(824), 11, 10, 3 },
                    { 24, "Repudiandae culpa non culpa quisquam aut quo. Quos excepturi beatae nulla rerum esse commodi commodi et. Mollitia doloribus quibusdam quo nesciunt velit rem. Quam ea odit ipsum possimus ea voluptatum quo ad. Neque deleniti quo alias ratione quo et quos provident quas.", new DateTime(2023, 4, 12, 7, 32, 42, 306, DateTimeKind.Unspecified).AddTicks(725), 4, 31, 1 },
                    { 25, "Officia qui illum beatae. Voluptas odit sint nobis aliquid omnis. Facere cum consequatur quia qui.", new DateTime(2023, 3, 23, 5, 0, 24, 645, DateTimeKind.Unspecified).AddTicks(2714), 5, 44, 1 },
                    { 26, "Vitae sint nam libero ut voluptatum similique incidunt quas. Deserunt vel saepe saepe. Sed quo quis autem. Autem tenetur animi id at. Ratione nihil est in.", new DateTime(2023, 3, 26, 5, 31, 59, 150, DateTimeKind.Unspecified).AddTicks(8282), 10, 38, 3 },
                    { 27, "Possimus expedita eos odio. Quia aliquam sit. Eos voluptatum veniam rerum. Commodi quibusdam quasi minima ab consequuntur voluptatem non vel. Sit et quas aut minima exercitationem qui voluptatem nesciunt.", new DateTime(2023, 4, 10, 5, 42, 55, 89, DateTimeKind.Unspecified).AddTicks(4553), 1, 12, 1 },
                    { 28, "Libero cumque esse in. Distinctio et possimus vero eaque veritatis tempora porro eligendi est. Eum nulla nemo aut magnam dolorum voluptatem et et. Quia quia voluptates.", new DateTime(2023, 3, 22, 17, 29, 3, 364, DateTimeKind.Unspecified).AddTicks(2740), 1, 36, 2 },
                    { 29, "Molestiae ut aliquid qui ipsum totam. Est et numquam. Odit praesentium omnis.", new DateTime(2023, 4, 15, 14, 11, 34, 588, DateTimeKind.Unspecified).AddTicks(9875), 3, 47, 2 },
                    { 30, "Ab unde excepturi quo tenetur suscipit quod pariatur est at. Molestias rerum enim dolor itaque voluptatum. Dolores facilis ratione.", new DateTime(2023, 3, 19, 15, 33, 17, 255, DateTimeKind.Unspecified).AddTicks(5779), 11, 40, 3 },
                    { 31, "Sunt impedit magni pariatur quidem voluptatum quia voluptas aut. Rerum et quo est aliquam officiis. Porro natus totam ratione. Voluptatem deleniti nemo autem animi. Beatae laudantium qui repudiandae voluptatem rem dolorem eos rerum. Eos aperiam occaecati.", new DateTime(2023, 3, 26, 7, 24, 30, 142, DateTimeKind.Unspecified).AddTicks(1758), 11, 42, 2 },
                    { 32, "Sint necessitatibus aspernatur officiis aut. Laudantium porro sed ducimus. Perspiciatis nulla debitis enim magnam esse similique est.", new DateTime(2023, 3, 28, 8, 22, 6, 748, DateTimeKind.Unspecified).AddTicks(6951), 10, 6, 2 },
                    { 33, "At non rerum neque. Porro rerum ratione. Soluta sint voluptatibus deserunt pariatur cum.", new DateTime(2023, 4, 9, 8, 37, 37, 536, DateTimeKind.Unspecified).AddTicks(4049), 7, 35, 3 },
                    { 34, "Perferendis nesciunt quia id rerum reiciendis. Voluptatem recusandae ea. Et distinctio sed impedit sint iste magni qui aut. Aliquid adipisci qui ut dolorem quisquam. Veniam laborum deserunt. Et facere voluptas consequatur quod molestiae.", new DateTime(2023, 4, 8, 21, 18, 52, 100, DateTimeKind.Unspecified).AddTicks(307), 3, 42, 2 },
                    { 35, "Qui fugit non qui ut. Velit fugiat sapiente. Veritatis distinctio sapiente vel totam inventore quaerat et eaque voluptatem. Ex fuga voluptates minima nisi omnis consequuntur rerum asperiores. Similique autem debitis magnam sequi eveniet.", new DateTime(2023, 3, 19, 9, 48, 0, 452, DateTimeKind.Unspecified).AddTicks(7089), 11, 21, 1 },
                    { 36, "Voluptatem est dolor voluptate non sapiente. Deleniti totam temporibus et. Temporibus quos voluptatem qui et ut quasi. Ut quas quos accusamus vitae natus enim nesciunt enim maiores. Et aut saepe commodi eius aspernatur recusandae nulla dolorem. Excepturi aut dolor unde voluptas laudantium distinctio debitis sed.", new DateTime(2023, 4, 16, 3, 17, 33, 602, DateTimeKind.Unspecified).AddTicks(3776), 5, 44, 2 },
                    { 37, "Velit nemo quia consequatur est ut non deleniti doloribus. Ut saepe magni et aliquid. Quam et architecto blanditiis quos quo voluptatem possimus. Et veniam minus.", new DateTime(2023, 4, 11, 15, 29, 31, 217, DateTimeKind.Unspecified).AddTicks(1740), 6, 7, 2 },
                    { 38, "Sit temporibus laborum deleniti sint nulla corporis. Autem non repellendus similique non architecto sit. Omnis odio quibusdam aperiam ut corrupti doloribus similique enim. Nobis voluptatum rerum neque est ea corrupti non repellendus error.", new DateTime(2023, 4, 15, 5, 6, 29, 538, DateTimeKind.Unspecified).AddTicks(1223), 1, 12, 2 },
                    { 39, "Sint odit ut non quia non unde dolor ad quia. Quis suscipit provident et ipsa. Occaecati nesciunt eum qui.", new DateTime(2023, 3, 30, 13, 38, 8, 752, DateTimeKind.Unspecified).AddTicks(7128), 7, 5, 2 },
                    { 40, "Dolorum cum est illo similique. Nemo similique aut animi maxime officiis voluptatum non dolorem rerum. Veritatis fugit consectetur magnam omnis eaque id et.", new DateTime(2023, 3, 27, 1, 37, 18, 211, DateTimeKind.Unspecified).AddTicks(4661), 1, 15, 2 },
                    { 41, "Ducimus sed et non aut nam quasi. Quos doloremque delectus et dignissimos laudantium facilis nobis ut. Maxime repellendus quia delectus consequatur eaque. Quidem officiis amet et iste non minima non perferendis. Possimus iste repellat veritatis eius.", new DateTime(2023, 3, 25, 21, 34, 13, 529, DateTimeKind.Unspecified).AddTicks(5937), 7, 9, 2 },
                    { 42, "Deserunt enim eius iure nihil tenetur perspiciatis rerum quaerat. Enim aut quasi totam autem aut. Itaque aspernatur nobis quo molestiae. Necessitatibus magni ut ea.", new DateTime(2023, 3, 23, 5, 53, 40, 915, DateTimeKind.Unspecified).AddTicks(6448), 6, 18, 1 },
                    { 43, "Sit ipsa id ut fugit magni reiciendis id quia. Vel dignissimos tempore non mollitia molestiae nihil perferendis est. Mollitia consequuntur neque. Voluptas quaerat cupiditate. Sit nobis modi eos nam consequuntur illo.", new DateTime(2023, 3, 22, 21, 0, 31, 28, DateTimeKind.Unspecified).AddTicks(5935), 5, 9, 3 },
                    { 44, "Hic iure tempore. Ducimus blanditiis ut voluptas aspernatur. Accusantium et qui nesciunt necessitatibus aut. Rerum vero est eum quisquam rerum. Cum dolor unde debitis ipsum labore autem. Aut itaque est quod quos placeat aut et omnis.", new DateTime(2023, 4, 14, 12, 52, 51, 446, DateTimeKind.Unspecified).AddTicks(9112), 10, 10, 1 },
                    { 45, "Delectus neque perspiciatis. Enim nemo velit quod incidunt placeat qui cum. Et explicabo deserunt vero nihil quia est facilis. Voluptatem iure placeat possimus illo illo iste.", new DateTime(2023, 3, 31, 1, 37, 11, 622, DateTimeKind.Unspecified).AddTicks(2039), 9, 10, 2 },
                    { 46, "Quo et unde occaecati perspiciatis nobis velit. Doloribus aliquid architecto numquam eveniet praesentium. Veritatis deleniti voluptatem quo. Praesentium perferendis sequi earum sint aliquam. Amet et exercitationem aut.", new DateTime(2023, 4, 15, 23, 19, 2, 291, DateTimeKind.Unspecified).AddTicks(4628), 6, 19, 1 },
                    { 47, "Amet harum sunt ducimus sunt. Eaque cum ut sequi. Voluptatem id aut enim deleniti voluptatem quia. Voluptatum id consequatur quis sed perferendis maiores optio. Qui magnam in beatae enim placeat exercitationem. Fuga doloribus quis at fugit ut.", new DateTime(2023, 3, 20, 1, 19, 50, 285, DateTimeKind.Unspecified).AddTicks(2245), 11, 44, 2 },
                    { 48, "Quos aut cumque velit cum. Nihil dolor nisi omnis et aut. Dolores sunt nostrum culpa excepturi quae. Soluta et at ad facere pariatur commodi laboriosam aperiam consectetur. Ratione nostrum autem ab in unde autem ea repellendus ipsa.", new DateTime(2023, 3, 18, 10, 59, 56, 988, DateTimeKind.Unspecified).AddTicks(8231), 2, 28, 1 },
                    { 49, "Et dolor soluta sint eaque qui. Rerum similique sequi molestiae ducimus eum consequuntur consequatur. Voluptatem error quis consequatur. Dignissimos excepturi maxime.", new DateTime(2023, 3, 20, 10, 14, 40, 224, DateTimeKind.Unspecified).AddTicks(8411), 3, 48, 1 },
                    { 50, "Repellendus quisquam atque praesentium maxime nesciunt aliquid tempore rerum quia. Minus deleniti nihil quia non sunt distinctio. Ut saepe quas ut praesentium ullam ipsum nam. Enim non natus voluptas beatae eligendi quis nihil sapiente quis. Quia autem deleniti dolorum sapiente modi.", new DateTime(2023, 4, 15, 21, 55, 5, 212, DateTimeKind.Unspecified).AddTicks(2841), 4, 32, 1 },
                    { 51, "Animi ut deserunt voluptatibus minima blanditiis accusantium. Sunt dolores velit ea. Voluptas illum et. Ab esse delectus sed minima totam dolor esse rerum.", new DateTime(2023, 3, 24, 7, 2, 47, 815, DateTimeKind.Unspecified).AddTicks(608), 4, 11, 3 },
                    { 52, "Aperiam reprehenderit a et corrupti. Sunt magnam recusandae non consequatur quo vel sed. Velit ea nihil dolor ipsa quia enim. Quia quibusdam velit similique reprehenderit. Temporibus eius commodi molestiae.", new DateTime(2023, 3, 27, 1, 18, 34, 29, DateTimeKind.Unspecified).AddTicks(4723), 2, 41, 2 },
                    { 53, "Architecto a neque doloremque. Totam possimus quibusdam exercitationem quis odit eum ut doloremque provident. Est inventore harum. Beatae ratione cumque aut ratione asperiores dignissimos repellendus.", new DateTime(2023, 4, 10, 15, 59, 35, 140, DateTimeKind.Unspecified).AddTicks(5224), 4, 20, 3 },
                    { 54, "Odit vitae ipsa minima nisi at ipsa. Enim odit quae sapiente voluptatibus suscipit qui. Animi similique quia dolorum vitae molestiae quaerat veritatis rerum repellat.", new DateTime(2023, 4, 16, 1, 1, 4, 370, DateTimeKind.Unspecified).AddTicks(9930), 1, 25, 2 },
                    { 55, "Maxime eligendi et ducimus et ducimus porro dolor. Laudantium officiis deserunt inventore sit perferendis aut reprehenderit. Velit ea numquam laudantium praesentium. Qui reiciendis reprehenderit nisi.", new DateTime(2023, 3, 19, 6, 55, 20, 683, DateTimeKind.Unspecified).AddTicks(662), 10, 39, 1 },
                    { 56, "Numquam nostrum esse rerum et. At qui sapiente dolorum. Nam consequatur cumque. Repudiandae in eius corporis voluptates et minima incidunt quod fuga. Inventore quis hic. Commodi aut quibusdam qui ut est eligendi.", new DateTime(2023, 3, 28, 11, 52, 43, 785, DateTimeKind.Unspecified).AddTicks(5684), 5, 28, 1 },
                    { 57, "Voluptas magni sequi ut est ea sint. Aut rem rerum dolorem recusandae inventore. Voluptatem quo explicabo atque dignissimos vel quaerat hic. Minima minus quaerat eius consequuntur pariatur aliquam commodi soluta. Reprehenderit est totam fugit consequatur aut aperiam dicta atque. Repudiandae ut aperiam nam voluptatem magni provident tenetur.", new DateTime(2023, 3, 28, 15, 48, 43, 517, DateTimeKind.Unspecified).AddTicks(2209), 1, 30, 1 },
                    { 58, "Eligendi a aspernatur optio quis. Eius cupiditate ratione. Libero veritatis pariatur quisquam.", new DateTime(2023, 3, 31, 15, 23, 14, 142, DateTimeKind.Unspecified).AddTicks(1722), 8, 15, 2 },
                    { 59, "Tenetur autem optio mollitia velit. Ipsam corporis exercitationem corporis expedita consequatur molestiae dolor quam velit. Suscipit porro qui velit reprehenderit possimus debitis repellat a minima. Tempora deserunt delectus eum consequatur eos suscipit voluptatem quaerat. Dolores quis porro sint tempora voluptas et. Harum libero ullam enim natus architecto culpa quia et.", new DateTime(2023, 4, 5, 4, 27, 26, 506, DateTimeKind.Unspecified).AddTicks(2514), 7, 31, 3 },
                    { 60, "Quas architecto nihil laboriosam dolorem alias similique voluptas. Sequi voluptate voluptas. Id dolores dolorem repudiandae autem.", new DateTime(2023, 3, 27, 0, 34, 44, 848, DateTimeKind.Unspecified).AddTicks(3587), 2, 26, 2 }
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
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 50);

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
                keyValue: 3);

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
                keyValue: 17);

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
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 28);

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
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 39);

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
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 48);

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

            migrationBuilder.RenameColumn(
                name: "DateOfOrder",
                table: "Orders",
                newName: "date");
        }
    }
}
