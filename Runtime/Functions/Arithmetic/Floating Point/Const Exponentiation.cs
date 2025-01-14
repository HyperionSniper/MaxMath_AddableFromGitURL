﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.CompilerServices;

namespace MaxMath
{



    // FRAC - split up





    unsafe public static partial class maxmath
    {
        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 pow(float8 x, float y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1f:   { return rcp(x); }
                    case -2f:   { return rcp(square(x)); }
                    case -3f:   { return rcp(square(x) * x); }
                    case -4f:   { float8 x2 = square(x); return rcp(square(x2)); }
                    case -5f:   { float8 x2 = square(x); return rcp(square(x2) * x); }
                    case -6f:   { float8 x2 = square(x); return rcp(square(x2) * x2); }
                    case -7f:   { float8 x2 = square(x); return rcp(square(x2) * (x * x2)); }
                    case -8f:   { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4)); }
                    case -9f:   { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * x); }
                    case -10f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * x2); }
                    case -11f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * (x * x2)); }
                    case -12f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * x4); }
                    case -13f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * (x * x4)); }
                    case -14f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * (x2 * x4)); }
                    case -15f:  { float8 x2 = square(x); float8 x4 = square(x2); return rcp(square(x4) * ((x * x2) * x4)); }
                    case -16f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8)); }
                    case -17f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * x); }
                    case -18f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * x2); }
                    case -19f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x * x2)); }
                    case -20f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * x4); }
                    case -21f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x * x4)); }
                    case -22f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x2 * x4)); }
                    case -23f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * ((x * x2) * x4)); }
                    case -24f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * x8); }
                    case -25f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x * x8)); }
                    case -26f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x2 * x8)); }
                    case -27f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * ((x * x2) * x8)); }
                    case -28f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * (x4 * x8)); }
                    case -29f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * ((x * x4) * x8)); }
                    case -30f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16)); }
                    case -33f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * x); }
                    case -34f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * x2); }
                    case -35f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x * x2)); }
                    case -36f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * x4); }
                    case -37f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x * x4)); }
                    case -38f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x2 * x4)); }
                    case -39f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x2) * x4)); }
                    case -40f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * x8); }
                    case -41f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x * x8)); }
                    case -42f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x2 * x8)); }
                    case -43f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x2) * x8)); }
                    case -44f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x4 * x8)); }
                    case -45f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x4) * x8)); }
                    case -46f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * x16); }
                    case -49f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x * x16)); }
                    case -50f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x2 * x16)); }
                    case -51f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x2) * x16)); }
                    case -52f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x4 * x16)); }
                    case -53f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x4) * x16)); }
                    case -54f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (x8 * x16)); }
                    case -57f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x * x8) * x16)); }
                    case -58f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32)); }
                    case -65f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x); }
                    case -66f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x2); }
                    case -67f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x * x2)); }
                    case -68f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x4); }
                    case -69f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x * x4)); }
                    case -70f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x2 * x4)); }
                    case -71f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x2) * x4)); }
                    case -72f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x8); }
                    case -73f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x * x8)); }
                    case -74f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x2 * x8)); }
                    case -75f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x2) * x8)); }
                    case -76f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x4 * x8)); }
                    case -77f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x4) * x8)); }
                    case -78f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x16); }
                    case -81f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x * x16)); }
                    case -82f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x2 * x16)); }
                    case -83f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x2) * x16)); }
                    case -84f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x4 * x16)); }
                    case -85f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x4) * x16)); }
                    case -86f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x8 * x16)); }
                    case -89f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x * x8) * x16)); }
                    case -90f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * x32); }
                    case -97f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * x)); }
                    case -98f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * x2)); }
                    case -99f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x * x2))); }
                    case -100f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * x4)); }
                    case -101f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x * x4))); }
                    case -102f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * x8)); }
                    case -105f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x * x8))); }
                    case -106f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * x16)); }
                    case -113f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x * x16))); }
                    case -114f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); float8 x64 = square(x32); return rcp(square(x64)); }

                    case -0.5f:    { return rsqrt(x); }
                    case -1f / 3f: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1f / 3f:  { return cbrt(x); }
                    case 0.5f:     { return sqrt(x); }
                    case 0.25f:    { return rsqrt(rsqrt(x)); }
                    case 0.125f:   { return sqrt(rsqrt(rsqrt(x))); }
                               
                    case 1f:   { return x; }
                    case 2f:   { return square(x); }
                    case 3f:   { return square(x) * x; }
                    case 4f:   { float8 x2 = square(x); return square(x2); }
                    case 5f:   { float8 x2 = square(x); return square(x2) * x; }
                    case 6f:   { float8 x2 = square(x); return square(x2) * x2; }
                    case 7f:   { float8 x2 = square(x); return square(x2) * (x * x2); }
                    case 8f:   { float8 x2 = square(x); float8 x4 = square(x2); return square(x4); }
                    case 9f:   { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * x; }
                    case 10f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * x2; }
                    case 11f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * x4; }
                    case 13f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15f:  { float8 x2 = square(x); float8 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8); }
                    case 17f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * x; }
                    case 18f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * x2; }
                    case 19f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * x4; }
                    case 21f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * x8; }
                    case 25f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16); }
                    case 33f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * x; }
                    case 34f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * x2; }
                    case 35f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * x4; }
                    case 37f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * x8; }
                    case 41f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * x16; }
                    case 49f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32); }
                    case 65f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x; }
                    case 66f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x2; }
                    case 67f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x4; }
                    case 69f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x8; }
                    case 73f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x16; }
                    case 81f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * x32; }
                    case 97f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99f:  { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128f: { float8 x2 = square(x); float8 x4 = square(x2); float8 x8 = square(x4); float8 x16 = square(x8); float8 x32 = square(x16); float8 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return pow(x, (float8)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 pow(float4 x, float y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1f:   { return math.rcp(x); }
                    case -2f:   { return math.rcp(square(x)); }
                    case -3f:   { return math.rcp(square(x) * x); }
                    case -4f:   { float4 x2 = square(x); return math.rcp(square(x2)); }
                    case -5f:   { float4 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6f:   { float4 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7f:   { float4 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8f:   { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9f:   { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15f:  { float4 x2 = square(x); float4 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); float4 x64 = square(x32); return math.rcp(square(x64)); }

                    case -0.5f:    { return math.rsqrt(x); }
                    case -1f / 3f: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1f / 3f:  { return cbrt(x); }
                    case 0.5f:     { return math.sqrt(x); }
                    case 0.25f:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125f:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1f:   { return x; }
                    case 2f:   { return square(x); }
                    case 3f:   { return square(x) * x; }
                    case 4f:   { float4 x2 = square(x); return square(x2); }
                    case 5f:   { float4 x2 = square(x); return square(x2) * x; }
                    case 6f:   { float4 x2 = square(x); return square(x2) * x2; }
                    case 7f:   { float4 x2 = square(x); return square(x2) * (x * x2); }
                    case 8f:   { float4 x2 = square(x); float4 x4 = square(x2); return square(x4); }
                    case 9f:   { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * x; }
                    case 10f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * x2; }
                    case 11f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * x4; }
                    case 13f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15f:  { float4 x2 = square(x); float4 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8); }
                    case 17f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * x; }
                    case 18f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * x2; }
                    case 19f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * x4; }
                    case 21f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * x8; }
                    case 25f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16); }
                    case 33f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * x; }
                    case 34f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * x2; }
                    case 35f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * x4; }
                    case 37f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * x8; }
                    case 41f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * x16; }
                    case 49f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32); }
                    case 65f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x; }
                    case 66f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x2; }
                    case 67f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x4; }
                    case 69f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x8; }
                    case 73f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x16; }
                    case 81f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * x32; }
                    case 97f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99f:  { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128f: { float4 x2 = square(x); float4 x4 = square(x2); float4 x8 = square(x4); float4 x16 = square(x8); float4 x32 = square(x16); float4 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (float4)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 pow(float3 x, float y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1f:   { return math.rcp(x); }
                    case -2f:   { return math.rcp(square(x)); }
                    case -3f:   { return math.rcp(square(x) * x); }
                    case -4f:   { float3 x2 = square(x); return math.rcp(square(x2)); }
                    case -5f:   { float3 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6f:   { float3 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7f:   { float3 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8f:   { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9f:   { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15f:  { float3 x2 = square(x); float3 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); float3 x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5f:    { return math.rsqrt(x); }
                    case -1f / 3f: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1f / 3f:  { return cbrt(x); }
                    case 0.5f:     { return math.sqrt(x); }
                    case 0.25f:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125f:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1f:   { return x; }
                    case 2f:   { return square(x); }
                    case 3f:   { return square(x) * x; }
                    case 4f:   { float3 x2 = square(x); return square(x2); }
                    case 5f:   { float3 x2 = square(x); return square(x2) * x; }
                    case 6f:   { float3 x2 = square(x); return square(x2) * x2; }
                    case 7f:   { float3 x2 = square(x); return square(x2) * (x * x2); }
                    case 8f:   { float3 x2 = square(x); float3 x4 = square(x2); return square(x4); }
                    case 9f:   { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * x; }
                    case 10f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * x2; }
                    case 11f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * x4; }
                    case 13f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15f:  { float3 x2 = square(x); float3 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8); }
                    case 17f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * x; }
                    case 18f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * x2; }
                    case 19f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * x4; }
                    case 21f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * x8; }
                    case 25f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16); }
                    case 33f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * x; }
                    case 34f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * x2; }
                    case 35f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * x4; }
                    case 37f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * x8; }
                    case 41f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * x16; }
                    case 49f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32); }
                    case 65f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x; }
                    case 66f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x2; }
                    case 67f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x4; }
                    case 69f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x8; }
                    case 73f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x16; }
                    case 81f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * x32; }
                    case 97f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99f:  { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128f: { float3 x2 = square(x); float3 x4 = square(x2); float3 x8 = square(x4); float3 x16 = square(x8); float3 x32 = square(x16); float3 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (float3)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 pow(float2 x, float y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1f:   { return math.rcp(x); }
                    case -2f:   { return math.rcp(square(x)); }
                    case -3f:   { return math.rcp(square(x) * x); }
                    case -4f:   { float2 x2 = square(x); return math.rcp(square(x2)); }
                    case -5f:   { float2 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6f:   { float2 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7f:   { float2 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8f:   { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9f:   { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15f:  { float2 x2 = square(x); float2 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); float2 x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5f:    { return math.rsqrt(x); }
                    case -1f / 3f: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1f / 3f:  { return cbrt(x); }
                    case 0.5f:     { return math.sqrt(x); }
                    case 0.25f:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125f:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1f:   { return x; }
                    case 2f:   { return square(x); }
                    case 3f:   { return square(x) * x; }
                    case 4f:   { float2 x2 = square(x); return square(x2); }
                    case 5f:   { float2 x2 = square(x); return square(x2) * x; }
                    case 6f:   { float2 x2 = square(x); return square(x2) * x2; }
                    case 7f:   { float2 x2 = square(x); return square(x2) * (x * x2); }
                    case 8f:   { float2 x2 = square(x); float2 x4 = square(x2); return square(x4); }
                    case 9f:   { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * x; }
                    case 10f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * x2; }
                    case 11f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * x4; }
                    case 13f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15f:  { float2 x2 = square(x); float2 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8); }
                    case 17f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * x; }
                    case 18f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * x2; }
                    case 19f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * x4; }
                    case 21f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * x8; }
                    case 25f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16); }
                    case 33f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * x; }
                    case 34f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * x2; }
                    case 35f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * x4; }
                    case 37f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * x8; }
                    case 41f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * x16; }
                    case 49f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32); }
                    case 65f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x; }
                    case 66f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x2; }
                    case 67f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x4; }
                    case 69f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x8; }
                    case 73f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x16; }
                    case 81f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * x32; }
                    case 97f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99f:  { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128f: { float2 x2 = square(x); float2 x4 = square(x2); float2 x8 = square(x4); float2 x16 = square(x8); float2 x32 = square(x16); float2 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (float2)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float pow(float x, float y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1f:   { return math.rcp(x); }
                    case -2f:   { return math.rcp(square(x)); }
                    case -3f:   { return math.rcp(square(x) * x); }
                    case -4f:   { float x2 = square(x); return math.rcp(square(x2)); }
                    case -5f:   { float x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6f:   { float x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7f:   { float x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8f:   { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4)); }
                    case -9f:   { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15f:  { float x2 = square(x); float x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8)); }
                    case -17f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16)); }
                    case -33f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32)); }
                    case -65f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); float x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5f:    { return math.rsqrt(x); }
                    case -1f / 3f: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1f / 3f:  { return cbrt(x); }
                    case 0.5f:     { return math.sqrt(x); }
                    case 0.25f:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125f:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1f:   { return x; }
                    case 2f:   { return square(x); }
                    case 3f:   { return square(x) * x; }
                    case 4f:   { float x2 = square(x); return square(x2); }
                    case 5f:   { float x2 = square(x); return square(x2) * x; }
                    case 6f:   { float x2 = square(x); return square(x2) * x2; }
                    case 7f:   { float x2 = square(x); return square(x2) * (x * x2); }
                    case 8f:   { float x2 = square(x); float x4 = square(x2); return square(x4); }
                    case 9f:   { float x2 = square(x); float x4 = square(x2); return square(x4) * x; }
                    case 10f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * x2; }
                    case 11f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * (x * x2); }
                    case 12f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * x4; }
                    case 13f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * (x * x4); }
                    case 14f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15f:  { float x2 = square(x); float x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8); }
                    case 17f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * x; }
                    case 18f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * x2; }
                    case 19f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x * x2); }
                    case 20f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * x4; }
                    case 21f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x * x4); }
                    case 22f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * x8; }
                    case 25f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x * x8); }
                    case 26f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16); }
                    case 33f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * x; }
                    case 34f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * x2; }
                    case 35f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x * x2); }
                    case 36f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * x4; }
                    case 37f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x * x4); }
                    case 38f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * x8; }
                    case 41f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x * x8); }
                    case 42f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * x16; }
                    case 49f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x * x16); }
                    case 50f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32); }
                    case 65f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x; }
                    case 66f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x2; }
                    case 67f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x * x2); }
                    case 68f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x4; }
                    case 69f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x * x4); }
                    case 70f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x8; }
                    case 73f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x * x8); }
                    case 74f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x16; }
                    case 81f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x * x16); }
                    case 82f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * x32; }
                    case 97f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99f:  { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128f: { float x2 = square(x); float x4 = square(x2); float x8 = square(x4); float x16 = square(x8); float x32 = square(x16); float x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (float)y);
        }


        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 pow(double4 x, double y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1d:   { return math.rcp(x); }
                    case -2d:   { return math.rcp(square(x)); }
                    case -3d:   { return math.rcp(square(x) * x); }
                    case -4d:   { double4 x2 = square(x); return math.rcp(square(x2)); }
                    case -5d:   { double4 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6d:   { double4 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7d:   { double4 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8d:   { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9d:   { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15d:  { double4 x2 = square(x); double4 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); double4 x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5d:    { return math.rsqrt(x); }
                    case -1d / 3d: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1d / 3d:  { return cbrt(x); }
                    case 0.5d:     { return math.sqrt(x); }
                    case 0.25d:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125d:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1d:   { return x; }
                    case 2d:   { return square(x); }
                    case 3d:   { return square(x) * x; }
                    case 4d:   { double4 x2 = square(x); return square(x2); }
                    case 5d:   { double4 x2 = square(x); return square(x2) * x; }
                    case 6d:   { double4 x2 = square(x); return square(x2) * x2; }
                    case 7d:   { double4 x2 = square(x); return square(x2) * (x * x2); }
                    case 8d:   { double4 x2 = square(x); double4 x4 = square(x2); return square(x4); }
                    case 9d:   { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * x; }
                    case 10d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * x2; }
                    case 11d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * x4; }
                    case 13d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15d:  { double4 x2 = square(x); double4 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8); }
                    case 17d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * x; }
                    case 18d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * x2; }
                    case 19d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * x4; }
                    case 21d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * x8; }
                    case 25d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16); }
                    case 33d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * x; }
                    case 34d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * x2; }
                    case 35d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * x4; }
                    case 37d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * x8; }
                    case 41d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * x16; }
                    case 49d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32); }
                    case 65d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x; }
                    case 66d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x2; }
                    case 67d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x4; }
                    case 69d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x8; }
                    case 73d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x16; }
                    case 81d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * x32; }
                    case 97d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99d:  { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128d: { double4 x2 = square(x); double4 x4 = square(x2); double4 x8 = square(x4); double4 x16 = square(x8); double4 x32 = square(x16); double4 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (double4)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 pow(double3 x, double y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1d:   { return math.rcp(x); }
                    case -2d:   { return math.rcp(square(x)); }
                    case -3d:   { return math.rcp(square(x) * x); }
                    case -4d:   { double3 x2 = square(x); return math.rcp(square(x2)); }
                    case -5d:   { double3 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6d:   { double3 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7d:   { double3 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8d:   { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9d:   { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15d:  { double3 x2 = square(x); double3 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); double3 x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5d:    { return math.rsqrt(x); }
                    case -1d / 3d: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1d / 3d:  { return cbrt(x); }
                    case 0.5d:     { return math.sqrt(x); }
                    case 0.25d:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125d:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1d:   { return x; }
                    case 2d:   { return square(x); }
                    case 3d:   { return square(x) * x; }
                    case 4d:   { double3 x2 = square(x); return square(x2); }
                    case 5d:   { double3 x2 = square(x); return square(x2) * x; }
                    case 6d:   { double3 x2 = square(x); return square(x2) * x2; }
                    case 7d:   { double3 x2 = square(x); return square(x2) * (x * x2); }
                    case 8d:   { double3 x2 = square(x); double3 x4 = square(x2); return square(x4); }
                    case 9d:   { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * x; }
                    case 10d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * x2; }
                    case 11d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * x4; }
                    case 13d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15d:  { double3 x2 = square(x); double3 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8); }
                    case 17d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * x; }
                    case 18d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * x2; }
                    case 19d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * x4; }
                    case 21d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * x8; }
                    case 25d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16); }
                    case 33d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * x; }
                    case 34d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * x2; }
                    case 35d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * x4; }
                    case 37d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * x8; }
                    case 41d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * x16; }
                    case 49d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32); }
                    case 65d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x; }
                    case 66d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x2; }
                    case 67d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x4; }
                    case 69d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x8; }
                    case 73d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x16; }
                    case 81d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * x32; }
                    case 97d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99d:  { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128d: { double3 x2 = square(x); double3 x4 = square(x2); double3 x8 = square(x4); double3 x16 = square(x8); double3 x32 = square(x16); double3 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (double3)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 pow(double2 x, double y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1d:   { return math.rcp(x); }
                    case -2d:   { return math.rcp(square(x)); }
                    case -3d:   { return math.rcp(square(x) * x); }
                    case -4d:   { double2 x2 = square(x); return math.rcp(square(x2)); }
                    case -5d:   { double2 x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6d:   { double2 x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7d:   { double2 x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8d:   { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4)); }
                    case -9d:   { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15d:  { double2 x2 = square(x); double2 x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8)); }
                    case -17d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16)); }
                    case -33d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32)); }
                    case -65d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); double2 x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5d:    { return math.rsqrt(x); }
                    case -1d / 3d: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1d / 3d:  { return cbrt(x); }
                    case 0.5d:     { return math.sqrt(x); }
                    case 0.25d:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125d:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1d:   { return x; }
                    case 2d:   { return square(x); }
                    case 3d:   { return square(x) * x; }
                    case 4d:   { double2 x2 = square(x); return square(x2); }
                    case 5d:   { double2 x2 = square(x); return square(x2) * x; }
                    case 6d:   { double2 x2 = square(x); return square(x2) * x2; }
                    case 7d:   { double2 x2 = square(x); return square(x2) * (x * x2); }
                    case 8d:   { double2 x2 = square(x); double2 x4 = square(x2); return square(x4); }
                    case 9d:   { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * x; }
                    case 10d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * x2; }
                    case 11d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * (x * x2); }
                    case 12d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * x4; }
                    case 13d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * (x * x4); }
                    case 14d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15d:  { double2 x2 = square(x); double2 x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8); }
                    case 17d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * x; }
                    case 18d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * x2; }
                    case 19d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x * x2); }
                    case 20d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * x4; }
                    case 21d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x * x4); }
                    case 22d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * x8; }
                    case 25d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x * x8); }
                    case 26d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16); }
                    case 33d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * x; }
                    case 34d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * x2; }
                    case 35d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x * x2); }
                    case 36d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * x4; }
                    case 37d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x * x4); }
                    case 38d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * x8; }
                    case 41d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x * x8); }
                    case 42d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * x16; }
                    case 49d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x * x16); }
                    case 50d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32); }
                    case 65d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x; }
                    case 66d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x2; }
                    case 67d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x * x2); }
                    case 68d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x4; }
                    case 69d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x * x4); }
                    case 70d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x8; }
                    case 73d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x * x8); }
                    case 74d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x16; }
                    case 81d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x * x16); }
                    case 82d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * x32; }
                    case 97d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99d:  { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128d: { double2 x2 = square(x); double2 x4 = square(x2); double2 x8 = square(x4); double2 x16 = square(x8); double2 x32 = square(x16); double2 x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (double2)y);
        }

        /// <summary>       Returns the result of raising each <paramref name="x"/> component to the power <paramref name="y"/>.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double pow(double x, double y)
        {
            if (Constant.IsConstantExpression(y))
            {
                switch (y)
                {
                    case -1d:   { return math.rcp(x); }
                    case -2d:   { return math.rcp(square(x)); }
                    case -3d:   { return math.rcp(square(x) * x); }
                    case -4d:   { double x2 = square(x); return math.rcp(square(x2)); }
                    case -5d:   { double x2 = square(x); return math.rcp(square(x2) * x); }
                    case -6d:   { double x2 = square(x); return math.rcp(square(x2) * x2); }
                    case -7d:   { double x2 = square(x); return math.rcp(square(x2) * (x * x2)); }
                    case -8d:   { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4)); }
                    case -9d:   { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * x); }
                    case -10d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * x2); }
                    case -11d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * (x * x2)); }
                    case -12d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * x4); }
                    case -13d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * (x * x4)); }
                    case -14d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * (x2 * x4)); }
                    case -15d:  { double x2 = square(x); double x4 = square(x2); return math.rcp(square(x4) * ((x * x2) * x4)); }
                    case -16d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8)); }
                    case -17d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * x); }
                    case -18d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * x2); }
                    case -19d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x * x2)); }
                    case -20d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * x4); }
                    case -21d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x * x4)); }
                    case -22d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x2 * x4)); }
                    case -23d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x4)); }
                    case -24d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * x8); }
                    case -25d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x * x8)); }
                    case -26d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x2 * x8)); }
                    case -27d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * x8)); }
                    case -28d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * (x4 * x8)); }
                    case -29d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * ((x * x4) * x8)); }
                    case -30d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * ((x2 * x4) * x8)); }
                    case -31d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return math.rcp(square(x8) * ((x * x2) * (x4 * x8))); }
                    case -32d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16)); }
                    case -33d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * x); }
                    case -34d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * x2); }
                    case -35d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x * x2)); }
                    case -36d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * x4); }
                    case -37d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x * x4)); }
                    case -38d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x2 * x4)); }
                    case -39d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x4)); }
                    case -40d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * x8); }
                    case -41d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x * x8)); }
                    case -42d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x2 * x8)); }
                    case -43d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x8)); }
                    case -44d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x4 * x8)); }
                    case -45d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x8)); }
                    case -46d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x8)); }
                    case -47d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x8)); }
                    case -48d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * x16); }
                    case -49d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x * x16)); }
                    case -50d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x2 * x16)); }
                    case -51d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x2) * x16)); }
                    case -52d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x4 * x16)); }
                    case -53d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x4) * x16)); }
                    case -54d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x2 * x4) * x16)); }
                    case -55d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x4) * x16)); }
                    case -56d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (x8 * x16)); }
                    case -57d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x * x8) * x16)); }
                    case -58d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x2 * x8) * x16)); }
                    case -59d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (((x * x2) * x8) * x16)); }
                    case -60d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((x4 * x8) * x16)); }
                    case -61d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (((x * x4) * x8) * x16)); }
                    case -62d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * (((x2 * x4) * x8) * x16)); }
                    case -63d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return math.rcp(square(x16) * ((((x * x2) * x4) * x8) * x16)); }
                    case -64d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32)); }
                    case -65d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x); }
                    case -66d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x2); }
                    case -67d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x * x2)); }
                    case -68d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x4); }
                    case -69d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x * x4)); }
                    case -70d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x2 * x4)); }
                    case -71d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x4)); }
                    case -72d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x8); }
                    case -73d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x * x8)); }
                    case -74d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x2 * x8)); }
                    case -75d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x8)); }
                    case -76d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x4 * x8)); }
                    case -77d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x8)); }
                    case -78d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x8)); }
                    case -79d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x8)); }
                    case -80d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x16); }
                    case -81d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x * x16)); }
                    case -82d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x2 * x16)); }
                    case -83d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x2) * x16)); }
                    case -84d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x4 * x16)); }
                    case -85d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x4) * x16)); }
                    case -86d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x2 * x4) * x16)); }
                    case -87d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x4) * x16)); }
                    case -88d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x8 * x16)); }
                    case -89d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x * x8) * x16)); }
                    case -90d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x2 * x8) * x16)); }
                    case -91d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (((x * x2) * x8) * x16)); }
                    case -92d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((x4 * x8) * x16)); }
                    case -93d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (((x * x4) * x8) * x16)); }
                    case -94d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (((x2 * x4) * x8) * x16)); }
                    case -95d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * ((((x * x2) * x4) * x8) * x16)); }
                    case -96d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * x32); }
                    case -97d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * x)); }
                    case -98d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * x2)); }
                    case -99d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x2))); }
                    case -100d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * x4)); }
                    case -101d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x4))); }
                    case -102d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x4))); }
                    case -103d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x4))); }
                    case -104d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * x8)); }
                    case -105d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x8))); }
                    case -106d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x8))); }
                    case -107d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x8))); }
                    case -108d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x8))); }
                    case -109d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x8))); }
                    case -110d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x8))); }
                    case -111d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x8))); }
                    case -112d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * x16)); }
                    case -113d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x * x16))); }
                    case -114d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x2 * x16))); }
                    case -115d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x2) * x16))); }
                    case -116d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x4 * x16))); }
                    case -117d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x4) * x16))); }
                    case -118d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x4) * x16))); }
                    case -119d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x4) * x16))); }
                    case -120d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (x8 * x16))); }
                    case -121d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x * x8) * x16))); }
                    case -122d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x2 * x8) * x16))); }
                    case -123d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x2) * x8) * x16))); }
                    case -124d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((x4 * x8) * x16))); }
                    case -125d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x * x4) * x8) * x16))); }
                    case -126d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * (((x2 * x4) * x8) * x16))); }
                    case -127d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return math.rcp(square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16))); }
                    case -128d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); double x64 = square(x32); return math.rcp(square(x64)); }
                    
                    case -0.5d:    { return math.rsqrt(x); }
                    case -1d / 3d: { return rcbrt(x); }
                    case 0f:       { return 1f; }
                    case 1d / 3d:  { return cbrt(x); }
                    case 0.5d:     { return math.sqrt(x); }
                    case 0.25d:    { return math.rsqrt(math.rsqrt(x)); }
                    case 0.125d:   { return math.sqrt(math.rsqrt(math.rsqrt(x))); }
                               
                    case 1d:   { return x; }
                    case 2d:   { return square(x); }
                    case 3d:   { return square(x) * x; }
                    case 4d:   { double x2 = square(x); return square(x2); }
                    case 5d:   { double x2 = square(x); return square(x2) * x; }
                    case 6d:   { double x2 = square(x); return square(x2) * x2; }
                    case 7d:   { double x2 = square(x); return square(x2) * (x * x2); }
                    case 8d:   { double x2 = square(x); double x4 = square(x2); return square(x4); }
                    case 9d:   { double x2 = square(x); double x4 = square(x2); return square(x4) * x; }
                    case 10d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * x2; }
                    case 11d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * (x * x2); }
                    case 12d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * x4; }
                    case 13d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * (x * x4); }
                    case 14d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * (x2 * x4); }
                    case 15d:  { double x2 = square(x); double x4 = square(x2); return square(x4) * ((x * x2) * x4); }
                    case 16d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8); }
                    case 17d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * x; }
                    case 18d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * x2; }
                    case 19d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x * x2); }
                    case 20d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * x4; }
                    case 21d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x * x4); }
                    case 22d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x2 * x4); }
                    case 23d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * ((x * x2) * x4); }
                    case 24d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * x8; }
                    case 25d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x * x8); }
                    case 26d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x2 * x8); }
                    case 27d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * ((x * x2) * x8); }
                    case 28d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * (x4 * x8); }
                    case 29d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * ((x * x4) * x8); }
                    case 30d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * ((x2 * x4) * x8); }
                    case 31d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); return square(x8) * ((x * x2) * (x4 * x8)); }
                    case 32d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16); }
                    case 33d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * x; }
                    case 34d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * x2; }
                    case 35d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x * x2); }
                    case 36d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * x4; }
                    case 37d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x * x4); }
                    case 38d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x2 * x4); }
                    case 39d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x2) * x4); }
                    case 40d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * x8; }
                    case 41d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x * x8); }
                    case 42d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x2 * x8); }
                    case 43d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x2) * x8); }
                    case 44d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x4 * x8); }
                    case 45d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x4) * x8); }
                    case 46d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x2 * x4) * x8); }
                    case 47d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (((x * x2) * x4) * x8); }
                    case 48d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * x16; }
                    case 49d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x * x16); }
                    case 50d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x2 * x16); }
                    case 51d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x2) * x16); }
                    case 52d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x4 * x16); }
                    case 53d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x4) * x16); }
                    case 54d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x2 * x4) * x16); }
                    case 55d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (((x * x2) * x4) * x16); }
                    case 56d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (x8 * x16); }
                    case 57d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x * x8) * x16); }
                    case 58d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x2 * x8) * x16); }
                    case 59d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (((x * x2) * x8) * x16); }
                    case 60d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((x4 * x8) * x16); }
                    case 61d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (((x * x4) * x8) * x16); }
                    case 62d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * (((x2 * x4) * x8) * x16); }
                    case 63d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); return square(x16) * ((((x * x2) * x4) * x8) * x16); }
                    case 64d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32); }
                    case 65d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x; }
                    case 66d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x2; }
                    case 67d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x * x2); }
                    case 68d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x4; }
                    case 69d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x * x4); }
                    case 70d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x2 * x4); }
                    case 71d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x2) * x4); }
                    case 72d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x8; }
                    case 73d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x * x8); }
                    case 74d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x2 * x8); }
                    case 75d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x2) * x8); }
                    case 76d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x4 * x8); }
                    case 77d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x4) * x8); }
                    case 78d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x2 * x4) * x8); }
                    case 79d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (((x * x2) * x4) * x8); }
                    case 80d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x16; }
                    case 81d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x * x16); }
                    case 82d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x2 * x16); }
                    case 83d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x2) * x16); }
                    case 84d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x4 * x16); }
                    case 85d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x4) * x16); }
                    case 86d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x2 * x4) * x16); }
                    case 87d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (((x * x2) * x4) * x16); }
                    case 88d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x8 * x16); }
                    case 89d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x * x8) * x16); }
                    case 90d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x2 * x8) * x16); }
                    case 91d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (((x * x2) * x8) * x16); }
                    case 92d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((x4 * x8) * x16); }
                    case 93d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (((x * x4) * x8) * x16); }
                    case 94d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (((x2 * x4) * x8) * x16); }
                    case 95d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * ((((x * x2) * x4) * x8) * x16); }
                    case 96d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * x32; }
                    case 97d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * x); }
                    case 98d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * x2); }
                    case 99d:  { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x * x2)); }
                    case 100d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * x4); }
                    case 101d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x * x4)); }
                    case 102d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x2 * x4)); }
                    case 103d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x4)); }
                    case 104d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * x8); }
                    case 105d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x * x8)); }
                    case 106d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x2 * x8)); }
                    case 107d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x8)); }
                    case 108d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x4 * x8)); }
                    case 109d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x8)); }
                    case 110d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x8)); }
                    case 111d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x8)); }
                    case 112d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * x16); }
                    case 113d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x * x16)); }
                    case 114d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x2 * x16)); }
                    case 115d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x2) * x16)); }
                    case 116d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x4 * x16)); }
                    case 117d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x4) * x16)); }
                    case 118d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x2 * x4) * x16)); }
                    case 119d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x4) * x16)); }
                    case 120d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (x8 * x16)); }
                    case 121d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x * x8) * x16)); }
                    case 122d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x2 * x8) * x16)); }
                    case 123d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (((x * x2) * x8) * x16)); }
                    case 124d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((x4 * x8) * x16)); }
                    case 125d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (((x * x4) * x8) * x16)); }
                    case 126d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * (((x2 * x4) * x8) * x16)); }
                    case 127d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); return square(x32) * (x32 * ((((x * x2) * x4) * x8) * x16)); }
                    case 128d: { double x2 = square(x); double x4 = square(x2); double x8 = square(x4); double x16 = square(x8); double x32 = square(x16); double x64 = square(x32); return square(x64); }

                    default: break;
                }
            }

            return math.pow(x, (double)y);
        }
    }
}