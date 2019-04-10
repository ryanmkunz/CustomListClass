using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {
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
        [TestMethod]
        public void ToString_IntList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "51015";
            actual = myList.toString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_DoubleList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<double> myList = new CustomList<double>();
            double value1 = 5.5;
            double value2 = 10.01;
            double value3 = 15.55;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "5.510.0115.55";
            actual = myList.toString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_BoolList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<bool> myList = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "TrueFalseTrue";
            actual = myList.toString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_StringList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value1 = "I ";
            string value2 = "Like ";
            string value3 = "Ham";
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "I Like Ham";
            actual = myList.toString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_FloatList_ReturnsListAsAString()
        {
            //Arrange
            CustomList<float> myList = new CustomList<float>();
            float value1 = 0.1234567f;
            float value2 = 8.9000000f;
            float value3 = 0.3333333f;
            string expected;
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            expected = "0.12345678.90.3333333";
            actual = myList.toString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
