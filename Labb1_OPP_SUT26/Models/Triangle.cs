using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1_OPP_SUT26.Models
{
    public class Triangle
    {
        public float Height;
        public float Length;

        public Triangle(float height, float length)
        {
            Height = height;
            Length = length;
        }

        public float GetArea()
        {
            return (Height * Length) / 2;
        }
    }
}
