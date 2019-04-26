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
        //             Name = "�������",
        //             Cities = new List<City>()
        //             {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������� �����",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������ ������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����",
        //                     RegionName = "�������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�������"
        //                }
        //             }
        //         });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "���������",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "���������"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "�����������",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "�����������",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "�����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "�����������"
        //                }

        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "����������",
        //            Cities = new List<City>()
        //            {
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����-�������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "���������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "����������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "����������"
        //                }
        //            }
        //        });
        //    context.Regions.Add(
        //        new Region
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "���������",
        //            Cities = new List<City>()
        //            {
        //                new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�����",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "�������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "����������",
        //                     RegionName = "���������"
        //                },
        //               new City
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                     Name = "��������",
        //                     RegionName = "���������"
        //                }
        //            }
        //        });



        //    context.Categories.Add(
        //           new Category
        //           {
        //               Id = Guid.NewGuid().ToString(),
        //               Name = "���� � �����",
        //               Subcategories = new List<Subcategory>()
        //               {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ������",
        //                    Points = 15,
        //                    CategoryName = "���� � �����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ������",
        //                    Points = 15,
        //                    CategoryName = "���� � �����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� �����",
        //                    Points = 10,
        //                    CategoryName = "���� � �����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� �����",
        //                    Points = 10,
        //                    CategoryName = "���� � �����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���������� � ����",
        //                    Points = 8,
        //                    CategoryName = "���� � �����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������� � ����������",
        //                    Points = 8,
        //                    CategoryName = "���� � �����"
        //                }
        //               }
        //           });
        //    context.Categories.Add(
        //        new Category
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "�������",
        //            Subcategories = new List<Subcategory>()
        //            {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������������",
        //                    Points = 25,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�� � ������������",
        //                    Points = 30,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���������� � �������������",
        //                    Points = 35,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "����������� � ������",
        //                    Points = 25,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������",
        //                    Points = 15,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "����������",
        //                    Points = 15,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� �������",
        //                    Points = 30,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� � ����������� �����",
        //                    Points = 15,
        //                    CategoryName = "�������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���� � ���������",
        //                    Points = 35,
        //                    CategoryName = "�������"
        //                }
        //            }
        //        });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "��� ��� ����",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������ � ��������",
        //                    Points = 20,
        //                    CategoryName = "��� ��� ����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������������� ������",
        //                    Points = 15,
        //                    CategoryName = "��� ��� ����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������ � �������� ��������������",
        //                    Points = 10,
        //                    CategoryName = "��� ��� ����"
        //                },
        //                 new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������� ��������",
        //                    Points = 5,
        //                    CategoryName = "��� ��� ����"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� �������",
        //                    Points = 8,
        //                    CategoryName = "��� ��� ����"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //        new Category
        //        {
        //            Id = Guid.NewGuid().ToString(),
        //            Name = "���� � ���������",
        //            Subcategories = new List<Subcategory>()
        //            {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� ����",
        //                    Points = 200,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������� � ��������",
        //                    Points = 250,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������� � �����������",
        //                    Points = 180,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� � ��������������",
        //                    Points = 150,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�����������",
        //                    Points = 120,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���� � �����",
        //                    Points = 80,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� ���������� �����",
        //                    Points = 50,
        //                    CategoryName = "���� � ���������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� � �����������",
        //                    Points = 100,
        //                    CategoryName = "���� � ���������"
        //                }
        //            }
        //        });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "������ � �������",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������������ ����������",
        //                    Points = 10,
        //                    CategoryName = "������ � �������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "����������",
        //                    Points = 25,
        //                    CategoryName = "������ � �������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������������",
        //                    Points = 10,
        //                    CategoryName = "������ � �������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���������� ���������",
        //                    Points = 25,
        //                    CategoryName = "������ � �������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���� � �����",
        //                    Points = 30,
        //                    CategoryName = "������ � �������"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "��� � ������",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ������ � �������",
        //                    Points = 10,
        //                    CategoryName = "��� � ������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� �������� ������� � ������",
        //                    Points = 8,
        //                    CategoryName = "��� � ������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ������� � ���������",
        //                    Points = 7,
        //                    CategoryName = "��� � ������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������",
        //                    Points = 10,
        //                    CategoryName = "��� � ������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ����������",
        //                    Points = 10
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��������� � ���������",
        //                    Points = 10,
        //                    CategoryName = "��� � ������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��� ��� ���������",
        //                    Points = 10,
        //                    CategoryName = "��� � ������"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //       new Category
        //       {
        //           Id = Guid.NewGuid().ToString(),
        //           Name = "��������",
        //           Subcategories = new List<Subcategory>()
        //           {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� �������",
        //                    Points = 0,
        //                    CategoryName = "��������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������� ��������",
        //                    Points = 3,
        //                    CategoryName = "��������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������ ��� ��������",
        //                    Points = 5,
        //                    CategoryName = "��������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "����� ��������",
        //                    Points = 5,
        //                    CategoryName = "��������"
        //                }
        //           }
        //       });
        //    context.Categories.Add(
        //      new Category
        //      {
        //          Id = Guid.NewGuid().ToString(),
        //          Name = "������",
        //          Subcategories = new List<Subcategory>()
        //          {
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "���� �������",
        //                    Points = 3,
        //                    CategoryName = "������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "������������ ������",
        //                    Points = 3,
        //                    CategoryName = "������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "����������� ������",
        //                    Points = 5,
        //                    CategoryName = "������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "�������� �������",
        //                    Points = 5,
        //                    CategoryName = "������"
        //                },
        //                new Subcategory
        //                {
        //                    Id = Guid.NewGuid().ToString(),
        //                    Name = "��� ���������",
        //                    Points = 3,
        //                    CategoryName = "������"
        //                }
        //          }
        //      });
        //    base.Seed(context);
        //    base.Seed(context);
        //}
    }
}
