﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two float2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 addsub(float2 a, float2 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new float2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two float3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 addsub(float3 a, float3 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new float3(a.x + b.x, a.y - b.y, a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two float4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 addsub(float4 a, float4 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new float4(a.x + b.x, a.y - b.y, a.z + b.z, a.w - b.w);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two float8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 addsub(float8 a, float8 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new float8(addsub(a.v4_0, b.v4_0), addsub(a.v4_4, b.v4_4));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two double2 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 addsub(double2 a, double2 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new double2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two double3 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 addsub(double3 a, double3 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new double3(a.x + b.x, a.y - b.y, a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two double4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 addsub(double4 a, double4 b)
        {
            if (Fma.IsFmaSupported)
            {
                return madsub(1f, a, b);
            }
            else
            {
                return new double4(a.x + b.x, a.y - b.y, a.z + b.z, a.w - b.w);
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 addsub(byte2 a, byte2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte2(1, 255));
            }
            else
            {
                return new byte2((byte)(a.x + b.x), (byte)(a.y - b.y));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 addsub(byte3 a, byte3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte4(1, 255, 1, 255));
            }
            else
            {
                return new byte3((byte)(a.x + b.x), (byte)(a.y - b.y), (byte)(a.z + b.z));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 addsub(byte4 a, byte4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte4(1, 255, 1, 255));
            }
            else
            {
                return new byte4((byte)(a.x + b.x), (byte)(a.y - b.y), (byte)(a.z + b.z), (byte)(a.w - b.w));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 addsub(byte8 a, byte8 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte8(1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new byte8((byte)(a.x0 + b.x0), (byte)(a.x1 - b.x1), (byte)(a.x2 + b.x2), (byte)(a.x3 - b.x3), (byte)(a.x4 + b.x4), (byte)(a.x5 - b.x5), (byte)(a.x6 + b.x6), (byte)(a.x7 - b.x7));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte16 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 addsub(byte16 a, byte16 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new v128(1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new byte16((byte)(a.x0 + b.x0), (byte)(a.x1 - b.x1), (byte)(a.x2 + b.x2), (byte)(a.x3 - b.x3), (byte)(a.x4 + b.x4), (byte)(a.x5 - b.x5), (byte)(a.x6 + b.x6), (byte)(a.x7 - b.x7), (byte)(a.x8 + b.x8), (byte)(a.x9 - b.x9), (byte)(a.x10 + b.x10), (byte)(a.x11 - b.x11), (byte)(a.x12 + b.x12), (byte)(a.x13 - b.x13), (byte)(a.x14 + b.x14), (byte)(a.x15 - b.x15));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two byte32 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 addsub(byte32 a, byte32 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi8(b, new v256(1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new byte32(addsub(a.v16_0, b.v16_0), addsub(a.v16_16, b.v16_16));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 addsub(sbyte2 a, sbyte2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte2(1, 255));
            }
            else
            {
                return new sbyte2((sbyte)(a.x + b.x), (sbyte)(a.y - b.y));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 addsub(sbyte3 a, sbyte3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte4(1, 255, 1, 255));
            }
            else
            {
                return new sbyte3((sbyte)(a.x + b.x), (sbyte)(a.y - b.y), (sbyte)(a.z + b.z));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 addsub(sbyte4 a, sbyte4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte4(1, 255, 1, 255));
            }
            else
            {
                return new sbyte4((sbyte)(a.x + b.x), (sbyte)(a.y - b.y), (sbyte)(a.z + b.z), (sbyte)(a.w - b.w));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 addsub(sbyte8 a, sbyte8 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new byte8(1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new sbyte8((sbyte)(a.x0 + b.x0), (sbyte)(a.x1 - b.x1), (sbyte)(a.x2 + b.x2), (sbyte)(a.x3 - b.x3), (sbyte)(a.x4 + b.x4), (sbyte)(a.x5 - b.x5), (sbyte)(a.x6 + b.x6), (sbyte)(a.x7 - b.x7));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte16 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 addsub(sbyte16 a, sbyte16 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi8(b, new v128(1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new sbyte16((sbyte)(a.x0 + b.x0), (sbyte)(a.x1 - b.x1), (sbyte)(a.x2 + b.x2), (sbyte)(a.x3 - b.x3), (sbyte)(a.x4 + b.x4), (sbyte)(a.x5 - b.x5), (sbyte)(a.x6 + b.x6), (sbyte)(a.x7 - b.x7), (sbyte)(a.x8 + b.x8), (sbyte)(a.x9 - b.x9), (sbyte)(a.x10 + b.x10), (sbyte)(a.x11 - b.x11), (sbyte)(a.x12 + b.x12), (sbyte)(a.x13 - b.x13), (sbyte)(a.x14 + b.x14), (sbyte)(a.x15 - b.x15));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two sbyte32 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 addsub(sbyte32 a, sbyte32 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi8(b, new v256(1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255, 1, 255));
            }
            else
            {
                return new sbyte32(addsub(a.v16_0, b.v16_0), addsub(a.v16_16, b.v16_16));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ushort2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 addsub(ushort2 a, ushort2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort2(1, ushort.MaxValue));
            }
            else
            {
                return new ushort2((ushort)(a.x + b.x), (ushort)(a.y - b.y));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ushort3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 addsub(ushort3 a, ushort3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort4(1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new ushort3((ushort)(a.x + b.x), (ushort)(a.y - b.y), (ushort)(a.z + b.z));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ushort4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 addsub(ushort4 a, ushort4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort4(1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new ushort4((ushort)(a.x + b.x), (ushort)(a.y - b.y), (ushort)(a.z + b.z), (ushort)(a.w - b.w));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ushort8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 addsub(ushort8 a, ushort8 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort8(1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new ushort8((ushort)(a.x0 + b.x0), (ushort)(a.x1 - b.x1), (ushort)(a.x2 + b.x2), (ushort)(a.x3 - b.x3), (ushort)(a.x4 + b.x4), (ushort)(a.x5 - b.x5), (ushort)(a.x6 + b.x6), (ushort)(a.x7 - b.x7));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ushort16 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 addsub(ushort16 a, ushort16 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi16(b, new v256(1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new ushort16(addsub(a.v8_0, b.v8_0), addsub(a.v8_8, b.v8_8));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two short2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 addsub(short2 a, short2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort2(1, ushort.MaxValue));
            }
            else
            {
                return new short2((short)(a.x + b.x), (short)(a.y - b.y));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two short3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 addsub(short3 a, short3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort4(1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new short3((short)(a.x + b.x), (short)(a.y - b.y), (short)(a.z + b.z));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two short4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 addsub(short4 a, short4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort4(1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new short4((short)(a.x + b.x), (short)(a.y - b.y), (short)(a.z + b.z), (short)(a.w - b.w));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two short8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 addsub(short8 a, short8 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                return a + Ssse3.sign_epi16(b, new ushort8(1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new short8((short)(a.x0 + b.x0), (short)(a.x1 - b.x1), (short)(a.x2 + b.x2), (short)(a.x3 - b.x3), (short)(a.x4 + b.x4), (short)(a.x5 - b.x5), (short)(a.x6 + b.x6), (short)(a.x7 - b.x7));
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two short16 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 addsub(short16 a, short16 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi16(b, new v256(1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue, 1, ushort.MaxValue));
            }
            else
            {
                return new short16(addsub(a.v8_0, b.v8_0), addsub(a.v8_8, b.v8_8));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two uint2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 addsub(uint2 a, uint2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, uint.MaxValue, uint.MaxValue));

                return a + *(uint2*)&temp;
            }
            else
            {
                return new uint2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two uint3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 addsub(uint3 a, uint3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, 1, uint.MaxValue));

                return a + *(uint3*)&temp;
            }
            else
            {
                return new uint3(a.x + b.x, a.y - b.y, a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two uint4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 addsub(uint4 a, uint4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, 1, uint.MaxValue));

                return a + *(uint4*)&temp;
            }
            else
            {
                return new uint4(a.x + b.x, a.y - b.y, a.z + b.z, a.w - b.w);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two uint8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 addsub(uint8 a, uint8 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi32(b, new uint8(1, uint.MaxValue, 1, uint.MaxValue, 1, uint.MaxValue, 1, uint.MaxValue));
            }
            else
            {
                return new uint8(addsub(a.v4_0, b.v4_0), addsub(a.v4_4, b.v4_4));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two int2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 addsub(int2 a, int2 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, 0, 0));

                return a + *(int2*)&temp;
            }
            else
            {
                return new int2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two int3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 addsub(int3 a, int3 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, 1, uint.MaxValue));

                return a + *(int3*)&temp;
            }
            else
            {
                return new int3(a.x + b.x, a.y - b.y, a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two int4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 addsub(int4 a, int4 b)
        {
            if (Ssse3.IsSsse3Supported)
            {
                v128 temp = Ssse3.sign_epi32(*(v128*)&b, new v128(1, uint.MaxValue, 1, uint.MaxValue));

                return a + *(int4*)&temp;
            }
            else
            {
                return new int4(a.x + b.x, a.y - b.y, a.z + b.z, a.w - b.w);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two int8 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 addsub(int8 a, int8 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_sign_epi32(b, new uint8(1, uint.MaxValue, 1, uint.MaxValue, 1, uint.MaxValue, 1, uint.MaxValue));
            }
            else
            {
                return new int8(addsub(a.v4_0, b.v4_0), addsub(a.v4_4, b.v4_4));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ulong2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 addsub(ulong2 a, ulong2 b)
        {
            if (Sse2.IsSse2Supported)
            {
                return a + Mask.BlendEpi16(b, default(v128) - b, 0b1111_0000);
            }
            else
            {
                return new ulong2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ulong3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 addsub(ulong3 a, ulong3 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_blend_epi16(b, default(v256) - b, 0b1111_0000);
            }
            else
            {
                return new ulong3(addsub(a.xy, b.xy), a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two ulong4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 addsub(ulong4 a, ulong4 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_blend_epi16(b, default(v256) - b, 0b1111_0000);
            }
            else
            {
                return new ulong4(addsub(a.xy, b.xy), addsub(a.zw, b.zw));
            }
        }


        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two long2 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 addsub(long2 a, long2 b)
        {
            if (Sse2.IsSse2Supported)
            {
                return a + Mask.BlendEpi16(b, -b, 0b1111_0000);
            }
            else
            {
                return new long2(a.x + b.x, a.y - b.y);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two long3 vectors       </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 addsub(long3 a, long3 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_blend_epi16(b, -b, 0b1111_0000);
            }
            else
            {
                return new long3(addsub(a.xy, b.xy), a.z + b.z);
            }
        }

        /// <summary>       Adds even indexed and subtracts odd indexed components (zero based) of two long4 vectors        </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 addsub(long4 a, long4 b)
        {
            if (Avx2.IsAvx2Supported)
            {
                return a + Avx2.mm256_blend_epi16(b, -b, 0b1111_0000);
            }
            else
            {
                return new long4(addsub(a.xy, b.xy), addsub(a.zw, b.zw));
            }
        }
    }
}