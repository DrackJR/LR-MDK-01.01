using System;
using System.Collections.Generic;

namespace StructProject
{
    public struct Vector
    {
        public Point begin;
        public Point end;

        static public List<double> CalcVectors(Vector[] allVectors)
        {
            List<double> lengthVectors = new List<double>();
            for(int index = 0; index < allVectors.Length; index++)
            {
                Vector v = new Vector();
                v = allVectors[index];
                double lenVector = Point.CalcLenVector(v.begin, v.end);
                lengthVectors.Add(lenVector);
            }
            return lengthVectors;
        }
    }
}
