namespace diplom.Migrations
{
    using diplom.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<diplom.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(diplom.Models.ApplicationDbContext context)
        {
            //var userManager = new ApplicationUserManager(new UserStore<Models.ApplicationUser>(context));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //var role1 = new IdentityRole { Name = "Administrator" };
            //var role2 = new IdentityRole { Name = "User" };
            //var role3 = new IdentityRole { Name = "Moderator" };

            //roleManager.Create(role1);
            //roleManager.Create(role2);

            //var admin = new Models.ApplicationUser { Id = Guid.NewGuid().ToString(), Email = "admin@mail.ru", UserName = "admin" };
            //string password = "3904And`";
            //var result = userManager.Create(admin, password);
            //if (result.Succeeded)
            //{
            //    userManager.AddToRole(admin.Id, role1.Name);
            //}
            //base.Seed(context);
        }
        //protected override void Seed(diplom.Models.ApplicationDbContext context)
        //{
        //    context.Regions.Add(
        //         new Region
        //         {
        //             Id = Guid.NewGuid().ToString(),
        //             Name = "Минская",
        //             Cities = new List<City>()
        //             {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Березино",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Борисов",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Вилейка",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Воложин",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Дзержинск",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Клецк",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Копыль",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Крупки",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Логойск",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Любань",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Минск",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Молодечно",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Мядель",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Несвиж",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Марьина Горка",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Слуцк",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Смолевичи",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Солигорск",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Старые Дороги",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Столбцы",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Узда",
        //                     RegionName = "Минская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Червень",
        //                     RegionName = "Минская"
        //                }
        //             }
        //         });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Брестская",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Брест",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Барановичи",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Берёза",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ганцевичи",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Дрогичин",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Жабинка",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Иваново",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ивацевичи",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Каменец",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Кобрин",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лунинец",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ляховичи",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Малорита",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Пинск",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Пружаны",
        //                     RegionName = "Брестская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Столин",
        //                     RegionName = "Брестская"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Гродненская",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Берестовица",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Волковыск",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Вороново",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Гродно",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Дятлово",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Зельва",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ивье",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Кореличи",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лида",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Мосты",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Новогрудок",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ошмяны",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Островец",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Свислочь",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Слоним",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Сморгонь",
        //                     RegionName = "Гродненская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Щучин",
        //                     RegionName = "Гродненская"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Могилевская",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Белыничи",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Бобруйск",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Быхов",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Глуск",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Горки",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Дрибин",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Кировск",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Климовичи",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Кличев",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Краснополье",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Кричев",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Круглое",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Костюковичи",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Могилёв",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Мстиславль",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Осиповичи",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Славгород",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Хотимск",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Чаусы",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Чериков",
        //                     RegionName = "Могилевская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Шклов",
        //                     RegionName = "Могилевская"
        //                }

        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Гомельская",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Брагин",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Буда-Кошелёво",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ветка",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Гомель",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Добруш",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ельск",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Житковичи",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Жлобин",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Калинковичи",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Корма",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лельчицы",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лоев",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Мозырь",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Наровля",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Октябрьский",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Петриков",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Речица",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Рогачёв",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Светлогорск",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Хойники",
        //                     RegionName = "Гомельская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Чечерск",
        //                     RegionName = "Гомельская"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Витебская",
        //            Cities = new List<City>()
        //            {
        //                new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Витебск",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Бешенковичи",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Браслав",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Верхнедвинск",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Глубокое",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Городок",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Докшицы",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Дубровно",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лепель",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Лиозно",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Миоры",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Орша",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Полоцк",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Поставы",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Россоны",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Сенно",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Толочин",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Ушачи",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Чашники",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Шарковщина",
        //                     RegionName = "Витебская"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "Шумилино",
        //                     RegionName = "Витебская"
        //                }
        //            }
        //        });



