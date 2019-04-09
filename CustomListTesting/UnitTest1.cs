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
            int expected = 5;
            int actual;

            //Act
            myList.Add(value);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_NewValue_ListCountIncreases()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int expected = 1;
            int actual;

            //Act
            myList.Add(value);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoNewValues_FirstAtIndexZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expected = 5;
            int actual;

            //Act
            myList.Add(value);
            myList.Add(value1);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoNewValues_SecondAtIndexOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value = 5;
            int value1 = 10;
            int expected = 10;
            int actual;

            //Act
            myList.Add(value);
            myList.Add(value1);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Index_IndexValue_ReturnsListValueAtIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int index = 0;
            int value = 5;
            int expected = 5;
            int actual;

            //Act
            myList.Add(value);
            actual = myList[index];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ExistingValue_RemovesExistingValueAtEnd()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 2;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value3);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_TwoExistingValues_RemovesTwoValuesFromEndOfList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value2);
            myList.Remove(value3);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FirstValue_RemovesValueAtIndexZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 10;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value1);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_MiddleIndex_RemovesValueMidList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 15;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value2);
            actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AllValues_ListCountIsZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 0;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value1);
            myList.Remove(value2);
            myList.Remove(value3);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AllIntValues_ValueAtIndexZeroIsZero()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int expected = 0;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value1);
            myList.Remove(value2);
            myList.Remove(value3);
            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ValueNotInList_ReturnsFalse()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            bool expected = false;
            bool actual;

            //Act
            myList.Add(value1);
            myList.Add(value3);
            actual = myList.Remove(value2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
