﻿using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Burst.Intrinsics;
using Unity.Burst.CompilerServices;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 shl(sbyte2 x, sbyte2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte2)shl((int2)x, (int2)n);
            }
            else
            {
                return new sbyte2((sbyte)(x.x << n.x), (sbyte)(x.y << n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 shl(sbyte3 x, sbyte3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte3)shl((int3)x, (int3)n);
            }
            else
            {
                return new sbyte3((sbyte)(x.x << n.x), (sbyte)(x.y << n.y), (sbyte)(x.z << n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 shl(sbyte4 x, sbyte4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte4)shl((int4)x, (int4)n);
            }
            else
            {
                return new sbyte4((sbyte)(x.x << n.x), (sbyte)(x.y << n.y), (sbyte)(x.z << n.z), (sbyte)(x.w << n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 shl(sbyte8 x, sbyte8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte8)shl((int8)x, (int8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                sbyte8 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (sbyte i = 1; i < 8; i++)
                {
                    x <<= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new sbyte8(i), n));
                }

                return result;
            }
            else
            {
                return new sbyte8((sbyte)(x.x0 << n.x0), (sbyte)(x.x1 << n.x1), (sbyte)(x.x2 << n.x2), (sbyte)(x.x3 << n.x3), (sbyte)(x.x4 << n.x4), (sbyte)(x.x5 << n.x5), (sbyte)(x.x6 << n.x6), (sbyte)(x.x7 << n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 shl(sbyte16 x, sbyte16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return new sbyte16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
            }
            else if (Sse2.IsSse2Supported)
            {
                sbyte16 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (sbyte i = 1; i < 8; i++)
                {
                    x <<= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new sbyte16(i), n));
                }

                return result;
            }
            else
            {
                return new sbyte16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 shl(sbyte32 x, sbyte32 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            return new sbyte32(shl(x.v16_0, n.v16_0), shl(x.v16_16, n.v16_16));
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 shl(byte2 x, byte2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte2)shl((uint2)x, (uint2)n);
            }
            else
            {
                return new byte2((byte)(x.x << n.x), (byte)(x.y << n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 shl(byte3 x, byte3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte3)shl((uint3)x, (uint3)n);
            }
            else
            {
                return new byte3((byte)(x.x << n.x), (byte)(x.y << n.y), (byte)(x.z << n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 shl(byte4 x, byte4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte4)shl((uint4)x, (uint4)n);
            }
            else
            {
                return new byte4((byte)(x.x << n.x), (byte)(x.y << n.y), (byte)(x.z << n.z), (byte)(x.w << n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 shl(byte8 x, byte8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte8)shl((uint8)x, (uint8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                byte8 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (byte i = 1; i < 8; i++)
                {
                    x <<= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new byte8(i), n));
                }

                return result;
            }
            else
            {
                return new byte8((byte)(x.x0 << n.x0), (byte)(x.x1 << n.x1), (byte)(x.x2 << n.x2), (byte)(x.x3 << n.x3), (byte)(x.x4 << n.x4), (byte)(x.x5 << n.x5), (byte)(x.x6 << n.x6), (byte)(x.x7 << n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 shl(byte16 x, byte16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return new byte16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
            }
            else if (Sse2.IsSse2Supported)
            {
                byte16 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (byte i = 1; i < 8; i++)
                {
                    x <<= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new byte16(i), n));
                }

                return result;
            }
            else
            {
                return new byte16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 shl(byte32 x, byte32 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            return new byte32(shl(x.v16_0, n.v16_0), shl(x.v16_16, n.v16_16));
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 shl(byte2 x, sbyte2 n)
        {
            return shl(x, (byte2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 shl(byte3 x, sbyte3 n)
        {
            return shl(x, (byte3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 shl(byte4 x, sbyte4 n)
        {
            return shl(x, (byte4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 shl(byte8 x, sbyte8 n)
        {
            return shl(x, (byte8)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 shl(byte16 x, sbyte16 n)
        {
            return shl(x, (byte16)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 shl(byte32 x, sbyte32 n)
        {
            return shl(x, (byte32)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 shl(short2 x, short2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short2)shl((int2)x, (int2)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
            }
            else
            {
                return new short2((short)(x.x << n.x), (short)(x.y << n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 shl(short3 x, short3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short3)shl((int3)x, (int3)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);

                return Sse4_1.blend_epi16(_xy, _z, 0b0000_0100);
            }
            else
            {
                return new short3((short)(x.x << n.x), (short)(x.y << n.y), (short)(x.z << n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 shl(short4 x, short4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short4)shl((int4)x, (int4)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                v128 _w = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b0000_1000);

                return Sse4_1.blend_epi16(_xy, _zw, 0b0000_1100);
            }
            else
            {
                return new short4((short)(x.x << n.x), (short)(x.y << n.y), (short)(x.z << n.z), (short)(x.w << n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 shl(short8 x, short8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short8)shl((int8)x, (int8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                short8 result = Sse2.setzero_si128();


                v128 shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0001);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0010);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0100);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_1000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0001_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 10, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0010_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0100_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 14, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b1000_0000);


                return result;
            }
            else
            {
                return new short8((short)(x.x0 << n.x0), (short)(x.x1 << n.x1), (short)(x.x2 << n.x2), (short)(x.x3 << n.x3), (short)(x.x4 << n.x4), (short)(x.x5 << n.x5), (short)(x.x6 << n.x6), (short)(x.x7 << n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 shl(short16 x, short16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            return new short16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 shl(ushort2 x, ushort2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort2)shl((uint2)x, (uint2)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
            }
            else
            {
                return new ushort2((ushort)(x.x << n.x), (ushort)(x.y << n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 shl(ushort3 x, ushort3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort3)shl((uint3)x, (uint3)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);

                return Sse4_1.blend_epi16(_xy, _z, 0b0000_0100);
            }
            else
            {
                return new ushort3((ushort)(x.x << n.x), (ushort)(x.y << n.y), (ushort)(x.z << n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 shl(ushort4 x, ushort4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort4)shl((uint4)x, (uint4)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                v128 _w = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b0000_1000);

                return Sse4_1.blend_epi16(_xy, _zw, 0b0000_1100);
            }
            else
            {
                return new ushort4((ushort)(x.x << n.x), (ushort)(x.y << n.y), (ushort)(x.z << n.z), (ushort)(x.w << n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 shl(ushort8 x, ushort8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort8)shl((uint8)x, (uint8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                ushort8 result;


                v128 shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = shift;

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0010);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0100);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_1000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0001_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 10, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0010_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0100_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 14, 0);
                shift = Sse2.sll_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b1000_0000);


                return result;
            }
            else
            {
                return new ushort8((ushort)(x.x0 << n.x0), (ushort)(x.x1 << n.x1), (ushort)(x.x2 << n.x2), (ushort)(x.x3 << n.x3), (ushort)(x.x4 << n.x4), (ushort)(x.x5 << n.x5), (ushort)(x.x6 << n.x6), (ushort)(x.x7 << n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 shl(ushort16 x, ushort16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            return new ushort16(shl(x.v8_0, n.v8_0), shl(x.v8_8, n.v8_8));
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 shl(ushort2 x, short2 n)
        {
            return shl(x, (ushort2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 shl(ushort3 x, short3 n)
        {
            return shl(x, (ushort3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 shl(ushort4 x, short4 n)
        {
            return shl(x, (ushort4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 shl(ushort8 x, short8 n)
        {
            return shl(x, (ushort8)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 shl(ushort16 x, short16 n)
        {
            return shl(x, (ushort16)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shl(int2 x, int2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.sllv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));
            
                return *(int2*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 result = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                return *(int2*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));

                v128 result = Sse2.unpacklo_epi32(_x, _y);

                return *(int2*)&result;
            }
            else
            {
                return new int2(x.x << n.x, x.y << n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shl(int3 x, int3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.sllv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));
            
                return *(int3*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                v128 result = Sse4_1.blend_epi16(_xy, _z, 0b0011_0000);

                return *(int3*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));
                v128 _z = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 2 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 2 * sizeof(int))));

                v128 lo = Sse2.unpacklo_epi32(_x, _y);
                v128 result = Sse2.unpacklo_epi64(lo, _z);

                return *(int3*)&result;
            }
            else
            {
                return new int3(x.x << n.x, x.y << n.y, x.z << n.z);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shl(int4 x, int4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.sllv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));
            
                return *(int4*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                v128 _w = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b1100_0000);

                v128 result = Sse4_1.blend_epi16(_xy, _zw, 0b1111_0000);

                return *(int4*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.sll_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));
                v128 _z = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 2 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 2 * sizeof(int))));
                v128 _w = Sse2.sll_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 3 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 3 * sizeof(int))));

                v128 lo = Sse2.unpacklo_epi32(_x, _y);
                v128 hi = Sse2.unpacklo_epi32(_z, _w);
                v128 result = Sse2.unpacklo_epi64(lo, hi);

                return *(int4*)&result;
            }
            else
            {
                return new int4(x.x << n.x, x.y << n.y, x.z << n.z, x.w << n.w);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 shl(int8 x, int8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sllv_epi32(x, n);
            }
            else
            {
                return new int8(shl(x.v4_0, n.v4_0), shl(x.v4_4, n.v4_4));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shl(uint2 x, uint2 n)
        {
            return (uint2)shl((int2)x, (int2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shl(uint3 x, uint3 n)
        {
            return (uint3)shl((int3)x, (int3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shl(uint4 x, uint4 n)
        {
            return (uint4)shl((int4)x, (int4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 shl(uint8 x, uint8 n)
        {
            return (uint8)shl((int8)x, (int8)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shl(uint2 x, int2 n)
        {
            return shl(x, (uint2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shl(uint3 x, int3 n)
        {
            return shl(x, (uint3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shl(uint4 x, int4 n)
        {
            return shl(x, (uint4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 shl(uint8 x, int8 n)
        {
            return shl(x, (uint8)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 shl(long2 x, long2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.sllv_epi64(x, n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sll_epi64(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _y = Sse2.sll_epi64(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b1111_0000);
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.sll_epi64(x,                                      Sse2.and_si128(MASK, n));
                v128 _y = Sse2.sll_epi64(Sse2.bsrli_si128(x, 1 * sizeof(ulong)), Sse2.and_si128(MASK, Sse2.bsrli_si128(n, 1 * sizeof(ulong))));

                return Sse2.unpacklo_epi64(_x, _y);
            }
            else
            {
                return new long2(x.x << (int)n.x, x.y << (int)n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 shl(long3 x, long3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sllv_epi64(x, n);
            }
            else
            {
                return new long3(shl(x._xy, n._xy), (x.z << (int)n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 shl(long4 x, long4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x << (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_sllv_epi64(x, n);
            }
            else
            {
                return new long4(shl(x._xy, n._xy), shl(x._zw, n._zw));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 shl(ulong2 x, ulong2 n)
        {
            return (ulong2)shl((long2)x, (long2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 shl(ulong3 x, ulong3 n)
        {
            return (ulong3)shl((long3)x, (long3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 shl(ulong4 x, ulong4 n)
        {
            return (ulong4)shl((long4)x, (long4)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 shl(ulong2 x, long2 n)
        {
            return shl(x, (ulong2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 shl(ulong3 x, long3 n)
        {
            return shl(x, (ulong3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 shl(ulong4 x, long4 n)
        {
            return shl(x, (ulong4)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 shrl(sbyte2 x, sbyte2 n)
        {
            return (sbyte2)shrl((byte2)x, (byte2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 shrl(sbyte3 x, sbyte3 n)
        {
            return (sbyte3)shrl((byte3)x, (byte3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the byteerval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 shrl(sbyte4 x, sbyte4 n)
        {
            return (sbyte4)shrl((byte4)x, (byte4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the byteerval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 shrl(sbyte8 x, sbyte8 n)
        {
            return (sbyte8)shrl((byte8)x, (byte8)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 shrl(sbyte16 x, sbyte16 n)
        {
            return (sbyte16)shrl((byte16)x, (byte16)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 shrl(sbyte32 x, sbyte32 n)
        {
            return (sbyte32)shrl((byte32)x, (byte32)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 shrl(byte2 x, byte2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte2)shrl((uint2)x, (uint2)n);
            }
            else
            {
                return new byte2((byte)(x.x >> n.x), (byte)(x.y >> n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 shrl(byte3 x, byte3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte3)shrl((uint3)x, (uint3)n);
            }
            else
            {
                return new byte3((byte)(x.x >> n.x), (byte)(x.y >> n.y), (byte)(x.z >> n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 shrl(byte4 x, byte4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte4)shrl((uint4)x, (uint4)n);
            }
            else
            {
                return new byte4((byte)(x.x >> n.x), (byte)(x.y >> n.y), (byte)(x.z >> n.z), (byte)(x.w >> n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 shrl(byte8 x, byte8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (byte8)shrl((uint8)x, (uint8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                byte8 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (byte i = 1; i < 8; i++)
                {
                    x >>= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new byte8(i), n));
                }

                return result;
            }
            else
            {
                return new byte8((byte)(x.x0 >> n.x0), (byte)(x.x1 >> n.x1), (byte)(x.x2 >> n.x2), (byte)(x.x3 >> n.x3), (byte)(x.x4 >> n.x4), (byte)(x.x5 >> n.x5), (byte)(x.x6 >> n.x6), (byte)(x.x7 >> n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 shrl(byte16 x, byte16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                uint8 lo = shrl((uint8)x.v8_0, (uint8)n.v8_0);
                uint8 hi = shrl((uint8)x.v8_8, (uint8)n.v8_8);

                v256 shorts = Avx2.mm256_packus_epi32(lo, hi);
                v256 bytes = Avx2.mm256_packus_epi16(shorts, default(v256));

                return Avx.mm256_castsi256_si128(Avx2.mm256_permutevar8x32_epi32(bytes, Avx.mm256_castsi128_si256(new v128(0, 4, 1, 5))));
            }
            else if (Sse2.IsSse2Supported)
            {
                byte16 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (byte i = 1; i < 8; i++)
                {
                    x >>= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new byte16(i), n));
                }

                return result;
            }
            else
            {
                return new byte16(shrl(x.v8_0, n.v8_0), shrl(x.v8_8, n.v8_8));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 shrl(byte32 x, byte32 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                uint8 lo_lo = shrl((uint8)x.v8_0,  (uint8)n.v8_0);
                uint8 lo_hi = shrl((uint8)x.v8_8,  (uint8)n.v8_8);
                uint8 hi_lo = shrl((uint8)x.v8_16, (uint8)n.v8_16);
                uint8 hi_hi = shrl((uint8)x.v8_24, (uint8)n.v8_24);

                ushort16 lo = Avx2.mm256_packus_epi32(lo_lo, lo_hi);
                ushort16 hi = Avx2.mm256_packus_epi32(hi_lo, hi_hi);

                v256 bytes = Avx2.mm256_packus_epi16(lo, hi);
                bytes = Avx2.mm256_permute4x64_epi64(bytes, Sse.SHUFFLE(3, 1, 2, 0));
                bytes = Avx2.mm256_shuffle_epi32(bytes, Sse.SHUFFLE(3, 1, 2, 0));

                return bytes;
            }
            else
            {
                return new byte32(shrl(x.v16_0, n.v16_0), shrl(x.v16_16, n.v16_16));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 shrl(byte2 x, sbyte2 n)
        {
            return shrl(x, (byte2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 shrl(byte3 x, sbyte3 n)
        {
            return shrl(x, (byte3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 shrl(byte4 x, sbyte4 n)
        {
            return shrl(x, (byte4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 shrl(byte8 x, sbyte8 n)
        {
            return shrl(x, (byte8)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 shrl(byte16 x, sbyte16 n)
        {
            return shrl(x, (byte16)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 shrl(byte32 x, sbyte32 n)
        {
            return shrl(x, (byte32)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 shrl(short2 x, short2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (short2)((ushort2)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short2)shrl((ushort2)x, (ushort2)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
            }
            else
            {
                return new short2((short)((ushort)x.x >> n.x), (short)((ushort)x.y >> n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 shrl(short3 x, short3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (short3)((ushort3)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short3)shrl((ushort3)x, (ushort3)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);

                return Sse4_1.blend_epi16(_xy, _z, 0b0000_0100);
            }
            else
            {
                return new short3((short)((ushort)x.x >> n.x), (short)((ushort)x.y >> n.y), (short)((ushort)x.z >> n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 shrl(short4 x, short4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (short4)((ushort4)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short4)shrl((ushort4)x, (ushort4)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                v128 _w = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b0000_1000);

                return Sse4_1.blend_epi16(_xy, _zw, 0b0000_1100);
            }
            else
            {
                return new short4((short)((ushort)x.x >> n.x), (short)((ushort)x.y >> n.y), (short)((ushort)x.z >> n.z), (short)((ushort)x.w >> n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 shrl(short8 x, short8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (short8)((ushort8)x >> n.x0);
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short8)shrl((ushort8)x, (ushort8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                short8 result;


                v128 shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = shift;

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0010);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0100);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_1000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0001_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 10, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0010_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0100_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 14, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b1000_0000);


                return result;
            }
            else
            {
                return new short8((short)((ushort)x.x0 >> n.x0), (short)((ushort)x.x1 >> n.x1), (short)((ushort)x.x2 >> n.x2), (short)((ushort)x.x3 >> n.x3), (short)((ushort)x.x4 >> n.x4), (short)((ushort)x.x5 >> n.x5), (short)((ushort)x.x6 >> n.x6), (short)((ushort)x.x7 >> n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 shrl(short16 x, short16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (short16)((ushort16)x >> n.x0);
            }

            if (Avx2.IsAvx2Supported)
            {
                uint8 lo = shrl((uint8)(ushort8)x.v8_0, (uint8)(ushort8)n.v8_0);
                uint8 hi = shrl((uint8)(ushort8)x.v8_8, (uint8)(ushort8)n.v8_8);

                return Avx2.mm256_permute4x64_epi64(Avx2.mm256_packus_epi32(lo, hi), Sse.SHUFFLE(3, 1, 2, 0));
            }
            else
            {
                return new short16(shrl(x.v8_0, n.v8_0), shrl(x.v8_8, n.v8_8));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 shrl(ushort2 x, ushort2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort2)shrl((uint2)x, (uint2)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
            }
            else
            {
                return new ushort2((ushort)(x.x >> n.x), (ushort)(x.y >> n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 shrl(ushort3 x, ushort3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort3)shrl((uint3)x, (uint3)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);

                return Sse4_1.blend_epi16(_xy, _z, 0b0000_0100);
            }
            else
            {
                return new ushort3((ushort)(x.x >> n.x), (ushort)(x.y >> n.y), (ushort)(x.z >> n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 shrl(ushort4 x, ushort4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort4)shrl((uint4)x, (uint4)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                v128 _w = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b0000_1000);

                return Sse4_1.blend_epi16(_xy, _zw, 0b0000_1100);
            }
            else
            {
                return new ushort4((ushort)(x.x >> n.x), (ushort)(x.y >> n.y), (ushort)(x.z >> n.z), (ushort)(x.w >> n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 shrl(ushort8 x, ushort8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (ushort8)shrl((uint8)x, (uint8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                ushort8 result;


                v128 shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = shift;

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0010);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0100);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_1000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0001_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 10, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0010_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0100_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 14, 0);
                shift = Sse2.srl_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b1000_0000);


                return result;
            }
            else
            {
                return new ushort8((ushort)(x.x0 >> n.x0), (ushort)(x.x1 >> n.x1), (ushort)(x.x2 >> n.x2), (ushort)(x.x3 >> n.x3), (ushort)(x.x4 >> n.x4), (ushort)(x.x5 >> n.x5), (ushort)(x.x6 >> n.x6), (ushort)(x.x7 >> n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the uinterval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 shrl(ushort16 x, ushort16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                uint8 lo = shrl((uint8)x.v8_0, (uint8)n.v8_0);
                uint8 hi = shrl((uint8)x.v8_8, (uint8)n.v8_8);

                return Avx2.mm256_permute4x64_epi64(Avx2.mm256_packus_epi32(lo, hi), Sse.SHUFFLE(3, 1, 2, 0));
            }
            else
            {
                return new ushort16(shrl(x.v8_0, n.v8_0), shrl(x.v8_8, n.v8_8));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 shrl(ushort3 x, short3 n)
        {
            return shrl(x, (ushort3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 shrl(ushort4 x, short4 n)
        {
            return shrl(x, (ushort4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 shrl(ushort8 x, short8 n)
        {
            return shrl(x, (ushort8)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift left operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 shrl(ushort16 x, short16 n)
        {
            return shrl(x, (ushort16)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shrl(int2 x, int2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (int2)((uint2)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srlv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int2*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 result = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                return *(int2*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));

                v128 result = Sse2.unpacklo_epi32(_x, _y);

                return *(int2*)&result;
            }
            else
            {
                return (int2)new uint2((uint)x.x >> n.x, (uint)x.y >> n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shrl(int3 x, int3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (int3)((uint3)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srlv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int3*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                v128 result = Sse4_1.blend_epi16(_xy, _z, 0b0011_0000);

                return *(int3*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));
                v128 _z = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 2 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 2 * sizeof(int))));

                v128 lo = Sse2.unpacklo_epi32(_x, _y);
                v128 result = Sse2.unpacklo_epi64(lo, _z);

                return *(int3*)&result;
            }
            else
            {
                return (int3)new uint3((uint)x.x >> n.x, (uint)x.y >> n.y, (uint)x.z >> n.z);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shrl(int4 x, int4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (int4)((uint4)x >> n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srlv_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int4*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                v128 _w = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b1100_0000);

                v128 result = Sse4_1.blend_epi16(_xy, _zw, 0b1111_0000);

                return *(int4*)&result;
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.srl_epi32(UnityMathematicsLink.Tov128(x),                                    Sse2.and_si128(MASK, UnityMathematicsLink.Tov128(n)));
                v128 _y = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 1 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 1 * sizeof(int))));
                v128 _z = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 2 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 2 * sizeof(int))));
                v128 _w = Sse2.srl_epi32(Sse2.bsrli_si128(UnityMathematicsLink.Tov128(x), 3 * sizeof(int)), Sse2.and_si128(MASK, Sse2.bsrli_si128(UnityMathematicsLink.Tov128(n), 3 * sizeof(int))));

                v128 lo = Sse2.unpacklo_epi32(_x, _y);
                v128 hi = Sse2.unpacklo_epi32(_z, _w);
                v128 result = Sse2.unpacklo_epi64(lo, hi);

                return *(int4*)&result;
            }
            else
            {
                return (int4)new uint4((uint)x.x >> n.x, (uint)x.y >> n.y, (uint)x.z >> n.z, (uint)x.w >> n.w);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 shrl(int8 x, int8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (int8)((uint8)x >> n.x0);
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srlv_epi32(x, n);
            }
            else
            {
                return new int8(shrl(x.v4_0, n.v4_0), shrl(x.v4_4, n.v4_4));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shrl(uint2 x, uint2 n)
        {
            return (uint2)shrl((int2)x, (int2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shrl(uint3 x, uint3 n)
        {
            return (uint3)shrl((int3)x, (int3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shrl(uint4 x, uint4 n)
        {
            return (uint4)shrl((int4)x, (int4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 shrl(uint8 x, uint8 n)
        {
            return (uint8)shrl((int8)x, (int8)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shrl(uint2 x, int2 n)
        {
            return shrl(x, (uint2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shrl(uint3 x, int3 n)
        {
            return shrl(x, (uint3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shrl(uint4 x, int4 n)
        {
            return shrl(x, (uint4)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 shrl(uint8 x, int8 n)
        {
            return shrl(x, (uint8)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 shrl(long2 x, long2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (long2)((ulong2)x >> (int)n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.srlv_epi64(x, n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.srl_epi64(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _y = Sse2.srl_epi64(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b1111_0000);
            }
            else if (Sse2.IsSse2Supported)
            {
                v128 MASK = Sse2.cvtsi32_si128(255);

                v128 _x = Sse2.srl_epi64(x,                                      Sse2.and_si128(MASK, n));
                v128 _y = Sse2.srl_epi64(Sse2.bsrli_si128(x, 1 * sizeof(ulong)), Sse2.and_si128(MASK, Sse2.bsrli_si128(n, sizeof(ulong))));

                return Sse2.unpacklo_epi64(_x, _y);
            }
            else
            {
                return (long2)new ulong2((ulong)x.x >> (int)n.x, (ulong)x.y >> (int)n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 shrl(long3 x, long3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (long3)((ulong3)x >> (int)n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srlv_epi64(x, n);
            }
            else
            {
                return new long3(shrl(x._xy, n._xy), (long)((ulong)x.z >> (int)n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 shrl(long4 x, long4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return (long4)((ulong4)x >> (int)n.x);
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srlv_epi64(x, n);
            }
            else
            {
                return new long4(shrl(x._xy, n._xy), shrl(x._zw, n._zw));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 shrl(ulong2 x, ulong2 n)
        {
            return (ulong2)shrl((long2)x, (long2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 shrl(ulong3 x, ulong3 n)
        {
            return (ulong3)shrl((long3)x, (long3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 shrl(ulong4 x, ulong4 n)
        {
            return (ulong4)shrl((long4)x, (long4)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 shrl(ulong2 x, long2 n)
        {
            return shrl(x, (ulong2)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 shrl(ulong3 x, long3 n)
        {
            return shrl(x, (ulong3)n);
        }

        /// <summary>       Returns the result of a componentwise bitshift right (logical) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 shrl(ulong4 x, long4 n)
        {
            return shrl(x, (ulong4)n);
        }


        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 shra(sbyte2 x, sbyte2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte2)shra((int2)x, (int2)n);
            }
            else
            {
                return new sbyte2((sbyte)(x.x >> n.x), (sbyte)(x.y >> n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 shra(sbyte3 x, sbyte3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte3)shra((int3)x, (int3)n);
            }
            else
            {
                return new sbyte3((sbyte)(x.x >> n.x), (sbyte)(x.y >> n.y), (sbyte)(x.z >> n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 shra(sbyte4 x, sbyte4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte4)shra((int4)x, (int4)n);
            }
            else
            {
                return new sbyte4((sbyte)(x.x >> n.x), (sbyte)(x.y >> n.y), (sbyte)(x.z >> n.z), (sbyte)(x.w >> n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 shra(sbyte8 x, sbyte8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (sbyte8)shra((int8)x, (int8)n);
            }
            else
            {
                return new sbyte8((sbyte)(x.x0 >> n.x0), (sbyte)(x.x1 >> n.x1), (sbyte)(x.x2 >> n.x2), (sbyte)(x.x3 >> n.x3), (sbyte)(x.x4 >> n.x4), (sbyte)(x.x5 >> n.x5), (sbyte)(x.x6 >> n.x6), (sbyte)(x.x7 >> n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 shra(sbyte16 x, sbyte16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                int8 lo = shra((int8)x.v8_0, (int8)n.v8_0);
                int8 hi = shra((int8)x.v8_8, (int8)n.v8_8);

                v256 shorts = Avx2.mm256_packs_epi32(lo, hi);
                v256 bytes_unordered = Avx2.mm256_packs_epi16(shorts, default(v256));

                return Avx.mm256_castsi256_si128(Avx2.mm256_permutevar8x32_epi32(bytes_unordered, Avx.mm256_castsi128_si256(new v128(0, 4, 1, 5))));
            }
            else if (Sse4_1.IsSse41Supported)
            {
                sbyte16 result = Sse2.setzero_si128();

                result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(result, n));

                for (sbyte i = 1; i < 8; i++)
                {
                    x >>= 1;
                    result = Mask.BlendV(result, x, Sse2.cmpeq_epi8(new sbyte16(i), n));
                }

                return result;
            }
            else
            {
                return new sbyte16(shra(x.v8_0, n.v8_0), shra(x.v8_8, n.v8_8));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 7] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 shra(sbyte32 x, sbyte32 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                int8 lo_lo = shra((int8)x.v8_0,  (int8)n.v8_0);
                int8 lo_hi = shra((int8)x.v8_8,  (int8)n.v8_8);
                int8 hi_lo = shra((int8)x.v8_16, (int8)n.v8_16);
                int8 hi_hi = shra((int8)x.v8_24, (int8)n.v8_24);

                short16 lo = Avx2.mm256_packs_epi32(lo_lo, lo_hi);
                short16 hi = Avx2.mm256_packs_epi32(hi_lo, hi_hi);

                v256 bytes = Avx2.mm256_packs_epi16(lo, hi);
                bytes = Avx2.mm256_permute4x64_epi64(bytes, Sse.SHUFFLE(3, 1, 2, 0));
                bytes = Avx2.mm256_shuffle_epi32(bytes, Sse.SHUFFLE(3, 1, 2, 0));

                return bytes;
            }
            else
            {
                return new sbyte32(shra(x.v16_0, n.v16_0), shra(x.v16_16, n.v16_16));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 shra(short2 x, short2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short2)shra((int2)x, (int2)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                return Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
            }
            else
            {
                return new short2((short)(x.x >> n.x), (short)(x.y >> n.y));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 shra(short3 x, short3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short3)shra((int3)x, (int3)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);

                return Sse4_1.blend_epi16(_xy, _z, 0b0000_0100);
            }
            else
            {
                return new short3((short)(x.x >> n.x), (short)(x.y >> n.y), (short)(x.z >> n.z));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 shra(short4 x, short4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short4)shra((int4)x, (int4)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                v128 _y = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _z = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                v128 _w = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_0010);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b0000_1000);

                return Sse4_1.blend_epi16(_xy, _zw, 0b0000_1100);
            }
            else
            {
                return new short4((short)(x.x >> n.x), (short)(x.y >> n.y), (short)(x.z >> n.z), (short)(x.w >> n.w));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 shra(short8 x, short8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return (short8)shra((int8)x, (int8)n);
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                short8 result;


                v128 shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = shift;

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 2, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0010);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_0100);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 6, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0000_1000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0001_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 10, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0010_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b0100_0000);

                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 14, 0);
                shift = Sse2.sra_epi16(x, Ssse3.shuffle_epi8(n, shuffleMask));
                result = Sse4_1.blend_epi16(result, shift, 0b1000_0000);


                return result;
            }
            else
            {
                return new short8((short)(x.x0 >> n.x0), (short)(x.x1 >> n.x1), (short)(x.x2 >> n.x2), (short)(x.x3 >> n.x3), (short)(x.x4 >> n.x4), (short)(x.x5 >> n.x5), (short)(x.x6 >> n.x6), (short)(x.x7 >> n.x7));
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 15] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 shra(short16 x, short16 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                int8 lo = shra((int8)x.v8_0, (int8)n.v8_0);
                int8 hi = shra((int8)x.v8_8, (int8)n.v8_8);

                return Avx2.mm256_permute4x64_epi64(Avx2.mm256_packs_epi32(lo, hi), Sse.SHUFFLE(3, 1, 2, 0));
            }
            else
            {
                return new short16(shra(x.v8_0, n.v8_0), shra(x.v8_8, n.v8_8));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shra(int2 x, int2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srav_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int2*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 result = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                return *(int2*)&result;
            }
            else
            {
                return new int2(x.x >> n.x, x.y >> n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shra(int3 x, int3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srav_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int3*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);

                v128 result = Sse4_1.blend_epi16(_xy, _z, 0b0011_0000);

                return *(int3*)&result;
            }
            else
            {
                return new int3(x.x >> n.x, x.y >> n.y, x.z >> n.z);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shra(int4 x, int4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                v128 temp = Avx2.srav_epi32(UnityMathematicsLink.Tov128(x), UnityMathematicsLink.Tov128(n));

                return *(int4*)&temp;
            }
            else if (Sse4_1.IsSse41Supported)
            {
                v128 shuffleMask = new v128(0, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1);
                v128 _x = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 4, 0);
                v128 _y = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 8, 0);
                v128 _z = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));
                shuffleMask = Sse4_1.insert_epi8(shuffleMask, 12, 0);
                v128 _w = Sse2.sra_epi32(UnityMathematicsLink.Tov128(x), Ssse3.shuffle_epi8(UnityMathematicsLink.Tov128(n), shuffleMask));

                v128 _xy = Sse4_1.blend_epi16(_x, _y, 0b0000_1100);
                v128 _zw = Sse4_1.blend_epi16(_z, _w, 0b1100_0000);

                v128 result = Sse4_1.blend_epi16(_xy, _zw, 0b1111_0000);

                return *(int4*)&result;
            }
            else
            {
                return new int4(x.x >> n.x, x.y >> n.y, x.z >> n.z, x.w >> n.w);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 31] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 shra(int8 x, int8 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> n.x0;
            }

            if (Avx2.IsAvx2Supported)
            {
                return Avx2.mm256_srav_epi32(x, n);
            }
            else
            {
                return new int8(shra(x.v4_0, n.v4_0), shra(x.v4_4, n.v4_4));
            }
        }


        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 shra(long2 x, long2 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                long2 mask = Sse2.and_si128(Operator.greater_mask_long(n, default(v128)),
                                            Operator.greater_mask_long(default(v128), x));

                mask = Avx2.sllv_epi64(mask, (64L - n));

                return mask | Avx2.srlv_epi64(x, n);
            }
            else
            {
                return new long2(x.x >> (int)n.x, x.y >> (int)n.y);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 shra(long3 x, long3 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                long3 mask = Avx2.mm256_and_si256(Avx2.mm256_cmpgt_epi64(n, default(v256)),
                                                  Avx2.mm256_cmpgt_epi64(default(v256), x));

                mask = Avx2.mm256_sllv_epi64(mask, (64L - n));

                return mask | Avx2.mm256_srlv_epi64(x, n);
            }
            else
            {
                return new long3(x.x >> (int)n.x, x.y >> (int)n.y, x.z >> (int)n.z);
            }
        }

        /// <summary>       Returns the result of a componentwise bitshift right (arithmetic) operation of <paramref name="x"/> by the corresponding value in <paramref name="n"/>. Shifting by a value outside of the interval [0, 63] is undefined behavior and yields different results when compiling managed C#, for SSE or for AVX.      </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 shra(long4 x, long4 n)
        {
            if (Constant.IsConstantExpression(n) && all_eq(n))
            {
                return x >> (int)n.x;
            }

            if (Avx2.IsAvx2Supported)
            {
                long4 mask = Avx2.mm256_and_si256(Avx2.mm256_cmpgt_epi64(n, default(v256)),
                                                  Avx2.mm256_cmpgt_epi64(default(v256), x));

                mask = Avx2.mm256_sllv_epi64(mask, (64L - n));

                return mask | Avx2.mm256_srlv_epi64(x, n);
            }
            else
            {
                return new long4(x.x >> (int)n.x, x.y >> (int)n.y, x.z >> (int)n.z, x.w >> (int)n.w);
            }
        }
    }
}