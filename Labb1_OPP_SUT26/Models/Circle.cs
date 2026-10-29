using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1_OPP_SUT26.Models
{
    public class Circle
    {
        public float Radius;
        float _pi = 3.141f;

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float GetArea()
        {
            return Radius * Radius * _pi;
        }

        public float GetCircumference()
        {
            return 2 * _pi * Radius;
        }

        public float GetVolume()
        {
            return 4f / 3f * _pi * Radius * Radius * Radius;
        }

    }
}
