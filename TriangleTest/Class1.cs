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
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

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
            int sideA = 70;
            int sideB = 40;
            int sideC = 70;

            // Act
            string result = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        //-	Five (5) tests for a valid scalene triangle
        [Test]
        public static void DetermineScaleneTriangle1Input80and40and60OutputIsScalene()
        {
            // Arrange
            int sideA = 80;
            int sideB = 40;
            int sideC = 60;

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
        public static void DetermineScaleneTriangle3Input1and2and3OutputIsNotScalene()
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
        public static void DetermineScaleneTriangle4Input100and70and10OutputIsNotScalene()
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
        public static void DetermineScaleneTriangle5Input100and11and1OutputIsNotScalene()
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
        
        //-	Three (3) tests for verifying a zero length for one or more sides
        [Test]
        public static void DetermineZeroLenghtInput0and40and40OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 0;
            int sideB = 40;
            int sideC = 40;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void DetermineZeroLenghtInput40and0and40OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 40;
            int sideB = 0;
            int sideC = 40;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        [Test]
        public static void DetermineZeroLenghtInput40and40and0OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 40;
            int sideB = 40;
            int sideC = 0;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("At least one side of your triangle has a zero length and is thus invalid", output);
        }

        //-	Three (3) tests for verifying an invalid response (other than a zero length)
        [Test]
        public static void DetermineInvalidResponseInputNegative10and40and4OutputInvalidTriangle()
        {
            //Arrange
            int sideA = -10;
            int sideB = 40;
            int sideC = 40;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void DetermineInvalidResponseInput40andNegative10and40OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 40;
            int sideB = -10;
            int sideC = 40;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }

        [Test]
        public static void DetermineInvalidResponseInput40and40andNegative10OutputInvalidTriangle()
        {
            //Arrange
            int sideA = 40;
            int sideB = 40;
            int sideC = -10;

            //Act
            String output = Triangle.AnalyzeTriangle(sideA, sideB, sideC);

            //Assert
            Assert.AreEqual("A triangle cannot be formed with those numbers", output);
        }
    }
       
    }
