using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using DesignPatterns.Creational.Singleton;


namespace DesignPatterns.Tests.Creational.Tests.Singleton.Tests
{
    public class SingletonTests
    {
        [Fact]
        public void Singleton_Constructor_ReturnsSingleObject()
        {
            // Arrange - Varriable, classes, Mock


            // Act
            var singleton1 = DesignPatterns.Creational.Singleton.Singleton.getSingleton();
            var singleton2 = DesignPatterns.Creational.Singleton.Singleton.getSingleton();

            //Assert
            Assert.True(singleton1 ==singleton2);
            //Assert.NotEqual(singleton1, singleton2);
        }
    }
}
