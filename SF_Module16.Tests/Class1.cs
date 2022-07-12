using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Xunit;
using Moq;

namespace SF_Module16.Tests
{
    // [16.2.4]
    /*
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Subtraction(300, 10) == 290);
        }
    }

    public class Calculator
    {
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
    */

    // [16.2.5]
    /*
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Assert.That(calculator.Division(200, 10) == 20);
        }
    }

    public class Calculator
    {
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
    */

    // [16.2.6]
    /*
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();

            Assert.Throws<DivideByZeroException> (() => calculator.Division(30, 0));
        }
    }

    public class Calculator
    {
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
    */

    // 16.2.7
    /*
    public class Class1
    {
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Xunit.Assert.True(calculator.Subtraction(300, 10) == 290);
        }
    }

    public class Calculator
    {
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
    */

    // 16.2.8
    /*
    public class Class1
    {
        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();

            Xunit.Assert.True(calculator.Division(200, 10) == 20);
        }
    }

    public class Calculator
    {
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
    */

    // 16.2.9
    /*
    public class Class1
    {
        [Fact]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();

            Xunit.Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }

    public class Calculator
    {
        public int Division(int a, int b)
        {
            return a / b;
        }
    }
    */

    // [16.3.1]
    /*
    public class User
    {
        public string Name { get; set; }
    }

    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }

    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return null;
        }
    }

    [TestFixture]
    public class Class1
    {
        [Test]
        public void Class_ShouldFindAll()
        {
            List<User> users = new List<User>();

            users.Add(new User() { Name = "Антон" });
            users.Add(new User() { Name = "Иван" });
            users.Add(new User() { Name = "Алексей" });

            Mock<IUserRepository> mock = new Mock<IUserRepository>();

            mock.Setup(v => v.FindAll()).Returns(users);

            NUnit.Framework.Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
            NUnit.Framework.Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
            NUnit.Framework.Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
    */

    // [16.3.2]
    /*
    public class Book
    {
        public string Title { get; set; }
    }
    
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }

    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }

    [TestFixture]
    public class Class1
    {
        [Test]
        public void Class_ShouldFindAll()
        {
            List<Book> library = new List<Book>();

            library.Add(new Book() { Title = "Война и мир" });
            library.Add(new Book() { Title = "Человек-невидимка" });
            library.Add(new Book() { Title = "Анна Каренина" });

            Mock<IBookRepository> mock = new Mock<IBookRepository>();

            mock.Setup(v => v.FindAll()).Returns(library);

            Xunit.Assert.Contains(mock.Object.FindAll(), book => book.Title == "Война и мир");
            Xunit.Assert.Contains(mock.Object.FindAll(), book => book.Title == "Человек-невидимка");
            Xunit.Assert.Contains(mock.Object.FindAll(), book => book.Title == "Анна Каренина");
        }
    }
    */

    // [16.4.3]
    /*
    public class Calculator
    {
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Multiplication(int a, int b, int c)
        {
            return a * b * c;
        }
    }

    public class CalculatorTests
    {
        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Xunit.Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Xunit.Assert.Equal(120, result);
        }
    }
    */

    // [16.6.2]
    //public class FileWorker
    //{
    //    private string GetSafeFilename(string filename)
    //    {
    //        return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
    //    }
    //}

    //[TestFixture]
    //public class FileWorkerTests
    //{
    //    [Test]
    //    public void GetSafeFilename_MustReturnCorrectValue()
    //    {
    //        var fileWorker = new FileWorker();
    //        PrivateObject privateObject = new PrivateObject(fileWorker);
    //        var privateFunction = privateObject.Invoke("GetSafeFilename", @ "Folder:?<>*/\_Name:");
    //        NUnit.Framework.Assert.AreEqual(privateFunction, "Folder________Name_");
    //    }
    //}
}
