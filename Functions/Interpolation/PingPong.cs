﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float pingpong(float x, float length)
        {
            return length - math.abs(repeat(x, length * 2f) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 pingpong(float2 x, float2 length)
        {
            return length - math.abs(repeat(x, length * 2f) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 pingpong(float3 x, float3 length)
        {
            return length - math.abs(repeat(x, length * 2f) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 pingpong(float4 x, float4 length)
        {
            return length - math.abs(repeat(x, length * 2f) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 pingpong(float8 x, float8 length)
        {
            return length - abs(repeat(x, length * 2f) - length);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double pingpong(double x, double length)
        {
            return length - math.abs(repeat(x, length * 2d) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 pingpong(double2 x, double2 length)
        {
            return length - math.abs(repeat(x, length * 2d) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 pingpong(double3 x, double3 length)
        {
            return length - math.abs(repeat(x, length * 2d) - length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 pingpong(double4 x, double4 length)
        {
            return length - math.abs(repeat(x, length * 2d) - length);
        }
    }
}