using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interface.Controllers;
namespace Interface.Tests.Controllers
{
    #region  HomeControllerTest   
    [TestClass]
    public class HomeControllerTest
    {
        HomeController controller;
        #region Initiation chaque test
        [TestInitialize]
        public void Init() => controller = new HomeController();
        #endregion
        #region Accueil
        [TestMethod]
        public void Accueil()
        {
            // Act
            ViewResult result = controller.Accueil() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        #endregion
        #region Index
        [TestMethod]
        public void Index()
        {
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        #endregion
        #region CreatSelectionSucre
        [TestMethod]
        public void CreatSelectionSucre()
        {
            // Act
            var result = controller.CreatSelectionSucre(1) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        #endregion
        #region CreatSelectionSucreMug
        [TestMethod]
        public void CreatSelectionSucreMug()
        {
            // Act
            ViewResult result = controller.CreatSelectionSucreMug(1, 1) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        #endregion
        #region CreatSelection
        [TestMethod]
        public void CreatSelection()
        {
            // Act
            //RedirectResult result = controller.CreatSelection(1, 1, true) as RedirectResult;
            var result = (RedirectToRouteResult)controller.CreatSelection(1, 1, true);
            // Assert
            Assert.AreEqual("Service", result.RouteValues["action"]);
        }
        #endregion
        #region Service
        [TestMethod]
        public void Service()
        {
            // Act
            ViewResult result = controller.Service() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        #endregion
    }
    #endregion

}
