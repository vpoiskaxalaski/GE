using GE.DAL;
using GE.DAL.Interfaces;
using GE.DAL.Model;
using GE.DAL.Repositories;
using GE.Models;
using GE.SL.Interfaces;
using GE.SL.Servives;
using GE.WEB.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class OrderControllerTest
    {
        private readonly IUnitOfWork _unitOfWork;
        private IOrderService _service;
        private IImageGalleryService _imageGalleryService;
        private OrderController _controller;
        
        public OrderControllerTest()
        {

            var option = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "DefaultConnection")
                .Options;

            _unitOfWork = new UnitOfWork(option);

            #region
            _unitOfWork.Cities.Create(new City {
                    Id = 2,
                    Name = "Минск"
                }
            );
            _unitOfWork.Save();

            _unitOfWork.ApplicationUsers.Create();
            var user = _unitOfWork.ApplicationUsers.GetByEmail("kitty@mail.ru");
            var user2 = _unitOfWork.ApplicationUsers.GetByEmail("alena_savchuk@mail.ru");

            _unitOfWork.Subcategories.Create(new Subcategory
            {
                Id = 22,
                Name = "Женская одежда",
                Points = 15,
                CategoryName = null,
                Category = null
            });
            _unitOfWork.Save();
            var subcategory = _unitOfWork.Subcategories.Get(22);

            var img = new ImagesGallery
            {
                Id = 1009,
                Name = "брюки1.jpg",
                PostId = 1007,
                Post = null
            };
            List<ImagesGallery> imagesGalleries = new List<ImagesGallery>();
            imagesGalleries.Add(img);

            _unitOfWork.Save();

            _unitOfWork.Posts.Create(new Post
            {
                Id = 1007,
                Name = "Брюки",
                Description = "Деловой стиль",
                DateCreatePost = "11.05.2019 17:42:20",
                Status = "1",
                CityId = 2,
                UserId = user.Id,
                SubcategoryId = 22,
                City = null,
                User = null,
                Subcategory = subcategory,
                ImagesGallery = imagesGalleries
            });
            _unitOfWork.Save();
            _unitOfWork.Posts.Create(new Post
            {
                Id = 1008,
                Name = "Брюки1",
                Description = "Деловой стиль",
                DateCreatePost = "11.05.2019 17:42:20",
                Status = "1",
                CityId = 2,
                UserId = user2.Id,
                SubcategoryId = 22,
                City = null,
                User = null,
                Subcategory = subcategory,
                ImagesGallery = imagesGalleries
            });
            _unitOfWork.Save();
            var post = _unitOfWork.Posts.Get(1007);
            var post2 = _unitOfWork.Posts.Get(1008);

            _unitOfWork.Orders.Create(new Order {
                Id = 4013,
                PostId = post.Id,
                UserId = user.Id,
                Post = post,
                User = user
            });
            _unitOfWork.Save();
            _unitOfWork.Orders.Create(new Order
            {
                Id = 4014,
                PostId = post2.Id,
                UserId = user2.Id,
                Post = post,
                User = user
            });
            _unitOfWork.Save();
            #endregion

            _imageGalleryService = new ImageGalleryService(_unitOfWork);
            _service = new OrderService(_unitOfWork, _imageGalleryService);

            _controller = new OrderController(_service);

        }

        #region Get Methods
        [Fact]
        public void Get_ReturnsNoResult()
        {
            // Act
            ActionResult<IEnumerable<OrderVM>> result = _controller.Get();

            // Assert
            Assert.Empty(result.Value);
        }

        [Fact]
        public void Get_ReturnsAllItems()
        {
            // Act
            ActionResult<IEnumerable<OrderVM>> result = _controller.Get();

            // Assert
            List<OrderVM> items = Assert.IsType<List<OrderVM>>(result.Value);
            Assert.Equal(2, items.Count);
        }
        #endregion

        #region GetById method
        [Fact]
        public void GetById_ReturnsNoResult()
        {
            // Act
            ActionResult<OrderVM> notFoundResult = _controller.Get(1);

            // Assert
            Assert.Null(notFoundResult.Value);
        }

        [Fact]
        public void GetById_ReturnsOkResult()
        {
            // Act
            ActionResult<OrderVM> okResult = _controller.Get(4014);

            // Assert
            Assert.NotNull(okResult.Value);
        }
        #endregion

        #region Add Method
        [Fact]
        public void Add_ReturnsNoResult()
        {
            int c1 = _service.GetAll().Count;
            // Arrange
            OrderVM WrongUserIdItem = new OrderVM()
            {
                PostId = 7,
                UserId = _unitOfWork.ApplicationUsers.GetByEmail("kitty@mail.ru").Id
            };

            // Act
            _controller.Post(WrongUserIdItem);
            int c2 = _service.GetAll().Count;

            bool okResponse = true;
            if (c2 - c1 != 1)
            {
                okResponse = false;
            }
            // Assert
            Assert.True(okResponse); 
        }


        [Fact]
        public void Add_ValidObjectPassed()
        {
            // Arrange
            int c1 = _service.GetAll().Count;
            OrderVM testItem = new OrderVM()
            {
                PostId = 1007,
                UserId = _unitOfWork.ApplicationUsers.GetByEmail("kitty@mail.ru").Id
            };

            // Act
             _controller.Post(testItem);
            int c2 = _service.GetAll().Count;

            bool createdResponse =  true;
            if (c2 - c1 != 1)
                createdResponse = false;
 
                // Assert
            Assert.True(createdResponse);
        }
        #endregion

        #region  Remove method
        [Fact]
        public void Remove_ReturnsNoResult()
        {
            // Arrange
            int c1 = _service.GetAll().Count;
            bool okResponse = true;

            // Act
            _controller.Delete(2);
            int c2 = _service.GetAll().Count;

            if (c1 - c2 != 1)
                okResponse = false;

            // Assert
            Assert.True(okResponse);
        }

        [Fact]
        public void Remove_ReturnsOkResult()
        {
            // Arrange
            bool okResponse = true;
            int c1 = _service.GetAll().Count;

            // Act
            _controller.Delete(4013);
            int c2 = _service.GetAll().Count;

            if (c1 - c2 != 1)
                okResponse = false;

            // Assert
            Assert.True(okResponse);
        }
        #endregion
    }


}
