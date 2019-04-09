using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;

            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expectedCount = 1;
            //Act
            myList.Add(value);

            //Assert
            Assert.AreEqual(expectedCount, myList.Count);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;

            //Act
            myList.Add(value);
            myList.Add(value1);

            //Assert
            Assert.AreEqual(value, myList[0]);
        }
    }
}
