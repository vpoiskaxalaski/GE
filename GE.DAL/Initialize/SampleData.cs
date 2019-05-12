using GE.DAL.Model;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace GE.DAL.Initialize
{
    public static class SampleData
    {

        public static void Initialize(DatabaseContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            if (!context.Regions.Any())
            {
                context.Regions.Add(
                new Region
                {

                    Name = "Минская",
                    Cities = new List<City>()
                    {
                       new City
                        {

                             Name = "Березино",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Борисов",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Вилейка",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Воложин",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Дзержинск",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Клецк",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Копыль",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Крупки",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Логойск",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Любань",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Минск",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Молодечно",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Мядель",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Несвиж",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Марьина Горка",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Слуцк",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Смолевичи",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Солигорск",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Старые Дороги",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Столбцы",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Узда",
                             RegionName = "Минская"
                        },
                       new City
                        {

                             Name = "Червень",
                             RegionName = "Минская"
                        }
                    }
                });
                context.Regions.Add(
                    new Region
                    {

                        Name = "Брестская",
                        Cities = new List<City>()
                        {
                       new City
                        {

                             Name = "Брест",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Барановичи",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Берёза",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Ганцевичи",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Дрогичин",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Жабинка",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Иваново",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Ивацевичи",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Каменец",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Кобрин",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Лунинец",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Ляховичи",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Малорита",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Пинск",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Пружаны",
                             RegionName = "Брестская"
                        },
                       new City
                        {

                             Name = "Столин",
                             RegionName = "Брестская"
                        }
                        }
                    });
                context.Regions.Add(
                    new Region
                    {

                        Name = "Гродненская",
                        Cities = new List<City>()
                        {
                       new City
                        {

                             Name = "Берестовица",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Волковыск",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Вороново",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Гродно",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Дятлово",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Зельва",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Ивье",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Кореличи",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Лида",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Мосты",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Новогрудок",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Ошмяны",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Островец",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Свислочь",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Слоним",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Сморгонь",
                             RegionName = "Гродненская"
                        },
                       new City
                        {

                             Name = "Щучин",
                             RegionName = "Гродненская"
                        }
                        }
                    });
                context.Regions.Add(
                    new Region
                    {

                        Name = "Могилевская",
                        Cities = new List<City>()
                        {
                       new City
                        {

                             Name = "Белыничи",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Бобруйск",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Быхов",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Глуск",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Горки",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Дрибин",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Кировск",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Климовичи",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Кличев",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Краснополье",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Кричев",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Круглое",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Костюковичи",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Могилёв",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Мстиславль",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Осиповичи",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Славгород",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Хотимск",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Чаусы",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Чериков",
                             RegionName = "Могилевская"
                        },
                       new City
                        {

                             Name = "Шклов",
                             RegionName = "Могилевская"
                        }

                        }
                    });
                context.Regions.Add(
                    new Region
                    {

                        Name = "Гомельская",
                        Cities = new List<City>()
                        {
                       new City
                        {

                             Name = "Брагин",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Буда-Кошелёво",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Ветка",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Гомель",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Добруш",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Ельск",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Житковичи",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Жлобин",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Калинковичи",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Корма",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Лельчицы",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Лоев",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Мозырь",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Наровля",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Октябрьский",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Петриков",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Речица",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Рогачёв",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Светлогорск",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Хойники",
                             RegionName = "Гомельская"
                        },
                       new City
                        {

                             Name = "Чечерск",
                             RegionName = "Гомельская"
                        }
                        }
                    });
                context.Regions.Add(
                new Region
                {

                    Name = "Витебская",
                    Cities = new List<City>()
                    {
                        new City
                        {

                             Name = "Витебск",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Бешенковичи",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Браслав",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Верхнедвинск",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Глубокое",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Городок",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Докшицы",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Дубровно",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Лепель",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Лиозно",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Миоры",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Орша",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Полоцк",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Поставы",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Россоны",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Сенно",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Толочин",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Ушачи",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Чашники",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Шарковщина",
                             RegionName = "Витебская"
                        },
                       new City
                        {

                             Name = "Шумилино",
                             RegionName = "Витебская"
                        }
                    }
                });

                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.Add(
                       new Category
                       {

                           Name = "Мода и стиль",
                           Subcategories = new List<Subcategory>()
                           {
                        new Subcategory
                        {

                            Name = "Мужская одежда",
                            Points = 15,
                            CategoryName = "Мода и стиль"
                        },
                        new Subcategory
                        {

                            Name = "Женская одежда",
                            Points = 15,
                            CategoryName = "Мода и стиль"
                        },
                        new Subcategory
                        {

                            Name = "Мужская обувь",
                            Points = 10,
                            CategoryName = "Мода и стиль"
                        },
                        new Subcategory
                        {

                            Name = "Женская обувь",
                            Points = 10,
                            CategoryName = "Мода и стиль"
                        },
                        new Subcategory
                        {

                            Name = "Аксессуары и часы",
                            Points = 8,
                            CategoryName = "Мода и стиль"
                        },
                        new Subcategory
                        {

                            Name = "Косметика и парфюмерия",
                            Points = 8,
                            CategoryName = "Мода и стиль"
                        }
                           }
                       });
                context.Categories.Add(
                    new Category
                    {

                        Name = "Техника",
                        Subcategories = new List<Subcategory>()
                        {
                        new Subcategory
                        {

                            Name = "Аудиотехника",
                            Points = 25,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "ТВ и видеотехника",
                            Points = 30,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Компьютеры и комплектующие",
                            Points = 35,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Фототехника и оптика",
                            Points = 25,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Телефоны",
                            Points = 15,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Оргтехника",
                            Points = 15,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Бытовая техника",
                            Points = 30,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Планшеты и электронные книги",
                            Points = 15,
                            CategoryName = "Техника"
                        },
                        new Subcategory
                        {

                            Name = "Игры и приставки",
                            Points = 35,
                            CategoryName = "Техника"
                        }
                        }
                    });
                context.Categories.Add(
                   new Category
                   {

                       Name = "Все для дома",
                       Subcategories = new List<Subcategory>()
                       {
                        new Subcategory
                        {

                            Name = "Мебель и интерьер",
                            Points = 20,
                            CategoryName = "Все для дома"
                        },
                        new Subcategory
                        {

                            Name = "Хозяйственные товары",
                            Points = 15,
                            CategoryName = "Все для дома"
                        },
                        new Subcategory
                        {

                            Name = "Посуда и кухонные принадлежности",
                            Points = 10,
                            CategoryName = "Все для дома"
                        },
                         new Subcategory
                        {

                            Name = "Комнатные растения",
                            Points = 5,
                            CategoryName = "Все для дома"
                        },
                        new Subcategory
                        {

                            Name = "Бытовая техника",
                            Points = 8,
                            CategoryName = "Все для дома"
                        }
                       }
                   });
                context.Categories.Add(
                    new Category
                    {

                        Name = "Авто и транспорт",
                        Subcategories = new List<Subcategory>()
                        {
                        new Subcategory
                        {

                            Name = "Легковые авто",
                            Points = 200,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Грузовики и автобусы",
                            Points = 250,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Мотоциклы и мототехника",
                            Points = 180,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Тракторы и сельхозтехника",
                            Points = 150,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Спецтехника",
                            Points = 120,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Шины и диски",
                            Points = 80,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Запчасти расходники химия",
                            Points = 50,
                            CategoryName = "Авто и транспорт"
                        },
                        new Subcategory
                        {

                            Name = "Прицепы и полуприцепы",
                            Points = 100,
                            CategoryName = "Авто и транспорт"
                        }
                        }
                    });
                context.Categories.Add(
                   new Category
                   {

                       Name = "Ремонт и стройка",
                       Subcategories = new List<Subcategory>()
                       {
                        new Subcategory
                        {

                            Name = "Строительный инструмент",
                            Points = 10,
                            CategoryName = "Ремонт и стройка"
                        },
                        new Subcategory
                        {

                            Name = "Сантехника",
                            Points = 25,
                            CategoryName = "Ремонт и стройка"
                        },
                        new Subcategory
                        {

                            Name = "Стройматериалы",
                            Points = 10,
                            CategoryName = "Ремонт и стройка"
                        },
                        new Subcategory
                        {

                            Name = "Отделочные материалы",
                            Points = 25,
                            CategoryName = "Ремонт и стройка"
                        },
                        new Subcategory
                        {

                            Name = "Окна и двери",
                            Points = 30,
                            CategoryName = "Ремонт и стройка"
                        }
                       }
                   });
                context.Categories.Add(
                   new Category
                   {

                       Name = "Сад и огород",
                       Subcategories = new List<Subcategory>()
                       {
                        new Subcategory
                        {

                            Name = "Садовая мебель и мангалы",
                            Points = 10,
                            CategoryName = "Сад и огород"
                        },
                        new Subcategory
                        {

                            Name = "Садовые растения рассада и семена",
                            Points = 8,
                            CategoryName = "Сад и огород"
                        },
                        new Subcategory
                        {

                            Name = "Садовая техника и инвентарь",
                            Points = 7,
                            CategoryName = "Сад и огород"
                        },
                        new Subcategory
                        {

                            Name = "Теплицы",
                            Points = 10,
                            CategoryName = "Сад и огород"
                        },
                        new Subcategory
                        {

                            Name = "Садовые аксессуары",
                            Points = 10
                        },
                        new Subcategory
                        {

                            Name = "Удобрения и агрохимия",
                            Points = 10,
                            CategoryName = "Сад и огород"
                        },
                        new Subcategory
                        {

                            Name = "Все для пчеловода",
                            Points = 10,
                            CategoryName = "Сад и огород"
                        }
                       }
                   });

                context.SaveChanges();
            }

            if (!context.ApplicationUsers.Any())
            {
                ApplicationUser manager = new ApplicationUser { UserName = "moderator", Email = "moderator@gmail.com" };
                userManager.CreateAsync(manager, ".System99");

                IdentityResult roleResult = roleManager.CreateAsync(new IdentityRole("Moderator")).Result;
                if (roleResult.Succeeded)
                {
                    userManager.AddToRoleAsync(manager, "Moderator");
                }
            }
        }

    }
}
