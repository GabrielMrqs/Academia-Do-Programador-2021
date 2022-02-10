using Microsoft.VisualStudio.TestTools.UnitTesting;
using Appium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Windows;

namespace ControleDeTarefasEContatos.Tests.Interfaces
{
    [TestClass]
    public class Interface
    {
        protected static WindowsDriver<WindowsElement> session;
        public Interface()
        {
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
