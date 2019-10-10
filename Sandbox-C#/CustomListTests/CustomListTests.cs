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
        public void Add_Mulitple_Numbers_ToList()
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

            string expected = testList.ToString();
            string actual;
            //Act
            testList.Add(1);
            testList.Add(3);
            testList.Add(5);

            actual = testList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    
}
