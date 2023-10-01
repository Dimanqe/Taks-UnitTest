using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Moq;
using Moq.Internals;
using Taks_UnitTest;

namespace UserRepositoryTests
{
    [TestFixture]
    public class UserRepositatyTests
    {

        [Test]
        public void FindAllMustReturnCorrectValue()
        {

            var list = new List<User>
            {

                new User()
                {
                    Name = "Антон"
                },
                new User()
                {
                    Name = "Иван"
                },
                new User()
                {
                    Name = "Алексей"
                },

            };
                
                
                
            var mockBookRepFinaAll = new Mock<IUserRepository>();
            mockBookRepFinaAll.Setup(x => x.FindAll()).Returns(list);
            Assert.That(mockBookRepFinaAll.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mockBookRepFinaAll.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mockBookRepFinaAll.Object.FindAll().Any(user => user.Name == "Алексей"));


        }

    }


}
