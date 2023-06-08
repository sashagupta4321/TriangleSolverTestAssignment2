using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TriangleSolver
{
    public static class Triangle
    {


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
