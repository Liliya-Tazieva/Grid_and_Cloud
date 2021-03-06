﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using WebApplication1.Controllers;

namespace UnitTestWebApplication1
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void TestMethodCalculate1()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("dd", "43", "Add") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Incorrect first parameter", result.ViewBag.Message);
        }

        [TestMethod]
        public void TestMethodCalculate2()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("22", "f", "Add") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Incorrect second parameter", result.ViewBag.Message);
        }

        [TestMethod]
        public void TestMethodCalculate3()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("22", "0", "Div") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Incorrect parameters", result.ViewBag.Message);
        }
        
        [TestMethod]
        public void TestMethodCalculate4()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("22 5", "43", "Mul") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Incorrect first parameter", result.ViewBag.Message);
        }
        
        [TestMethod]
        public void TestMethodCalculate5()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("25","5", "Sub") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("20",result.ViewBag.Message);
        }
        [TestMethod]
        public void TestMethodCalculate6()
        {
            //Arrange
            var controller = new CalcController();
            //Act
            var result = controller.Calculate("22,4", "43,3", "Add") as ViewResult;
            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("65.7", result.ViewBag.Message);
        }
    }
}
