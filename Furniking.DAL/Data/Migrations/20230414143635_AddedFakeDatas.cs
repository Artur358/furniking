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
                    { 1, 0, "c7b4b666-38d4-4319-a606-d35bb4b642f7", "user@gmail.com", false, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEJ9oxPbm0ApqYnR/fumfChP8DaVOaUfiQIi6zH75SqeptfUfC+eSwtQ+EWB7T4Gb4Q==", null, false, null, false, "user@gmail.com" },
                    { 2, 0, "6eb2b563-0de1-4d5e-a68b-2261fe921131", "moderator@gmail.com", false, false, null, "MODERATOR@GMAIL.COM", "MODERATOR@GMAIL.COM", "AQAAAAIAAYagAAAAEFTy10Pb0ueGaAtJYncZkTWzdwwOxABp0kYZdzC/Op7THlWcZSj18c/EDfXqaolqpw==", null, false, null, false, "moderator@gmail.com" },
                    { 3, 0, "3d6aeb4d-2ac7-47b8-b2c2-61b2c3df4a36", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEAUieu8dk45LF0ibjiFd4w2C7cP5WPwWGouwg1QaJlDh6RMhjzbiaXPP/0K33Mxn0g==", null, false, null, false, "admin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Jewelery" },
                    { 2, "Health, Music & Games" },
                    { 3, "Garden" },
                    { 4, "Industrial & Shoes" },
                    { 5, "Books, Movies & Music" },
                    { 6, "Electronics, Electronics & Beauty" }
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
                    { 1, 3, "Et quia illo ipsum necessitatibus. Dicta maiores nemo est dolorem quo. Quam fugiat assumenda dolor officia voluptas est ut. Cumque est fugit incidunt. Voluptatem in laboriosam modi labore voluptatem quia velit cum. Minus dicta fuga neque voluptatibus.", "Unbranded Metal Bacon", 398.04292209804220m },
                    { 2, 3, "Odit quaerat rerum adipisci deleniti sint aut iure. Eos ullam vel inventore nostrum inventore ratione. Error maiores possimus dolor assumenda. Consequatur officia vel quae velit. Ut rerum dolor eveniet rem expedita minima sapiente quos et. Odit omnis sapiente cumque est.", "Ergonomic Fresh Computer", 307.175615296282360m },
                    { 3, 6, "Et ut nihil sequi soluta et. Occaecati doloremque commodi rem. Quis aperiam iure qui labore sint placeat. Aut harum asperiores id voluptates rerum accusantium qui neque. Nobis eum iure quisquam et. Nihil iure quo deserunt amet veritatis aspernatur quos.", "Tasty Plastic Salad", 517.250014988352130m },
                    { 4, 3, "Fugiat rerum nostrum nam quod at similique dolores. Quibusdam et aperiam in molestiae. Inventore quaerat sapiente. Enim temporibus id illo sit natus esse inventore et. Autem expedita soluta rem iusto aspernatur numquam.", "Tasty Wooden Shirt", 637.135781339755270m },
                    { 5, 2, "Quia similique commodi. Excepturi quam doloremque dolorum consequatur et consequatur velit dolore. Asperiores recusandae animi expedita aut nulla nulla in et. Incidunt et aut tempora optio vel maiores ut ut.", "Sleek Frozen Chair", 260.872971585523210m },
                    { 6, 2, "Aut perferendis amet similique dolores quia reiciendis quam soluta. Eos aut laudantium repudiandae sit commodi sint ullam aperiam voluptatem. Quisquam ratione porro maiores sequi culpa voluptatem libero illo qui. Veniam similique vero expedita non sint odio iure. Voluptatibus recusandae et tempora optio qui eius consectetur id. Culpa sit error.", "Ergonomic Steel Computer", 796.9002516805870m },
                    { 7, 2, "Iste eligendi dolorum. Ea et vel aut voluptatem iure molestias aspernatur dignissimos explicabo. Earum laborum laudantium quo eius ex sed voluptas corporis. Dolorum expedita quidem magni et nihil eos explicabo corrupti amet.", "Licensed Metal Pizza", 127.361896266282580m },
                    { 8, 4, "Reprehenderit numquam quod minus sapiente officia libero. Blanditiis repellendus iure in possimus dolor omnis et. Molestiae nihil dolorem quia id consequuntur. Enim id dolore nihil fuga. Quia doloremque et. Ut cupiditate occaecati ullam et voluptatem.", "Rustic Wooden Ball", 840.974327370839080m },
                    { 9, 5, "Aut et tempora error aut soluta harum. Alias doloribus quia aut laborum expedita quas nisi. Voluptas ex illo quae. Aperiam consectetur aperiam suscipit iste et illum dolorum reiciendis. Illum soluta dolore nesciunt voluptatem sint.", "Gorgeous Concrete Chips", 620.323214950726750m },
                    { 10, 2, "Ratione reprehenderit molestiae. Perferendis saepe culpa. Eum ut enim et quisquam quibusdam sapiente. Blanditiis voluptatibus esse beatae.", "Rustic Plastic Soap", 243.834638740993180m },
                    { 11, 2, "Occaecati ipsum quis rerum qui molestiae accusantium porro. Quo assumenda aut molestias quia consequatur tempore. Sed enim commodi quibusdam et temporibus distinctio.", "Tasty Soft Sausages", 579.135878603723530m },
                    { 12, 3, "Consequatur ut ea quidem doloremque. Hic nihil voluptatibus. Laborum eos maxime nihil.", "Rustic Wooden Cheese", 778.367579758063120m },
                    { 13, 4, "Facere quis velit nostrum sequi dolores est autem molestiae incidunt. Magni cupiditate incidunt eius harum eum facilis laboriosam ullam temporibus. Qui porro debitis eaque qui expedita quibusdam.", "Rustic Wooden Chair", 524.891670815215540m },
                    { 14, 3, "Rerum quo error. Nam sed quod fugiat distinctio cumque qui in id. Ratione quam itaque omnis. Et omnis aliquid aut repellendus voluptatibus.", "Sleek Wooden Pants", 180.208344691938520m },
                    { 15, 1, "Adipisci omnis eum et quo. Eaque magni rerum atque non aut iusto dolor. Est occaecati at aliquid est laboriosam odit aut vero ut.", "Sleek Rubber Chips", 644.138110148473810m },
                    { 16, 6, "Nemo aut inventore. Facilis et quam cum eum id. Qui praesentium aperiam sed velit sint nostrum fuga nobis exercitationem. Dolores iusto accusamus et ut pariatur repudiandae.", "Gorgeous Cotton Sausages", 234.525501283963330m },
                    { 17, 6, "Reprehenderit quidem quia libero voluptas magnam. Doloremque magnam at atque. Aspernatur accusantium illo sit et. Ea nobis eveniet illum fuga rerum laboriosam non. Eum est maiores amet sit. Vel dolorum saepe possimus soluta possimus eum dolor unde pariatur.", "Refined Wooden Soap", 210.76271353489780m },
                    { 18, 5, "Et necessitatibus eligendi dolorem accusantium quo id modi. Velit magnam iure est qui. Laborum excepturi in sed quisquam et. Aliquam sunt tempore non maiores optio sint dolores error.", "Gorgeous Metal Ball", 681.238745614578790m },
                    { 19, 2, "Optio ea et omnis et sapiente velit ducimus dolorum. Amet ratione eveniet consequuntur. Itaque ducimus dolor eaque quia.", "Ergonomic Granite Chicken", 187.584922465774120m },
                    { 20, 2, "Quia omnis et adipisci totam aut quaerat. Culpa quidem nobis quibusdam deserunt assumenda. Nisi eaque et qui dolores magni. Doloribus aut qui aut dolor rerum rerum perspiciatis odio. Voluptas odio repellendus accusantium quis non. Est temporibus dolore veniam est rerum eaque tenetur.", "Practical Soft Chicken", 54.6455908760667850m },
                    { 21, 1, "Accusamus odio quod facere expedita modi sapiente dolorum est nihil. Sit corporis soluta praesentium omnis sit voluptatem eum. Mollitia nostrum incidunt facilis quis voluptatum.", "Generic Metal Computer", 676.036728291159280m },
                    { 22, 3, "Minima perspiciatis adipisci. Ipsam hic blanditiis aliquam voluptatibus eos at incidunt iste. Quis quia at et est et accusamus nulla.", "Small Concrete Shoes", 446.436750984017410m },
                    { 23, 1, "Incidunt harum earum. Natus qui nulla maiores expedita nostrum eum nemo qui sit. Nesciunt pariatur veritatis. Enim officiis qui ut illum odit illum similique ut.", "Fantastic Plastic Keyboard", 231.316975036309240m },
                    { 24, 6, "Qui consequuntur est eos dolores aliquid iste est natus qui. Quibusdam ullam eos sit laudantium quisquam nesciunt qui deleniti. Qui quo maiores sed rerum eveniet repudiandae.", "Small Granite Shirt", 919.772637896927530m },
                    { 25, 4, "Similique maxime doloremque. Aut molestias perspiciatis expedita officia. Quod dolor soluta cupiditate est aliquam. Molestias earum dolorem nam sequi. Voluptas et vel quis laborum neque voluptatem reprehenderit. Aut inventore repellendus minima natus facilis ut aliquid.", "Rustic Metal Table", 742.966794131703670m },
                    { 26, 6, "Quas fugit consequatur natus. Magni itaque enim velit in architecto nesciunt natus. Eum et nemo rem aut. Cumque temporibus sed aut ea minus. Totam ipsam occaecati explicabo. Tempora praesentium eveniet maxime.", "Fantastic Rubber Cheese", 271.653111163188910m },
                    { 27, 6, "In sint deleniti minima quis nulla veritatis explicabo sint perferendis. Tempora et asperiores iure doloremque vitae suscipit consequuntur commodi voluptatem. Quia voluptatem et magni.", "Licensed Wooden Chair", 367.144996013049970m },
                    { 28, 5, "Expedita eaque et asperiores facilis aut. Voluptas a similique aperiam sapiente debitis et quam. Placeat voluptatem exercitationem vero inventore ipsam quo suscipit. Consequatur impedit optio molestias quis totam ex vel laboriosam officia.", "Generic Plastic Gloves", 93.6980056792877140m },
                    { 29, 1, "Ab hic temporibus quia qui perspiciatis voluptas cupiditate. Ipsam architecto assumenda magni. Velit libero aliquid aut officiis corrupti. Distinctio labore est asperiores dolor. Quae iste nihil deserunt sed sit ut ratione. Dolorum eum et sint omnis necessitatibus quas exercitationem ullam.", "Rustic Wooden Shoes", 402.065960352464530m },
                    { 30, 2, "Id fugiat quisquam impedit nesciunt doloribus ab deleniti id ea. Fugit quia sit deserunt voluptatibus. Id veritatis quis. Aut architecto saepe et magnam dicta.", "Fantastic Wooden Mouse", 524.820430308464830m },
                    { 31, 3, "Eligendi suscipit aut deleniti ut doloremque quaerat nihil et. Soluta quisquam architecto et laudantium voluptatum. Asperiores sunt id sint voluptate harum. Sunt dolores beatae non quas.", "Practical Steel Computer", 964.416462915327940m },
                    { 32, 5, "Qui reprehenderit quidem velit natus voluptatem aliquid dicta soluta nam. Dolore ratione eius qui commodi sit et rerum eligendi ut. Ab earum officiis est illo et et nemo. Veritatis minima harum ducimus nihil suscipit reprehenderit nesciunt. Et et atque ratione fugiat est aut vel. Atque magnam minima est.", "Handmade Wooden Gloves", 390.985238019581470m },
                    { 33, 5, "Eaque ullam repellat quia sint non dolor vitae. Error dolores occaecati inventore quia voluptatum. Ut hic quos blanditiis aut nihil et. Voluptatem vitae dolore odit soluta sint laborum fugiat sunt.", "Handcrafted Soft Table", 345.005750527037920m },
                    { 34, 2, "Aut odit nobis ea. Quasi molestiae ad molestias excepturi sunt quos iste temporibus tempora. Debitis ipsam dolorum et sit. Sit eos cumque rerum blanditiis.", "Refined Steel Towels", 222.017630556613420m },
                    { 35, 2, "Ut neque sed odio tenetur mollitia voluptatem enim. Doloribus ut deleniti pariatur. Assumenda quod quasi consequatur molestias. Dolorum ab autem illum qui. Ut animi suscipit ratione magni facilis eveniet quam et. Debitis voluptate nostrum sint.", "Licensed Wooden Keyboard", 819.985143642371290m },
                    { 36, 3, "Odit beatae esse perferendis quo veniam sunt reprehenderit. Porro autem beatae autem saepe est qui voluptas repellat. Incidunt ea rem qui blanditiis et est. Expedita sed sit.", "Generic Cotton Hat", 578.824015302704260m },
                    { 37, 3, "Eos corrupti doloribus ea et. Laudantium aut et iste optio voluptatem autem adipisci qui. Enim non fuga error commodi. At laudantium sed nostrum. Necessitatibus odio voluptas ea magni sed facere sunt totam.", "Handcrafted Concrete Chips", 418.526213611483990m },
                    { 38, 5, "Consectetur porro est unde magnam commodi nemo natus sapiente. Saepe sint error fuga similique autem eos similique. Possimus vero vitae culpa vero sequi et sunt quas. Ratione omnis pariatur.", "Refined Fresh Salad", 759.752529631877530m },
                    { 39, 1, "Aperiam debitis beatae aliquid occaecati. Excepturi est neque a possimus. Eveniet quos enim ullam non praesentium et vel. Voluptatum sint est aut non ab. Eos id et. Exercitationem ducimus quam est fuga aut aut est consequatur sunt.", "Unbranded Soft Bike", 547.654936610814220m },
                    { 40, 2, "Quo et sunt distinctio. Sit veritatis voluptatem omnis et. Quo ut culpa sint enim.", "Generic Fresh Bike", 949.659879454136830m },
                    { 41, 4, "Voluptatibus modi dolorem quos. Impedit sit voluptate voluptas. Non minus qui quisquam facilis accusantium voluptas quia molestiae vero. Quo optio quasi voluptas. Quam inventore pariatur beatae dignissimos recusandae nisi qui quia earum. In quasi doloribus quia quia maxime.", "Unbranded Steel Soap", 488.904242819953060m },
                    { 42, 6, "Praesentium doloremque consequatur corporis. Ex qui sint illo vel. Omnis consequatur quia qui laudantium accusamus illo. Dolorem accusamus recusandae suscipit rerum veniam sequi. Illum sapiente non magni amet consectetur. Quos quia esse.", "Handmade Granite Shoes", 234.684924826882960m },
                    { 43, 4, "Quae soluta porro esse atque quaerat eius qui qui. Repellat magnam a ipsa eos provident cumque quidem. Fuga recusandae esse quibusdam fugit quis.", "Unbranded Soft Shirt", 128.6882517376270m },
                    { 44, 4, "Aut maxime at ipsam voluptatibus similique quidem enim maxime omnis. Dolorem et incidunt et esse ea eos fuga. Totam odio quasi et omnis eum. Labore provident deserunt ut necessitatibus ipsa pariatur quasi eum cumque. Nam natus enim hic in sed aut debitis labore aut.", "Unbranded Steel Fish", 420.505943914605880m },
                    { 45, 2, "Odit incidunt illo at. Magnam sunt et culpa odio soluta. Eligendi rerum sapiente aspernatur qui.", "Licensed Soft Shoes", 171.143135877480130m },
                    { 46, 4, "Quos fugiat pariatur ipsa dolorem aut. Aut delectus et adipisci dolores. Pariatur temporibus est quia modi mollitia consectetur temporibus commodi qui.", "Tasty Fresh Bacon", 166.926708490706110m },
                    { 47, 6, "Voluptatum quo sed veniam omnis est at aut. Reiciendis veniam natus omnis qui. Placeat deleniti voluptatum qui eveniet magnam quia. Aut rerum voluptatum. Consequatur deserunt consequatur. Excepturi quia omnis accusantium ab quia dolorum quo asperiores.", "Practical Plastic Keyboard", 161.212298619430180m },
                    { 48, 5, "Neque nostrum non ut repellat suscipit. Voluptas fugiat eum. Maxime ut ad autem. Eos quaerat quas quidem qui corporis nam. Soluta debitis eius eos qui unde atque.", "Refined Frozen Pants", 758.877896589267610m },
                    { 49, 4, "Deleniti voluptatem laboriosam sunt qui rerum quis. Quod qui illo. Distinctio modi quidem asperiores atque aperiam nihil. Ut accusamus repellendus ut tempora et quis. Illo sunt sit repellat facilis dolores.", "Sleek Steel Towels", 832.596230431278820m },
                    { 50, 5, "Doloremque facere ut perspiciatis aliquam nihil blanditiis sit assumenda. Beatae eligendi accusamus. Corrupti officiis reiciendis voluptatum ipsa delectus eos. Doloribus velit natus autem rem rerum. Blanditiis dolores tenetur totam et quisquam ratione sed ea excepturi.", "Tasty Soft Chair", 156.236508768952360m }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "DateTime", "Evaluation", "FurnitureId", "UserId" },
                values: new object[,]
                {
                    { 1, "At omnis voluptates omnis. Nobis aliquid ipsa et. Consequatur dignissimos omnis pariatur unde. Ipsa recusandae architecto temporibus ut voluptatem voluptatem ipsum blanditiis. Quidem sed velit id omnis voluptas.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(5963), 1, 15, 2 },
                    { 2, "Quas culpa assumenda exercitationem. Tempore eum aut. Aut dolorem esse voluptas. Voluptate numquam impedit vel dicta voluptatem. Adipisci perferendis modi eius totam rerum aperiam qui. Et id corporis aut provident corrupti et.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(7613), 9, 28, 1 },
                    { 3, "Qui molestias cum consectetur nihil. Ut molestiae nobis dolores. Aut nostrum qui voluptatem omnis. Iure nam omnis sapiente nemo eligendi. Sit qui veniam non. Unde accusantium aut earum ipsum cupiditate quos.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(7800), 8, 44, 1 },
                    { 4, "Suscipit et porro. Laudantium est magnam illum tempora veritatis cumque blanditiis. Delectus sit ea porro veniam. Reiciendis occaecati exercitationem molestiae sed quia voluptatem voluptatem. Nostrum ipsa enim et fuga. Consequuntur dolores et hic sed qui.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(7954), 9, 9, 1 },
                    { 5, "Vel est perferendis totam dolor consectetur. Asperiores vero consequuntur quis. Sint rerum magni sunt repellat. Expedita ea nesciunt sint nesciunt aut. Eos molestias mollitia vel suscipit ullam laudantium eligendi.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8098), 6, 39, 1 },
                    { 6, "Dolorem saepe dolorem. Saepe eum impedit at. Et quo delectus similique voluptas impedit.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8216), 11, 42, 3 },
                    { 7, "Optio odio ipsam iusto iusto eos recusandae sit soluta cum. Pariatur qui ea ad debitis repudiandae porro. Magnam quam nihil nihil ipsum.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8308), 7, 13, 1 },
                    { 8, "Exercitationem est corrupti autem illo voluptatum non deleniti illo. Quas architecto error illo labore magnam et ipsa. Vitae et deserunt exercitationem aut qui dolores aut. Velit animi vel. In quo repudiandae nobis aut. Ut illum qui nostrum error sit possimus nulla.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8483), 1, 49, 3 },
                    { 9, "Voluptatum et modi sit est. Vel enim sed alias accusantium. Aut ut eum reiciendis sit eum provident. Incidunt eveniet aut sit. Error harum aliquam.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8591), 2, 9, 1 },
                    { 10, "In aut blanditiis distinctio. Excepturi facere et tempore enim. Incidunt unde rerum debitis aut vero beatae vero.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8670), 9, 44, 2 },
                    { 11, "Et voluptatum quaerat. Ratione iure minima neque occaecati. Sit quisquam quia. Et doloribus quos autem rerum.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8753), 8, 42, 1 },
                    { 12, "Minus earum nihil. Est mollitia animi consequatur nostrum. Cupiditate est quas quisquam molestiae et sequi delectus. Illo facere ipsum dolores ex perspiciatis consequatur. Sapiente quaerat asperiores nobis.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(8863), 2, 27, 1 },
                    { 13, "At perspiciatis pariatur voluptatem odio voluptas debitis quia et tempora. Consequatur voluptate enim. A provident illum accusamus nam est nam corrupti. Quidem explicabo itaque sit qui voluptatem aut. Repellat in ipsa omnis illo consequatur ipsum deserunt magni. Porro eligendi amet eligendi ut cupiditate.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9028), 10, 47, 1 },
                    { 14, "Quia amet sed culpa. Quos voluptatibus non quia. Odit qui aperiam sint consectetur iste consectetur eius sapiente soluta. Qui et eius possimus rem omnis natus dolor. Cumque quo corrupti voluptatem fugit ipsam voluptatem nulla omnis. Fugiat fuga et quidem repellat adipisci eligendi quo quo.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9234), 8, 38, 1 },
                    { 15, "Nihil labore vero qui sint sunt. Repellat ut quidem. Nostrum voluptatum saepe est ad. Ut iste occaecati quo at excepturi non et qui. Modi voluptas tempore quo sunt. Corrupti modi iste aut magnam voluptas sed.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9361), 1, 10, 2 },
                    { 16, "Saepe quam nobis excepturi. Ipsam deleniti repudiandae aut quos aut aliquam eaque quidem. Veritatis enim sit quam non corrupti reprehenderit et autem repellendus. Qui libero ex expedita aut eligendi omnis voluptatem nisi odit. Tempora voluptatum perspiciatis iure est expedita animi qui laudantium ea.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9512), 7, 29, 2 },
                    { 17, "Doloribus non beatae est error excepturi rerum rerum. Harum nihil eligendi quisquam. Quos dolores fugiat quis unde culpa tempore voluptatum eum. Tempora et non earum mollitia sint expedita. Provident nemo aspernatur.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9629), 1, 44, 1 },
                    { 18, "Velit quae iure vero officiis iste enim cum. Minima voluptatem voluptatum dolor eum quia commodi qui possimus. Ducimus vel nisi dolores non et. Et non optio possimus ut. Rerum explicabo facere dolorem nemo at voluptate qui est.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9760), 9, 7, 1 },
                    { 19, "Facilis et omnis deleniti rerum ducimus ut. Dolorem optio quaerat voluptatem sunt repellat magni. Voluptatem est cum sit praesentium blanditiis odio perspiciatis.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9843), 8, 23, 3 },
                    { 20, "Recusandae et quia enim in sunt laborum. Non voluptates ipsa non recusandae vel officiis sint. Non explicabo distinctio sapiente dolorum sed. Et ut voluptas asperiores mollitia dignissimos perferendis expedita. Fugit voluptatum ut quas. Ducimus nemo ipsam harum.", new DateTime(2023, 4, 14, 14, 36, 35, 563, DateTimeKind.Utc).AddTicks(9979), 3, 33, 2 },
                    { 21, "Omnis quia culpa et aliquam est facilis veritatis a et. Veniam est ut et sit aut. Deleniti dicta ut ab. Nihil fuga consequuntur voluptate repellat esse est et est.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(88), 11, 43, 3 },
                    { 22, "Eos tempore maiores nesciunt qui occaecati sit sunt magnam. Alias rem hic voluptas quibusdam velit hic sunt eos. Reiciendis qui quibusdam quaerat vel officiis et aspernatur minus. Placeat rem totam. In cupiditate consequuntur incidunt dolorum quidem et molestias est repellendus. Et nihil aliquid quis.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(240), 3, 4, 3 },
                    { 23, "Et cum deserunt. Eos necessitatibus perspiciatis enim et quae est iusto quis. Est provident iusto et illo quaerat.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(321), 8, 10, 1 },
                    { 24, "Amet eum eum ut. Consequatur et natus culpa suscipit dolor modi sequi temporibus. Mollitia sit quisquam ducimus sed esse error. Et nulla dignissimos. Voluptas ea sunt voluptatibus maxime consequatur sit. Id quis sit.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(438), 9, 19, 2 },
                    { 25, "Corporis velit ullam aut provident sint. Nisi omnis facere assumenda sed voluptatem aliquid in. Temporibus est consequatur quidem libero perspiciatis. Dolores deserunt minima est quia non labore debitis libero. Et aspernatur quis corporis quia molestiae ut ducimus voluptatem et. Culpa quasi maxime impedit error quod culpa.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(595), 5, 35, 3 },
                    { 26, "Sed qui quos nihil doloribus. Omnis modi repellendus in non. Sunt explicabo et. Nesciunt beatae debitis laboriosam iusto sed.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(680), 11, 47, 1 },
                    { 27, "Ducimus at molestiae voluptatibus enim. Vero rerum nisi molestias odit perferendis non totam. Nulla qui quia iste.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(752), 4, 8, 1 },
                    { 28, "Quisquam voluptates omnis. Eveniet voluptatum nobis officia dolorem. Consequuntur aut sint mollitia nemo.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(814), 6, 26, 3 },
                    { 29, "Est velit qui qui autem. Et eum est quis est officia. Officia impedit quisquam vel. Qui id rem. Nesciunt qui voluptas animi facilis harum quia dolorem molestiae laboriosam.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(929), 10, 23, 3 },
                    { 30, "Excepturi commodi aut. Nam nobis impedit sed omnis repellat harum architecto. Rerum fuga consequatur occaecati eligendi dolorum. Voluptates eum dolores aut.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1093), 9, 19, 2 },
                    { 31, "Quisquam at maxime delectus enim sit nihil et. Nisi inventore soluta et quia ratione voluptas nemo incidunt. Illo quibusdam eaque quis in quos sunt ut. Non qui voluptas optio et qui vel omnis.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1219), 1, 44, 3 },
                    { 32, "Numquam et quidem. Rem quo quod delectus odit voluptatem voluptas iure. Praesentium eum quod suscipit.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1289), 3, 50, 2 },
                    { 33, "Dolor numquam doloremque et et quam autem iusto enim. In hic possimus repudiandae qui rem harum. Rerum eos reiciendis.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1364), 8, 29, 2 },
                    { 34, "Deleniti expedita vero nulla non fugiat quia cupiditate omnis ut. In laboriosam non quis enim iusto ad. Quibusdam sit magnam non. Eos hic quisquam et quia. Omnis odit voluptas et magnam. Ipsa deserunt neque nihil perferendis aut beatae.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1497), 2, 17, 3 },
                    { 35, "Rerum recusandae dolorem. Aut enim cum molestiae molestiae. Maxime rem aut dolor voluptates et necessitatibus nulla porro. Adipisci inventore suscipit ut et hic nostrum. Eveniet voluptatem et.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1599), 10, 8, 1 },
                    { 36, "Expedita itaque sint. Aut asperiores explicabo porro error est. Laborum rem cupiditate cumque recusandae sed. Aut repellendus numquam officia repellat fugiat. Ab modi accusamus saepe ullam voluptas occaecati.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1707), 4, 9, 2 },
                    { 37, "Sit vel facilis quo est at quaerat suscipit corporis et. Sint itaque consequatur est. Ducimus dolores ea similique consequatur delectus.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1782), 7, 10, 2 },
                    { 38, "Voluptas doloremque atque modi molestiae hic eius quas. Quia autem fuga atque accusantium non blanditiis consequatur in. Omnis aut fuga ut blanditiis eligendi ex odit nostrum. Vitae explicabo rem quia. Necessitatibus qui similique quia quia aperiam qui.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(1910), 8, 2, 3 },
                    { 39, "Consequatur excepturi nam laudantium ut voluptatem consequatur omnis blanditiis. Laudantium officiis facilis necessitatibus quia asperiores dolore. Consequatur inventore dicta assumenda libero voluptatum ipsa dolorum saepe omnis. Quisquam non velit. Est dolores laudantium veniam et id non dignissimos atque.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2045), 10, 47, 2 },
                    { 40, "Excepturi omnis animi error blanditiis quod ad non nostrum. Cumque ut rerum impedit dolores est voluptates qui voluptatem. Sequi aspernatur iure eaque tempore cum molestiae. Nihil velit quisquam error aut neque sint veritatis dolore. Aliquam consequatur maiores autem officia culpa. Sed et id dolorem aliquid repellat.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2196), 5, 16, 1 },
                    { 41, "Aut iure nesciunt magni exercitationem aperiam repudiandae. Vero et quis ipsa sint. Sunt quasi eius velit. Eaque eum aut ut ut ratione. Nam repellendus porro quia perferendis deleniti sint. Sint occaecati nam.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2320), 1, 45, 1 },
                    { 42, "Excepturi consequatur ratione in eum quos voluptate. Tempore incidunt necessitatibus ducimus fugit quaerat quia in quod at. Recusandae vitae aut voluptates sed omnis consequatur omnis error ullam. In perferendis et.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2423), 10, 41, 2 },
                    { 43, "Doloribus dolores et dolores. Illum commodi quos accusantium molestiae. Sit nostrum sed officiis. Officiis ducimus exercitationem occaecati ipsa nisi placeat. Quidem et dicta id.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2520), 7, 38, 1 },
                    { 44, "Eveniet molestiae consectetur ea quia nemo aliquam repellendus. Vitae in et tenetur nostrum ullam excepturi ea. Velit nam ullam assumenda. A dolorum non magnam repudiandae voluptas vel officia dolor. Autem occaecati quam nobis minima vel dolores quos ea.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2643), 5, 25, 2 },
                    { 45, "Eum qui odio ut delectus. Dolorem porro sunt nobis sit magni. Amet aut sit id animi sed est iste pariatur aut. Incidunt ipsa quo omnis sunt rerum quia omnis. Qui molestiae saepe non quisquam dicta odit est.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2771), 6, 13, 1 },
                    { 46, "Magnam omnis nisi rerum animi perferendis est est voluptas. Dolorum eos eos at ut nobis tempora neque iste. A magni dignissimos. Quo occaecati et voluptas perspiciatis. Non non ad at aut rerum et qui nostrum. Vitae id suscipit voluptatem.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(2907), 6, 49, 1 },
                    { 47, "Repellat sit vitae tempore molestiae corporis sit sit enim consequatur. Voluptas vero occaecati et eos error nobis. Totam pariatur ex expedita officiis deserunt quia est eligendi iste. Molestias nostrum voluptatibus doloremque sequi et laudantium natus perferendis quia. Velit non quas sunt est. Ipsam alias aliquid aut.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3063), 11, 41, 2 },
                    { 48, "Nihil perspiciatis a facere. Debitis sapiente aliquid quia est eligendi fugiat recusandae voluptatem perspiciatis. Numquam ut sunt asperiores exercitationem ipsam aut enim. Et voluptas laboriosam eligendi provident incidunt vel facilis aut. Inventore velit in nemo quo.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3209), 3, 21, 3 },
                    { 49, "Recusandae quo facilis quia porro repellat laborum esse repudiandae iusto. Dolores et nesciunt velit quod. Cum quo eius aut ducimus possimus omnis deserunt. Qui sed aperiam sit exercitationem alias dolor qui. Repellendus fugiat ea iusto suscipit voluptas eos eaque aspernatur sit.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3346), 1, 42, 3 },
                    { 50, "Hic soluta veniam porro excepturi iste non. Natus officia qui quos aliquid qui consequatur quisquam voluptas autem. Iusto iure tempore exercitationem non sunt velit. Sit eos dignissimos. Dignissimos quisquam aut id illum consequuntur.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3467), 1, 32, 1 },
                    { 51, "Quia non ea unde et ea quam ut explicabo aut. Minus dolor sunt voluptas. Deserunt voluptatem dolor aliquam aspernatur odit eligendi officiis. Iusto similique minima quibusdam.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3566), 8, 33, 1 },
                    { 52, "Repellat et a dolores et perferendis ad odit eveniet soluta. Facilis sunt nisi non quam ad. Provident molestiae in reiciendis est incidunt nam atque. Animi dicta quia eligendi illo quaerat vero vel placeat. Beatae porro et cupiditate ratione repudiandae voluptate temporibus. Consequuntur quia ut ut molestias eos.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3718), 4, 2, 2 },
                    { 53, "Saepe soluta et accusamus magni culpa velit deserunt deleniti. Et placeat illum. Ea voluptate voluptatem nemo animi a sed autem incidunt. Ipsum consequuntur non.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3813), 5, 44, 1 },
                    { 54, "Amet autem quasi a reprehenderit. Nam minus blanditiis. Qui illo est unde quo impedit. Magnam consectetur in sit. Voluptate nemo ducimus ipsum deleniti voluptas deleniti. Autem suscipit et nesciunt enim quibusdam tempore consequatur sunt.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(3936), 11, 50, 3 },
                    { 55, "Rem ut quas voluptas eius reprehenderit corrupti cumque error. Dolorem repudiandae vel nihil ipsa numquam numquam est cupiditate. Et neque qui repellat corporis nesciunt eligendi neque. Facilis impedit facilis sit provident. Voluptate necessitatibus molestias nihil voluptates quasi omnis id cum.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4066), 4, 45, 1 },
                    { 56, "Eos doloribus culpa. Voluptatibus sunt voluptas. Quo mollitia perspiciatis dolorem earum.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4128), 10, 5, 2 },
                    { 57, "Quia eaque id magnam quibusdam nisi beatae. Saepe aliquam est beatae sit architecto reprehenderit perferendis recusandae quia. Et non exercitationem ad quia saepe.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4212), 3, 33, 2 },
                    { 58, "Occaecati fugit facere exercitationem sed tempora. In eos voluptatem hic rerum quibusdam veniam ullam libero. Et distinctio mollitia est iure nobis. Quos voluptatem omnis illo quisquam mollitia sed quod dolorum rem. Ut id facere iure suscipit fuga. Adipisci pariatur assumenda pariatur libero odio fugiat.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4360), 11, 14, 1 },
                    { 59, "Non corporis amet occaecati fuga omnis et vitae. Error enim fugit hic. Cupiditate nobis accusantium dolores. Quidem et consectetur possimus.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4447), 5, 28, 2 },
                    { 60, "Dolorem iste magni omnis sapiente eligendi ducimus. Maxime quam deleniti quia quidem. Et dolorem omnis ut.", new DateTime(2023, 4, 14, 14, 36, 35, 564, DateTimeKind.Utc).AddTicks(4512), 1, 9, 1 }
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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 6);

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
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 24);

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
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 48);

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
                keyValue: 2);

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
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 14);

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
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 23);

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
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 29);

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
                keyValue: 35);

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
                keyValue: 41);

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
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Furnitures",
                keyColumn: "Id",
                keyValue: 49);

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
