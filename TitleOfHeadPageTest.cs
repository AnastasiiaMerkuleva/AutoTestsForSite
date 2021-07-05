using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    

    public class TitleOfHeadPageTest : TestBase
    {

        [Test]
        public void VerifyTitleOfHeadPage()
        {
            string expectedTitle = "C# Online Compiler | .NET Fiddle";
            string actuaiTitle = Driver.Title;
            Assert.AreEqual(expectedTitle, actuaiTitle);
        }
        
        
    }
}