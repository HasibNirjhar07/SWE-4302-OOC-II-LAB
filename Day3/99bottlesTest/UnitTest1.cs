using _99_Botttle;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _99bottlesTest
{
    [TestClass]
    public class UnitTest1
    {
        Bottles bottles = new Bottles();
        [TestMethod]
        public void Test_a_verse()
        {
 
            String expected = "99 bottles of beer on the wall , 99 bottles of beer .\n" +
                              " Take one down and pass it around , 98 bottles of beer on the wall .\n";
            String actual = bottles.verse(99);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void Test_another_verse()
        {
            String expected = "89 bottles of beer on the wall , 89 bottles of beer .\n" +
                              " Take one down and pass it around , 88 bottles of beer on the wall .\n";
            String actual = bottles.verse(89);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_0_verse()
        {
            string expected = "No more bottles of beer on the wall , no more bottles of beer.\n" +
                              "Go to the store and buy some more , 99 bottlesof beer on the wall.\n";
            string actual = bottles.verse(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_a_couple_verses()
        {
            string expected = "99 bottles of beer on the wall , 99 bottles of beer .\n" +
                              " Take one down and pass it around , 98 bottles of beer on the wall .\n" +
                              "98 bottles of beer on the wall , 98 bottles of beer .\n" +
                              " Take one down and pass it around , 97 bottles of beer on the wall .\n";
            string actual = bottles.verses(99, 98);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
      


        public void Test_one_verse()
        {
            string expected = "1 bottle of beer on the wall , 1 bottle ofbeer.\n" +
                               " Take it down and pass it around , no more bottles of beer on the wall .\n";
            string actual = bottles.verse(1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

       


        public void Test_a_few_verses()
        {
            string expected = "2 bottles of beer on the wall , 2 bottles of beer.\n" +
                           " Take one down and pass it around , 1 bottle of beer on the wall .\n" +
            "1 bottle of beer on the wall , 1 bottle ofbeer.\n" +
                               " Take it down and pass it around , no more bottles of beer on the wall .\n" +
                              "No more bottles of beer on the wall , no more bottles of beer.\n" +
                                "Go to the store and buy some more , 99 bottlesof beer on the wall.\n";
            string actual = bottles.verses(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Test_the_whole_song()
        {
            string expected=bottles.verses(99,0);
            string actual = bottles.song();
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]

        public void test_two_verses()
        {
            String expected = "2 bottles of beer on the wall , 2 bottles of beer.\n" +
                           " Take one down and pass it around , 1 bottle of beer on the wall .\n";
            Assert.AreEqual(expected,bottles.verse(2));
        }
    }

}
