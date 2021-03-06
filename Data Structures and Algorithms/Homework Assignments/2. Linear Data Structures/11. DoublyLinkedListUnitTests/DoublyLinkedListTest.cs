﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListUnitTests
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        [TestMethod]
        public void TestDoublyLinkedListConstructor()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestDoublyLinkedListAdd()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");

            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void TestDoublyLinkedListIndexer()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Zero, Two, Three", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListRemoveAt()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.RemoveAt(1);

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Zero, Three", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListForEach()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";

            string[] array = new string[list.Count];
            int index = 0;

            foreach (string item in list)
            {
                array[index] = item;
                index++;
            }

            Assert.AreEqual("Zero, Two, Three", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListInsert_InsertInTheMiddle()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.Insert(1, "Ten");

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Zero, Ten, Two, Three", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListInsert_InsertAtTheEnd()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.Insert(3, "Ten");

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Zero, Two, Three, Ten", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListInsert_InsertAtTheBeginning()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.Insert(0, "Ten");

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Ten, Zero, Two, Three", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListRemove()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.Remove("Three");

            string[] array = new string[list.Count];
            list.CopyTo(array);
            Assert.AreEqual("Zero, Two", string.Join(", ", array));
        }

        [TestMethod]
        public void TestDoublyLinkedListIndexOf()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list[0] = "Zero";
            list.Insert(2, "Four");

            Assert.AreEqual(3, list.IndexOf("Three"));
        }
    }
}
