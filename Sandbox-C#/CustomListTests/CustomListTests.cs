using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;
using System.Collections.Generic;
using System.Collections;



namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Add_Numbers_ToList()
        {
            CustomList<int> testList = new CustomList<int>();

            int expected = 2;
            int actual;

            testList.Add(2);
            testList.Add(3);
            actual = testList[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ToEmptyList_WhatsInTheSecondIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            testList.Add(10);
            testList.Add(13);
            testList.Add(12);
            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ToEmptyList_Items_WhatsInTheFifthIndex()
        {
            CustomList<int> testList = new CustomList<int>();

            int expected = 22;
            int actual;

            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            testList.Add(10);
            testList.Add(11);
            testList.Add(22);

            actual = testList[5];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ToEmptyList_Items_WhatsInTheSixthIndex()
        {
            CustomList<int> testList = new CustomList<int>();

            int expected = 33;
            int actual;

            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            testList.Add(10);
            testList.Add(11);
            testList.Add(22);
            testList.Add(33);


            actual = testList[6];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ToEmptyList_Items_WhatsInTheFourthIndex()
        {
            CustomList<int> testList = new CustomList<int>();

            int expected = 11;
            int actual;

            testList.Add(2);
            testList.Add(1);
            testList.Add(3);
            testList.Add(10);
            testList.Add(11);
            testList.Add(22);
            testList.Add(33);


            actual = testList[4];

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //act
            testList.Add(234);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Mulitple_Numbers_ToList_GetCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();

            int expected = 2;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Ten_Numbers_ToList_GetCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();

            int expected = 10;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(8);
            testList.Add(9);
            testList.Add(10);

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Mulitple_Five_ToList_GetCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();

            int expected = 5;
            int actual;

            // act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_Mulitple_Twelve_ToList_GetCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();

            int expected = 12;
            int actual;

            // act
            testList.Add(2); testList.Add(6); testList.Add(6); testList.Add(6);
            testList.Add(3); testList.Add(6); testList.Add(6); testList.Add(6);
            testList.Add(4); testList.Add(6); testList.Add(6); testList.Add(6);

            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Capacity_Full_So_AddToCapacity()
        {
            CustomList<int> testList = new CustomList<int>();

            int expected = 8;
            int actual;

            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(6);
            testList.Add(8);
            testList.Add(10);
            actual = testList.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Removing_Object_FromArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();

            int expected = 1;
            int actual;
            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Remove(1);
            actual = testList.Count;

            //Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Make_ListInto_String()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();

            string expected = "[1, 3, 5]";

            //Act
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);

            string actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_ThreeNumbers_And_MakeIntoAString()
        {
            CustomList<int> testList = new CustomList<int>();

            string expected = "[1, 4, 6, 5, 4, 6]";

            testList.Add(1);
            testList.Add(4);
            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(6);
            string actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddToList_RemoveFromList_MakeIntoAString()
        {
            CustomList<int> testList = new CustomList<int>();

            string expected = "[10, 12, 30]";
            testList.Add(10);
            testList.Add(12);
            testList.Add(30);
            testList.Add(5);
            testList.Add(6);
            testList.Remove(5);
            testList.Remove(6);

            string actual = testList.ToString();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Adding_strings_IntoList()
        {
            CustomList<string> testList = new CustomList<string>();

            string expected = "[S, A, V, E,  , F, E, R, R, I, S]";

            testList.Add("S");
            testList.Add("A");
            testList.Add("V");
            testList.Add("E");
            testList.Add(" ");
            testList.Add("F");
            testList.Add("E");
            testList.Add("R");
            testList.Add("R");
            testList.Add("I");
            testList.Add("S");
            string actual = testList.ToString();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverLoad_Operator_AddTwo_Instances()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int> { 1, 3, 5, 2, 4, 6 };
            CustomList<int> actual;
            actual = one + two;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Overload_Operator_AddTwoIntances_ThatHaveSix_Integers()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5, 4, 3, 2 };
            CustomList<int> two = new CustomList<int>() { 2, 4, 6, 4, 3, 2 };
            CustomList<int> expected = new CustomList<int> { 1, 3, 5, 4, 3, 2, 2, 4, 6, 4, 3, 2 };
            CustomList<int> actual;
            actual = one + two;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Overload_Operator_That_SubtractsOne_Instance()
        {
            CustomList<int> one = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> two = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> expected = new CustomList<int> { 3, 5 };
            CustomList<int> actual;

            actual = one - two;

            Assert.AreEqual(expected, actual);


        }
    }
}


