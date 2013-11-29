using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{

    //”Triangeln är liksidig” om triangeln är liksidig (Equilateral)
    //”Triangeln är likbent ” om triangeln är likbent(Isosceles)
    // ”Triangeln har inga lika sidor” om triangeln inte har några lika sidor(Scalene).

    [TestClass]
    public class UnitTest1
    {
        //Test med felaktig indata


                        //Test1

        [TestMethod]
        public void IsIsoscelesTestWithEquilateral()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(tri.isIsosceles());               
        }
        
                        //Test2

        [TestMethod]
        public void IsIsocelesTestWithScalene()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(tri.isIsosceles());                     
        }

                        //Test3

        [TestMethod]
        public void IsEquilateralTestWithIsosceles()
        {
            Triangle tri = new Triangle(2.0, 1.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());            
        }

                        //Test4

        [TestMethod]
        public void IsEquilateralTestWithScalene()
        {
            Triangle tri = new Triangle(1.0, 2.0, 3.0);
            Assert.IsFalse(tri.isEquilateral());           
        }

                        //Test5

        [TestMethod]
        public void IsScaleneTestWithEquiliteral()
        {
            Triangle tri = new Triangle(2.0, 2.0, 2.0);
            Assert.IsFalse(tri.isScalene());
        }

        //Test6

        [TestMethod]
        public void IsScaleneTestWithIscosceles()
        {
            Triangle tri = new Triangle(2.0, 1.0, 2.0);
            Assert.IsFalse(tri.isScalene());
        }


        //Test med korrekt indata

                        //Test7

        [TestMethod]
        public void IsIsoscelesPassTest()
        {
            Triangle tri = new Triangle(2.0, 2.0, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }

                        //Test8

        [TestMethod]
        public void IsEquilateralPassTest()
        {
            Triangle tri = new Triangle(2.0, 2.0, 2.0);
            Assert.IsTrue(tri.isEquilateral());
        }

                        //Test 9

        [TestMethod]
        public void IsScalenePassTest()
        {
            Triangle tri = new Triangle(2.0, 3.0, 4.0);
            Assert.IsTrue(tri.isScalene());
        }


        //Test "utan" decimaler

                     // Test 10

        [TestMethod]
        public void IsScaleneNoDecimals()
        {
            Triangle tri = new Triangle(2, 3, 4);
            Assert.IsTrue(tri.isScalene());
        }

                     //Test 11

        [TestMethod]
        public void IsEquilateralNoDecimals()
        {
            Triangle tri = new Triangle(3, 3, 3);
            Assert.IsTrue(tri.isEquilateral());
        }


        //Test med 3 decimaler

                    //Test 12

        [TestMethod]
        public void IsScaleneThreeDecimals()
        {
            Triangle tri = new Triangle(2.345, 3.456, 4.567);
            Assert.IsTrue(tri.isScalene());
        }

                    //Test 13

        [TestMethod]
        public void IsIsoscelesThreeDecimals()
        {
            Triangle tri = new Triangle(3.456, 4.567, 3.456);
            Assert.IsTrue(tri.isIsosceles());
        }


                    //Test 14

        [TestMethod]
        public void IsEquilateralThreeDecimals()
        {
            Triangle tri = new Triangle(3.456, 3.456, 3.456);
            Assert.IsTrue(tri.isEquilateral());
        }

        //Test med negativa tal

                    //Test 15

        [TestMethod]
        public void IsIsoscelesNegative()
        {
            Triangle tri = new Triangle(-1.0, -2.0, -3.0);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void IsScaleneNegative()
        {
            Triangle tri = new Triangle(-2.0, -3.0, -4.0);
            Assert.IsTrue(tri.isScalene());
        }


        //Points

                //Test 16

        [TestMethod]
        public void Points()  
        {
            Point a = new Point(1,4);
            Point b = new Point(-7, -18);
            Point c = new Point(5,5);

            Triangle tri = new Triangle(a,b,c);

            Assert.IsTrue(tri.isScalene());
           
                     
        }

            //Test 17

        [TestMethod]
        public void PointsInArray()
        {
            Point a = new Point(1, 4);
            Point b = new Point(-7, -18);
            Point c = new Point(5, 5);

            Point[] pointarr = new Point[3];

            pointarr[0] = a;
            pointarr[1] = b;
            pointarr[2] = c;


            Triangle tri = new Triangle(pointarr);

            Assert.IsTrue(tri.isScalene());


        }


                //Test 18

        [TestMethod]
        public void DoubleArraytest()
        {
            double[] sides;

            sides = new double[3];

            sides[0] = 1.0;
            sides[2] = 2.0;
            sides[3] = 3.0;

            Triangle tri = new Triangle(sides);

            Assert.IsTrue(tri.isScalene());
        }

        //Testa public Triangle(double[] s)

    }
}
