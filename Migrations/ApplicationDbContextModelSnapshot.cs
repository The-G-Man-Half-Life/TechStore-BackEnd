﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechStore_BackEnd.Data;

#nullable disable

namespace TechStore_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("TechStore_BackEnd.Models.Brand", b =>
                {
                    b.Property<int>("Brand_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("brand_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Brand_id"));

                    b.Property<string>("Brand_description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("brand_description");

                    b.Property<string>("Brand_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("brand_name");

                    b.HasKey("Brand_id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Brand_id = 1,
                            Brand_description = "Dignissimos aut quod rem dolore consequatur est non harum consequatur.",
                            Brand_name = "Cummings, Gaylord and Sipes"
                        },
                        new
                        {
                            Brand_id = 2,
                            Brand_description = "Autem voluptatem vitae vel sunt laudantium nostrum harum minus asperiores.",
                            Brand_name = "Adams - Howe"
                        },
                        new
                        {
                            Brand_id = 3,
                            Brand_description = "Aut eum voluptas cumque sunt hic est et ad itaque.",
                            Brand_name = "Rodriguez Group"
                        },
                        new
                        {
                            Brand_id = 4,
                            Brand_description = "Dolor sapiente non perspiciatis pariatur neque blanditiis adipisci et dolorum.",
                            Brand_name = "Wintheiser Group"
                        },
                        new
                        {
                            Brand_id = 5,
                            Brand_description = "Molestias asperiores eum rerum enim quo adipisci earum omnis ea.",
                            Brand_name = "Thompson, Schoen and Witting"
                        },
                        new
                        {
                            Brand_id = 6,
                            Brand_description = "Eligendi repudiandae ratione qui provident dolorem est a sed sunt.",
                            Brand_name = "Dare Inc"
                        },
                        new
                        {
                            Brand_id = 7,
                            Brand_description = "Alias autem saepe debitis a sequi et qui rerum dignissimos.",
                            Brand_name = "Oberbrunner, Donnelly and Schneider"
                        },
                        new
                        {
                            Brand_id = 8,
                            Brand_description = "Sed autem laboriosam incidunt rem corporis et quia est aut.",
                            Brand_name = "Hickle, Bartell and Ward"
                        },
                        new
                        {
                            Brand_id = 9,
                            Brand_description = "Quos incidunt nobis dolor ipsam dignissimos sed optio totam dicta.",
                            Brand_name = "Heathcote - Gerhold"
                        },
                        new
                        {
                            Brand_id = 10,
                            Brand_description = "Nisi aut sed sint sed voluptate sequi quaerat ut non.",
                            Brand_name = "Ebert, Walsh and Kessler"
                        },
                        new
                        {
                            Brand_id = 11,
                            Brand_description = "Vel asperiores iste nobis nihil dolores et est eos quo.",
                            Brand_name = "Gerlach - Schaden"
                        },
                        new
                        {
                            Brand_id = 12,
                            Brand_description = "Est vel voluptas voluptatibus assumenda nesciunt suscipit alias doloremque iure.",
                            Brand_name = "Beahan - Walter"
                        },
                        new
                        {
                            Brand_id = 13,
                            Brand_description = "Sed velit blanditiis nesciunt consequatur ut ut voluptas rem et.",
                            Brand_name = "Lemke - Fahey"
                        },
                        new
                        {
                            Brand_id = 14,
                            Brand_description = "Impedit praesentium autem deleniti amet sint doloremque dolorem et corporis.",
                            Brand_name = "Runolfsson, Kemmer and Nader"
                        },
                        new
                        {
                            Brand_id = 15,
                            Brand_description = "Ipsam ab sed deleniti eveniet omnis voluptas quam in delectus.",
                            Brand_name = "Tremblay - Wuckert"
                        },
                        new
                        {
                            Brand_id = 16,
                            Brand_description = "Delectus consequatur numquam sunt quia quibusdam sit qui voluptatum fugit.",
                            Brand_name = "Ullrich - Spencer"
                        },
                        new
                        {
                            Brand_id = 17,
                            Brand_description = "Vitae quia suscipit voluptates consequuntur error voluptatem necessitatibus consequatur tempore.",
                            Brand_name = "Carroll - Hahn"
                        },
                        new
                        {
                            Brand_id = 18,
                            Brand_description = "Cumque sed qui laboriosam sit nulla illum non accusamus illum.",
                            Brand_name = "Deckow, Yundt and Kuhn"
                        },
                        new
                        {
                            Brand_id = 19,
                            Brand_description = "Est sint et qui aut expedita aut consequatur et est.",
                            Brand_name = "Leannon LLC"
                        },
                        new
                        {
                            Brand_id = 20,
                            Brand_description = "Quia iusto illo quis aut et earum necessitatibus et doloribus.",
                            Brand_name = "Schowalter Inc"
                        },
                        new
                        {
                            Brand_id = 21,
                            Brand_description = "Excepturi harum ea nemo nihil est quia enim saepe vel.",
                            Brand_name = "Nader - Bechtelar"
                        },
                        new
                        {
                            Brand_id = 22,
                            Brand_description = "Sequi sit doloribus est cumque est quos eius iusto rem.",
                            Brand_name = "Boyer LLC"
                        },
                        new
                        {
                            Brand_id = 23,
                            Brand_description = "Nam voluptatem mollitia fugit et saepe voluptates consequuntur occaecati distinctio.",
                            Brand_name = "Senger and Sons"
                        },
                        new
                        {
                            Brand_id = 24,
                            Brand_description = "Repellat eveniet aut deleniti eos est maiores sed odio dolorem.",
                            Brand_name = "Barton, Bode and Erdman"
                        },
                        new
                        {
                            Brand_id = 25,
                            Brand_description = "In commodi a quidem ea soluta magnam ipsum velit repellendus.",
                            Brand_name = "Upton - Robel"
                        },
                        new
                        {
                            Brand_id = 26,
                            Brand_description = "Quae natus ea a consectetur aut reiciendis quis nemo fugit.",
                            Brand_name = "Morissette, Sanford and Abernathy"
                        },
                        new
                        {
                            Brand_id = 27,
                            Brand_description = "Eum error dolor est aut voluptates quae aliquid laborum magni.",
                            Brand_name = "Satterfield, Hoppe and Ernser"
                        },
                        new
                        {
                            Brand_id = 28,
                            Brand_description = "Placeat ex voluptas aut ea blanditiis quo iste consequatur aliquam.",
                            Brand_name = "Barrows - Johnson"
                        },
                        new
                        {
                            Brand_id = 29,
                            Brand_description = "Mollitia illum officiis magnam debitis et non ea et similique.",
                            Brand_name = "Bins - Wuckert"
                        },
                        new
                        {
                            Brand_id = 30,
                            Brand_description = "Qui et expedita enim aut repellat eligendi doloremque asperiores adipisci.",
                            Brand_name = "Lehner - Johns"
                        },
                        new
                        {
                            Brand_id = 31,
                            Brand_description = "Placeat itaque doloribus dicta repellendus vero modi rerum sunt beatae.",
                            Brand_name = "Pfannerstill Group"
                        },
                        new
                        {
                            Brand_id = 32,
                            Brand_description = "Maxime architecto sed rerum eveniet ut facere in quaerat vel.",
                            Brand_name = "McCullough Group"
                        },
                        new
                        {
                            Brand_id = 33,
                            Brand_description = "Quo vel accusantium qui fugiat veniam distinctio minus est omnis.",
                            Brand_name = "Shanahan - Morissette"
                        },
                        new
                        {
                            Brand_id = 34,
                            Brand_description = "Velit velit soluta voluptatem nostrum ea ut ipsam consequatur dolorem.",
                            Brand_name = "Nader - Rodriguez"
                        },
                        new
                        {
                            Brand_id = 35,
                            Brand_description = "Aut aut occaecati error voluptatum est libero qui asperiores molestiae.",
                            Brand_name = "Stark Inc"
                        },
                        new
                        {
                            Brand_id = 36,
                            Brand_description = "Ipsam eligendi sunt distinctio asperiores repellat totam nostrum repellendus aut.",
                            Brand_name = "Jones Inc"
                        },
                        new
                        {
                            Brand_id = 37,
                            Brand_description = "Itaque et voluptas natus consectetur esse dolores similique nostrum soluta.",
                            Brand_name = "Frami, Cronin and Kutch"
                        },
                        new
                        {
                            Brand_id = 38,
                            Brand_description = "Voluptatem inventore corporis eaque quis saepe quis ipsam voluptas porro.",
                            Brand_name = "Gislason Group"
                        },
                        new
                        {
                            Brand_id = 39,
                            Brand_description = "Earum ut voluptatem esse illum suscipit est molestiae modi autem.",
                            Brand_name = "Osinski, Stark and Okuneva"
                        },
                        new
                        {
                            Brand_id = 40,
                            Brand_description = "Unde eveniet velit ut voluptatum eligendi harum cupiditate voluptas commodi.",
                            Brand_name = "Mraz, Swift and Hilpert"
                        },
                        new
                        {
                            Brand_id = 41,
                            Brand_description = "Corrupti rem eos corrupti commodi vel ut at ipsa assumenda.",
                            Brand_name = "Cassin and Sons"
                        },
                        new
                        {
                            Brand_id = 42,
                            Brand_description = "Eos molestias autem qui molestiae eius corporis id libero excepturi.",
                            Brand_name = "Emard Group"
                        },
                        new
                        {
                            Brand_id = 43,
                            Brand_description = "Consequatur dolorum et rem repudiandae autem ipsa maiores quia nobis.",
                            Brand_name = "Hermiston - Raynor"
                        },
                        new
                        {
                            Brand_id = 44,
                            Brand_description = "Vero dolorum qui qui ullam dolor deleniti veritatis ut est.",
                            Brand_name = "Langosh, Ernser and Bartoletti"
                        },
                        new
                        {
                            Brand_id = 45,
                            Brand_description = "Ut quo occaecati quasi provident corporis quo corrupti laboriosam impedit.",
                            Brand_name = "Berge, Funk and Metz"
                        },
                        new
                        {
                            Brand_id = 46,
                            Brand_description = "Accusamus deserunt dolorum dolores quis qui soluta tempora iusto blanditiis.",
                            Brand_name = "Sawayn, Padberg and Monahan"
                        },
                        new
                        {
                            Brand_id = 47,
                            Brand_description = "Impedit voluptatem similique vitae nam maiores consequuntur necessitatibus molestiae tenetur.",
                            Brand_name = "Balistreri and Sons"
                        },
                        new
                        {
                            Brand_id = 48,
                            Brand_description = "Ipsam eum ratione eaque sequi dicta debitis illo dicta neque.",
                            Brand_name = "Tillman, Goldner and Thompson"
                        },
                        new
                        {
                            Brand_id = 49,
                            Brand_description = "Blanditiis accusamus hic dolor et rem enim sint quia accusantium.",
                            Brand_name = "Becker - Krajcik"
                        },
                        new
                        {
                            Brand_id = 50,
                            Brand_description = "Voluptatum eos tempora adipisci possimus omnis unde est et odit.",
                            Brand_name = "Bruen - Marks"
                        },
                        new
                        {
                            Brand_id = 51,
                            Brand_description = "Ad et quisquam nam repellat sit quia quaerat veniam porro.",
                            Brand_name = "Murazik - Streich"
                        },
                        new
                        {
                            Brand_id = 52,
                            Brand_description = "Sed eum rerum deleniti asperiores non voluptatem accusamus assumenda aut.",
                            Brand_name = "Hauck, Gaylord and Rippin"
                        },
                        new
                        {
                            Brand_id = 53,
                            Brand_description = "Dolor dicta omnis sint magni pariatur inventore mollitia facere sint.",
                            Brand_name = "Keeling LLC"
                        },
                        new
                        {
                            Brand_id = 54,
                            Brand_description = "Natus sit id facere aut aspernatur iure eligendi deleniti nesciunt.",
                            Brand_name = "Pacocha, Luettgen and Bergnaum"
                        },
                        new
                        {
                            Brand_id = 55,
                            Brand_description = "Et dicta excepturi quisquam magnam qui omnis consequatur quo quia.",
                            Brand_name = "Bayer - Sipes"
                        },
                        new
                        {
                            Brand_id = 56,
                            Brand_description = "Natus dolorem sunt consequuntur explicabo itaque magni molestias amet totam.",
                            Brand_name = "Little - Flatley"
                        },
                        new
                        {
                            Brand_id = 57,
                            Brand_description = "Et nisi eveniet illum aut libero nulla qui ut quo.",
                            Brand_name = "Wunsch - O'Conner"
                        },
                        new
                        {
                            Brand_id = 58,
                            Brand_description = "Et error eos aut tempore rerum libero facilis sit nemo.",
                            Brand_name = "Deckow - Bailey"
                        },
                        new
                        {
                            Brand_id = 59,
                            Brand_description = "Atque iste rerum officia ut eveniet perspiciatis id recusandae harum.",
                            Brand_name = "Wilderman and Sons"
                        },
                        new
                        {
                            Brand_id = 60,
                            Brand_description = "Ex aut quam atque porro ut ut dolorum totam sed.",
                            Brand_name = "Abshire - Sauer"
                        },
                        new
                        {
                            Brand_id = 61,
                            Brand_description = "Et dolor quae eligendi suscipit et consectetur sed aut omnis.",
                            Brand_name = "Sauer, Hagenes and DuBuque"
                        },
                        new
                        {
                            Brand_id = 62,
                            Brand_description = "Consectetur beatae ipsa impedit architecto cum consectetur facilis magni beatae.",
                            Brand_name = "Blick, Dicki and Christiansen"
                        },
                        new
                        {
                            Brand_id = 63,
                            Brand_description = "Provident sed iste et voluptate iure cupiditate rerum in et.",
                            Brand_name = "Feest Group"
                        },
                        new
                        {
                            Brand_id = 64,
                            Brand_description = "Neque cupiditate tenetur quas eveniet eos numquam quis explicabo facilis.",
                            Brand_name = "Fritsch Group"
                        },
                        new
                        {
                            Brand_id = 65,
                            Brand_description = "Non ex sed dolores sint sint vero nostrum ipsa inventore.",
                            Brand_name = "Lang LLC"
                        },
                        new
                        {
                            Brand_id = 66,
                            Brand_description = "Ducimus sunt quia cum et quam magnam fuga qui sed.",
                            Brand_name = "Abernathy - Blick"
                        },
                        new
                        {
                            Brand_id = 67,
                            Brand_description = "Enim rerum officiis vitae nisi quia repellendus consequatur labore voluptatem.",
                            Brand_name = "Nikolaus, Weimann and Mayert"
                        },
                        new
                        {
                            Brand_id = 68,
                            Brand_description = "Sed voluptatibus adipisci non dolorum id consequuntur dolore at id.",
                            Brand_name = "Donnelly and Sons"
                        },
                        new
                        {
                            Brand_id = 69,
                            Brand_description = "Neque numquam voluptatem rerum aut nihil iste atque natus velit.",
                            Brand_name = "Bruen LLC"
                        },
                        new
                        {
                            Brand_id = 70,
                            Brand_description = "Soluta debitis aut voluptate autem id voluptatum tempora tempora nihil.",
                            Brand_name = "Hettinger LLC"
                        },
                        new
                        {
                            Brand_id = 71,
                            Brand_description = "Numquam quasi deserunt non eum enim accusantium velit et perspiciatis.",
                            Brand_name = "Harvey Inc"
                        },
                        new
                        {
                            Brand_id = 72,
                            Brand_description = "Illum nulla rerum dignissimos eius dolorem voluptatibus eligendi iusto officia.",
                            Brand_name = "Gusikowski - Feil"
                        },
                        new
                        {
                            Brand_id = 73,
                            Brand_description = "Saepe est rerum et dolorum aliquam aspernatur perferendis nobis maxime.",
                            Brand_name = "Sporer - Kuhn"
                        },
                        new
                        {
                            Brand_id = 74,
                            Brand_description = "Cum qui ut unde facilis illum deleniti sit ea necessitatibus.",
                            Brand_name = "Cremin - Doyle"
                        },
                        new
                        {
                            Brand_id = 75,
                            Brand_description = "Minus occaecati molestiae officiis quia nihil maiores qui delectus illo.",
                            Brand_name = "Bruen - Gulgowski"
                        },
                        new
                        {
                            Brand_id = 76,
                            Brand_description = "Quia quis aut est illum et consequatur rerum ad placeat.",
                            Brand_name = "Stokes - Leannon"
                        },
                        new
                        {
                            Brand_id = 77,
                            Brand_description = "Ipsum quisquam aut ut eius possimus non est nesciunt dolorum.",
                            Brand_name = "Terry, Hickle and Kub"
                        },
                        new
                        {
                            Brand_id = 78,
                            Brand_description = "Perspiciatis mollitia ducimus eveniet iste sed deleniti qui aut facere.",
                            Brand_name = "Boyer, Goodwin and O'Connell"
                        },
                        new
                        {
                            Brand_id = 79,
                            Brand_description = "Omnis quasi consequuntur dolorum animi impedit eligendi incidunt ut ut.",
                            Brand_name = "Wunsch - Quigley"
                        },
                        new
                        {
                            Brand_id = 80,
                            Brand_description = "Necessitatibus quia doloribus dolorem enim aut natus omnis quam nam.",
                            Brand_name = "Rolfson, Johns and Ullrich"
                        },
                        new
                        {
                            Brand_id = 81,
                            Brand_description = "Est temporibus voluptatibus nisi et ut culpa et et nesciunt.",
                            Brand_name = "Cruickshank LLC"
                        },
                        new
                        {
                            Brand_id = 82,
                            Brand_description = "Et qui omnis pariatur labore ipsa architecto non est est.",
                            Brand_name = "Bechtelar, Bosco and Stroman"
                        },
                        new
                        {
                            Brand_id = 83,
                            Brand_description = "A et consequatur quidem quibusdam molestiae sapiente debitis iure et.",
                            Brand_name = "Marquardt - Roob"
                        },
                        new
                        {
                            Brand_id = 84,
                            Brand_description = "Voluptatem harum sed excepturi in blanditiis voluptatem deserunt eaque perferendis.",
                            Brand_name = "Greenholt Inc"
                        },
                        new
                        {
                            Brand_id = 85,
                            Brand_description = "Repellendus non voluptatem culpa possimus exercitationem temporibus cumque modi ducimus.",
                            Brand_name = "Hauck Group"
                        },
                        new
                        {
                            Brand_id = 86,
                            Brand_description = "Non eum optio reprehenderit placeat ad est omnis est illum.",
                            Brand_name = "Larkin, Kautzer and Rath"
                        },
                        new
                        {
                            Brand_id = 87,
                            Brand_description = "Possimus est id ratione sed blanditiis eos quis ratione assumenda.",
                            Brand_name = "Renner LLC"
                        },
                        new
                        {
                            Brand_id = 88,
                            Brand_description = "Recusandae exercitationem quod facere fuga cupiditate debitis iste et facere.",
                            Brand_name = "Lang - Christiansen"
                        },
                        new
                        {
                            Brand_id = 89,
                            Brand_description = "Aut asperiores officiis voluptas deleniti et voluptatem qui assumenda tempore.",
                            Brand_name = "Nienow - Ruecker"
                        },
                        new
                        {
                            Brand_id = 90,
                            Brand_description = "Et odio et quae ut quod consequatur minus atque tempore.",
                            Brand_name = "Zemlak - Reinger"
                        },
                        new
                        {
                            Brand_id = 91,
                            Brand_description = "Corrupti vitae eos dolores nam sunt quo veritatis illo harum.",
                            Brand_name = "Blanda, Kessler and Pagac"
                        },
                        new
                        {
                            Brand_id = 92,
                            Brand_description = "Velit velit qui officiis eligendi rerum beatae reprehenderit incidunt esse.",
                            Brand_name = "Kunze - Hegmann"
                        },
                        new
                        {
                            Brand_id = 93,
                            Brand_description = "Laboriosam molestiae quidem incidunt est earum non repellat voluptas occaecati.",
                            Brand_name = "Brown, Connelly and Spencer"
                        },
                        new
                        {
                            Brand_id = 94,
                            Brand_description = "Dolorem ut amet non nostrum sint vel id dolores quod.",
                            Brand_name = "Sauer - Schamberger"
                        },
                        new
                        {
                            Brand_id = 95,
                            Brand_description = "Magnam perspiciatis ab sint quasi et et aut facilis corrupti.",
                            Brand_name = "Hayes - Walter"
                        },
                        new
                        {
                            Brand_id = 96,
                            Brand_description = "Perspiciatis voluptates voluptas amet in nisi esse dolor sunt dolores.",
                            Brand_name = "Gulgowski Group"
                        },
                        new
                        {
                            Brand_id = 97,
                            Brand_description = "Eum magnam molestiae voluptas voluptas ea ex est distinctio velit.",
                            Brand_name = "Welch LLC"
                        },
                        new
                        {
                            Brand_id = 98,
                            Brand_description = "Maiores itaque velit est ducimus quisquam laborum minima assumenda ut.",
                            Brand_name = "Lakin, Kihn and Ziemann"
                        },
                        new
                        {
                            Brand_id = 99,
                            Brand_description = "Similique voluptatem et et iste impedit numquam laboriosam debitis neque.",
                            Brand_name = "Harris and Sons"
                        },
                        new
                        {
                            Brand_id = 100,
                            Brand_description = "Voluptas similique nihil tempore placeat animi labore est et modi.",
                            Brand_name = "Dicki - Lubowitz"
                        });
                });

            modelBuilder.Entity("TechStore_BackEnd.Models.Carrier", b =>
                {
                    b.Property<int>("Carrier_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("carrier_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Carrier_id"));

                    b.Property<string>("Carrier_description")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("carrier_description");

                    b.Property<string>("Carrier_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("carrier_name");

                    b.HasKey("Carrier_id");

                    b.ToTable("Carriers");
                });

            modelBuilder.Entity("TechStore_BackEnd.Models.Shipment", b =>
                {
                    b.Property<int>("Shipment_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("shipment_id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Shipment_id"));

                    b.Property<int>("Carrier_id")
                        .HasColumnType("int")
                        .HasColumnName("carrier_id");

                    b.Property<DateOnly>("Shipment_arrival_date")
                        .HasColumnType("date")
                        .HasColumnName("shipment_arrival_date");

                    b.Property<DateOnly>("Shipment_order_date")
                        .HasColumnType("date")
                        .HasColumnName("shipment_order_date");

                    b.Property<double>("Shipment_price_usa")
                        .HasColumnType("double")
                        .HasColumnName("shipment_price_usa");

                    b.Property<double>("Shipment_weight_kg")
                        .HasColumnType("double")
                        .HasColumnName("shipment_weight_kg");

                    b.HasKey("Shipment_id");

                    b.HasIndex("Carrier_id");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("TechStore_BackEnd.Models.Shipment", b =>
                {
                    b.HasOne("TechStore_BackEnd.Models.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("Carrier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrier");
                });
#pragma warning restore 612, 618
        }
    }
}
