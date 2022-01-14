using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeploymentItemAttributeSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeploymentItemAttributeSample.Tests
{
    [TestClass]
    public class MessageFromTemplateTests
    {
        [TestMethod]
        [DeploymentItem("Files\\ExamCreatedResult.txt","folder")]
        [DeploymentItem("Files\\ExamCreatedTemplate.txt")]
        public void FromTemplate_PassTestValue_StringFromTemplateReturned()
        {
            MessageFromTemplate messageBuilder=new MessageFromTemplate();
            messageBuilder.TemplateFolder = "."; 

            string expectedResult = File.ReadAllText(@"folder\ExamCreatedResult.txt");
            string actualResult = messageBuilder.FromTemplate("TestExam", "Beginer", new DateTime(2000, 1, 1));
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}