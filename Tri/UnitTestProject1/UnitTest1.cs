using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1

    
      //”Triangeln är liksidig” om triangeln är liksidig (Equilateral)
      //”Triangeln är likbent ” om triangeln är likbent(Isosceles)
      // ”Triangeln har inga lika sidor” om triangeln inte har några lika sidor(Scalene).
    

    {
        //Test med felaktig indata


                        //Test1

        [TestMethod]
        public void IsIsocelesFailTest1()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsTrue(tri.isIsosceles());               
        }
        
                        //Test2

        [TestMethod]
        public void IsIsocelesFailTest2()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isIsosceles());                     
        }

                        //Test3

        [TestMethod]
        public void isEquilateralFailTest1()
        {
            Triangle tri = new Triangle(2.0, 1.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());            
        }

                        //Test4

        [TestMethod]
        public void isEquilateralFailTest2()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsTrue(tri.isEquilateral());           
        }

                        //Test5

        [TestMethod]
        public void isScaleneFailTest1()
        {
            Triangle tri = new Triangle(2.0, 2.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());
        }

                        //Test6

        [TestMethod]
        public void isScaleneFailTest2()
        {
            Triangle tri = new Triangle(2.0, 1.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());
        }


       //Test med korrekt indata

                        //Test7

        [TestMethod]
        public void IsIsocelesPassTest()
        {
            Triangle tri = new Triangle(1.0, 2.0, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }

                      //Test8

        [TestMethod]
        public void isEquilateralPassTest()
        {
            Triangle tri = new Triangle(2.0, 2.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());
        }
       
                    //Test 9

        [TestMethod]
        public void isScalenePassTest()
        {
            Triangle tri = new Triangle(2.0, 3.0, 4.0);
            Assert.IsTrue(tri.isEquilateral());
        }
    }
}
