using System;

namespace FormsHA
{
    internal static class Operands
    {
        internal delegate float PerformCalculation(float x, float y);

        internal static float Add(float x, float y)
        { 
            return x + y;
        }

        internal static float Subtract(float x, float y)
        {
            return (x - y);
        }

        internal static float Multiply(float x, float y)
        {
            return x * y;
        }

        internal static float Pow(float x, float y)
        {
            return (float)Math.Pow(x, y);
        }

        internal static float And(float x, float y)
        {
            return (uint)x & (uint)y;
        }

        internal static float Or(float x, float y)
        {
            return (uint)x | (uint)y;
        }
    }
}