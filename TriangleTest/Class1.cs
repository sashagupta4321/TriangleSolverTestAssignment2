using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleTest
{
    public class Class1
    {
        //-	Only one (1) test for a valid equilateral triangle
        [Test]
        public static void DetermineEquilateralTriangle1_Input60and60and60_OutputIsEquilateral()
        {
            // Arrange
            int sideA = 60;
            int sideB = 60;
            int sideC = 60;

            // Act
            string triangleType = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", triangleType);
        }
        // Three (3) tests for a valid isosceles triangle
        [Test]
        public static void DetermineIsoscelesTriangleInput50and50and80OutputIsIsosceles()
        {
            // Arrange
            int sideA = 50;
            int sideB = 50;
            int sideC = 80;
            // Act
            string result = AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

        [Test]
        public static void DetermineIsoscelesTriangleInput40and70and70OutputIsIsosceles()
        {
            // Arrange
            int firstAngle = 40;
            int secondAngle = 70;
            int thirdAngle = 70;

            // Act
            string result = Triangle.AnalyzeTriangle(firstAngle, secondAngle, thirdAngle);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        [Test]
        public static void DetermineIsoscelesTriangleInput30and120and30OutputIsIsosceles()
        {
            // Arrange
            int sideA = 30;
            int sideB = 120;
            int sideC = 30;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        //-	Five (5) tests for a valid scalene triangle
        [Test]
        public static void DetermineScaleneTriangle1Input90and40and50OutputIsScalene()
        {
            // Arrange
            int sideA = 90;
            int sideB = 40;
            int sideC = 50;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void DetermineScaleneTriangle2Input5000and2000and4000OutputIsScalene()
        {
            // Arrange
            int sideA = 5000;
            int sideB = 2000;
            int sideC = 4000;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void DetermineScaleneTriangle3Input1and2and3OutputIsScalene()
        {
            // Arrange
            int sideA = 1;
            int sideB = 2;
            int sideC = 3;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }
        [Test]
        public static void DetermineScaleneTriangle4Input100and70and10OutputIsScalene()
        {
            // Arrange
            int sideA = 100;
            int sideB = 70;
            int sideC = 10;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }

        [Test]
        public static void DetermineScaleneTriangle5Input100and11and1OutputIsScalene()
        {
            // Arrange
            int sideA = 100;
            int sideB = 11;
            int sideC = 1;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreNotEqual("The triangle is valid and is a SCALENE", result);
        }



        public static string AnalyzeTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string output;
            if ((firstSide == 0) || (secondSide == 0) || (thirdSide == 0))
            {
                output = "At least one side of your triangle has a zero length and is thus invalid";
                return output;
            }

            if (((firstSide + secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) && ((secondSide + thirdSide) > firstSide))
            {
                if ((firstSide == secondSide) && (firstSide == thirdSide) && (secondSide == thirdSide))
                {
                    output = "The triangle is valid and is an EQUILATERAL";
                }
                else if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
                {
                    output = "The triangle is valid and is an ISOSCELES";

                }
                else
                {
                    output = "The triangle is valid and is a SCALENE";

                }


            }
            else
            {
                output = "A triangle cannot be formed with those numbers";
            }


            return output;

        }
    }
}
