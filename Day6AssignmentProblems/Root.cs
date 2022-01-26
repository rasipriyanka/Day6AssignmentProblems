using System;
using System.Collections.Generic;
using System.Text;

namespace Day6AssignmentProblems
{
    internal class Root
    {
       
            public static double RootNumber(double n, double l)
            {
                double x = n;
                double root;
                int count = 0;
                while (true)
                {
                    count++;
                    root = 0.5 * (x + (n / x));// calculate square root for non negative value
                    if (Math.Abs(root - x) < l)
                        break;
                    x = root;
                }
                return root;
            }
        }
    }
    

