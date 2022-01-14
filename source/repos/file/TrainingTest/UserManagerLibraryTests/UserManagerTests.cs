using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerLibrary.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        public TestContext TestContext { get; set; }
        private UserManager manager=new UserManager();

        //DataSource - определение источника данных
        //1 параметр - имя провайдера
        //2 параметр - строка подключения или путь к файлу
        //3 параметр - имя таблицы или элемента в xml
        //4 параметр - как происходит доступ к записям из источника данных  
        [DataSource ("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "testData.xml",
            "User",
            DataAccessMethod.Sequential)]

        [TestMethod]
        public void Add_FromXML()
        {
            Console.WriteLine(TestContext.TestName);
            string userID = Convert.ToString(TestContext.DataRow["userid"]);
            string phone = Convert.ToString(TestContext.DataRow["phone"]);
            string email = Convert.ToString(TestContext.DataRow["email"]);

            bool res=manager.Add(userID, phone, email);
            Assert.IsTrue(res, "Пользователь не может быть создан");
        }
    }
}