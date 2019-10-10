using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        // unit test for adding multiple items to check position of last item
        // unit test for adding multiple items to check Count property
        // unit test for adding number of items beyond 'Capacity' but it still adds


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
        public void Make_ListInto_String()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();

            string expected = "[1, 3, 5]";
            
            //Act
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);

            string actual = testList.ToString();        // still not done, convert to another array
                                                 //Assert
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

        }   }
}


