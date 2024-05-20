using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace CRUD_application_2.Tests.Controllers
{
    [TestClass]
    public class UserControllerTests
    {
        [TestMethod]
        public void Index_ReturnsCorrectView()
        {
            // Arrange
            UserController controller = new UserController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details_ReturnsCorrectView()
        {
            // Arrange
            UserController controller = new UserController();
            UserController.userlist.Add(new User { Id = 1, Name = "Test", Email = "test@test.com" });

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_ReturnsCorrectView()
        {
            // Arrange
            UserController controller = new UserController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit_ReturnsCorrectView()
        {
            // Arrange
            UserController controller = new UserController();
            UserController.userlist.Add(new User { Id = 1, Name = "Test", Email = "test@test.com" });

            // Act
            ViewResult result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete_ReturnsCorrectView()
        {
            // Arrange
            UserController controller = new UserController();
            UserController.userlist.Add(new User { Id = 1, Name = "Test", Email = "test@test.com" });

            // Act
            ViewResult result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
