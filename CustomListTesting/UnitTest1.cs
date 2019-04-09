using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTesting
{
    [TestClass]
    public class UnitTest1
    {
        //Unit of work, state under test, expected behavior

        [TestMethod]
        public void Add_NewValue_ValueIsAddedToEndOfList()
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
        public void Add_NewValue_ListCountIncreases()
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
        public void Add_TwoValues_FirstAtIndexZero()
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
        [TestMethod]
        public void Index_IndexValue_ReturnsListValueAtIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int index = 0;
            int expectedValue = 5;

            //Act
            myList.Add(expectedValue);
            int actualValue = myList[index];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
