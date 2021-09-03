﻿using Moq;
using System.Collections.Generic;
using WWSInc.Imgur.Models;
using WWSInc.Imgur.Services;
using Xunit;

namespace Imgur_test.ServiceTest
{
    public class Service_AlbumDataModel_Should : BaseServiceTest<AlbumDataModel>
    {

        public Service_AlbumDataModel_Should() : base(System.IO.Directory.GetCurrentDirectory(), @"\sample-data\album-response.json") { }

        [Theory]
        [InlineData(@"\sample-data\album-response.json")]
        public void Response_AlbumDataModel_Should_Not_Be_Null(string jsonFile)
        {
            // Arrange 
            var imageIds = new List<int> { 1, 2 };
            var deleteIdHashes = new List<int> { 1, 2 };
            var title = "title goes here";
            var description = "description goes here";
            var privacy = Privacy.Hidden;
            var coverId = 1;

            var mockService = new Mock<IAlbumServices>();
            mockService
                .Setup(service => service.CreateAlbumAsync(imageIds, deleteIdHashes, title, description, privacy, coverId))
                .ReturnsAsync(GetResponse(jsonFile));

            // Act
            var service = mockService.Object;
            var response = service.CreateAlbumAsync(imageIds, deleteIdHashes, title, description, privacy, coverId).Result;

            // Assert
            Assert.NotNull(response.Data);
        }
    }
}