        //    context.Categories.Add(
        //           new Category
        //           {
        //               Id = Guid.NewGuid().ToString(),
        //               Name = "Мода и стиль",
        //               Subcategories = new List<Subcategory>()
        //               {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Мужская одежда",
        //                    Points = 15,
        //                    CategoryName = "Мода и стиль"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Женская одежда",
        //                    Points = 15,
        //                    CategoryName = "Мода и стиль"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Мужская обувь",
        //                    Points = 10,
        //                    CategoryName = "Мода и стиль"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Женская обувь",
        //                    Points = 10,
        //                    CategoryName = "Мода и стиль"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Аксессуары и часы",
        //                    Points = 8,
        //                    CategoryName = "Мода и стиль"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Косметика и парфюмерия",
        //                    Points = 8,
        //                    CategoryName = "Мода и стиль"
        //                }
        //               }
        //           });
        //    context.Categories.Add(
        //        new Category
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Техника",
        //            Subcategories = new List<Subcategory>()
        //            {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Аудиотехника",
        //                    Points = 25,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "ТВ и видеотехника",
        //                    Points = 30,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Компьютеры и комплектующие",
        //                    Points = 35,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Фототехника и оптика",
        //                    Points = 25,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Телефоны",
        //                    Points = 15,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Оргтехника",
        //                    Points = 15,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Бытовая техника",
        //                    Points = 30,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Планшеты и электронные книги",
        //                    Points = 15,
        //                    CategoryName = "Техника"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Игры и приставки",
        //                    Points = 35,
        //                    CategoryName = "Техника"
        //                }
        //            }
        //        });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "Все для дома",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Мебель и интерьер",
        //                    Points = 20,
        //                    CategoryName = "Все для дома"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Хозяйственные товары",
        //                    Points = 15,
        //                    CategoryName = "Все для дома"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Посуда и кухонные принадлежности",
        //                    Points = 10,
        //                    CategoryName = "Все для дома"
        //                },
        //                 new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Комнатные растения",
        //                    Points = 5,
        //                    CategoryName = "Все для дома"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Бытовая техника",
        //                    Points = 8,
        //                    CategoryName = "Все для дома"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //        new Category
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "Авто и транспорт",
        //            Subcategories = new List<Subcategory>()
        //            {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Легковые авто",
        //                    Points = 200,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Грузовики и автобусы",
        //                    Points = 250,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Мотоциклы и мототехника",
        //                    Points = 180,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Тракторы и сельхозтехника",
        //                    Points = 150,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Спецтехника",
        //                    Points = 120,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Шины и диски",
        //                    Points = 80,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Запчасти расходники химия",
        //                    Points = 50,
        //                    CategoryName = "Авто и транспорт"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Прицепы и полуприцепы",
        //                    Points = 100,
        //                    CategoryName = "Авто и транспорт"
        //                }
        //            }
        //        });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "Ремонт и стройка",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Строительный инструмент",
        //                    Points = 10,
        //                    CategoryName = "Ремонт и стройка"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Сантехника",
        //                    Points = 25,
        //                    CategoryName = "Ремонт и стройка"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Стройматериалы",
        //                    Points = 10,
        //                    CategoryName = "Ремонт и стройка"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Отделочные материалы",
        //                    Points = 25,
        //                    CategoryName = "Ремонт и стройка"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Окна и двери",
        //                    Points = 30,
        //                    CategoryName = "Ремонт и стройка"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "Сад и огород",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Садовая мебель и мангалы",
        //                    Points = 10,
        //                    CategoryName = "Сад и огород"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Садовые растения рассада и семена",
        //                    Points = 8,
        //                    CategoryName = "Сад и огород"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Садовая техника и инвентарь",
        //                    Points = 7,
        //                    CategoryName = "Сад и огород"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Теплицы",
        //                    Points = 10,
        //                    CategoryName = "Сад и огород"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Садовые аксессуары",
        //                    Points = 10
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Удобрения и агрохимия",
        //                    Points = 10,
        //                    CategoryName = "Сад и огород"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Все для пчеловода",
        //                    Points = 10,
        //                    CategoryName = "Сад и огород"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "Животные",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Домашние питомцы",
        //                    Points = 0,
        //                    CategoryName = "Животные"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Сельхоз животные",
        //                    Points = 3,
        //                    CategoryName = "Животные"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Товары для животных",
        //                    Points = 5,
        //                    CategoryName = "Животные"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Вязка животных",
        //                    Points = 5,
        //                    CategoryName = "Животные"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //      new Category
        //      {
        //          Id = Guid.NewGuid().ToString(),
        //          Name = "Прочее",
        //          Subcategories = new List<Subcategory>()
        //          {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Бюро находок",
        //                    Points = 3,
        //                    CategoryName = "Прочее"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Канцелярские товары",
        //                    Points = 3,
        //                    CategoryName = "Прочее"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Медицинские товары",
        //                    Points = 5,
        //                    CategoryName = "Прочее"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Продукты питания",
        //                    Points = 5,
        //                    CategoryName = "Прочее"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "Все остальное",
        //                    Points = 3,
        //                    CategoryName = "Прочее"
        //                }
        //          }
        //      });
        //    base.Seed(context);
        //    base.Seed(context);
        //}
    }
}
