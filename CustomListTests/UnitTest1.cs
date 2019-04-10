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
            actual = myList.ToString();

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
            actual = myList.ToString();

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
            actual = myList.ToString();

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
            actual = myList.ToString();

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
            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineList_IntCustomLists_CombinesListsTogether()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();            
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 4;
            int value6 = 6;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            expected = "135246";
            odd += even;
            actual = odd.ToString();
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineList_DoubleCustomLists_CombinesListsTogether()
        {
            //Arrange
            CustomList<double> odd = new CustomList<double>();
            CustomList<double> even = new CustomList<double>();
            CustomList<double> Combination = new CustomList<double>();
            double value1 = 1.1;
            double value2 = 3.3;
            double value3 = 5.5;
            double value4 = 2.2;
            double value5 = 4.4;
            double value6 = 6.6;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            expected = "1.13.35.52.24.46.6";
            Combination = odd + even;
            actual = Combination.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineList_CustomListsDiffLength_CombinesListsTogether()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> Combination = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            expected = "1352";
            Combination = odd + even;
            actual = Combination.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineList_CustomListsAllSameValue_CombinesListsTogether()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> Combination = new CustomList<int>();
            int value1 = 3;
            int value2 = 3;
            int value3 = 3;
            int value4 = 3;
            int value5 = 3;
            int value6 = 3;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            expected = "333333";
            Combination = odd + even;
            actual = Combination.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineList_BoolCustomList_CombinesListsTogether()
        {
            //Arrange
            CustomList<bool> first = new CustomList<bool>();
            CustomList<bool> second = new CustomList<bool>();
            CustomList<bool> Combination = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            bool value4 = false;
            bool value5 = true;
            bool value6 = false;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value4);
            second.Add(value5);
            second.Add(value6);
            expected = "TrueFalseTrueFalseTrueFalse";
            Combination = first + second;
            actual = Combination.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_Int_RemovesIntFromList()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value2);
            expected = "15";
            result = first - second;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_Bool_RemovesBoolFromList()
        {
            //Arrange
            CustomList<bool> first = new CustomList<bool>();
            CustomList<bool> second = new CustomList<bool>();
            CustomList<bool> result = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value2);
            expected = "TrueTrue";
            result = first - second;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_Double_RemovesDoubleFromList()
        {
            //Arrange
            CustomList<double> first = new CustomList<double>();
            CustomList<double> second = new CustomList<double>();
            CustomList<double> result = new CustomList<double>();
            double value1 = 5.5;
            double value2 = 6.6;
            double value3 = 7.7;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value2);
            expected = "5.57.7";
            result = first - second;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_IntNotInList_ReturnsOriginalList()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int value4 = 1;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value4);
            expected = "567";
            result = first - second;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_IntandIntNotInList_RemovesOneIntFromList()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();

            int value1 = 5;
            int value2 = 6;
            int value3 = 7;
            int value4 = 1;
            string expected;
            string actual;

            //Act
            first.Add(value1);
            first.Add(value2);
            first.Add(value3);
            second.Add(value4);
            second.Add(value2);
            expected = "57";
            result = first - second;
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_TwoIntLists_ReturnsListWithAlternatingValues()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 4;
            int value6 = 6;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            result = odd.Zip(even);
            expected = "123456";
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_TwoDoubleLists_ReturnsListWithAlternatingValues()
        {
            //Arrange
            CustomList<double> odd = new CustomList<double>();
            CustomList<double> even = new CustomList<double>();
            CustomList<double> result = new CustomList<double>();
            double value1 = 1.1;
            double value2 = 3.3;
            double value3 = 5.5;
            double value4 = 2.2;
            double value5 = 4.4;
            double value6 = 6.6;
            double value7 = 7.7;
            double value8 = 8.8;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            result = odd.Zip(even);
            expected = "1.12.23.34.45.56.67.78.8";
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_TwoBoolLists_ReturnsListWithAlternatingValues()
        {
            //Arrange
            CustomList<bool> odd = new CustomList<bool>();
            CustomList<bool> even = new CustomList<bool>();
            CustomList<bool> result = new CustomList<bool>();
            bool value1 = true;
            bool value2 = true;
            bool value3 = true;
            bool value4 = false;
            bool value5 = false;
            bool value6 = false;
            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);
            even.Add(value4);
            even.Add(value5);
            even.Add(value6);
            result = odd.Zip(even);
            expected = "TrueFalseTrueFalseTrueFalse";
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_ListAndEmptyList_ReturnsFirstList()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;

            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);

            result = odd.Zip(even);
            expected = "135";
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zip_EmptyListFullList_ReturnsSecondList()
        {
            //Arrange
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            string expected;
            string actual;

            //Act
            odd.Add(value1);
            odd.Add(value2);
            odd.Add(value3);

            result = odd.Zip(even);
            expected = "246";
            actual = result.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
