using Moq;
using WWSInc.Imgur.Core.Models.Data;
using WWSInc.Imgur.Core.Services;
using Xunit;

namespace Imgur_test.ServiceTest
{
    public class Service_ImageDataModel_Should : BaseServiceTest<ImageDataModel>
    {
        public Service_ImageDataModel_Should() : base(System.IO.Directory.GetCurrentDirectory(), @"\sample-data\image.json")
        {

        }

        [Theory]
        [InlineData(@"\sample-data\image.json")]
        public void Response_ImageDataModel_Should_Not_Be_Null(string jsonFile)
        {
            // Arrange 
            var mockImageService = new Mock<IImageService>();
            mockImageService.Setup(service => service.GetImageAsync("")).ReturnsAsync(GetResponse(jsonFile));

            // Act
            var imageService = mockImageService.Object;
            var response = imageService.GetImageAsync("").Result;

            // Assert
            Assert.NotNull(response.Data);
        }

        [Theory]
        [InlineData(@"\sample-data\image.json")]
        public void Response_ImageDataModel_Should_Have_ID(string jsonFile)
        {
            // Arrange 
            var mockImageService = new Mock<IImageService>();
            mockImageService.Setup(service => service.GetImageAsync("")).ReturnsAsync(GetResponse(jsonFile));

            // Act
            var imageService = mockImageService.Object;
            var response = imageService.GetImageAsync("").Result;

            // Assert
            Assert.Equal("UflWTHU", response.Data.Id);
        }

        [Theory]
        [InlineData(@"\sample-data\image.json")]
        public void Response_ImageDataModel_Should_Have_Description(string jsonFile)
        {
            // Arrange 
            var mockImageService = new Mock<IImageService>();
            mockImageService.Setup(service => service.GetImageAsync("")).ReturnsAsync(GetResponse(jsonFile));

            // Act
            var imageService = mockImageService.Object;
            var response = imageService.GetImageAsync("").Result;

            // Assert
            Assert.Equal("Img Description 1", response.Data.Description);
        }

        [Theory]
        [InlineData(@"\sample-data\image.json")]
        public void Response_ImageDataModel_Should_Have_Bandwith(string jsonFile)
        {
            // Arrange 
            var mockImageService = new Mock<IImageService>();
            mockImageService.Setup(service => service.GetImageAsync("")).ReturnsAsync(GetResponse(jsonFile));

            // Act
            var imageService = mockImageService.Object;
            var response = imageService.GetImageAsync("").Result;

            // Assert
            Assert.Equal(675974840, response.Data.Bandwidth);
        }

        [Theory]
        [InlineData(@"\sample-data\image.json")]
        public void Response_ImageDataModel_Should_Have_Size(string jsonFile)
        {
            // Arrange 
            var mockImageService = new Mock<IImageService>();
            mockImageService.Setup(service => service.GetImageAsync("")).ReturnsAsync(GetResponse(jsonFile));

            // Act
            var imageService = mockImageService.Object;
            var response = imageService.GetImageAsync("").Result;

            // Assert
            Assert.Equal(2180564, response.Data.Size);
        }        
    }
}
