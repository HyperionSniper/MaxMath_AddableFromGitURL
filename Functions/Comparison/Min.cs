﻿using System.Runtime.CompilerServices;
using Unity.Burst.Intrinsics;

namespace MaxMath
{
    unsafe public static partial class maxmath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 min(byte2 a, byte2 b)
        {
            return X86.Sse2.min_epu8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 min(byte3 a, byte3 b)
        {
            return X86.Sse2.min_epu8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte4 min(byte4 a, byte4 b)
        {
            return X86.Sse2.min_epu8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte8 min(byte8 a, byte8 b)
        {
            return X86.Sse2.min_epu8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte16 min(byte16 a, byte16 b)
        {
            return X86.Sse2.min_epu8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte32 min(byte32 a, byte32 b)
        {
            return X86.Avx2.mm256_min_epu8(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte2 min(sbyte2 a, sbyte2 b)
        {
            return X86.Sse4_1.min_epi8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte3 min(sbyte3 a, sbyte3 b)
        {
            return X86.Sse4_1.min_epi8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte4 min(sbyte4 a, sbyte4 b)
        {
            return X86.Sse4_1.min_epi8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte8 min(sbyte8 a, sbyte8 b)
        {
            return X86.Sse4_1.min_epi8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte16 min(sbyte16 a, sbyte16 b)
        {
            return X86.Sse4_1.min_epi8(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte32 min(sbyte32 a, sbyte32 b)
        {
            return X86.Avx2.mm256_min_epi8(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort2 min(ushort2 a, ushort2 b)
        {
            return X86.Sse4_1.min_epu16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort3 min(ushort3 a, ushort3 b)
        {
            return X86.Sse4_1.min_epu16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort4 min(ushort4 a, ushort4 b)
        {
            return X86.Sse4_1.min_epu16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort8 min(ushort8 a, ushort8 b)
        {
            return X86.Sse4_1.min_epu16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort16 min(ushort16 a, ushort16 b)
        {
            return X86.Avx2.mm256_min_epu16(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short2 min(short2 a, short2 b)
        {
            return X86.Sse2.min_epi16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short3 min(short3 a, short3 b)
        {
            return X86.Sse2.min_epi16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 min(short4 a, short4 b)
        {
            return X86.Sse2.min_epi16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short8 min(short8 a, short8 b)
        {
            return X86.Sse2.min_epi16(a, b);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short16 min(short16 a, short16 b)
        {
            return X86.Avx2.mm256_min_epi16(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int8 min(int8 a, int8 b)
        {
            return X86.Avx2.mm256_min_epi32(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint8 min(uint8 a, uint8 b)
        {
            return X86.Avx2.mm256_min_epu32(a, b);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong2 min(ulong2 a, ulong2 b)
        {
            return X86.Sse4_1.blendv_epi8(a, b, Operator.greater_mask_ulong(a, b));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong3 min(ulong3 a, ulong3 b)
        {
            return X86.Avx2.mm256_blendv_epi8(a, b, Operator.greater_mask_ulong(a, b));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong4 min(ulong4 a, ulong4 b)
        {
            return X86.Avx2.mm256_blendv_epi8(a, b, Operator.greater_mask_ulong(a, b));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long2 min(long2 a, long2 b)
        {
            return X86.Sse4_1.blendv_epi8(a, b, X86.Sse4_2.cmpgt_epi64(a, b));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long3 min(long3 a, long3 b)
        {
            return X86.Avx2.mm256_blendv_epi8(a, b, X86.Avx2.mm256_cmpgt_epi64(a, b));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long4 min(long4 a, long4 b)
        {
            return X86.Avx2.mm256_blendv_epi8(a, b, X86.Avx2.mm256_cmpgt_epi64(a, b));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float8 min(float8 a, float8 b)
        {
            return X86.Avx.mm256_min_ps(a, b);
        }
    }
}