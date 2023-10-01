using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using Moq;
using Moq.Internals;
using Taks_UnitTest;
using Xunit;

namespace NewBookRepositoryTest
{
    public class NewBookRepositoryTest
    {

        [Fact]

        public void FindAllMustReturnCorrectValue()
        {
            var list = new List<Book>
            {
                new Book()
                {
                    Title = "Война и Мир",
                },
                 new Book()
                {
                    Title = "Человек-невидимка",

                },
                  new Book()
                {
                    Title = "Анна Каренина",

                },


            };

            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(x => x.FindAll()).Returns(list);
            Assert.Contains(mock.Object.FindAll(), book =>book.Title== "Война и Мир");
            Assert.Contains(mock.Object.FindAll(), book =>book.Title== "Человек-невидимка");
            Assert.Contains(mock.Object.FindAll(), book =>book.Title== "Анна Каренина");


        }
    }
}
