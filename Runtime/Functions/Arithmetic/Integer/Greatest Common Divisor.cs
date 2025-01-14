﻿using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;
using Unity.Mathematics;

using static Unity.Burst.Intrinsics.X86;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        /// <summary>       Returns the greatest common divisor of two <see cref="UInt128"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 gcd(UInt128 x, UInt128 y)
        {
            if ((x.lo | x.hi) == 0) return y;
            if ((y.lo | y.hi) == 0) return x;

            int shift = tzcnt(x | y);
            x >>= tzcnt(x);

            do
            {
                y >>= tzcnt(y);

                if (x > y)
                {
                    UInt128 t = y;
                    y = x;
                    x = t;
                }

                y -= x;

            } 
            while ((y.lo | y.hi) != 0);

            return x << shift;
        }

        /// <summary>       Returns the greatest common divisor of two <see cref="Int128"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt128 gcd(Int128 x, Int128 y)
        {
            return gcd((UInt128)abs(x), (UInt128)abs(y));
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="long"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong gcd(long x, long y)
        {
            return gcd((ulong)math.abs(x), (ulong)math.abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.long2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 gcd(long2 x, long2 y)
        {
            return gcd((ulong2)abs(x), (ulong2)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.long3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 gcd(long3 x, long3 y)
        {
            return gcd((ulong3)abs(x), (ulong3)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.long4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 gcd(long4 x, long4 y)
        {
            return gcd((ulong4)abs(x), (ulong4)abs(y));
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="ulong"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong gcd(ulong x, ulong y)
        {
            if (x == 0) return y;
            if (y == 0) return x;

            int shift = math.tzcnt(x | y);
            x >>= math.tzcnt(x);

            do
            {
                y >>= math.tzcnt(y);

                if (x > y)
                {
                    ulong t = y;
                    y = x;
                    x = t;
                }

                y -= x;

            } 
            while (y != 0);

            return x << shift;
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ulong2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 gcd(ulong2 x, ulong2 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Operator.equals_mask_long(x, ZERO);
                v128 y_is_zero = Operator.equals_mask_long(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);

                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                ulong2 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;
                    v128 x_greater_y = Operator.greater_mask_ulong(x, y);

                    x = Mask.BlendV(x, y, x_greater_y);
                    y = Mask.BlendV(y, tempX, x_greater_y);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Operator.equals_mask_long(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(2 * sizeof(ulong)) != Sse2.movemask_epi8(doneMask));

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ulong2(gcd(x.x, y.x), gcd(x.y, y.y));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ulong3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 gcd(ulong3 x, ulong3 y)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 ZERO = Avx.mm256_setzero_si256();

                v256 result = ZERO;

                v256 x_is_zero = Avx2.mm256_cmpeq_epi64(x, ZERO);
                v256 y_is_zero = Avx2.mm256_cmpeq_epi64(y, ZERO);
                v256 any_zero = Avx2.mm256_or_si256(x_is_zero, y_is_zero);

                v256 result_if_zero_any = Avx2.mm256_and_si256(y, x_is_zero);
                result_if_zero_any = Avx2.mm256_blendv_epi8(result_if_zero_any, x, y_is_zero);

                v256 doneMask = any_zero;

                v256 shift = tzcnt(x | y);

                x = Avx2.mm256_srlv_epi64(x, tzcnt(x));

                do
                {
                    y = Avx2.mm256_srlv_epi64(y, tzcnt(y));

                    v256 tempX = x;
                    v256 x_greater_y = Operator.greater_mask_ulong(x, y);

                    x = Avx2.mm256_blendv_epi8(x, y, x_greater_y);
                    y = Avx2.mm256_blendv_epi8(y, tempX, x_greater_y);

                    y -= x;

                    v256 loopCheck = Avx2.mm256_andnot_si256(doneMask, Avx2.mm256_cmpeq_epi64(y, ZERO));
                    result = Avx2.mm256_blendv_epi8(result, x, loopCheck);
                    doneMask = Avx2.mm256_or_si256(doneMask, loopCheck);

                } 
                while (bitmask32(3 * sizeof(ulong)) != (bitmask32(3 * sizeof(ulong)) & Avx2.mm256_movemask_epi8(doneMask)));

                result = Avx2.mm256_sllv_epi64(result, shift);

                result = Avx2.mm256_blendv_epi8(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ulong3(gcd(x._xy, y._xy), gcd(x.z, y.z));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ulong4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 gcd(ulong4 x, ulong4 y)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 ZERO = Avx.mm256_setzero_si256();

                v256 result = ZERO;

                v256 x_is_zero = Avx2.mm256_cmpeq_epi64(x, ZERO);
                v256 y_is_zero = Avx2.mm256_cmpeq_epi64(y, ZERO);
                v256 any_zero = Avx2.mm256_or_si256(x_is_zero, y_is_zero);
                
                v256 result_if_zero_any = Avx2.mm256_and_si256(y, x_is_zero);
                result_if_zero_any = Avx2.mm256_blendv_epi8(result_if_zero_any, x, y_is_zero);

                v256 doneMask = any_zero;

                v256 shift = tzcnt(x | y);

                x = Avx2.mm256_srlv_epi64(x, tzcnt(x));

                do
                {
                    y = Avx2.mm256_srlv_epi64(y, tzcnt(y));

                    v256 tempX = x;
                    v256 x_greater_y = Operator.greater_mask_ulong(x, y);

                    x = Avx2.mm256_blendv_epi8(x, y, x_greater_y);
                    y = Avx2.mm256_blendv_epi8(y, tempX, x_greater_y);

                    y -= x;

                    v256 loopCheck = Avx2.mm256_andnot_si256(doneMask, Avx2.mm256_cmpeq_epi64(y, ZERO));
                    result = Avx2.mm256_blendv_epi8(result, x, loopCheck);
                    doneMask = Avx2.mm256_or_si256(doneMask, loopCheck);

                } 
                while (bitmask32(4 * sizeof(ulong)) != Avx2.mm256_movemask_epi8(doneMask));

                result = Avx2.mm256_sllv_epi64(result, shift);

                result = Avx2.mm256_blendv_epi8(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ulong4(gcd(x._xy, y._xy), gcd(x._zw, y._zw));
            }
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="int"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint gcd(int x, int y)
        {
            return gcd((uint)math.abs(x), (uint)math.abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="int2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 gcd(int2 x, int2 y)
        {
            return gcd((uint2)math.abs(x), (uint2)math.abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="int3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 gcd(int3 x, int3 y)
        {
            return gcd((uint3)math.abs(x), (uint3)math.abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="int4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 gcd(int4 x, int4 y)
        {
            return gcd((uint4)math.abs(x), (uint4)math.abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.int8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 gcd(int8 x, int8 y)
        {
            return gcd((uint8)abs(x), (uint8)abs(y));
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="uint"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint gcd(uint x, uint y)
        {
            if (x == 0) return y;
            if (y == 0) return x;

            int shift = math.tzcnt(x | y);
            x >>= math.tzcnt(x);

            do
            {
                y >>= math.tzcnt(y);

                if (x > y)
                {
                    uint t = y;
                    y = x;
                    x = t;
                }

                y -= x;

            } 
            while (y != 0);

            return x << shift;
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="uint2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 gcd(uint2 x, uint2 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 _x = UnityMathematicsLink.Tov128(x);
                v128 _y = UnityMathematicsLink.Tov128(y);

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi32(_x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi32(_y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(_y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, _x, y_is_zero);

                v128 doneMask = any_zero;

                int2 shift = math.tzcnt(x | y);

                x = shrl(x, math.tzcnt(x));
                _x = UnityMathematicsLink.Tov128(x);

                do
                {
                    uint2 temp_y = shrl(*(uint2*)&_y, math.tzcnt(*(uint2*)&_y));
                    _y = UnityMathematicsLink.Tov128(temp_y);

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = _x;

                        _x = Sse4_1.min_epu32(_x, _y);
                        _y = Sse4_1.max_epu32(_y, tempX);
                    }
                    else
                    {
                        v128 tempX = _x;
                        v128 x_greater_y = Operator.greater_mask_uint(_x, _y);

                        _x = Mask.BlendV(_x, _y, x_greater_y);
                        _y = Mask.BlendV(_y, tempX, x_greater_y);
                    }

                    _y = Sse2.sub_epi32(_y, _x);

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi32(_y, ZERO));
                    result = Mask.BlendV(result, _x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (doneMask.SLong0 != -1);

                uint2 result_temp = shl(*(uint2*)&result, shift);
                result = UnityMathematicsLink.Tov128(result_temp);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return *(uint2*)&result;
            }
            else
            {
                return new uint2(gcd(x.x, y.x), gcd(x.y, y.y));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="uint3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 gcd(uint3 x, uint3 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 _x = UnityMathematicsLink.Tov128(x);
                v128 _y = UnityMathematicsLink.Tov128(y);

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi32(_x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi32(_y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(_y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, _x, y_is_zero);

                v128 doneMask = any_zero;

                int3 shift = math.tzcnt(x | y);

                x = shrl(x, math.tzcnt(x));
                _x = UnityMathematicsLink.Tov128(x);

                do
                {
                    uint3 temp_y = shrl(*(uint3*)&_y, math.tzcnt(*(uint3*)&_y));
                    _y = UnityMathematicsLink.Tov128(temp_y);

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = _x;

                        _x = Sse4_1.min_epu32(_x, _y);
                        _y = Sse4_1.max_epu32(_y, tempX);
                    }
                    else
                    {
                        v128 tempX = _x;
                        v128 x_greater_y = Operator.greater_mask_uint(_x, _y);

                        _x = Mask.BlendV(_x, _y, x_greater_y);
                        _y = Mask.BlendV(_y, tempX, x_greater_y);
                    }

                    _y = Sse2.sub_epi32(_y, _x);

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi32(_y, ZERO));
                    result = Mask.BlendV(result, _x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(3 * sizeof(uint)) != (bitmask32(3 * sizeof(uint)) & Sse2.movemask_epi8(doneMask)));

                uint3 result_temp = shl(*(uint3*)&result, shift);
                result = UnityMathematicsLink.Tov128(result_temp);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return *(uint3*)&result;
            }
            else
            {
                return new uint3(gcd(x.x, y.x), gcd(x.y, y.y), gcd(x.z, y.z));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="uint4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 gcd(uint4 x, uint4 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 _x = UnityMathematicsLink.Tov128(x);
                v128 _y = UnityMathematicsLink.Tov128(y);

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi32(_x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi32(_y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(_y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, _x, y_is_zero);

                v128 doneMask = any_zero;

                int4 shift = math.tzcnt(x | y);

                x = shrl(x, math.tzcnt(x));
                _x = UnityMathematicsLink.Tov128(x);

                do
                {
                    uint4 temp_y = shrl(*(uint4*)&_y, math.tzcnt(*(uint4*)&_y));
                    _y = UnityMathematicsLink.Tov128(temp_y);

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = _x;

                        _x = Sse4_1.min_epu32(_x, _y);
                        _y = Sse4_1.max_epu32(_y, tempX);
                    }
                    else
                    {
                        v128 tempX = _x;
                        v128 x_greater_y = Operator.greater_mask_uint(_x, _y);

                        _x = Mask.BlendV(_x, _y, x_greater_y);
                        _y = Mask.BlendV(_y, tempX, x_greater_y);
                    }

                    _y = Sse2.sub_epi32(_y, _x);

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi32(_y, ZERO));
                    result = Mask.BlendV(result, _x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(4 * sizeof(uint)) != Sse2.movemask_epi8(doneMask));

                uint4 result_temp = shl(*(uint4*)&result, shift);
                result = UnityMathematicsLink.Tov128(result_temp);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return *(uint4*)&result;
            }
            else
            {
                return new uint4(gcd(x.x, y.x), gcd(x.y, y.y), gcd(x.z, y.z), gcd(x.w, y.w));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.uint8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 gcd(uint8 x, uint8 y)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 ZERO = Avx.mm256_setzero_si256();

                v256 result = ZERO;

                v256 x_is_zero = Avx2.mm256_cmpeq_epi32(x, ZERO);
                v256 y_is_zero = Avx2.mm256_cmpeq_epi32(y, ZERO);
                v256 any_zero = Avx2.mm256_or_si256(x_is_zero, y_is_zero);
                
                v256 result_if_zero_any = Avx2.mm256_and_si256(y, x_is_zero);
                result_if_zero_any = Avx2.mm256_blendv_epi8(result_if_zero_any, x, y_is_zero);

                v256 doneMask = any_zero;

                v256 shift = tzcnt(x | y);

                x = Avx2.mm256_srlv_epi32(x, tzcnt(x));

                do
                {
                    y = Avx2.mm256_srlv_epi32(y, tzcnt(y));

                    v256 tempX = x;

                    x = Avx2.mm256_min_epu32(x, y);
                    y = Avx2.mm256_max_epu32(y, tempX);

                    y -= x;

                    v256 loopCheck = Avx2.mm256_andnot_si256(doneMask, Avx2.mm256_cmpeq_epi32(y, ZERO));
                    result = Avx2.mm256_blendv_epi8(result, x, loopCheck);
                    doneMask = Avx2.mm256_or_si256(doneMask, loopCheck);

                } 
                while (bitmask32(8 * sizeof(uint)) != Avx2.mm256_movemask_epi8(doneMask));

                result = Avx2.mm256_sllv_epi32(result, shift);

                result = Avx2.mm256_blendv_epi8(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new uint8(gcd(x.v4_0, y.v4_0), gcd(x.v4_4, y.v4_4));
            }
        }

        /// <summary>       Returns the greatest common divisor of two <see cref="short"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort gcd(short x, short y)
        {
            return (ushort)gcd(abs(x), abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.short2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 gcd(short2 x, short2 y)
        {
            return gcd((ushort2)abs(x), (ushort2)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.short3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 gcd(short3 x, short3 y)
        {
            return gcd((ushort3)abs(x), (ushort3)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.short4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 gcd(short4 x, short4 y)
        {
            return gcd((ushort4)abs(x), (ushort4)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.short8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 gcd(short8 x, short8 y)
        {
            return gcd((ushort8)abs(x), (ushort8)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.short16"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 gcd(short16 x, short16 y)
        {
            return gcd((ushort16)abs(x), (ushort16)abs(y));
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="ushort"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort gcd(ushort x, ushort y)
        {
            return (ushort)gcd((uint)x, (uint)y);
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ushort2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 gcd(ushort2 x, ushort2 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi16(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi16(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                ushort2 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = x;

                        x = Sse4_1.min_epu16(x, y);
                        y = Sse4_1.max_epu16(y, tempX);
                    }
                    else
                    {
                        ushort2 MASK = 1 << 15;

                        v128 xMasked = Sse2.xor_si128(x, MASK);
                        v128 yMasked = Sse2.xor_si128(y, MASK);
                        
                        x = Sse2.xor_si128(MASK,
                                           Sse2.min_epi16(xMasked,
                                                          yMasked));
                        y = Sse2.xor_si128(MASK,
                                           Sse2.max_epi16(xMasked,
                                                          yMasked));
                    }

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi16(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (-1 != doneMask.SInt0);

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ushort2((ushort)gcd((uint)x.x, (uint)y.x), (ushort)gcd((uint)x.y, (uint)y.y));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ushort3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 gcd(ushort3 x, ushort3 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi16(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi16(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                ushort3 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = x;

                        x = Sse4_1.min_epu16(x, y);
                        y = Sse4_1.max_epu16(y, tempX);
                    }
                    else
                    {
                        ushort4 MASK = 1 << 15;

                        v128 xMasked = Sse2.xor_si128(x, MASK);
                        v128 yMasked = Sse2.xor_si128(y, MASK);
                        
                        x = Sse2.xor_si128(MASK,
                                           Sse2.min_epi16(xMasked,
                                                          yMasked));
                        y = Sse2.xor_si128(MASK,
                                           Sse2.max_epi16(xMasked,
                                                          yMasked));
                    }

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi16(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(3 * sizeof(ushort)) != (bitmask32(3 * sizeof(ushort)) & Sse2.movemask_epi8(doneMask)));

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ushort3((ushort)gcd((uint)x.x, (uint)y.x), (ushort)gcd((uint)x.y, (uint)y.y), (ushort)gcd((uint)x.z, (uint)y.z));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ushort4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 gcd(ushort4 x, ushort4 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi16(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi16(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                ushort4 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = x;

                        x = Sse4_1.min_epu16(x, y);
                        y = Sse4_1.max_epu16(y, tempX);
                    }
                    else
                    {
                        ushort4 MASK = 1 << 15;

                        v128 xMasked = Sse2.xor_si128(x, MASK);
                        v128 yMasked = Sse2.xor_si128(y, MASK);
                        
                        x = Sse2.xor_si128(MASK,
                                           Sse2.min_epi16(xMasked,
                                                          yMasked));
                        y = Sse2.xor_si128(MASK,
                                           Sse2.max_epi16(xMasked,
                                                          yMasked));
                    }

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi16(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (-1 != doneMask.SLong0);

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ushort4((ushort)gcd((uint)x.x, (uint)y.x), (ushort)gcd((uint)x.y, (uint)y.y), (ushort)gcd((uint)x.z, (uint)y.z), (ushort)gcd((uint)x.w, (uint)y.w));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ushort8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 gcd(ushort8 x, ushort8 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi16(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi16(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                ushort8 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    if (Sse4_1.IsSse41Supported)
                    {
                        v128 tempX = x;

                        x = Sse4_1.min_epu16(x, y);
                        y = Sse4_1.max_epu16(y, tempX);
                    }
                    else
                    {
                        ushort8 MASK = 1 << 15;

                        v128 xMasked = Sse2.xor_si128(x, MASK);
                        v128 yMasked = Sse2.xor_si128(y, MASK);
                        
                        x = Sse2.xor_si128(MASK,
                                           Sse2.min_epi16(xMasked,
                                                          yMasked));
                        y = Sse2.xor_si128(MASK,
                                           Sse2.max_epi16(xMasked,
                                                          yMasked));
                    }

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi16(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(8 * sizeof(ushort)) != Sse2.movemask_epi8(doneMask));

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ushort8((ushort)gcd((uint)x.x0,  (uint)y.x0),
                                   (ushort)gcd((uint)x.x1,  (uint)y.x1),
                                   (ushort)gcd((uint)x.x2,  (uint)y.x2),
                                   (ushort)gcd((uint)x.x3,  (uint)y.x3),
                                   (ushort)gcd((uint)x.x4,  (uint)y.x4),
                                   (ushort)gcd((uint)x.x5,  (uint)y.x5),
                                   (ushort)gcd((uint)x.x6,  (uint)y.x6),
                                   (ushort)gcd((uint)x.x7,  (uint)y.x7));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.ushort16"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 gcd(ushort16 x, ushort16 y)
        { 
            if (Avx2.IsAvx2Supported)
            {
                v256 ZERO = Avx.mm256_setzero_si256();

                v256 result = ZERO;

                v256 x_is_zero = Avx2.mm256_cmpeq_epi16(x, ZERO);
                v256 y_is_zero = Avx2.mm256_cmpeq_epi16(y, ZERO);
                v256 any_zero = Avx2.mm256_or_si256(x_is_zero, y_is_zero);
                
                v256 result_if_zero_any = Avx2.mm256_and_si256(y, x_is_zero);
                result_if_zero_any = Avx2.mm256_blendv_epi8(result_if_zero_any, x, y_is_zero);

                v256 doneMask = any_zero;

                v256 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v256 tempX = x;

                    x = Avx2.mm256_min_epu16(x, y);
                    y = Avx2.mm256_max_epu16(y, tempX);

                    y -= x;

                    v256 loopCheck = Avx2.mm256_andnot_si256(doneMask, Avx2.mm256_cmpeq_epi16(y, ZERO));
                    result = Avx2.mm256_blendv_epi8(result, x, loopCheck);
                    doneMask = Avx2.mm256_or_si256(doneMask, loopCheck);

                } 
                while (-1 != Avx2.mm256_movemask_epi8(doneMask));

                result = shl((ushort16)result, (ushort16)shift);

                result = Avx2.mm256_blendv_epi8(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new ushort16(gcd(x.v8_0, y.v8_0), gcd(x.v8_8, y.v8_8));
            }
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="sbyte"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte gcd(sbyte x, sbyte y)
        {
            return (byte)gcd(abs(x), abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 gcd(sbyte2 x, sbyte2 y)
        {
            return gcd((byte2)abs(x), (byte2)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 gcd(sbyte3 x, sbyte3 y)
        {
            return gcd((byte3)abs(x), (byte3)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 gcd(sbyte4 x, sbyte4 y)
        {
            return gcd((byte4)abs(x), (byte4)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 gcd(sbyte8 x, sbyte8 y)
        {
            return gcd((byte8)abs(x), (byte8)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte16"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 gcd(sbyte16 x, sbyte16 y)
        {
            return gcd((byte16)abs(x), (byte16)abs(y));
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.sbyte32"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 gcd(sbyte32 x, sbyte32 y)
        {
            return gcd((byte32)abs(x), (byte32)abs(y));
        }


        /// <summary>       Returns the greatest common divisor of two <see cref="byte"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte gcd(byte x, byte y)
        {
            return (byte)gcd((uint)x, (uint)y);
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte2"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 gcd(byte2 x, byte2 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi8(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi8(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                byte2 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;

                    x = Sse2.min_epu8(x, y);
                    y = Sse2.max_epu8(y, tempX);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi8(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (-1 != doneMask.SShort0);

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte2((byte)gcd((uint)x.x, (uint)y.x), (byte)gcd((uint)x.y, (uint)y.y));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte3"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 gcd(byte3 x, byte3 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi8(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi8(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                byte3 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;

                    x = Sse2.min_epu8(x, y);
                    y = Sse2.max_epu8(y, tempX);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi8(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(3 * sizeof(byte)) != (bitmask32(3 * sizeof(byte)) & Sse2.movemask_epi8(doneMask)));

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte3((byte)gcd((uint)x.x, (uint)y.x), (byte)gcd((uint)x.y, (uint)y.y), (byte)gcd((uint)x.z, (uint)y.z));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte4"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 gcd(byte4 x, byte4 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi8(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi8(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                byte4 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;

                    x = Sse2.min_epu8(x, y);
                    y = Sse2.max_epu8(y, tempX);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi8(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (-1 != doneMask.SInt0);

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte4((byte)gcd((uint)x.x, (uint)y.x), (byte)gcd((uint)x.y, (uint)y.y), (byte)gcd((uint)x.z, (uint)y.z), (byte)gcd((uint)x.w, (uint)y.w));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte8"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 gcd(byte8 x, byte8 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi8(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi8(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                byte8 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;

                    x = Sse2.min_epu8(x, y);
                    y = Sse2.max_epu8(y, tempX);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi8(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (-1 != doneMask.SLong0);

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte8((byte)gcd((uint)x.x0,  (uint)y.x0),
                                 (byte)gcd((uint)x.x1,  (uint)y.x1),
                                 (byte)gcd((uint)x.x2,  (uint)y.x2),
                                 (byte)gcd((uint)x.x3,  (uint)y.x3),
                                 (byte)gcd((uint)x.x4,  (uint)y.x4),
                                 (byte)gcd((uint)x.x5,  (uint)y.x5),
                                 (byte)gcd((uint)x.x6,  (uint)y.x6),
                                 (byte)gcd((uint)x.x7,  (uint)y.x7));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte16"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 gcd(byte16 x, byte16 y)
        {
            if (Sse2.IsSse2Supported)
            {
                v128 ZERO = Sse2.setzero_si128();

                v128 result = ZERO;

                v128 x_is_zero = Sse2.cmpeq_epi8(x, ZERO);
                v128 y_is_zero = Sse2.cmpeq_epi8(y, ZERO);
                v128 any_zero = Sse2.or_si128(x_is_zero, y_is_zero);
                
                v128 result_if_zero_any = Sse2.and_si128(y, x_is_zero);
                result_if_zero_any = Mask.BlendV(result_if_zero_any, x, y_is_zero);

                v128 doneMask = any_zero;

                byte16 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v128 tempX = x;

                    x = Sse2.min_epu8(x, y);
                    y = Sse2.max_epu8(y, tempX);

                    y -= x;

                    v128 loopCheck = Sse2.andnot_si128(doneMask, Sse2.cmpeq_epi8(y, ZERO));
                    result = Mask.BlendV(result, x, loopCheck);
                    doneMask = Sse2.or_si128(doneMask, loopCheck);

                } 
                while (bitmask32(16 * sizeof(byte)) != Sse2.movemask_epi8(doneMask));

                result = shl(result, shift);

                result = Mask.BlendV(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte16((byte)gcd((uint)x.x0,  (uint)y.x0),
                                  (byte)gcd((uint)x.x1,  (uint)y.x1),
                                  (byte)gcd((uint)x.x2,  (uint)y.x2),
                                  (byte)gcd((uint)x.x3,  (uint)y.x3),
                                  (byte)gcd((uint)x.x4,  (uint)y.x4),
                                  (byte)gcd((uint)x.x5,  (uint)y.x5),
                                  (byte)gcd((uint)x.x6,  (uint)y.x6),
                                  (byte)gcd((uint)x.x7,  (uint)y.x7),
                                  (byte)gcd((uint)x.x8,  (uint)y.x8),
                                  (byte)gcd((uint)x.x9,  (uint)y.x9),
                                  (byte)gcd((uint)x.x10, (uint)y.x10),
                                  (byte)gcd((uint)x.x11, (uint)y.x11),
                                  (byte)gcd((uint)x.x12, (uint)y.x12),
                                  (byte)gcd((uint)x.x13, (uint)y.x13),
                                  (byte)gcd((uint)x.x14, (uint)y.x14),
                                  (byte)gcd((uint)x.x15, (uint)y.x15));
            }
        }

        /// <summary>       Returns the componentwise greatest common divisor of two <see cref="MaxMath.byte32"/>s.    </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 gcd(byte32 x, byte32 y)
        {
            if (Avx2.IsAvx2Supported)
            {
                v256 ZERO = Avx.mm256_setzero_si256();

                v256 result = ZERO;

                v256 x_is_zero = Avx2.mm256_cmpeq_epi8(x, ZERO);
                v256 y_is_zero = Avx2.mm256_cmpeq_epi8(y, ZERO);
                v256 any_zero = Avx2.mm256_or_si256(x_is_zero, y_is_zero);
                
                v256 result_if_zero_any = Avx2.mm256_and_si256(y, x_is_zero);
                result_if_zero_any = Avx2.mm256_blendv_epi8(result_if_zero_any, x, y_is_zero);

                v256 doneMask = any_zero;

                v256 shift = tzcnt(x | y);

                x = shrl(x, tzcnt(x));

                do
                {
                    y = shrl(y, tzcnt(y));

                    v256 tempX = x;

                    x = Avx2.mm256_min_epu8(x, y);
                    y = Avx2.mm256_max_epu8(y, tempX);

                    y -= x;

                    v256 loopCheck = Avx2.mm256_andnot_si256(doneMask, Avx2.mm256_cmpeq_epi8(y, ZERO));
                    result = Avx2.mm256_blendv_epi8(result, x, loopCheck);
                    doneMask = Avx2.mm256_or_si256(doneMask, loopCheck);

                } 
                while (-1 != Avx2.mm256_movemask_epi8(doneMask));

                result = shl((byte32)result, (byte32)shift);

                result = Avx2.mm256_blendv_epi8(result, result_if_zero_any, any_zero);

                return result;
            }
            else
            {
                return new byte32(gcd(x.v16_0, y.v16_0), gcd(x.v16_16, y.v16_16));
            }
        }
    }
}